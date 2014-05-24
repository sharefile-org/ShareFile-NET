﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Helpers;
using ShareFile.Api.Models;
using Group = System.Text.RegularExpressions.Group;

namespace ShareFile.Api.Client.Converters
{
    /// <summary>
    /// This class handles the creation of OData Objects from string-based specifications, mainly
    /// for deserialization operations. It uses several method to identify the serialized classes:
    /// the Odata metadata, the Odata Url, and the ID in certain cases - based on ShareFile ID 
    /// prefixes
    /// </summary>
    public class ODataFactory
    {
        public static ODataFactory GetInstance()
        {
            if (_instance == null) _instance = new ODataFactory();
            return _instance;
        }

        private static ODataFactory _instance = null;

        private ODataFactory()
        {
            _constructorCache = new Dictionary<Type, ConstructorInfo>();
            _typeMap = new Dictionary<Type, Type>();
            var odataObjectType = typeof(ODataObject);
            var types = TypeHelpers.GetTypes(TypeHelpers.GetAssembly(odataObjectType));

            foreach (var t in types.Where(x => TypeHelpers.IsAssignableFrom(odataObjectType, x)))
            {
                TryAddType(t);
            }

            _entityTypeMap = EntityTypeMap.GetEntityTypeMap();
        }

        private void TryAddType(Type modelType, Type overrideType = null)
        {
            var effectiveType = overrideType ?? modelType;

            var ctor = effectiveType.GetConstructor(new[] { typeof(ODataObject), typeof(JsonSerializer) });
            if (ctor != null)
            {
                _constructorCache[modelType] = ctor;
            }
        }

        private ODataObject InvokeConstructor(Type type, ODataObject existingObject, JsonSerializer serializer)
        {
            ODataObject oDataObject = null;
            if (_constructorCache.ContainsKey(type))
            {
                oDataObject = (ODataObject)_constructorCache[type].Invoke(new Object[] { });
            }
            else if (type != null)
            {
                var ctor = type.GetConstructor(new Type[] { });
                if (ctor != null)
                {
                    oDataObject = (ODataObject)ctor.Invoke(new Object[] { });
                }
            }

            if (oDataObject == null)
            {
                oDataObject = new ODataObject();
            }

            oDataObject.Copy(existingObject, serializer);

            return oDataObject;
        }

        private readonly Dictionary<Type, ConstructorInfo> _constructorCache;
        private readonly Dictionary<Type, Type> _typeMap;
        private readonly Dictionary<string, Type> _entityTypeMap;
        private readonly Dictionary<Type, bool> _typeHasSubclassMap = new Dictionary<Type, bool>();
        private readonly object _hasSubclassLock = new object();

        internal bool HasSubclass(Type type)
        {
            bool hasSubclass;

            if (!_typeHasSubclassMap.TryGetValue(type, out hasSubclass))
            {
                lock (_hasSubclassLock)
                {
                    hasSubclass = FindModelType(type, null) != type;
                    if (!hasSubclass)
                    {
                        hasSubclass = _constructorCache.Keys.FirstOrDefault(x => x.IsSubclassOf(type)) != null;
                    }
                    _typeHasSubclassMap[type] = hasSubclass;
                }
            }

            return hasSubclass;
        }

        /// <summary>
        /// Allow consumers to regsiter type substitutions.
        /// </summary>
        /// <typeparam name="TNew">Type constructor to use in place of TReplace</typeparam>
        /// <typeparam name="TReplace">Type you want to replace</typeparam>
        public void RegisterType<TNew, TReplace>()
            where TNew : TReplace
            where TReplace : ODataObject
        {
            var overrideType = typeof(TNew);
            var modelType = typeof(TReplace);
            _typeMap[overrideType] = modelType;

            TryAddType(modelType, overrideType);
        }

        public void RegisterEntity(string EntityName, Type EntityType)
        {
            _entityTypeMap[EntityName] = EntityType;
        }

        /// <summary>
        /// Creates a Model class based on the type name, as a string.
        /// </summary>
        /// <remarks>
        /// This is not a terribly efficient method, should be used as catch-22 if you want a generic
        /// handler. If you know the return type, or at least the superclass, use Create passing the
        /// .NET Type object, which is more efficient.
        /// </remarks>
        /// <param name="cast">Type name. Either full namespace or just name will work. Entity set names 
        /// are also supported (e.g., Items for Item)</param>
        /// <param name="context">Optional request context</param>
        /// <param name="id">Optional id if you already know it. This method will use the ShareFile ID 
        /// prefixes to handle superclasses (e.g., cast=Items and id=fi* instantiate a File instance)</param>
        /// <returns>A subtype of ODataObject, matching the requested type/id. Returns null if type doesnt
        /// match any known type</returns>
        public ODataObject Create(string cast, string id = null)
        {
            var type = FindModelType(null, cast, id);
            return InvokeConstructor(type, null, null);
        }

        public Type FindModelType(Type knownType, string cast, string id = null)
        {
            Type type = knownType;
            // Normalize cast, remove namespaces
            if (cast != null)
            {
                string namesp = typeof(ODataObject).Namespace;
                if (cast.StartsWith(namesp)) cast = cast.Substring(namesp.Length + 1);
            }
            // If knownType is unknown, type to infer from the Cast string
            if ((type == null || type == typeof(ODataObject)) && cast != null)
            {
                type = _entityTypeMap.ContainsKey(cast) ? _entityTypeMap[cast] : null;
            }
            if (type != null && type != typeof(ODataObject))
            {
                if (cast != null || id != null)
                {
                    // Entities with subtypes
                    // Try the Cast string
                    if (cast != null && (type == typeof(Item) || type == typeof(Principal)))
                    {
                        type = _entityTypeMap.ContainsKey(cast) ? _entityTypeMap[cast] : type;
                    }
                    // Try the ID
                    if (id != null && (type == typeof(Item) || type == typeof(Principal)))
                    {
                        if (id.StartsWith("fi")) type = typeof(File);
                        else if (id.StartsWith("for")) type = typeof(SymbolicLink);
                        else if (id.StartsWith("fo")) type = typeof(Folder);
                        else if (id.StartsWith("n")) type = typeof(Note);
                        else if (id.StartsWith("l")) type = typeof(Link);
                        else if (id.StartsWith("a")) type = typeof(Folder);
                        else if (id.StartsWith("g")) type = typeof(Group);
                        // User has no prefix; so assume it's an user at this point (if superclass is Principal)
                        else if (type == typeof(Principal)) type = typeof(User);
                    }
                }
            }
            else type = typeof(ODataObject);

            if (_typeMap.ContainsKey(type))
            {
                type = _typeMap[type];
            }
            return type;
        }

        /// <summary>
        /// Creates a new instance of ODataObject of the specified type. 
        /// </summary>
        /// <remarks>
        /// If Type is Item or
        /// Principal, the appropriate sub-type is instantiated based on ID. This is not kosher from
        /// ODATA perspective: the Type Cast parameter in metadata should be used instead.. 
        /// The method will use reflection to find the type constructor. Objects must have a
        /// constructor (string, context) or (string, context, string) to be found. Otherwise,
        /// a ODataObject instance is created instead.
        /// </remarks>
        /// <param name="type"></param>
        /// <param name="cast"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public ODataObject Create(Type type, string cast = null, ODataObject oDataObject = null, JsonSerializer serializer = null, string id = null)
        {
            type = FindModelType(type, cast, null);
            if (oDataObject != null && type == oDataObject.GetType()) return oDataObject;

            var obj = InvokeConstructor(type, oDataObject, serializer);
            if (!string.IsNullOrEmpty(id))
            {
                obj.Id = id;
            }
            return obj;
        }

        public ODataObject CreateFromUrl(string Url, ODataObject oDataObject, JsonSerializer serializer)
        {
            var odataExpression = @"^(?<cast>[^$\(]+)\((?<id>[^\)]+)\)";

            Uri uri = new Uri(Url);
            string type = null;
            string id = null;
            var uriSegments = uri.GetSegments();

            foreach (var segment in uriSegments)
            {
                var match = Regex.Match(segment, odataExpression, RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    type = match.Groups["cast"].Value;
                    id = match.Groups["id"].Value;
                }
            }
            if (type == null && uriSegments.Length > 0) { type = uriSegments[uriSegments.Length - 1]; }

            if (type != null)
            {
                var o = Create(oDataObject.GetType(), type, oDataObject, serializer, id);
                return o;
            }

            if (oDataObject != null) return oDataObject;

            return null;
        }

        internal class JsonLightMetadataParser
        {
            internal static char[] SplitChars = {'/'};
            internal static string Namespace = typeof (ODataObject).Namespace + ".";

            internal JsonLightMetadataParserResult Parse(string metadataUri)
            {
                var indexOfMetadataStart = metadataUri.IndexOf('$');
                var result = new JsonLightMetadataParserResult
                {
                    MetadataBaseUri = metadataUri.Substring(0, indexOfMetadataStart)
                };

                var metadataString = metadataUri.Substring(indexOfMetadataStart + "$metadata#".Length);
                var splitResults = metadataString.Split(SplitChars, StringSplitOptions.RemoveEmptyEntries);

                if (splitResults.Length == 1)
                {
                    var indexOfAtElement = splitResults[0].IndexOf("@Element", StringComparison.Ordinal);
                    if (indexOfAtElement >= 0)
                    {
                        result.Entity = splitResults[0].Substring(0, indexOfAtElement);
                        return result;
                    }
                    var indexOfNamespace = splitResults[0].IndexOf(Namespace, StringComparison.Ordinal);
                    if (indexOfNamespace == 0)
                    {
                        result.Cast = splitResults[0].Substring(Namespace.Length);
                        return result;
                    }
                    result.FeedEntity = splitResults[0];
                    return result;
                }
                if (splitResults.Length == 2)
                {
                    result.Entity = splitResults[0];
                    var indexOfAtElement = splitResults[1].IndexOf("@Element", StringComparison.Ordinal);
                    if (indexOfAtElement >= 0)
                    {
                        result.Cast = splitResults[1].Substring(0, indexOfAtElement);
                        return result;
                    }
                    result.Cast = splitResults[1];
                }

                return result;
            }
        }

        internal class JsonLightMetadataParserResult
        {
            internal string MetadataBaseUri { get; set; }
            internal string Cast { get; set; }
            internal string Entity { get; set; }
            internal string FeedEntity { get; set; }
            internal bool HasCast { get { return Cast != null; } }
            internal bool HasEntity { get { return Entity != null; } }
            internal bool HasFeedEntity { get { return FeedEntity != null; } }
        }

        public ODataObject CreateFromMetadata(string metadata, Type knownType, ODataObject jObject, JsonSerializer serializer)
        {
            var parser = new JsonLightMetadataParser();
            var result = parser.Parse(metadata);

            ODataObject o = null;
            if (result.HasFeedEntity)
            {
                var type = FindModelType(knownType, result.FeedEntity);
                Type specificType;
                if (TypeHelpers.IsGenericType(type) && type.GetGenericTypeDefinition() == typeof(ODataFeed<>))
                {
                    specificType = type;
                }
                else specificType = typeof(ODataFeed<>).MakeGenericType(new [] { type });

                if (specificType == knownType) return jObject;
                o = InvokeConstructor(specificType, jObject, serializer);

                o.SetMetadata(new Uri(result.MetadataBaseUri), result.FeedEntity, null, ODataObjectType.ComplexType);
            }
            else
            {
                string metadataType = result.HasCast ? result.Cast : result.Entity;
                o = Create(knownType, metadataType, jObject, serializer);
                if (result.HasEntity)
                {
                    o.SetMetadata(new Uri(result.MetadataBaseUri), result.Entity, result.Cast, ODataObjectType.Entity);
                }
                else
                {
                    o.SetMetadata(new Uri(result.MetadataBaseUri), null, o.GetType().FullName, ODataObjectType.ComplexType);
                }
            }
            return o;
        }
    }
}

// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2014 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;

namespace ShareFile.Api.Models 
{
	public class ODataObject : object 
	{

		/// <summary>
		/// ODATA Metadata information about the model instance
		/// </summary>
		[JsonProperty(PropertyName = "odata.metadata")]
		public string MetadataUrl { get; set; }

		/// <summary>
		/// Object Identifier
		/// </summary>
		public string Id { get; set; }

		public Uri url { get; set; }

		[JsonExtensionData]
		internal IDictionary<string, JToken> Properties { get; set; }

		public virtual void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;

			var typedSource = source as ODataObject;
				MetadataUrl = typedSource.MetadataUrl;
				Id = typedSource.Id;
				url = typedSource.url;
		}
	}
}
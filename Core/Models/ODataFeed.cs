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
	public class ODataFeed<T> : ODataObject 
	{

		[JsonProperty(PropertyName = "odata.count")] 
		public int count { get; set; }

		[JsonProperty(PropertyName = "value")] 
		public IEnumerable<T> Feed { get; set; }

		[JsonProperty(PropertyName = "odata.nextLink")] 
		public string NextLink { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			if(source.GetType().IsSubclassOf(GetType()) || GetType() == source.GetType())
			{
				var typedSource = (ODataFeed<T>)source;
				count = typedSource.count;
				Feed = typedSource.Feed;
				NextLink = typedSource.NextLink;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("odata.count", out token) && token.Type != JTokenType.Null)
				{
					count = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
				if(source.TryGetProperty("value", out token) && token.Type != JTokenType.Null)
				{
					Feed = (IEnumerable<T>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<T>));
				}
				if(source.TryGetProperty("odata.nextLink", out token) && token.Type != JTokenType.Null)
				{
					NextLink = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
			}
		}
	}
}
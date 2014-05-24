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
	public class QueryPaging : ODataObject 
	{

		public string Key { get; set; }

		public int PageNumber { get; set; }

		public int PageSize { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			if(source.GetType().IsSubclassOf(GetType()) || GetType() == source.GetType())
			{
				var typedSource = (QueryPaging)source;
				Key = typedSource.Key;
				PageNumber = typedSource.PageNumber;
				PageSize = typedSource.PageSize;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Key", out token) && token.Type != JTokenType.Null)
				{
					Key = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("PageNumber", out token) && token.Type != JTokenType.Null)
				{
					PageNumber = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
				if(source.TryGetProperty("PageSize", out token) && token.Type != JTokenType.Null)
				{
					PageSize = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
			}
		}
	}
}
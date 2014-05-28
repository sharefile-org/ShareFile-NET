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
	public class SearchResults : ODataObject 
	{

		public bool ParitalResults { get; set; }

		public IEnumerable<SearchResult> Results { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as SearchResults;
			if(typedSource != null)
			{
				ParitalResults = typedSource.ParitalResults;
				Results = typedSource.Results;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("ParitalResults", out token) && token.Type != JTokenType.Null)
				{
					ParitalResults = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("Results", out token) && token.Type != JTokenType.Null)
				{
					Results = (IEnumerable<SearchResult>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<SearchResult>));
				}
			}
		}
	}
}
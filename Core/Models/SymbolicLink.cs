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
	public class SymbolicLink : Folder 
	{

		public Uri Link { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			if(source.GetType().IsSubclassOf(GetType()) || GetType() == source.GetType())
			{
				var typedSource = (SymbolicLink)source;
				Link = typedSource.Link;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Link", out token) && token.Type != JTokenType.Null)
				{
					Link = (Uri)serializer.Deserialize(token.CreateReader(), typeof(Uri));
				}
			}
		}
	}
}
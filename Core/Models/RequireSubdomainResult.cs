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
	public class RequireSubdomainResult : ODataObject 
	{

		public bool RequireSubdomain { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			if(source.GetType().IsSubclassOf(GetType()) || GetType() == source.GetType())
			{
				var typedSource = (RequireSubdomainResult)source;
				RequireSubdomain = typedSource.RequireSubdomain;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("RequireSubdomain", out token) && token.Type != JTokenType.Null)
				{
					RequireSubdomain = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
			}
		}
	}
}
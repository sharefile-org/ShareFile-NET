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
	public class EnsSubscriptionToken : ODataObject 
	{

		public string SubscriptionId { get; set; }

		public string EntityId { get; set; }

		public SafeEnum<EnsEventType> EventTypes { get; set; }

		public bool IncludeProgeny { get; set; }

		public long LastEventCount { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			if(source.GetType().IsSubclassOf(GetType()) || GetType() == source.GetType())
			{
				var typedSource = (EnsSubscriptionToken)source;
				SubscriptionId = typedSource.SubscriptionId;
				EntityId = typedSource.EntityId;
				EventTypes = typedSource.EventTypes;
				IncludeProgeny = typedSource.IncludeProgeny;
				LastEventCount = typedSource.LastEventCount;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("SubscriptionId", out token) && token.Type != JTokenType.Null)
				{
					SubscriptionId = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("EntityId", out token) && token.Type != JTokenType.Null)
				{
					EntityId = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("EventTypes", out token) && token.Type != JTokenType.Null)
				{
					EventTypes = (SafeEnum<EnsEventType>)serializer.Deserialize(token.CreateReader(), typeof(SafeEnum<EnsEventType>));
				}
				if(source.TryGetProperty("IncludeProgeny", out token) && token.Type != JTokenType.Null)
				{
					IncludeProgeny = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("LastEventCount", out token) && token.Type != JTokenType.Null)
				{
					LastEventCount = (long)serializer.Deserialize(token.CreateReader(), typeof(long));
				}
			}
		}
	}
}
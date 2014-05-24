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
	public class EnsSubscriberConfiguration : ODataObject 
	{

		public bool IsEnsEnabled { get; set; }

		public string EnsServerUrl { get; set; }

		public string Version { get; set; }

		public object RecommendedPollingSyncInterval { get; set; }

		public object RecommendedNotificationSyncInterval { get; set; }

		public int NotificationConfigurationCount { get; set; }

		public int FailSafePollingCount { get; set; }

		public int MaxNotificationSyncWaitCount { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			if(source.GetType().IsSubclassOf(GetType()) || GetType() == source.GetType())
			{
				var typedSource = (EnsSubscriberConfiguration)source;
				IsEnsEnabled = typedSource.IsEnsEnabled;
				EnsServerUrl = typedSource.EnsServerUrl;
				Version = typedSource.Version;
				RecommendedPollingSyncInterval = typedSource.RecommendedPollingSyncInterval;
				RecommendedNotificationSyncInterval = typedSource.RecommendedNotificationSyncInterval;
				NotificationConfigurationCount = typedSource.NotificationConfigurationCount;
				FailSafePollingCount = typedSource.FailSafePollingCount;
				MaxNotificationSyncWaitCount = typedSource.MaxNotificationSyncWaitCount;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("IsEnsEnabled", out token) && token.Type != JTokenType.Null)
				{
					IsEnsEnabled = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("EnsServerUrl", out token) && token.Type != JTokenType.Null)
				{
					EnsServerUrl = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Version", out token) && token.Type != JTokenType.Null)
				{
					Version = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("RecommendedPollingSyncInterval", out token) && token.Type != JTokenType.Null)
				{
					RecommendedPollingSyncInterval = (object)serializer.Deserialize(token.CreateReader(), typeof(object));
				}
				if(source.TryGetProperty("RecommendedNotificationSyncInterval", out token) && token.Type != JTokenType.Null)
				{
					RecommendedNotificationSyncInterval = (object)serializer.Deserialize(token.CreateReader(), typeof(object));
				}
				if(source.TryGetProperty("NotificationConfigurationCount", out token) && token.Type != JTokenType.Null)
				{
					NotificationConfigurationCount = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
				if(source.TryGetProperty("FailSafePollingCount", out token) && token.Type != JTokenType.Null)
				{
					FailSafePollingCount = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
				if(source.TryGetProperty("MaxNotificationSyncWaitCount", out token) && token.Type != JTokenType.Null)
				{
					MaxNotificationSyncWaitCount = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
			}
		}
	}
}
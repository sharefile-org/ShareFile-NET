// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2015 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;

namespace ShareFile.Api.Models 
{
#if ShareFile
	public class QueueEntry : ODataObject 
	{

		public DateTime? CreationDate { get; set; }

		public DateTime? ModifiedDate { get; set; }

		public SafeEnum<QueueStatus> Status { get; set; }

		public bool? IsLocked { get; set; }

		public string WorkerName { get; set; }

		public IDictionary<string, string> Payload { get; set; }

		public int ErrorCount { get; set; }

		public int ErrorCode { get; set; }

		public string ErrorMessage { get; set; }

		public Queue Queue { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as QueueEntry;
			if(typedSource != null)
			{
				CreationDate = typedSource.CreationDate;
				ModifiedDate = typedSource.ModifiedDate;
				Status = typedSource.Status;
				IsLocked = typedSource.IsLocked;
				WorkerName = typedSource.WorkerName;
				Payload = typedSource.Payload;
				ErrorCount = typedSource.ErrorCount;
				ErrorCode = typedSource.ErrorCode;
				ErrorMessage = typedSource.ErrorMessage;
				Queue = typedSource.Queue;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("CreationDate", out token) && token.Type != JTokenType.Null)
				{
					CreationDate = (DateTime?)serializer.Deserialize(token.CreateReader(), typeof(DateTime?));
				}
				if(source.TryGetProperty("ModifiedDate", out token) && token.Type != JTokenType.Null)
				{
					ModifiedDate = (DateTime?)serializer.Deserialize(token.CreateReader(), typeof(DateTime?));
				}
				if(source.TryGetProperty("Status", out token) && token.Type != JTokenType.Null)
				{
					Status = (SafeEnum<QueueStatus>)serializer.Deserialize(token.CreateReader(), typeof(SafeEnum<QueueStatus>));
				}
				if(source.TryGetProperty("IsLocked", out token) && token.Type != JTokenType.Null)
				{
					IsLocked = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("WorkerName", out token) && token.Type != JTokenType.Null)
				{
					WorkerName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Payload", out token) && token.Type != JTokenType.Null)
				{
					Payload = (IDictionary<string, string>)serializer.Deserialize(token.CreateReader(), typeof(IDictionary<string, string>));
				}
				if(source.TryGetProperty("ErrorCount", out token) && token.Type != JTokenType.Null)
				{
					ErrorCount = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
				if(source.TryGetProperty("ErrorCode", out token) && token.Type != JTokenType.Null)
				{
					ErrorCode = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
				if(source.TryGetProperty("ErrorMessage", out token) && token.Type != JTokenType.Null)
				{
					ErrorMessage = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Queue", out token) && token.Type != JTokenType.Null)
				{
					Queue = (Queue)serializer.Deserialize(token.CreateReader(), typeof(Queue));
				}
			}
		}
	}
#endif
}
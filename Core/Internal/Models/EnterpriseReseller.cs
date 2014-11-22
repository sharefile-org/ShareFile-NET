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
#if ShareFile
	public class EnterpriseReseller : ODataObject 
	{

		public string City { get; set; }

		public string Country { get; set; }

		public string CustomerNo { get; set; }

		public string CompanyName { get; set; }

		public string Phone { get; set; }

		public string State { get; set; }

		public string Street { get; set; }

		public string ZipCode { get; set; }

		public string OrgId { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as EnterpriseReseller;
			if(typedSource != null)
			{
				City = typedSource.City;
				Country = typedSource.Country;
				CustomerNo = typedSource.CustomerNo;
				CompanyName = typedSource.CompanyName;
				Phone = typedSource.Phone;
				State = typedSource.State;
				Street = typedSource.Street;
				ZipCode = typedSource.ZipCode;
				OrgId = typedSource.OrgId;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("City", out token) && token.Type != JTokenType.Null)
				{
					City = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Country", out token) && token.Type != JTokenType.Null)
				{
					Country = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("CustomerNo", out token) && token.Type != JTokenType.Null)
				{
					CustomerNo = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("CompanyName", out token) && token.Type != JTokenType.Null)
				{
					CompanyName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Phone", out token) && token.Type != JTokenType.Null)
				{
					Phone = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("State", out token) && token.Type != JTokenType.Null)
				{
					State = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Street", out token) && token.Type != JTokenType.Null)
				{
					Street = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("ZipCode", out token) && token.Type != JTokenType.Null)
				{
					ZipCode = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("OrgId", out token) && token.Type != JTokenType.Null)
				{
					OrgId = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
			}
		}
	}
#endif
}
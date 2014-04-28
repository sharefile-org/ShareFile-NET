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
using System.IO;
using ShareFile.Api.Models;
using ShareFile.Api.Client;
using ShareFile.Api.Client.Requests;

namespace ShareFile.Api.Client.Entities
{
#if ShareFile

	public interface IDevicesEntityInternal : IEntityBase
	{
		/// <summary>
		/// Get Device Users for Current User
		/// </summary>
		/// <returns>
		/// A feed of DeviceUser objects
		/// </returns>
		IQuery<ODataFeed<DeviceUser>> Get();
		/// <summary>
		/// Get Device by ID
		/// </summary>
		/// <param name="id"></param>
		/// <returns>
		/// Device
		/// </returns>
		IQuery<Device> Get(string id);
		IQuery<ODataFeed<DeviceUser>> GetByUser(string userId);
		/// <summary>
		/// Delete Device
		/// </summary>
		/// <param name="id"></param>
		/// <returns>
		/// no data on success
		/// </returns>
		IQuery Delete(string id);
		IQuery DeleteByUser(string userId, string deviceId);
		IQuery<DeviceUser> CreateByUser(string userId, DeviceUser du);
		/// <summary>
		/// Wipe Device
		/// </summary>
		/// <param name="deviceID"></param>
		/// <param name="userid"></param>
		/// <returns>
		/// no data on success
		/// </returns>
		IQuery Wipe(string deviceID, string userid = null);
		/// <summary>
		/// Signal Wipe Done
		/// </summary>
		/// <example>
		/// {
		/// "Logs" :
		/// [
		/// { "FileName":"fileA",
		/// "FileID":"id",
		/// "Timestamp":0,
		/// "AccountID":"id",
		/// "UserID":"userId1",
		/// "Action":"OpenGeneric",
		/// "AdditionalInfo":""
		/// },
		/// ...
		/// ],
		/// "WipeResults" :
		/// [
		/// {"id":"userId1", "WipeToken":"token1", "Success":"true", "ErrorMessage":"" },
		/// {"id":"userId1", "WipeToken":"token2", "Success":"false", "ErrorMessage":"some error" },
		/// ...
		/// ]
		/// }
		/// </example>
		/// <remarks>
		/// Signal that a device wipe has been completed
		/// </remarks>
		/// <param name="deviceID"></param>
		/// <param name="deviceWipeReport"></param>
		/// <param name="singlePlane"></param>
		/// <returns>
		/// no data on success
		/// </returns>
		IQuery WipeDone(string deviceID, DeviceWipeReport deviceWipeReport, bool singlePlane = false);
		/// <summary>
		/// Check Device Status
		/// </summary>
		/// <param name="deviceID"></param>
		/// <returns>
		/// DeviceStatus
		/// </returns>
		IQuery<DeviceStatus> Status(string deviceID);
	}

	public class DevicesEntityInternal : EntityBase, IDevicesEntityInternal
	{
		public DevicesEntityInternal(IShareFileClient client)
			: base (client, "Devices")
			
		{

		}

		/// <summary>
		/// Get Device Users for Current User
		/// </summary>
		/// <returns>
		/// A feed of DeviceUser objects
		/// </returns>
		public IQuery<ODataFeed<DeviceUser>> Get()
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<DeviceUser>>(Client);
			sfApiQuery.From("Devices");
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get Device by ID
		/// </summary>
		/// <param name="id"></param>
		/// <returns>
		/// Device
		/// </returns>
		public IQuery<Device> Get(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Device>(Client);
			sfApiQuery.From("Devices");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		public IQuery<ODataFeed<DeviceUser>> GetByUser(string userId)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<DeviceUser>>(Client);
			sfApiQuery.From("User");
			sfApiQuery.Action("Devices");
			sfApiQuery.Ids(userId);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Delete Device
		/// </summary>
		/// <param name="id"></param>
		/// <returns>
		/// no data on success
		/// </returns>
		public IQuery Delete(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("Devices");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "DELETE";
			return sfApiQuery;
		}

		public IQuery DeleteByUser(string userId, string deviceId)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("User");
			sfApiQuery.Action("Devices");
			sfApiQuery.Ids(userId);
			sfApiQuery.ActionIds(deviceId);
			sfApiQuery.HttpMethod = "DELETE";
			return sfApiQuery;
		}

		public IQuery<DeviceUser> CreateByUser(string userId, DeviceUser du)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<DeviceUser>(Client);
			sfApiQuery.From("User");
			sfApiQuery.Action("Devices");
			sfApiQuery.Ids(userId);
			sfApiQuery.Body = du;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Wipe Device
		/// </summary>
		/// <param name="deviceID"></param>
		/// <param name="userid"></param>
		/// <returns>
		/// no data on success
		/// </returns>
		public IQuery Wipe(string deviceID, string userid = null)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("Devices");
			sfApiQuery.Action("Wipe");
			sfApiQuery.Ids(deviceID);
			sfApiQuery.QueryString("userid", userid);
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Signal Wipe Done
		/// </summary>
		/// <example>
		/// {
		/// "Logs" :
		/// [
		/// { "FileName":"fileA",
		/// "FileID":"id",
		/// "Timestamp":0,
		/// "AccountID":"id",
		/// "UserID":"userId1",
		/// "Action":"OpenGeneric",
		/// "AdditionalInfo":""
		/// },
		/// ...
		/// ],
		/// "WipeResults" :
		/// [
		/// {"id":"userId1", "WipeToken":"token1", "Success":"true", "ErrorMessage":"" },
		/// {"id":"userId1", "WipeToken":"token2", "Success":"false", "ErrorMessage":"some error" },
		/// ...
		/// ]
		/// }
		/// </example>
		/// <remarks>
		/// Signal that a device wipe has been completed
		/// </remarks>
		/// <param name="deviceID"></param>
		/// <param name="deviceWipeReport"></param>
		/// <param name="singlePlane"></param>
		/// <returns>
		/// no data on success
		/// </returns>
		public IQuery WipeDone(string deviceID, DeviceWipeReport deviceWipeReport, bool singlePlane = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("Devices");
			sfApiQuery.Action("WipeDone");
			sfApiQuery.Ids(deviceID);
			sfApiQuery.QueryString("singlePlane", singlePlane);
			sfApiQuery.Body = deviceWipeReport;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Check Device Status
		/// </summary>
		/// <param name="deviceID"></param>
		/// <returns>
		/// DeviceStatus
		/// </returns>
		public IQuery<DeviceStatus> Status(string deviceID)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<DeviceStatus>(Client);
			sfApiQuery.From("Devices");
			sfApiQuery.Action("Status");
			sfApiQuery.Ids(deviceID);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

	}
#endif
}

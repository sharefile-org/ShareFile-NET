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

	public interface IAccessControlsEntity : IEntityBase
	{
		/// <summary>
		/// Get AccessControl by ID
		/// </summary>
		/// <remarks>
		/// Retrieves a single Access Control entry for a given Item and Principal
		/// </remarks>
		/// <param name="principalid"></param>
		/// <param name="itemid"></param>
		/// <returns>
		/// A single AccessControl object matching the query
		/// </returns>
		IQuery<AccessControl> Get(string principalid, string itemid);
		/// <summary>
		/// Get AccessControl List By Item
		/// </summary>
		/// <remarks>
		/// Retrieves the Access Control List for a given Item.
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// Access Control List of the given object ID.
		/// </returns>
		IQuery<ODataFeed<AccessControl>> GetByItem(string id);
		/// <summary>
		/// Create AccessControl
		/// </summary>
		/// <example>
		/// {
		/// "Principal":{"url":"https://account.sf-api.com/v3/Groups(id)"},
		/// "CanUpload":true,
		/// "CanDownload":true,
		/// "CanView":true,
		/// "CanDelete":true,
		/// "CanManagePermissions":true,
		/// "Message":"Message"
		/// }
		/// </example>
		/// <remarks>
		/// Creates a new Access Controls entry for a given Item. Access controls can only define a single Principal,
		/// which can be either a Group or User. The 'Principal' element is specified as an object - you should populate
		/// either the URL or the ID reference.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="accessControl"></param>
		/// <param name="recursive"></param>
		/// <param name="message"></param>
		/// <param name="sendDefaultNotification"></param>
		/// <returns>
		/// the created or modified AccessControl instance
		/// </returns>
		IQuery<AccessControl> CreateByItem(string id, AccessControl accessControl, bool recursive = false, bool sendDefaultNotification = false, string message = null);
		/// <summary>
		/// Update AccessControl
		/// </summary>
		/// <example>
		/// {
		/// "Principal":{"Email":"user@domain.com"},
		/// "CanUpload":true,
		/// "CanDownload":true,
		/// "CanView":true,
		/// "CanDelete":true,
		/// "CanManagePermissions":true
		/// }
		/// </example>
		/// <remarks>
		/// Updates an existing Access Controls of a given Item. The Principal element cannot be modified, it is provided
		/// in the Body to identity the AccessControl element to be modified. You can provide an ID, Email or URL on the
		/// Principal object.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="accessControl"></param>
		/// <param name="recursive"></param>
		/// <returns>
		/// the created or modified AccessControl instance
		/// </returns>
		IQuery<AccessControl> UpdateByItem(string id, AccessControl accessControl, bool recursive = false);
		/// <summary>
		/// Delete AccessControl
		/// </summary>
		/// <remarks>
		/// Deletes an AccessControl entry by itemID and principalID. This method does not return any object, a 204 (No Content)
		/// response indicates success.
		/// </remarks>
		/// <param name="principalid"></param>
		/// <param name="itemid"></param>
		IQuery Delete(string principalid, string itemid);
	}

	public class AccessControlsEntity : EntityBase, IAccessControlsEntity
	{
		public AccessControlsEntity(IShareFileClient client)
			: base (client, "AccessControls")
			
		{

		}

		/// <summary>
		/// Get AccessControl by ID
		/// </summary>
		/// <remarks>
		/// Retrieves a single Access Control entry for a given Item and Principal
		/// </remarks>
		/// <param name="principalid"></param>
		/// <param name="itemid"></param>
		/// <returns>
		/// A single AccessControl object matching the query
		/// </returns>
		public IQuery<AccessControl> Get(string principalid, string itemid)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<AccessControl>(Client);
			sfApiQuery.From("AccessControls");
			sfApiQuery.Ids("principalid", principalid);
			sfApiQuery.Ids("itemid", itemid);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get AccessControl List By Item
		/// </summary>
		/// <remarks>
		/// Retrieves the Access Control List for a given Item.
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// Access Control List of the given object ID.
		/// </returns>
		public IQuery<ODataFeed<AccessControl>> GetByItem(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<AccessControl>>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("AccessControls");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Create AccessControl
		/// </summary>
		/// <example>
		/// {
		/// "Principal":{"url":"https://account.sf-api.com/v3/Groups(id)"},
		/// "CanUpload":true,
		/// "CanDownload":true,
		/// "CanView":true,
		/// "CanDelete":true,
		/// "CanManagePermissions":true,
		/// "Message":"Message"
		/// }
		/// </example>
		/// <remarks>
		/// Creates a new Access Controls entry for a given Item. Access controls can only define a single Principal,
		/// which can be either a Group or User. The 'Principal' element is specified as an object - you should populate
		/// either the URL or the ID reference.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="accessControl"></param>
		/// <param name="recursive"></param>
		/// <param name="message"></param>
		/// <param name="sendDefaultNotification"></param>
		/// <returns>
		/// the created or modified AccessControl instance
		/// </returns>
		public IQuery<AccessControl> CreateByItem(string id, AccessControl accessControl, bool recursive = false, bool sendDefaultNotification = false, string message = null)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<AccessControl>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("AccessControls");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("recursive", recursive);
			sfApiQuery.QueryString("sendDefaultNotification", sendDefaultNotification);
			accessControl.Properties["message"] = message;
			sfApiQuery.Body = accessControl;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Update AccessControl
		/// </summary>
		/// <example>
		/// {
		/// "Principal":{"Email":"user@domain.com"},
		/// "CanUpload":true,
		/// "CanDownload":true,
		/// "CanView":true,
		/// "CanDelete":true,
		/// "CanManagePermissions":true
		/// }
		/// </example>
		/// <remarks>
		/// Updates an existing Access Controls of a given Item. The Principal element cannot be modified, it is provided
		/// in the Body to identity the AccessControl element to be modified. You can provide an ID, Email or URL on the
		/// Principal object.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="accessControl"></param>
		/// <param name="recursive"></param>
		/// <returns>
		/// the created or modified AccessControl instance
		/// </returns>
		public IQuery<AccessControl> UpdateByItem(string id, AccessControl accessControl, bool recursive = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<AccessControl>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("AccessControls");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("recursive", recursive);
			sfApiQuery.Body = accessControl;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Delete AccessControl
		/// </summary>
		/// <remarks>
		/// Deletes an AccessControl entry by itemID and principalID. This method does not return any object, a 204 (No Content)
		/// response indicates success.
		/// </remarks>
		/// <param name="principalid"></param>
		/// <param name="itemid"></param>
		public IQuery Delete(string principalid, string itemid)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("AccessControls");
			sfApiQuery.Ids("principalid", principalid);
			sfApiQuery.Ids("itemid", itemid);
			sfApiQuery.HttpMethod = "DELETE";
			return sfApiQuery;
		}

	}
}

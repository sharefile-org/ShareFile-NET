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
	public class FavoriteFoldersEntity : EntityBase
	{
		public FavoriteFoldersEntity(IShareFileClient client)
			: base (client, "FavoriteFolders")
			
		{

		}

		/// <summary>
		/// Get List of FavoriteFolders
		/// </summary>
		/// <remarks>
		/// Retrieves the list of Favorite folders for a given user.
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// A list of Favorite Folders specified by this user
		/// </returns>
		public IQuery<ODataFeed<FavoriteFolder>> GetByUser(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<FavoriteFolder>>(Client);
			sfApiQuery.From("User");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get FavoriteFolder
		/// </summary>
		/// <remarks>
		/// Retrieves a single Favorite Folder
		/// </remarks>
		/// <param name="userid"></param>
		/// <param name="itemid"></param>
		/// <returns>
		/// A list of Favorite Folders specified by this user
		/// </returns>
		public IQuery<FavoriteFolder> GetByUser(string itemid, string userid)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<FavoriteFolder>(Client);
			sfApiQuery.From("User");
			sfApiQuery.Action("FavoriteFolders");
			sfApiQuery.Ids(itemid);
			sfApiQuery.ActionIds(userid);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get FavoriteFolder
		/// </summary>
		/// <remarks>
		/// Retrieve a single Favorite Folder from a give user
		/// </remarks>
		/// <param name="userid"></param>
		/// <param name="itemid"></param>
		/// <returns>
		/// The selected Favorite Folder
		/// </returns>
		public IQuery<FavoriteFolder> Get(string userid, string itemid)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<FavoriteFolder>(Client);
			sfApiQuery.From("FavoriteFolders");
			sfApiQuery.Ids("userid", userid);
			sfApiQuery.Ids("itemid", itemid);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Create FavoriteFolder
		/// </summary>
		/// <example>
		/// {
		/// "Folder": { "Id":"fo96aec5-d637-4124-bcc9-c86fd7301e4d" },
		/// "FolderAlias" : "alias"
		/// }
		/// </example>
		/// <remarks>
		/// Adds an existing folder to the list of favorites of a given user.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="folder"></param>
		/// <returns>
		/// A new FavoriteFolder record
		/// </returns>
		public IQuery<FavoriteFolder> CreateByUser(string id, FavoriteFolder folder)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<FavoriteFolder>(Client);
			sfApiQuery.From("User");
			sfApiQuery.Action("FavoriteFolders");
			sfApiQuery.Ids(id);
			sfApiQuery.Body = folder;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Delete FavoriteFolder
		/// </summary>
		/// <remarks>
		/// Removes a favorite folder from a user's list.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="itemid"></param>
		public IQuery Delete(string id, string itemid)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("User");
			sfApiQuery.Action("FavoriteFolders");
			sfApiQuery.Ids(id);
			sfApiQuery.ActionIds(itemid);
			sfApiQuery.HttpMethod = "DELETE";
			return sfApiQuery;
		}

		public IQuery DeleteByUser(string userId, string itemId)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("User");
			sfApiQuery.Action("FavoriteFolders");
			sfApiQuery.Ids(userId);
			sfApiQuery.ActionIds(itemId);
			sfApiQuery.HttpMethod = "DELETE";
			return sfApiQuery;
		}

	}
}

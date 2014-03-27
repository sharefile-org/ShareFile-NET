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
	public class ItemsEntity : EntityBase
	{
		public ItemsEntity(IShareFileClient client)
			: base (client, "Items")
			
		{

		}

		/// <summary>
		/// Get List of Items
		/// </summary>
		/// <remarks>
		/// Retrieve the initial folder and files of the authenticated user.
		/// This method will return the user's root directory, using Item.GetRootFromWasabiPath("root").
		/// It will force expansion of the Children element, so first level of items under the root is also returned
		/// </remarks>
		/// <returns>
		/// a user's root directory and first level of children items
		/// </returns>
		public IQuery<Item> Get()
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Item>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get Item by ID
		/// </summary>
		/// <remarks>
		/// Returns a single Item
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// a single Item
		/// </returns>
		public IQuery<Item> Get(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Item>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		public IQuery<Item> Get(string id, TreeMode treeMode, string sourceId, string rootId = null, bool canCreateRootFolder = false, bool fileBox = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Item>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("treeMode", treeMode);
			sfApiQuery.QueryString("sourceId", sourceId);
			sfApiQuery.QueryString("rootId", rootId);
			sfApiQuery.QueryString("canCreateRootFolder", canCreateRootFolder);
			sfApiQuery.QueryString("fileBox", fileBox);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get Stream
		/// </summary>
		/// <remarks>
		/// Retrieves the versions of a given Stream.
		/// An Item represents a single version of a file system object. The stream identifies
		/// all versions of the same file system object. For example, when users upload or modify an existing file, a new Item
		/// is created with the same StreamID. All default Item enumerations return only the latest version of a given stream.
		/// Use this method to retrieve previous versions of a given stream
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="includeDeleted"></param>
		public IQuery<ODataFeed<Item>> Stream(string id, bool includeDeleted = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Item>>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Stream");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("includeDeleted", includeDeleted);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get Item by Path
		/// </summary>
		/// <remarks>
		/// Retrieves an item from its path. The path is of format /foldername/foldername/filename
		/// This call may redirect the client to another API provider, if the path
		/// contains a symbolic link.
		/// </remarks>
		/// <param name="path"></param>
		/// <returns>
		/// An item identified by a path
		/// </returns>
		public IQuery<Item> ByPath(string path)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Item>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("ByPath");
			sfApiQuery.QueryString("path", path);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get Item by relative Path from ID
		/// </summary>
		/// <remarks>
		/// Retrieves an item from its path, relative to the provided ID.
		/// The path is of format /foldername/foldername/filename
		/// This call may redirect the client to another API provider, if the path
		/// contains a symbolic link.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="path"></param>
		/// <returns>
		/// An item identified by a path
		/// </returns>
		public IQuery<Item> ByPath(string id, string path)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Item>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("ByPath");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("path", path);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get Parent Item
		/// </summary>
		/// <remarks>
		/// Retrieves the Parent navigation property of a single Item.
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// the Parent Item of the give object ID.
		/// </returns>
		public IQuery<Item> GetParent(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Item>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Parent");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get Children
		/// </summary>
		/// <remarks>
		/// Handler for the Children navigation property of a given Item.
		/// A 302 redirection is returned if the folder is a SymbolicLink. The redirection
		/// will enumerate the children of the remote connector
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// the list of children under the given object ID
		/// </returns>
		public IQuery<ODataFeed<Item>> GetChildren(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Item>>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Children");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get Folder Access Info
		/// </summary>
		/// <remarks>
		/// Returns the effective Access Controls for the current authenticated user for the
		/// selected folder - i.e., the resulting set of Access Controls for the Item/User context.This operation applies to Folders only, will return an error for other Item types.
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// The Folder Access Control Information
		/// </returns>
		public IQuery<ItemInfo> GetInfo(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ItemInfo>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Info");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Download Item Content
		/// </summary>
		/// <remarks>
		/// Initiate the download operation for an item. It will return 302 redirection to the
		/// actual download link. For Folders, the download link will retrieve a ZIP archive
		/// with the contents of the Folder.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="redirect"></param>
		/// <returns>
		/// the download link for the provided item content.
		/// </returns>
		public IQuery<DownloadSpecification> Download(string id, bool redirect = true)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<DownloadSpecification>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Download");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("redirect", redirect);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Create Folder
		/// </summary>
		/// <example>
		/// {
		/// "Name":"Folder Name",
		/// "Description":"Description",
		/// "Zone":{ "Id":"z014766e-8e96-4615-86aa-57132a69843c" }
		/// }
		/// </example>
		/// <remarks>
		/// Creates a new Folder.
		/// The POST body must contain the serialized object.
		/// For top-level folders, use Items/Folder.
		/// The Zone object may only be provided for top-level folders. The Zone object must
		/// contain a zone ID.
		/// </remarks>
		/// <param name="parentid"></param>
		/// <param name="folder"></param>
		/// <param name="overwrite"></param>
		/// <param name="passthrough"></param>
		/// <returns>
		/// the new Folder
		/// </returns>
		public IQuery<Folder> CreateFolder(string parentid, Folder folder, bool overwrite = false, bool passthrough = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Folder>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Folder");
			sfApiQuery.Ids(parentid);
			sfApiQuery.QueryString("overwrite", overwrite);
			sfApiQuery.QueryString("passthrough", passthrough);
			sfApiQuery.Body = folder;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Create Note
		/// </summary>
		/// <example>
		/// {
		/// "Name":"Note Name",
		/// "Description":"Description"
		/// }
		/// </example>
		/// <remarks>
		/// Creates a new Note.
		/// </remarks>
		/// <param name="parentid"></param>
		/// <param name="note"></param>
		/// <returns>
		/// the new Note
		/// </returns>
		public IQuery<Note> CreateNote(string parentid, Note note)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Note>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Note");
			sfApiQuery.Ids(parentid);
			sfApiQuery.Body = note;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Create Link
		/// </summary>
		/// <example>
		/// {
		/// "Name":"Link Name",
		/// "Description":"Description",
		/// "Uri":"https://server/path"
		/// }
		/// </example>
		/// <remarks>
		/// Creates a new Link
		/// </remarks>
		/// <param name="parentid"></param>
		/// <param name="link"></param>
		/// <returns>
		/// the new Link
		/// </returns>
		public IQuery<Link> CreateLink(string parentid, Link link)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Link>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Link");
			sfApiQuery.Ids(parentid);
			sfApiQuery.Body = link;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Create SymbolicLink
		/// </summary>
		/// <example>
		/// {
		/// "Name":"Connection Name",
		/// "Description":"Description",
		/// "Link":"https://server/path"
		/// }
		/// {
		/// "FileName":"RemoteFileName",
		/// "Description":"Description",
		/// "Zone":{ "Id":"z014766e-8e96-4615-86aa-57132a69843c" }
		/// }
		/// </example>
		/// <remarks>
		/// Creates a Symbolic Link
		/// The body must contain either a "Link" parameter with a fully qualified URI; or use
		/// FileName + Zone to have sharefile.com attempt to convert the Connector path to an
		/// URI using a call to the Zone - using ShareFile Hash authentication mode. For active
		/// clients, it's recommended to make the convertion call to the Zone directly, using
		/// Items/ByPath=name, retriving the resulting URL, and calling this method with the
		/// Link parameter.SymbolicLinks must be created as top-level folders
		/// </remarks>
		/// <param name="parentid"></param>
		/// <param name="symlink"></param>
		/// <param name="overwrite"></param>
		/// <returns>
		/// the new SymbolicLink
		/// </returns>
		public IQuery<SymbolicLink> CreateSymbolicLink(string parentid, SymbolicLink symlink, bool overwrite = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<SymbolicLink>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("SymbolicLink");
			sfApiQuery.Ids(parentid);
			sfApiQuery.QueryString("overwrite", overwrite);
			sfApiQuery.Body = symlink;
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Update Item
		/// </summary>
		/// <example>
		/// {
		/// "Name":"Name",
		/// "FileName":"FileName",
		/// "Description":"Description",
		/// "ExpirationDate": "date",
		/// "Parent": { "Id": "parentid" },
		/// "Zone": { "Id": "zoneid" }
		/// }
		/// </example>
		/// <remarks>
		/// Updates an Item object
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="item"></param>
		/// <returns>
		/// A modified Item object. If the item Zone or Parent Zone is modified, then this
		/// method will return an Asynchronous operation record instead. Note: the parameters listed in the
		/// body of the request are the only parameters that can be updated through this call.
		/// </returns>
		public IQuery<Item> Update(string id, Item item)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Item>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Ids(id);
			sfApiQuery.Body = item;
			sfApiQuery.HttpMethod = "PATCH";
			return sfApiQuery;
		}

		/// <summary>
		/// Update Link
		/// </summary>
		/// <example>
		/// {
		/// "Name":"Name",
		/// "Uri":"https://server/path",
		/// "Description":"Description",
		/// "Parent": { "Id": "parentid" },
		/// }
		/// </example>
		/// <remarks>
		/// Updates a Link object
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="link"></param>
		/// <param name="notify"></param>
		/// <returns>
		/// A modified Link object
		/// </returns>
		public IQuery<Item> UpdateLink(string id, Link link, bool notify = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Item>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Link");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("notify", notify);
			sfApiQuery.Body = link;
			sfApiQuery.HttpMethod = "PATCH";
			return sfApiQuery;
		}

		/// <summary>
		/// Update Note
		/// </summary>
		/// <example>
		/// {
		/// "Name":"Name",
		/// "Description":"Description",
		/// "Parent": { "Id": "parentid" },
		/// }
		/// </example>
		/// <remarks>
		/// Updates a Note object
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="note"></param>
		/// <param name="notify"></param>
		/// <returns>
		/// The modified Note object
		/// </returns>
		public IQuery<Item> UpdateNote(string id, Note note, bool notify = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Item>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Note");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("notify", notify);
			sfApiQuery.Body = note;
			sfApiQuery.HttpMethod = "PATCH";
			return sfApiQuery;
		}

		/// <summary>
		/// Update SymbolicLink
		/// </summary>
		/// <example>
		/// {
		/// "Name":"Name",
		/// "Description":"Description",
		/// "Link": "https://server/path"
		/// }
		/// </example>
		/// <remarks>
		/// Updates a Symbolic Link object
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="symlink"></param>
		/// <returns>
		/// The modified SymbolicLink object
		/// </returns>
		public IQuery<SymbolicLink> UpdateSymbolicLink(string id, SymbolicLink symlink)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<SymbolicLink>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("SymbolicLink");
			sfApiQuery.Ids(id);
			sfApiQuery.Body = symlink;
			sfApiQuery.HttpMethod = "PATCH";
			return sfApiQuery;
		}

		public IQuery Delete(string id, bool singleversion = false, bool forceSync = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("singleversion", singleversion);
			sfApiQuery.QueryString("forceSync", forceSync);
			sfApiQuery.HttpMethod = "PATCH";
			return sfApiQuery;
		}

		/// <summary>
		/// Delete Multiple Items
		/// </summary>
		/// <example>
		/// ["id1","id2",...]
		/// </example>
		/// <remarks>
		/// All items in bulk delete must be children of the same parent, identified in the URI
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="body"></param>
		public IQuery BulkDelete(string parentid, IEnumerable<string> ids, bool forceSync = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("BulkDelete");
			sfApiQuery.Ids(parentid);
			sfApiQuery.QueryString("ids", ids);
			sfApiQuery.QueryString("forceSync", forceSync);
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		public IQuery<Stream> GetThumbnail(string parentid, int size = 75, bool redirect = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Stream>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Thumbnail");
			sfApiQuery.Ids(parentid);
			sfApiQuery.QueryString("size", size);
			sfApiQuery.QueryString("redirect", redirect);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get Breadcrumbs
		/// </summary>
		/// <remarks>
		/// Retrieves the path from an item from the root. The return list is a Feed of Items, with the top-level
		/// folder at the first position. If this item is in a Connection path, the breadcrumbs may contain URL
		/// reference back to the parent account - and the Item in the feed will contain just the URL reference.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="path"></param>
		/// <param name="vroot"></param>
		/// <returns>
		/// A feed containing the path of folders from the specified root to the item, in order
		/// </returns>
		public IQuery<ODataFeed<Item>> GetBreadcrumbs(string id, string path = null, VRootType vroot = VRootType.Default)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Item>>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Breadcrumbs");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("path", path);
			sfApiQuery.QueryString("vroot", vroot);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Copy Item
		/// </summary>
		/// <remarks>
		/// Copies an item to a new target Folder. If the target folder is in another zone, the operation will
		/// return an AsyncOperation record instead. Clients may query the /AsyncOperation Entity to determine
		/// operation progress and result.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="targetid"></param>
		/// <param name="overwrite"></param>
		/// <returns>
		/// the modified source object
		/// </returns>
		public IQuery<Item> Copy(string id, string targetid, bool overwrite = false)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Item>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Copy");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("targetid", targetid);
			sfApiQuery.QueryString("overwrite", overwrite);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Upload File
		/// </summary>
		/// <remarks>
		/// Prepares the links for uploading files to the target Folder.
		/// This method returns an Upload Specification object. The fields are
		/// populated based on the upload method, provider, and resume parameters passed to the
		/// upload call.
		/// The Method determines how the URLs must be called.
		/// 
		/// Standard uploads use a single HTTP POST message to the ChunkUri address provided in
		/// the response. All other fields will be empty. Standard uploads do not support Resume.
		/// 
		/// Streamed uploads use multiple HTTP POST calls to the ChunkUri address. The client must
		/// append the parameters index, offset and hash to the end of the ChunkUri address. Index
		/// is a sequential number representing the data block (zero-based); Offset represents the
		/// byte offset for the block; and hash contains the MD5 hash of the block. The last HTTP
		/// POST must also contain finish=true parameter.
		/// 
		/// Threaded uploads use multiple HTTP POST calls to ChunkUri, and can have a number of
		/// threads issuing blocks in parallel. Clients must append index, offset and hash to
		/// the end of ChunkUri, as explained in Streamed. After all chunks were sent, the client
		/// must call the FinishUri provided in this spec.
		/// 
		/// For all uploaders, the contents of the POST Body can either be "raw", if the "Raw" parameter
		/// was provided to the Uploader, or use MIME multi-part form encoding otherwise. Raw uploads
		/// simply put the block content in the POST body - Content-Length specifies the size. Multi-part
		/// form encoding has to pass the File as a Form parameter named "File1".
		/// 
		/// For streamed and threaded, if Resume options were provided to the Upload call, then the
		/// fields IsResume, ResumeIndex, ResumeOffset and ResumeFileHash MAY be populated. If they are,
		/// it indicates that the server has identified a partial upload with that specification, and is
		/// ready to resume on the provided parameters. The clients can then verify the ResumeFileHash to
		/// ensure the file has not been modified; and continue issuing ChunkUri calls from the ResumeIndex
		/// ResumeOffset parameters. If the client decides to restart, it should simply ignore the resume
		/// parameters and send the blocks from Index 0.
		/// 
		/// For all uploaders: the result code for the HTTP POST calls to Chunk and Finish Uri can either
		/// be a 401 - indicating authentication is required; 4xx/5xx indicating some kind of error; or
		/// 200 with a Content Body of format 'ERROR:message'. Successful calls will return either a 200
		/// response with no Body, or with Body of format 'OK'.
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="method"></param>
		/// <param name="raw"></param>
		/// <param name="fileName"></param>
		/// <param name="fileSize"></param>
		/// <param name="batchId"></param>
		/// <param name="batchLast"></param>
		/// <param name="canResume"></param>
		/// <param name="startOver"></param>
		/// <param name="unzip"></param>
		/// <param name="tool"></param>
		/// <param name="overwrite"></param>
		/// <param name="title"></param>
		/// <param name="details"></param>
		/// <param name="isSend"></param>
		/// <param name="sendGuid"></param>
		/// <param name="opid"></param>
		/// <param name="threadCount"></param>
		/// <param name="responseFormat"></param>
		/// <param name="notify"></param>
		/// <param name="clientCreatedDateUTC"></param>
		/// <param name="clientModifiedDateUTC"></param>
		/// <returns>
		/// an Upload Specification element, containing the links for uploading, and the parameters for resume.
		/// The caller must know the protocol for sending the prepare, chunk and finish URLs returned in the spec; as well as
		/// negotiate the resume upload.
		/// </returns>
		public IQuery<UploadSpecification> Upload(string id, UploadMethod method = UploadMethod.Standard, bool raw = false, string fileName = null, long fileSize = 0, string batchId = null, bool batchLast = false, bool canResume = false, bool startOver = false, bool unzip = false, string tool = "apiv3", bool overwrite = false, string title = null, string details = null, bool isSend = false, string sendGuid = null, string opid = null, int threadCount = 4, string responseFormat = "json", bool notify = false, DateTime? clientCreatedDateUTC = null, DateTime? clientModifiedDateUTC = null, int? expirationDays = null)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<UploadSpecification>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Upload");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("method", method);
			sfApiQuery.QueryString("raw", raw);
			sfApiQuery.QueryString("fileName", fileName);
			sfApiQuery.QueryString("fileSize", fileSize);
			sfApiQuery.QueryString("batchId", batchId);
			sfApiQuery.QueryString("batchLast", batchLast);
			sfApiQuery.QueryString("canResume", canResume);
			sfApiQuery.QueryString("startOver", startOver);
			sfApiQuery.QueryString("unzip", unzip);
			sfApiQuery.QueryString("tool", tool);
			sfApiQuery.QueryString("overwrite", overwrite);
			sfApiQuery.QueryString("title", title);
			sfApiQuery.QueryString("details", details);
			sfApiQuery.QueryString("isSend", isSend);
			sfApiQuery.QueryString("sendGuid", sendGuid);
			sfApiQuery.QueryString("opid", opid);
			sfApiQuery.QueryString("threadCount", threadCount);
			sfApiQuery.QueryString("responseFormat", responseFormat);
			sfApiQuery.QueryString("notify", notify);
			sfApiQuery.QueryString("clientCreatedDateUTC", clientCreatedDateUTC);
			sfApiQuery.QueryString("clientModifiedDateUTC", clientModifiedDateUTC);
			sfApiQuery.QueryString("expirationDays", expirationDays);
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Unlock File
		/// </summary>
		/// <remarks>
		/// Unlock a locked file.
		/// This operation is only implemented in Sharepoint providers (/sp)
		/// </remarks>
		/// <param name="id"></param>
		/// <param name="message"></param>
		public IQuery CheckIn(string id, string message)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("CheckIn");
			sfApiQuery.Ids(id);
			sfApiQuery.QueryString("message", message);
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Lock File
		/// </summary>
		/// <remarks>
		/// Locks a file.
		/// This operation is only implemented in Sharepoint providers (/sp)
		/// </remarks>
		/// <param name="id"></param>
		public IQuery CheckOut(string id)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("CheckOut");
			sfApiQuery.Ids(id);
			sfApiQuery.HttpMethod = "POST";
			return sfApiQuery;
		}

		/// <summary>
		/// Search
		/// </summary>
		/// <remarks>
		/// Search for Items matching the criteria of the query parameter
		/// </remarks>
		/// <param name="query"></param>
		/// <returns>
		/// SearchResults
		/// </returns>
		public IQuery<SearchResults> Search(string query)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<SearchResults>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("Search");
			sfApiQuery.QueryString("query", query);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get all Item Protocol Link
		/// </summary>
		/// <remarks>
		/// This method returns all alternate protocol links supported by ShareFile (such
		/// as WOPI, FTP, WebDAV).
		/// </remarks>
		/// <param name="id"></param>
		/// <returns>
		/// A Feed containing all protocols links supported by the given item
		/// </returns>
		public IQuery<ODataFeed<ItemProtocolLink>> GetProtocolLinks(string parentid)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<ItemProtocolLink>>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("ProtocolLinks");
			sfApiQuery.Ids(parentid);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

		/// <summary>
		/// Get an Item Protocol Link
		/// </summary>
		/// <param name="id"></param>
		/// <param name="protocol"></param>
		/// <returns>
		/// A single protocol link if supported, 404 (Not Found) if not supported by the item
		/// </returns>
		public IQuery<ItemProtocolLink> GetProtocolLinks(string id, string protocol)
		{
			var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ItemProtocolLink>(Client);
			sfApiQuery.From("Items");
			sfApiQuery.Action("ProtocolLinks");
			sfApiQuery.Ids(id);
			sfApiQuery.ActionIds(protocol);
			sfApiQuery.HttpMethod = "GET";
			return sfApiQuery;
		}

	}
}

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
using ShareFile.Api.Client.Extensions;

namespace ShareFile.Api.Client.Entities
{
    public interface IFileLockEntity : IEntityBase
    {
        
        /// <summary>
        /// Get Item Lock info
        /// </summary>
        /// <remarks>
        /// Retrieves the lock info for a given Item.
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// Lock info
        /// </returns>
        IQuery<FileLock> GetByItem(Uri url);
        
        /// <summary>
        /// Create Lock
        /// </summary>
        /// <param name="url"></param>
        /// <param name="fileLock"></param>
        /// <returns>
        /// The created item Lock object
        /// </returns>
        IQuery<FileLock> CreateByItem(Uri url, FileLock fileLock);
        
        /// <summary>
        /// Update FileLock
        /// </summary>
        /// <example>
        /// {
        /// LockId:"lockid",
        /// Owner:{Id:"ownerid"},
        /// ExpirationTimeInMinutes:30
        /// }
        /// </example>
        /// <param name="url"></param>
        /// <param name="fileLock"></param>
        /// <returns>
        /// The updated lock object
        /// </returns>
        IQuery<FileLock> UpdateByItem(Uri url, FileLock fileLock);
        
        /// <summary>
        /// Unlock File
        /// </summary>
        /// <remarks>
        /// Unlock a locked file.
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="lockid"></param>
        IQuery DeleteByItem(Uri url, string lockid);
    }

    public class FileLockEntity : EntityBase, IFileLockEntity
    {
        public FileLockEntity (IShareFileClient client)
            : base (client, "FileLock")
        { }
        
        
        /// <summary>
        /// Get Item Lock info
        /// </summary>
        /// <remarks>
        /// Retrieves the lock info for a given Item.
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// Lock info
        /// </returns>
        public IQuery<FileLock> GetByItem(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<FileLock>(Client);
		    sfApiQuery.Action("FileLock");
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Create Lock
        /// </summary>
        /// <param name="url"></param>
        /// <param name="fileLock"></param>
        /// <returns>
        /// The created item Lock object
        /// </returns>
        public IQuery<FileLock> CreateByItem(Uri url, FileLock fileLock)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<FileLock>(Client);
		    sfApiQuery.Action("FileLock");
            sfApiQuery.Uri(url);
            sfApiQuery.Body = fileLock;
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Update FileLock
        /// </summary>
        /// <example>
        /// {
        /// LockId:"lockid",
        /// Owner:{Id:"ownerid"},
        /// ExpirationTimeInMinutes:30
        /// }
        /// </example>
        /// <param name="url"></param>
        /// <param name="fileLock"></param>
        /// <returns>
        /// The updated lock object
        /// </returns>
        public IQuery<FileLock> UpdateByItem(Uri url, FileLock fileLock)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<FileLock>(Client);
		    sfApiQuery.Action("FileLock");
            sfApiQuery.Uri(url);
            sfApiQuery.Body = fileLock;
            sfApiQuery.HttpMethod = "PATCH";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Unlock File
        /// </summary>
        /// <remarks>
        /// Unlock a locked file.
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="lockid"></param>
        public IQuery DeleteByItem(Uri url, string lockid)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
		    sfApiQuery.Action("FileLock");
            sfApiQuery.Uri(url);
            sfApiQuery.ActionIds(lockid);
            sfApiQuery.HttpMethod = "DELETE";	
		    return sfApiQuery;
        }
    }
}
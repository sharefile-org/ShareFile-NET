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
using System.IO;
using ShareFile.Api.Models;
using ShareFile.Api.Client;
using ShareFile.Api.Client.Requests;
using ShareFile.Api.Client.Extensions;

namespace ShareFile.Api.Client.Entities
{
    public interface IAsyncOperationsEntity : IEntityBase
    {
        
        /// <summary>
        /// Get AsyncOperation by ID
        /// </summary>
        /// <remarks>
        /// Retrieve a single Async Op record by ID
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// A single Async Operation record
        /// </returns>
        IQuery<AsyncOperation> Get(Uri url);
        
        /// <summary>
        /// Get List of AsyncOperations by Operation Batch ID
        /// </summary>
        /// <remarks>
        /// Retrieves all AsyncOperations on the specified batch
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>
        /// A Feed of AsyncOperation objects, containing all items in the specified batch
        /// </returns>
        IQuery<ODataFeed<AsyncOperation>> GetByBatch(string id);
        
        /// <summary>
        /// Get the progress of the AsyncOperations by Opertaion Batch ID
        /// </summary>
        /// <param name="id"></param>
        IQuery<AsyncOperation> GetBatch(string id);
        
        /// <summary>
        /// Get List of AsyncOperations by Folder
        /// </summary>
        /// <remarks>
        /// Retrieves all AsyncOperations associated with the calling user and the Item ID
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>
        /// A Feed of AsyncOperation objects, containing all pending operations in the specific folder,
        /// for the authenticated SDK user
        /// </returns>
        IQuery<ODataFeed<AsyncOperation>> GetByFolder(string id);
        IQuery<AsyncOperation> Create(AsyncOperation asyncOp);
        
        /// <summary>
        /// Cancel AsyncOperation
        /// </summary>
        /// <remarks>
        /// Cancels a single Async operation record
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// The modified Async Operation record
        /// </returns>
        IQuery<AsyncOperation> Cancel(Uri url);
        
        /// <summary>
        /// Delete AsyncOperation
        /// </summary>
        /// <remarks>
        /// Cancels a single Async operation record (same as /Cancel)
        /// </remarks>
        /// <param name="url"></param>
        IQuery Delete(Uri url);
        
        /// <summary>
        /// Cancel an Operation Batch
        /// </summary>
        /// <remarks>
        /// Cancel an Async Operation batch - all unfinished Async Operation records in that batch
        /// will be moved to Cancelled state.
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>
        /// A list of the modified Async Operations in the batch
        /// </returns>
        IQuery<ODataFeed<AsyncOperation>> CancelBatch(string id);
        
        /// <summary>
        /// Changes the state of an AsyncOperation
        /// </summary>
        /// <example>
        /// { "State": "..." }
        /// </example>
        /// <remarks>
        /// Only the State parameter is updated, other fields are ignored
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="newAsyncOp"></param>
        /// <returns>
        /// The modified Async Operation
        /// </returns>
        IQuery<AsyncOperation> Update(Uri url, AsyncOperation newAsyncOp);
    }

    public class AsyncOperationsEntity : EntityBase, IAsyncOperationsEntity
    {
        public AsyncOperationsEntity (IShareFileClient client)
            : base (client, "AsyncOperations")
        { }
        
        
        /// <summary>
        /// Get AsyncOperation by ID
        /// </summary>
        /// <remarks>
        /// Retrieve a single Async Op record by ID
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// A single Async Operation record
        /// </returns>
        public IQuery<AsyncOperation> Get(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<AsyncOperation>(Client);
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get List of AsyncOperations by Operation Batch ID
        /// </summary>
        /// <remarks>
        /// Retrieves all AsyncOperations on the specified batch
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>
        /// A Feed of AsyncOperation objects, containing all items in the specified batch
        /// </returns>
        public IQuery<ODataFeed<AsyncOperation>> GetByBatch(string id)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<AsyncOperation>>(Client);
		    sfApiQuery.From("AsyncOperations");
		    sfApiQuery.Action("GetByBatch");
            sfApiQuery.ActionIds(id);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get the progress of the AsyncOperations by Opertaion Batch ID
        /// </summary>
        /// <param name="id"></param>
        public IQuery<AsyncOperation> GetBatch(string id)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<AsyncOperation>(Client);
		    sfApiQuery.From("AsyncOperations");
		    sfApiQuery.Action("GetBatch");
            sfApiQuery.ActionIds(id);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get List of AsyncOperations by Folder
        /// </summary>
        /// <remarks>
        /// Retrieves all AsyncOperations associated with the calling user and the Item ID
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>
        /// A Feed of AsyncOperation objects, containing all pending operations in the specific folder,
        /// for the authenticated SDK user
        /// </returns>
        public IQuery<ODataFeed<AsyncOperation>> GetByFolder(string id)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<AsyncOperation>>(Client);
		    sfApiQuery.From("AsyncOperations");
		    sfApiQuery.Action("GetByFolder");
            sfApiQuery.ActionIds(id);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        public IQuery<AsyncOperation> Create(AsyncOperation asyncOp)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<AsyncOperation>(Client);
		    sfApiQuery.From("AsyncOperations");
            sfApiQuery.Body = asyncOp;
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Cancel AsyncOperation
        /// </summary>
        /// <remarks>
        /// Cancels a single Async operation record
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// The modified Async Operation record
        /// </returns>
        public IQuery<AsyncOperation> Cancel(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<AsyncOperation>(Client);
		    sfApiQuery.Action("Cancel");
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Delete AsyncOperation
        /// </summary>
        /// <remarks>
        /// Cancels a single Async operation record (same as /Cancel)
        /// </remarks>
        /// <param name="url"></param>
        public IQuery Delete(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "DELETE";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Cancel an Operation Batch
        /// </summary>
        /// <remarks>
        /// Cancel an Async Operation batch - all unfinished Async Operation records in that batch
        /// will be moved to Cancelled state.
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>
        /// A list of the modified Async Operations in the batch
        /// </returns>
        public IQuery<ODataFeed<AsyncOperation>> CancelBatch(string id)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<AsyncOperation>>(Client);
		    sfApiQuery.From("AsyncOperations");
		    sfApiQuery.Action("CancelBatch");
            sfApiQuery.ActionIds(id);
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Changes the state of an AsyncOperation
        /// </summary>
        /// <example>
        /// { "State": "..." }
        /// </example>
        /// <remarks>
        /// Only the State parameter is updated, other fields are ignored
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="newAsyncOp"></param>
        /// <returns>
        /// The modified Async Operation
        /// </returns>
        public IQuery<AsyncOperation> Update(Uri url, AsyncOperation newAsyncOp)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<AsyncOperation>(Client);
            sfApiQuery.Uri(url);
            sfApiQuery.Body = newAsyncOp;
            sfApiQuery.HttpMethod = "PATCH";	
		    return sfApiQuery;
        }
    }
}
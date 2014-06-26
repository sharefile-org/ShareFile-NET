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
	public class Item : ODataObject 
	{

		/// <summary>
		/// Item Name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Item File Name. ShareFile allows Items to have different Display and File names: display
		/// names are shown during client navigation, while file names are used when the item is
		/// downloaded.
		/// </summary>
		public string FileName { get; set; }

		/// <summary>
		/// User that Created this Item
		/// </summary>
		public User Creator { get; set; }

		/// <summary>
		/// Parent container of the Item. A container is usually a Folder object, with a few exceptions -
		/// the "Account" is the container of top-level folders.
		/// </summary>
		public Item Parent { get; set; }

		/// <summary>
		/// List of Access Controls for this Item. This is not the effective ACL on the Item, just the
		/// ACLs directly attached to this Item. Use the "Info" reference to retrieve effective ACL
		/// </summary>
		public IEnumerable<AccessControl> AccessControls { get; set; }

		/// <summary>
		/// The Storage Zone that contains this Item.
		/// </summary>
		public Zone Zone { get; set; }

		/// <summary>
		/// Item Creation Date.
		/// </summary>
		public DateTime? CreationDate { get; set; }

		/// <summary>
		/// The last modified date of this item and all of its children, recursively. This parameter
		/// is not supported in all ShareFile providers - it is always set in sharefile.com hosting, but
		/// not in some StorageZone connectors. The Capability object of the provider indicates whether
		/// the provider supports this field or not.
		/// </summary>
		public DateTime? ProgenyEditDate { get; set; }

		/// <summary>
		/// Client device filesystem Created Date of this Item.
		/// </summary>
		public DateTime? ClientCreatedDate { get; set; }

		/// <summary>
		/// Client device filesystem last Modified Date of this Item.
		/// </summary>
		public DateTime? ClientModifiedDate { get; set; }

		/// <summary>
		/// Defines the Retention Policy for this Item. After this date, the item is automatically moved
		/// to recycle bin.
		/// </summary>
		public DateTime? ExpirationDate { get; set; }

		/// <summary>
		/// Item description
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Disk space limit for the Item. Define the maximum amount of bytes that this container can
		/// hold at any given time.
		/// </summary>
		public int? DiskSpaceLimit { get; set; }

		/// <summary>
		/// Defines whether the Item has a 'hidden' flag.
		/// </summary>
		public bool? IsHidden { get; set; }

		/// <summary>
		/// Bandwidth limit for the Item. Define the maximum amount of bytes that can be added and
		/// retrieved from this item.
		/// </summary>
		public int? BandwidthLimitInMB { get; set; }

		/// <summary>
		/// User Owner of this Item.
		/// </summary>
		public User Owner { get; set; }

		/// <summary>
		/// ShareFile Account containing this item.
		/// </summary>
		public Account Account { get; set; }

		/// <summary>
		/// Item size in Kilobytes. For containers, this field includes all children sizes, recursively.
		/// </summary>
		public int? FileSizeInKB { get; set; }

		/// <summary>
		/// Contains a ItemID path, separated by /, from the virtual root to this given file. Example
		/// /accountID/folderID/folderID/itemID
		/// </summary>
		public string Path { get; set; }

		/// <summary>
		/// First name of the user that created this item
		/// </summary>
		public string CreatorFirstName { get; set; }

		/// <summary>
		/// Last name of the user that created this item
		/// </summary>
		public string CreatorLastName { get; set; }

		/// <summary>
		/// Amount of days until this item expireses (see ExpirationDate)
		/// </summary>
		public int? ExpirationDays { get; set; }

		/// <summary>
		/// Item size in bytes. For containers, this field will include all children sizes, recursively.
		/// </summary>
		public long? FileSizeBytes { get; set; }

		/// <summary>
		/// Indicates whether a preview image is available for this Item.
		/// 
		/// ShareFile.com always create previews for known file types, although there is a delay from the file
		/// creation until the preview is available. Some Storage Zones Providers do not create previews, depending
		/// on version and deployment options.
		/// 
		/// Previews are not created for unknown file types
		/// </summary>
		public SafeEnum<PreviewStatus> PreviewStatus { get; set; }

		public int? MaxPreviewSize { get; set; }

		/// <summary>
		/// Indicates that the Item is pending for removal. At the next execution of the Cleanup process, the data
		/// blob associated with this item will be removed. This parameter is not used for certain Storage Zone
		/// Providers. For example, in CIFS and SharePoint connectors, removals are performed imediately. The
		/// Capability "HasRecycleBin" indicates whether this field is used or not in the provider.
		/// </summary>
		public bool? HasPendingDeletion { get; set; }

		/// <summary>
		/// Folder Template reference. If set, it indicates that this Item was created from a Folder Template. Modifications
		/// to the folder template are propagated to the associated items.
		/// 
		/// The Capability FolderTemplate indicates whether the provider supports Folder Templates.
		/// </summary>
		public string AssociatedFolderTemplateID { get; set; }

		/// <summary>
		/// Indicates whether the item is owned by a Folder Template. If set, it indicates that this Item was created from a
		/// Folder Template. Modifications to the folder template are propagated to the associated items.
		/// 
		/// The Capability FolderTemplate indicates whether the provider supports Folder Templates.
		/// </summary>
		public bool? IsTemplateOwned { get; set; }

		public bool? HasPermissionInfo { get; set; }

		public int? State { get; set; }

		/// <summary>
		/// Identifier for the Item stream. An Item represents a single version of a file system object. The stream identifies
		/// all versions of the same file system object. For example, when users upload or modify an existing file, a new Item
		/// is created with the same StreamID. All Item enumerations return only the latest version of a given stream. You can
		/// access the previous versions of a file using the StreamID reference.
		/// </summary>
		public string StreamID { get; set; }

		/// <summary>
		/// Short version of items creator's name. E.g., J. Doe.
		/// </summary>
		public string CreatorNameShort { get; set; }

		/// <summary>
		/// Specifies whether there are other versions of this item. Not all providers support file versioning. The
		/// Capability FileVersioning indicates whether the provider supports file versions.
		/// </summary>
		public bool? HasMultipleVersions { get; set; }

		/// <summary>
		/// List of custom metadata object associated with this item
		/// </summary>
		public IEnumerable<Metadata> Metadata { get; set; }

		/// <summary>
		/// Electronic signature object associated with this item
		/// </summary>
		public ESignature ESignatureDocument { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as Item;
			if(typedSource != null)
			{
				Name = typedSource.Name;
				FileName = typedSource.FileName;
				Creator = typedSource.Creator;
				Parent = typedSource.Parent;
				AccessControls = typedSource.AccessControls;
				Zone = typedSource.Zone;
				CreationDate = typedSource.CreationDate;
				ProgenyEditDate = typedSource.ProgenyEditDate;
				ClientCreatedDate = typedSource.ClientCreatedDate;
				ClientModifiedDate = typedSource.ClientModifiedDate;
				ExpirationDate = typedSource.ExpirationDate;
				Description = typedSource.Description;
				DiskSpaceLimit = typedSource.DiskSpaceLimit;
				IsHidden = typedSource.IsHidden;
				BandwidthLimitInMB = typedSource.BandwidthLimitInMB;
				Owner = typedSource.Owner;
				Account = typedSource.Account;
				FileSizeInKB = typedSource.FileSizeInKB;
				Path = typedSource.Path;
				CreatorFirstName = typedSource.CreatorFirstName;
				CreatorLastName = typedSource.CreatorLastName;
				ExpirationDays = typedSource.ExpirationDays;
				FileSizeBytes = typedSource.FileSizeBytes;
				PreviewStatus = typedSource.PreviewStatus;
				MaxPreviewSize = typedSource.MaxPreviewSize;
				HasPendingDeletion = typedSource.HasPendingDeletion;
				AssociatedFolderTemplateID = typedSource.AssociatedFolderTemplateID;
				IsTemplateOwned = typedSource.IsTemplateOwned;
				HasPermissionInfo = typedSource.HasPermissionInfo;
				State = typedSource.State;
				StreamID = typedSource.StreamID;
				CreatorNameShort = typedSource.CreatorNameShort;
				HasMultipleVersions = typedSource.HasMultipleVersions;
				Metadata = typedSource.Metadata;
				ESignatureDocument = typedSource.ESignatureDocument;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("Name", out token) && token.Type != JTokenType.Null)
				{
					Name = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("FileName", out token) && token.Type != JTokenType.Null)
				{
					FileName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Creator", out token) && token.Type != JTokenType.Null)
				{
					Creator = (User)serializer.Deserialize(token.CreateReader(), typeof(User));
				}
				if(source.TryGetProperty("Parent", out token) && token.Type != JTokenType.Null)
				{
					Parent = (Item)serializer.Deserialize(token.CreateReader(), typeof(Item));
				}
				if(source.TryGetProperty("AccessControls", out token) && token.Type != JTokenType.Null)
				{
					AccessControls = (IEnumerable<AccessControl>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<AccessControl>));
				}
				if(source.TryGetProperty("Zone", out token) && token.Type != JTokenType.Null)
				{
					Zone = (Zone)serializer.Deserialize(token.CreateReader(), typeof(Zone));
				}
				if(source.TryGetProperty("CreationDate", out token) && token.Type != JTokenType.Null)
				{
					CreationDate = (DateTime?)serializer.Deserialize(token.CreateReader(), typeof(DateTime?));
				}
				if(source.TryGetProperty("ProgenyEditDate", out token) && token.Type != JTokenType.Null)
				{
					ProgenyEditDate = (DateTime?)serializer.Deserialize(token.CreateReader(), typeof(DateTime?));
				}
				if(source.TryGetProperty("ClientCreatedDate", out token) && token.Type != JTokenType.Null)
				{
					ClientCreatedDate = (DateTime?)serializer.Deserialize(token.CreateReader(), typeof(DateTime?));
				}
				if(source.TryGetProperty("ClientModifiedDate", out token) && token.Type != JTokenType.Null)
				{
					ClientModifiedDate = (DateTime?)serializer.Deserialize(token.CreateReader(), typeof(DateTime?));
				}
				if(source.TryGetProperty("ExpirationDate", out token) && token.Type != JTokenType.Null)
				{
					ExpirationDate = (DateTime?)serializer.Deserialize(token.CreateReader(), typeof(DateTime?));
				}
				if(source.TryGetProperty("Description", out token) && token.Type != JTokenType.Null)
				{
					Description = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("DiskSpaceLimit", out token) && token.Type != JTokenType.Null)
				{
					DiskSpaceLimit = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("IsHidden", out token) && token.Type != JTokenType.Null)
				{
					IsHidden = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("BandwidthLimitInMB", out token) && token.Type != JTokenType.Null)
				{
					BandwidthLimitInMB = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("Owner", out token) && token.Type != JTokenType.Null)
				{
					Owner = (User)serializer.Deserialize(token.CreateReader(), typeof(User));
				}
				if(source.TryGetProperty("Account", out token) && token.Type != JTokenType.Null)
				{
					Account = (Account)serializer.Deserialize(token.CreateReader(), typeof(Account));
				}
				if(source.TryGetProperty("FileSizeInKB", out token) && token.Type != JTokenType.Null)
				{
					FileSizeInKB = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("Path", out token) && token.Type != JTokenType.Null)
				{
					Path = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("CreatorFirstName", out token) && token.Type != JTokenType.Null)
				{
					CreatorFirstName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("CreatorLastName", out token) && token.Type != JTokenType.Null)
				{
					CreatorLastName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("ExpirationDays", out token) && token.Type != JTokenType.Null)
				{
					ExpirationDays = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("FileSizeBytes", out token) && token.Type != JTokenType.Null)
				{
					FileSizeBytes = (long?)serializer.Deserialize(token.CreateReader(), typeof(long?));
				}
				if(source.TryGetProperty("PreviewStatus", out token) && token.Type != JTokenType.Null)
				{
					PreviewStatus = (SafeEnum<PreviewStatus>)serializer.Deserialize(token.CreateReader(), typeof(SafeEnum<PreviewStatus>));
				}
				if(source.TryGetProperty("MaxPreviewSize", out token) && token.Type != JTokenType.Null)
				{
					MaxPreviewSize = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("HasPendingDeletion", out token) && token.Type != JTokenType.Null)
				{
					HasPendingDeletion = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("AssociatedFolderTemplateID", out token) && token.Type != JTokenType.Null)
				{
					AssociatedFolderTemplateID = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("IsTemplateOwned", out token) && token.Type != JTokenType.Null)
				{
					IsTemplateOwned = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("HasPermissionInfo", out token) && token.Type != JTokenType.Null)
				{
					HasPermissionInfo = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("State", out token) && token.Type != JTokenType.Null)
				{
					State = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("StreamID", out token) && token.Type != JTokenType.Null)
				{
					StreamID = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("CreatorNameShort", out token) && token.Type != JTokenType.Null)
				{
					CreatorNameShort = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("HasMultipleVersions", out token) && token.Type != JTokenType.Null)
				{
					HasMultipleVersions = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("Metadata", out token) && token.Type != JTokenType.Null)
				{
					Metadata = (IEnumerable<Metadata>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<Metadata>));
				}
				if(source.TryGetProperty("ESignatureDocument", out token) && token.Type != JTokenType.Null)
				{
					ESignatureDocument = (ESignature)serializer.Deserialize(token.CreateReader(), typeof(ESignature));
				}
			}
		}
	}
}
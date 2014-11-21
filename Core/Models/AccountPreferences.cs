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
	public class AccountPreferences : ODataObject 
	{

		public bool? EnableViewOnly { get; set; }

		public bool? EnableWatermarkOnViewOnly { get; set; }

		public bool? AllowProactiveNotifications { get; set; }

		public bool? ShowUserListToClients { get; set; }

		public bool? RequireLoginOnDownload { get; set; }

		public bool? RequireLoginByDefault { get; set; }

		public bool? EnableClientSend { get; set; }

		public bool? EnableThumbnails { get; set; }

		public bool? EnableSSO { get; set; }

		public int? VirusStrictness { get; set; }

		public bool? EnableSfAdi { get; set; }

		public bool? EnableMultipleZones { get; set; }

		public Zone DefaultZone { get; set; }

		public bool? EnableVersioning { get; set; }

		public string SystemType { get; set; }

		public bool? EnableSync { get; set; }

		public bool? EnableSyncAutoUpdate { get; set; }

		public string SystemName { get; set; }

		public string HomeScreenName { get; set; }

		public bool? ShowTermsCheckbox { get; set; }

		public string TermsCheckboxText { get; set; }

		public int? TermsCheckboxStrictness { get; set; }

		public bool? RequireCompanyNameWithUserInfo { get; set; }

		public bool? EnableEditor { get; set; }

		public int? ShareIDMaxExpirationDays { get; set; }

		public bool? AdminIsSuperUser { get; set; }

		public bool? ShowFolderAccessList { get; set; }

		public bool? FromEmailIsShareFile { get; set; }

		public bool? UseAlternateSMTP { get; set; }

		public bool? ShowPasswordInEmail { get; set; }

		public string EmailPasswordText { get; set; }

		public bool? EnableSelfNotificationsUpload { get; set; }

		public bool? EnableSelfNotificationsDownload { get; set; }

		public bool? EnableUploadShareIDReceipt { get; set; }

		public int? DefaultConsolidatedNotificationInterval { get; set; }

		public int? ExpirationDays { get; set; }

		public string DefaultSortField { get; set; }

		public string DefaultSortOrder { get; set; }

		public bool? DefaultIsVersioned { get; set; }

		public int? DefaultMaxVersions { get; set; }

		public string ViewOnlyWatermarkText { get; set; }

		public bool? EnableDocViewerPrinting { get; set; }

		public bool? EnableWatermarkedDownloads { get; set; }

		public bool? EnableTwoFactorAuth { get; set; }

		public int? LoginFailMaxAttempts { get; set; }

		public int? LoginFailLockoutSecs { get; set; }

		public string IPRestrictions { get; set; }

		public int? InactiveTimeoutMins { get; set; }

		public int? OAuth2RefreshTokenLifetimeMinutes { get; set; }

		public string PasswordRegEx { get; set; }

		public string PasswordRegExFormula { get; set; }

		public string PasswordRegExDescription { get; set; }

		public bool? EnableActivationLinks { get; set; }

		public bool? IsFINRA { get; set; }

		public bool? EnableOAuth { get; set; }

		public bool EnableQandA { get; set; }

		public bool? EnableQandATextInNotifications { get; set; }

		public SafeEnum<UXMode> UXMode { get; set; }

		public int? IndustryCode { get; set; }

		public int PasswordMaxAgeDays { get; set; }

		public int PasswordHistoryCount { get; set; }

		public int MinimumLength { get; set; }

		public int MinimumSpecialCharacters { get; set; }

		public int MinimumNumeric { get; set; }

		public string AllowedSpecialCharacters { get; set; }

		public bool? EnableWebDAV { get; set; }

		public bool? EnableFTP { get; set; }

		public bool? EnableSFTP { get; set; }

		public bool? DisableMarketing { get; set; }

		public string VDRDocViewerURL { get; set; }

		public bool? EnableSMBConnectorForAccount { get; set; }

		public bool? EnablePersonalCloudConnectors { get; set; }

		public string AccountID { get; set; }

		public bool? EnableGetApp { get; set; }

		public bool? EnableStorageZoneConnector { get; set; }

		public bool? HasAnyConnectorZones { get; set; }

		public bool? EnableENSForAccount { get; set; }

		public string ENSRecommendedPollingSyncInterval { get; set; }

		public string ENSRecommendedNotificationSyncInterval { get; set; }

		public int? ENSNotificationConfigurationCount { get; set; }

		public int? ENSFailSafePollingCount { get; set; }

		public int? ENSMaxNotificationSyncWaitCount { get; set; }

		public string TrustedDomains { get; set; }

		public bool? EnableEncryptedEmailForOutlookPlugin { get; set; }

		public bool? EnableDocPreviews { get; set; }

		public bool? EnableDesktopEditorForAccount { get; set; }

		public bool? UseStrictEmployeeDefinition { get; set; }

		public string EmployeeEmailDomains { get; set; }

		public bool? IsPremier { get; set; }

		public bool? DisableShareConnectForAccount { get; set; }

		public bool? EnableWebAppConnectorBrowsing { get; set; }

		public bool? EnableStrictCrossdomainPolicy { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as AccountPreferences;
			if(typedSource != null)
			{
				EnableViewOnly = typedSource.EnableViewOnly;
				EnableWatermarkOnViewOnly = typedSource.EnableWatermarkOnViewOnly;
				AllowProactiveNotifications = typedSource.AllowProactiveNotifications;
				ShowUserListToClients = typedSource.ShowUserListToClients;
				RequireLoginOnDownload = typedSource.RequireLoginOnDownload;
				RequireLoginByDefault = typedSource.RequireLoginByDefault;
				EnableClientSend = typedSource.EnableClientSend;
				EnableThumbnails = typedSource.EnableThumbnails;
				EnableSSO = typedSource.EnableSSO;
				VirusStrictness = typedSource.VirusStrictness;
				EnableSfAdi = typedSource.EnableSfAdi;
				EnableMultipleZones = typedSource.EnableMultipleZones;
				DefaultZone = typedSource.DefaultZone;
				EnableVersioning = typedSource.EnableVersioning;
				SystemType = typedSource.SystemType;
				EnableSync = typedSource.EnableSync;
				EnableSyncAutoUpdate = typedSource.EnableSyncAutoUpdate;
				SystemName = typedSource.SystemName;
				HomeScreenName = typedSource.HomeScreenName;
				ShowTermsCheckbox = typedSource.ShowTermsCheckbox;
				TermsCheckboxText = typedSource.TermsCheckboxText;
				TermsCheckboxStrictness = typedSource.TermsCheckboxStrictness;
				RequireCompanyNameWithUserInfo = typedSource.RequireCompanyNameWithUserInfo;
				EnableEditor = typedSource.EnableEditor;
				ShareIDMaxExpirationDays = typedSource.ShareIDMaxExpirationDays;
				AdminIsSuperUser = typedSource.AdminIsSuperUser;
				ShowFolderAccessList = typedSource.ShowFolderAccessList;
				FromEmailIsShareFile = typedSource.FromEmailIsShareFile;
				UseAlternateSMTP = typedSource.UseAlternateSMTP;
				ShowPasswordInEmail = typedSource.ShowPasswordInEmail;
				EmailPasswordText = typedSource.EmailPasswordText;
				EnableSelfNotificationsUpload = typedSource.EnableSelfNotificationsUpload;
				EnableSelfNotificationsDownload = typedSource.EnableSelfNotificationsDownload;
				EnableUploadShareIDReceipt = typedSource.EnableUploadShareIDReceipt;
				DefaultConsolidatedNotificationInterval = typedSource.DefaultConsolidatedNotificationInterval;
				ExpirationDays = typedSource.ExpirationDays;
				DefaultSortField = typedSource.DefaultSortField;
				DefaultSortOrder = typedSource.DefaultSortOrder;
				DefaultIsVersioned = typedSource.DefaultIsVersioned;
				DefaultMaxVersions = typedSource.DefaultMaxVersions;
				ViewOnlyWatermarkText = typedSource.ViewOnlyWatermarkText;
				EnableDocViewerPrinting = typedSource.EnableDocViewerPrinting;
				EnableWatermarkedDownloads = typedSource.EnableWatermarkedDownloads;
				EnableTwoFactorAuth = typedSource.EnableTwoFactorAuth;
				LoginFailMaxAttempts = typedSource.LoginFailMaxAttempts;
				LoginFailLockoutSecs = typedSource.LoginFailLockoutSecs;
				IPRestrictions = typedSource.IPRestrictions;
				InactiveTimeoutMins = typedSource.InactiveTimeoutMins;
				OAuth2RefreshTokenLifetimeMinutes = typedSource.OAuth2RefreshTokenLifetimeMinutes;
				PasswordRegEx = typedSource.PasswordRegEx;
				PasswordRegExFormula = typedSource.PasswordRegExFormula;
				PasswordRegExDescription = typedSource.PasswordRegExDescription;
				EnableActivationLinks = typedSource.EnableActivationLinks;
				IsFINRA = typedSource.IsFINRA;
				EnableOAuth = typedSource.EnableOAuth;
				EnableQandA = typedSource.EnableQandA;
				EnableQandATextInNotifications = typedSource.EnableQandATextInNotifications;
				UXMode = typedSource.UXMode;
				IndustryCode = typedSource.IndustryCode;
				PasswordMaxAgeDays = typedSource.PasswordMaxAgeDays;
				PasswordHistoryCount = typedSource.PasswordHistoryCount;
				MinimumLength = typedSource.MinimumLength;
				MinimumSpecialCharacters = typedSource.MinimumSpecialCharacters;
				MinimumNumeric = typedSource.MinimumNumeric;
				AllowedSpecialCharacters = typedSource.AllowedSpecialCharacters;
				EnableWebDAV = typedSource.EnableWebDAV;
				EnableFTP = typedSource.EnableFTP;
				EnableSFTP = typedSource.EnableSFTP;
				DisableMarketing = typedSource.DisableMarketing;
				VDRDocViewerURL = typedSource.VDRDocViewerURL;
				EnableSMBConnectorForAccount = typedSource.EnableSMBConnectorForAccount;
				EnablePersonalCloudConnectors = typedSource.EnablePersonalCloudConnectors;
				AccountID = typedSource.AccountID;
				EnableGetApp = typedSource.EnableGetApp;
				EnableStorageZoneConnector = typedSource.EnableStorageZoneConnector;
				HasAnyConnectorZones = typedSource.HasAnyConnectorZones;
				EnableENSForAccount = typedSource.EnableENSForAccount;
				ENSRecommendedPollingSyncInterval = typedSource.ENSRecommendedPollingSyncInterval;
				ENSRecommendedNotificationSyncInterval = typedSource.ENSRecommendedNotificationSyncInterval;
				ENSNotificationConfigurationCount = typedSource.ENSNotificationConfigurationCount;
				ENSFailSafePollingCount = typedSource.ENSFailSafePollingCount;
				ENSMaxNotificationSyncWaitCount = typedSource.ENSMaxNotificationSyncWaitCount;
				TrustedDomains = typedSource.TrustedDomains;
				EnableEncryptedEmailForOutlookPlugin = typedSource.EnableEncryptedEmailForOutlookPlugin;
				EnableDocPreviews = typedSource.EnableDocPreviews;
				EnableDesktopEditorForAccount = typedSource.EnableDesktopEditorForAccount;
				UseStrictEmployeeDefinition = typedSource.UseStrictEmployeeDefinition;
				EmployeeEmailDomains = typedSource.EmployeeEmailDomains;
				IsPremier = typedSource.IsPremier;
				DisableShareConnectForAccount = typedSource.DisableShareConnectForAccount;
				EnableWebAppConnectorBrowsing = typedSource.EnableWebAppConnectorBrowsing;
				EnableStrictCrossdomainPolicy = typedSource.EnableStrictCrossdomainPolicy;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("EnableViewOnly", out token) && token.Type != JTokenType.Null)
				{
					EnableViewOnly = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableWatermarkOnViewOnly", out token) && token.Type != JTokenType.Null)
				{
					EnableWatermarkOnViewOnly = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("AllowProactiveNotifications", out token) && token.Type != JTokenType.Null)
				{
					AllowProactiveNotifications = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("ShowUserListToClients", out token) && token.Type != JTokenType.Null)
				{
					ShowUserListToClients = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("RequireLoginOnDownload", out token) && token.Type != JTokenType.Null)
				{
					RequireLoginOnDownload = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("RequireLoginByDefault", out token) && token.Type != JTokenType.Null)
				{
					RequireLoginByDefault = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableClientSend", out token) && token.Type != JTokenType.Null)
				{
					EnableClientSend = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableThumbnails", out token) && token.Type != JTokenType.Null)
				{
					EnableThumbnails = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableSSO", out token) && token.Type != JTokenType.Null)
				{
					EnableSSO = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("VirusStrictness", out token) && token.Type != JTokenType.Null)
				{
					VirusStrictness = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("EnableSfAdi", out token) && token.Type != JTokenType.Null)
				{
					EnableSfAdi = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableMultipleZones", out token) && token.Type != JTokenType.Null)
				{
					EnableMultipleZones = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("DefaultZone", out token) && token.Type != JTokenType.Null)
				{
					DefaultZone = (Zone)serializer.Deserialize(token.CreateReader(), typeof(Zone));
				}
				if(source.TryGetProperty("EnableVersioning", out token) && token.Type != JTokenType.Null)
				{
					EnableVersioning = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("SystemType", out token) && token.Type != JTokenType.Null)
				{
					SystemType = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("EnableSync", out token) && token.Type != JTokenType.Null)
				{
					EnableSync = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableSyncAutoUpdate", out token) && token.Type != JTokenType.Null)
				{
					EnableSyncAutoUpdate = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("SystemName", out token) && token.Type != JTokenType.Null)
				{
					SystemName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("HomeScreenName", out token) && token.Type != JTokenType.Null)
				{
					HomeScreenName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("ShowTermsCheckbox", out token) && token.Type != JTokenType.Null)
				{
					ShowTermsCheckbox = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("TermsCheckboxText", out token) && token.Type != JTokenType.Null)
				{
					TermsCheckboxText = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("TermsCheckboxStrictness", out token) && token.Type != JTokenType.Null)
				{
					TermsCheckboxStrictness = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("RequireCompanyNameWithUserInfo", out token) && token.Type != JTokenType.Null)
				{
					RequireCompanyNameWithUserInfo = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableEditor", out token) && token.Type != JTokenType.Null)
				{
					EnableEditor = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("ShareIDMaxExpirationDays", out token) && token.Type != JTokenType.Null)
				{
					ShareIDMaxExpirationDays = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("AdminIsSuperUser", out token) && token.Type != JTokenType.Null)
				{
					AdminIsSuperUser = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("ShowFolderAccessList", out token) && token.Type != JTokenType.Null)
				{
					ShowFolderAccessList = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("FromEmailIsShareFile", out token) && token.Type != JTokenType.Null)
				{
					FromEmailIsShareFile = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("UseAlternateSMTP", out token) && token.Type != JTokenType.Null)
				{
					UseAlternateSMTP = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("ShowPasswordInEmail", out token) && token.Type != JTokenType.Null)
				{
					ShowPasswordInEmail = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EmailPasswordText", out token) && token.Type != JTokenType.Null)
				{
					EmailPasswordText = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("EnableSelfNotificationsUpload", out token) && token.Type != JTokenType.Null)
				{
					EnableSelfNotificationsUpload = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableSelfNotificationsDownload", out token) && token.Type != JTokenType.Null)
				{
					EnableSelfNotificationsDownload = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableUploadShareIDReceipt", out token) && token.Type != JTokenType.Null)
				{
					EnableUploadShareIDReceipt = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("DefaultConsolidatedNotificationInterval", out token) && token.Type != JTokenType.Null)
				{
					DefaultConsolidatedNotificationInterval = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("ExpirationDays", out token) && token.Type != JTokenType.Null)
				{
					ExpirationDays = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("DefaultSortField", out token) && token.Type != JTokenType.Null)
				{
					DefaultSortField = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("DefaultSortOrder", out token) && token.Type != JTokenType.Null)
				{
					DefaultSortOrder = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("DefaultIsVersioned", out token) && token.Type != JTokenType.Null)
				{
					DefaultIsVersioned = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("DefaultMaxVersions", out token) && token.Type != JTokenType.Null)
				{
					DefaultMaxVersions = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("ViewOnlyWatermarkText", out token) && token.Type != JTokenType.Null)
				{
					ViewOnlyWatermarkText = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("EnableDocViewerPrinting", out token) && token.Type != JTokenType.Null)
				{
					EnableDocViewerPrinting = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableWatermarkedDownloads", out token) && token.Type != JTokenType.Null)
				{
					EnableWatermarkedDownloads = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableTwoFactorAuth", out token) && token.Type != JTokenType.Null)
				{
					EnableTwoFactorAuth = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("LoginFailMaxAttempts", out token) && token.Type != JTokenType.Null)
				{
					LoginFailMaxAttempts = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("LoginFailLockoutSecs", out token) && token.Type != JTokenType.Null)
				{
					LoginFailLockoutSecs = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("IPRestrictions", out token) && token.Type != JTokenType.Null)
				{
					IPRestrictions = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("InactiveTimeoutMins", out token) && token.Type != JTokenType.Null)
				{
					InactiveTimeoutMins = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("OAuth2RefreshTokenLifetimeMinutes", out token) && token.Type != JTokenType.Null)
				{
					OAuth2RefreshTokenLifetimeMinutes = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("PasswordRegEx", out token) && token.Type != JTokenType.Null)
				{
					PasswordRegEx = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("PasswordRegExFormula", out token) && token.Type != JTokenType.Null)
				{
					PasswordRegExFormula = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("PasswordRegExDescription", out token) && token.Type != JTokenType.Null)
				{
					PasswordRegExDescription = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("EnableActivationLinks", out token) && token.Type != JTokenType.Null)
				{
					EnableActivationLinks = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsFINRA", out token) && token.Type != JTokenType.Null)
				{
					IsFINRA = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableOAuth", out token) && token.Type != JTokenType.Null)
				{
					EnableOAuth = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableQandA", out token) && token.Type != JTokenType.Null)
				{
					EnableQandA = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
				if(source.TryGetProperty("EnableQandATextInNotifications", out token) && token.Type != JTokenType.Null)
				{
					EnableQandATextInNotifications = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("UXMode", out token) && token.Type != JTokenType.Null)
				{
					UXMode = (SafeEnum<UXMode>)serializer.Deserialize(token.CreateReader(), typeof(SafeEnum<UXMode>));
				}
				if(source.TryGetProperty("IndustryCode", out token) && token.Type != JTokenType.Null)
				{
					IndustryCode = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("PasswordMaxAgeDays", out token) && token.Type != JTokenType.Null)
				{
					PasswordMaxAgeDays = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
				if(source.TryGetProperty("PasswordHistoryCount", out token) && token.Type != JTokenType.Null)
				{
					PasswordHistoryCount = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
				if(source.TryGetProperty("MinimumLength", out token) && token.Type != JTokenType.Null)
				{
					MinimumLength = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
				if(source.TryGetProperty("MinimumSpecialCharacters", out token) && token.Type != JTokenType.Null)
				{
					MinimumSpecialCharacters = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
				if(source.TryGetProperty("MinimumNumeric", out token) && token.Type != JTokenType.Null)
				{
					MinimumNumeric = (int)serializer.Deserialize(token.CreateReader(), typeof(int));
				}
				if(source.TryGetProperty("AllowedSpecialCharacters", out token) && token.Type != JTokenType.Null)
				{
					AllowedSpecialCharacters = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("EnableWebDAV", out token) && token.Type != JTokenType.Null)
				{
					EnableWebDAV = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableFTP", out token) && token.Type != JTokenType.Null)
				{
					EnableFTP = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableSFTP", out token) && token.Type != JTokenType.Null)
				{
					EnableSFTP = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("DisableMarketing", out token) && token.Type != JTokenType.Null)
				{
					DisableMarketing = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("VDRDocViewerURL", out token) && token.Type != JTokenType.Null)
				{
					VDRDocViewerURL = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("EnableSMBConnectorForAccount", out token) && token.Type != JTokenType.Null)
				{
					EnableSMBConnectorForAccount = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnablePersonalCloudConnectors", out token) && token.Type != JTokenType.Null)
				{
					EnablePersonalCloudConnectors = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("AccountID", out token) && token.Type != JTokenType.Null)
				{
					AccountID = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("EnableGetApp", out token) && token.Type != JTokenType.Null)
				{
					EnableGetApp = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableStorageZoneConnector", out token) && token.Type != JTokenType.Null)
				{
					EnableStorageZoneConnector = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("HasAnyConnectorZones", out token) && token.Type != JTokenType.Null)
				{
					HasAnyConnectorZones = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableENSForAccount", out token) && token.Type != JTokenType.Null)
				{
					EnableENSForAccount = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("ENSRecommendedPollingSyncInterval", out token) && token.Type != JTokenType.Null)
				{
					ENSRecommendedPollingSyncInterval = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("ENSRecommendedNotificationSyncInterval", out token) && token.Type != JTokenType.Null)
				{
					ENSRecommendedNotificationSyncInterval = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("ENSNotificationConfigurationCount", out token) && token.Type != JTokenType.Null)
				{
					ENSNotificationConfigurationCount = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("ENSFailSafePollingCount", out token) && token.Type != JTokenType.Null)
				{
					ENSFailSafePollingCount = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("ENSMaxNotificationSyncWaitCount", out token) && token.Type != JTokenType.Null)
				{
					ENSMaxNotificationSyncWaitCount = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("TrustedDomains", out token) && token.Type != JTokenType.Null)
				{
					TrustedDomains = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("EnableEncryptedEmailForOutlookPlugin", out token) && token.Type != JTokenType.Null)
				{
					EnableEncryptedEmailForOutlookPlugin = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableDocPreviews", out token) && token.Type != JTokenType.Null)
				{
					EnableDocPreviews = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableDesktopEditorForAccount", out token) && token.Type != JTokenType.Null)
				{
					EnableDesktopEditorForAccount = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("UseStrictEmployeeDefinition", out token) && token.Type != JTokenType.Null)
				{
					UseStrictEmployeeDefinition = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EmployeeEmailDomains", out token) && token.Type != JTokenType.Null)
				{
					EmployeeEmailDomains = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("IsPremier", out token) && token.Type != JTokenType.Null)
				{
					IsPremier = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("DisableShareConnectForAccount", out token) && token.Type != JTokenType.Null)
				{
					DisableShareConnectForAccount = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableWebAppConnectorBrowsing", out token) && token.Type != JTokenType.Null)
				{
					EnableWebAppConnectorBrowsing = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("EnableStrictCrossdomainPolicy", out token) && token.Type != JTokenType.Null)
				{
					EnableStrictCrossdomainPolicy = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
			}
		}
	}
}
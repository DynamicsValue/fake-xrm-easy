#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataverseEntities
{
	
	
	/// <summary>
	/// Identifies the type of queue item, such as the specific activity type, case, or article.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.6")]
	public enum queueitem_objecttypecode
	{
		
		/// <summary>
		/// Activity that tracks a survey invitation sent to a person.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		CustomerVoicesurveyinvite = 10671,
		
		/// <summary>
		/// System operation used to perform lengthy and asynchronous operations on large data sets, such as distributing a campaign activity or quick campaign.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		QuickCampaign = 4406,
		
		/// <summary>
		/// For internal use only. Entity which stores association data of Dynamics 365 records with Microsoft Teams chat
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Teamschat = 10221,
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		SocialActivity = 4216,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		CopilotTranscript = 10987,
		
		/// <summary>
		/// Task performed, or to be performed, by a user. An activity is any action for which an entry can be made on a calendar.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Activity = 4200,
		
		/// <summary>
		/// The Master appointment of a recurring appointment series.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		RecurringAppointment = 4251,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		CustomerVoicealert = 10661,
		
		/// <summary>
		/// Tracks the interactions between the agents and customer
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Ongoingconversation_Deprecated = 10754,
		
		/// <summary>
		/// Generic activity representing work needed to be done.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Task = 4212,
		
		/// <summary>
		/// Activity offered by the organization to satisfy its customer's needs. Each service activity includes date, time, duration, and required resources.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		ServiceActivity = 4214,
		
		/// <summary>
		/// Organizational Knowledge Article Template for Internal and external creation of Knowledge Articles.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		KnowledgeArticleTemplate = 10237,
		
		/// <summary>
		/// Activity that is delivered using email protocols.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Email = 4202,
		
		/// <summary>
		/// Overflow action configurations.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		OverflowActionConfig = 10730,
		
		/// <summary>
		/// Task performed, or to be performed, by a user for planning or running a campaign.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		CampaignActivity = 4402,
		
		/// <summary>
		/// Activity that tracks call outcome and number of pages for a fax and optionally stores an electronic copy of the document.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Fax = 4204,
		
		/// <summary>
		/// Service request case associated with a contract.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Case = 112,
		
		/// <summary>
		/// Response to a survey.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		CustomerVoicesurveyresponse = 10673,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		IoTAlert = 10453,
		
		/// <summary>
		/// Holds information about the redemption of an invite.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		InviteRedemption = 10356,
		
		/// <summary>
		/// Response from an existing or a potential new customer for a campaign.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		CampaignResponse = 4401,
		
		/// <summary>
		/// Tracks the interaction between the agents and customer
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Conversation = 10766,
		
		/// <summary>
		/// Session for interacting with a customer
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Session = 10783,
		
		/// <summary>
		/// Commitment representing a time interval with start/end times and duration.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Meeting = 4201,
		
		/// <summary>
		/// An activity which is used to share information between the user and the customer on the portal.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		PortalComment = 10357,
		
		/// <summary>
		/// Activity to track a telephone call.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		PhoneCall = 4210,
		
		/// <summary>
		/// Activity that tracks the delivery of a letter. The activity can contain the electronic copy of the letter.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Letter = 4207,
		
		/// <summary>
		/// Organizational knowledge for internal and external use.
		/// </summary>
		[System.Runtime.Serialization.EnumMemberAttribute()]
		KnowledgeArticle = 9953,
	}
	
	/// <summary>
	/// Status of the queue item.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.6")]
	public enum queueitem_statecode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Reason for the status of the queue item.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.6")]
	public enum queueitem_statuscode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 1,
	}
	
	/// <summary>
	/// A specific item in a queue, such as a case record or an activity record.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("queueitem")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.6")]
	public partial class QueueItem : Microsoft.Xrm.Sdk.Entity
	{
		
		/// <summary>
		/// Available fields, a the time of codegen, for the queueitem entity
		/// </summary>
		public partial class Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyname";
			public const string CreatedByYomiName = "createdbyyominame";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyname";
			public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
			public const string EnteredOn = "enteredon";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyname";
			public const string ModifiedByYomiName = "modifiedbyyominame";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
			public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
			public const string msdyn_liveworkstreamid = "msdyn_liveworkstreamid";
			public const string msdyn_liveworkstreamidName = "msdyn_liveworkstreamidname";
			public const string msdyn_skipursync = "msdyn_skipursync";
			public const string msdyn_skipursyncName = "msdyn_skipursyncname";
			public const string ObjectId = "objectid";
			public const string ObjectIdName = "objectidname";
			public const string ObjectTypeCode = "objecttypecode";
			public const string ObjectTypeCodeName = "objecttypecodename";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidname";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningUser = "owninguser";
			public const string Priority = "priority";
			public const string QueueId = "queueid";
			public const string QueueIdName = "queueidname";
			public const string QueueItemId = "queueitemid";
			public const string Id = "queueitemid";
			public const string Sender = "sender";
			public const string State = "state";
			public const string StateCode = "statecode";
			public const string StateCodeName = "statecodename";
			public const string Status = "status";
			public const string StatusCode = "statuscode";
			public const string StatusCodeName = "statuscodename";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string Title = "title";
			public const string ToRecipients = "torecipients";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string TransactionCurrencyIdName = "transactioncurrencyidname";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string WorkerId = "workerid";
			public const string WorkerIdModifiedOn = "workeridmodifiedon";
			public const string WorkerIdName = "workeridname";
			public const string WorkerIdYomiName = "workeridyominame";
			public const string QueueItem_AsyncOperations = "QueueItem_AsyncOperations";
			public const string QueueItem_ProcessSessions = "QueueItem_ProcessSessions";
			public const string ActivityPointer_QueueItem = "ActivityPointer_QueueItem";
			public const string Email_QueueItem = "Email_QueueItem";
			public const string Fax_QueueItem = "Fax_QueueItem";
			public const string Incident_QueueItem = "Incident_QueueItem";
			public const string lk_queueitem_createdonbehalfby = "lk_queueitem_createdonbehalfby";
			public const string lk_queueitem_modifiedonbehalfby = "lk_queueitem_modifiedonbehalfby";
			public const string lk_queueitembase_createdby = "lk_queueitembase_createdby";
			public const string lk_queueitembase_modifiedby = "lk_queueitembase_modifiedby";
			public const string lk_queueitembase_workerid = "lk_queueitembase_workerid";
			public const string organization_queueitems = "organization_queueitems";
			public const string PhoneCall_QueueItem = "PhoneCall_QueueItem";
			public const string queue_entries = "queue_entries";
			public const string Task_QueueItem = "Task_QueueItem";
			public const string team_queueitembase_workerid = "team_queueitembase_workerid";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public QueueItem() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "queueitem";
		
		public const string EntityLogicalCollectionName = "queueitems";
		
		public const string EntitySetName = "queueitems";
		
		public const int EntityTypeCode = 2029;
		
		/// <summary>
		/// Shows who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyname")]
		public string CreatedByName
		{
			get
			{
				if (this.FormattedValues.Contains("createdby"))
				{
					return this.FormattedValues["createdby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyyominame")]
		public string CreatedByYomiName
		{
			get
			{
				if (this.FormattedValues.Contains("createdby"))
				{
					return this.FormattedValues["createdby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Shows who created the record on behalf of another user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfbyname")]
		public string CreatedOnBehalfByName
		{
			get
			{
				if (this.FormattedValues.Contains("createdonbehalfby"))
				{
					return this.FormattedValues["createdonbehalfby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfbyyominame")]
		public string CreatedOnBehalfByYomiName
		{
			get
			{
				if (this.FormattedValues.Contains("createdonbehalfby"))
				{
					return this.FormattedValues["createdonbehalfby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Shows the date the record was assigned to the queue.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("enteredon")]
		public System.Nullable<System.DateTime> EnteredOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("enteredon");
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.SetAttributeValue("importsequencenumber", value);
			}
		}
		
		/// <summary>
		/// Shows who last updated the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyname")]
		public string ModifiedByName
		{
			get
			{
				if (this.FormattedValues.Contains("modifiedby"))
				{
					return this.FormattedValues["modifiedby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyyominame")]
		public string ModifiedByYomiName
		{
			get
			{
				if (this.FormattedValues.Contains("modifiedby"))
				{
					return this.FormattedValues["modifiedby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the queueitem.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfbyname")]
		public string ModifiedOnBehalfByName
		{
			get
			{
				if (this.FormattedValues.Contains("modifiedonbehalfby"))
				{
					return this.FormattedValues["modifiedonbehalfby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfbyyominame")]
		public string ModifiedOnBehalfByYomiName
		{
			get
			{
				if (this.FormattedValues.Contains("modifiedonbehalfby"))
				{
					return this.FormattedValues["modifiedonbehalfby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Liveworkstream this queue item belongs to
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_liveworkstreamid")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_liveworkstreamid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_liveworkstreamid");
			}
			set
			{
				this.SetAttributeValue("msdyn_liveworkstreamid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_liveworkstreamidname")]
		public string msdyn_liveworkstreamidName
		{
			get
			{
				if (this.FormattedValues.Contains("msdyn_liveworkstreamid"))
				{
					return this.FormattedValues["msdyn_liveworkstreamid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// This attribute is used by Unified Routing system to decide whether to Skip Sync Call to Omnichannel Service or not.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_skipursync")]
		public System.Nullable<bool> msdyn_skipursync
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_skipursync");
			}
			set
			{
				this.SetAttributeValue("msdyn_skipursync", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_skipursyncname")]
		public string msdyn_skipursyncName
		{
			get
			{
				if (this.FormattedValues.Contains("msdyn_skipursync"))
				{
					return this.FormattedValues["msdyn_skipursync"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Choose the activity, case, or article assigned to the queue.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		public Microsoft.Xrm.Sdk.EntityReference ObjectId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("objectid");
			}
			set
			{
				this.SetAttributeValue("objectid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectidname")]
		public string ObjectIdName
		{
			get
			{
				if (this.FormattedValues.Contains("objectid"))
				{
					return this.FormattedValues["objectid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Select the type of the queue item, such as activity, case, or appointment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
		public virtual queueitem_objecttypecode? ObjectTypeCode
		{
			get
			{
				return ((queueitem_objecttypecode?)(EntityOptionSetEnum.GetEnum(this, "objecttypecode")));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecodename")]
		public string ObjectTypeCodeName
		{
			get
			{
				if (this.FormattedValues.Contains("objecttypecode"))
				{
					return this.FormattedValues["objecttypecode"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the queue item is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationidname")]
		public string OrganizationIdName
		{
			get
			{
				if (this.FormattedValues.Contains("organizationid"))
				{
					return this.FormattedValues["organizationid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.SetAttributeValue("overriddencreatedon", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the user or team who owns the queue item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the business unit that owns the queue item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who owns the queue item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Priority of the queue item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("priority")]
		[System.ObsoleteAttribute()]
		public System.Nullable<int> Priority
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("priority");
			}
			set
			{
				this.SetAttributeValue("priority", value);
			}
		}
		
		/// <summary>
		/// Choose the queue that the item is assigned to.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
		public Microsoft.Xrm.Sdk.EntityReference QueueId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("queueid");
			}
			set
			{
				this.SetAttributeValue("queueid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueidname")]
		public string QueueIdName
		{
			get
			{
				if (this.FormattedValues.Contains("queueid"))
				{
					return this.FormattedValues["queueid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Unique identifier of the queue item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueitemid")]
		public System.Nullable<System.Guid> QueueItemId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("queueitemid");
			}
			set
			{
				this.SetAttributeValue("queueitemid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueitemid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.QueueItemId = value;
			}
		}
		
		/// <summary>
		/// Sender who created the queue item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sender")]
		[System.ObsoleteAttribute()]
		public string Sender
		{
			get
			{
				return this.GetAttributeValue<string>("sender");
			}
			set
			{
				this.SetAttributeValue("sender", value);
			}
		}
		
		/// <summary>
		/// Status of the queue item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("state")]
		[System.ObsoleteAttribute()]
		public System.Nullable<int> State
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("state");
			}
			set
			{
				this.SetAttributeValue("state", value);
			}
		}
		
		/// <summary>
		/// Shows whether the queue record is active or inactive. Inactive queue records are read-only and can't be edited unless they are reactivated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public virtual queueitem_statecode? StateCode
		{
			get
			{
				return ((queueitem_statecode?)(EntityOptionSetEnum.GetEnum(this, "statecode")));
			}
			set
			{
				this.SetAttributeValue("statecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecodename")]
		public string StateCodeName
		{
			get
			{
				if (this.FormattedValues.Contains("statecode"))
				{
					return this.FormattedValues["statecode"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Reason for the status of the queue item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("status")]
		[System.ObsoleteAttribute()]
		public System.Nullable<int> Status
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("status");
			}
			set
			{
				this.SetAttributeValue("status", value);
			}
		}
		
		/// <summary>
		/// Select the item's status.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual queueitem_statuscode? StatusCode
		{
			get
			{
				return ((queueitem_statuscode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			set
			{
				this.SetAttributeValue("statuscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscodename")]
		public string StatusCodeName
		{
			get
			{
				if (this.FormattedValues.Contains("statuscode"))
				{
					return this.FormattedValues["statuscode"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.SetAttributeValue("timezoneruleversionnumber", value);
			}
		}
		
		/// <summary>
		/// Shows the title or name that describes the queue record. This value is copied from the record that was assigned to the queue.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
		public string Title
		{
			get
			{
				return this.GetAttributeValue<string>("title");
			}
			set
			{
				this.SetAttributeValue("title", value);
			}
		}
		
		/// <summary>
		/// Recipients listed on the To line of the message for email queue items.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("torecipients")]
		[System.ObsoleteAttribute()]
		public string ToRecipients
		{
			get
			{
				return this.GetAttributeValue<string>("torecipients");
			}
			set
			{
				this.SetAttributeValue("torecipients", value);
			}
		}
		
		/// <summary>
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.SetAttributeValue("transactioncurrencyid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyidname")]
		public string TransactionCurrencyIdName
		{
			get
			{
				if (this.FormattedValues.Contains("transactioncurrencyid"))
				{
					return this.FormattedValues["transactioncurrencyid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.SetAttributeValue("utcconversiontimezonecode", value);
			}
		}
		
		/// <summary>
		/// Version number of the queue item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// Shows who is working on the queue item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workerid")]
		public Microsoft.Xrm.Sdk.EntityReference WorkerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("workerid");
			}
			set
			{
				this.SetAttributeValue("workerid", value);
			}
		}
		
		/// <summary>
		/// Shows the date and time when the queue item was last assigned to a user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workeridmodifiedon")]
		public System.Nullable<System.DateTime> WorkerIdModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("workeridmodifiedon");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workeridname")]
		public string WorkerIdName
		{
			get
			{
				if (this.FormattedValues.Contains("workerid"))
				{
					return this.FormattedValues["workerid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workeridyominame")]
		public string WorkerIdYomiName
		{
			get
			{
				if (this.FormattedValues.Contains("workerid"))
				{
					return this.FormattedValues["workerid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// 1:N QueueItem_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QueueItem_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<DataverseEntities.AsyncOperation> QueueItem_AsyncOperations
		{
			get
			{
				return this.GetRelatedEntities<DataverseEntities.AsyncOperation>("QueueItem_AsyncOperations", null);
			}
			set
			{
				this.SetRelatedEntities<DataverseEntities.AsyncOperation>("QueueItem_AsyncOperations", null, value);
			}
		}
		
		/// <summary>
		/// 1:N QueueItem_ProcessSessions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QueueItem_ProcessSessions")]
		public System.Collections.Generic.IEnumerable<DataverseEntities.ProcessSession> QueueItem_ProcessSessions
		{
			get
			{
				return this.GetRelatedEntities<DataverseEntities.ProcessSession>("QueueItem_ProcessSessions", null);
			}
			set
			{
				this.SetRelatedEntities<DataverseEntities.ProcessSession>("QueueItem_ProcessSessions", null, value);
			}
		}
		
		/// <summary>
		/// N:1 ActivityPointer_QueueItem
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityPointer_QueueItem")]
		public DataverseEntities.ActivityPointer ActivityPointer_QueueItem
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.ActivityPointer>("ActivityPointer_QueueItem", null);
			}
			set
			{
				this.SetRelatedEntity<DataverseEntities.ActivityPointer>("ActivityPointer_QueueItem", null, value);
			}
		}
		
		/// <summary>
		/// N:1 Email_QueueItem
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_QueueItem")]
		public DataverseEntities.Email Email_QueueItem
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.Email>("Email_QueueItem", null);
			}
			set
			{
				this.SetRelatedEntity<DataverseEntities.Email>("Email_QueueItem", null, value);
			}
		}
		
		/// <summary>
		/// N:1 Fax_QueueItem
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Fax_QueueItem")]
		public DataverseEntities.Fax Fax_QueueItem
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.Fax>("Fax_QueueItem", null);
			}
			set
			{
				this.SetRelatedEntity<DataverseEntities.Fax>("Fax_QueueItem", null, value);
			}
		}
		
		/// <summary>
		/// N:1 Incident_QueueItem
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_QueueItem")]
		public DataverseEntities.Incident Incident_QueueItem
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.Incident>("Incident_QueueItem", null);
			}
			set
			{
				this.SetRelatedEntity<DataverseEntities.Incident>("Incident_QueueItem", null, value);
			}
		}
		
		/// <summary>
		/// N:1 lk_queueitem_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitem_createdonbehalfby")]
		public DataverseEntities.SystemUser lk_queueitem_createdonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.SystemUser>("lk_queueitem_createdonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_queueitem_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitem_modifiedonbehalfby")]
		public DataverseEntities.SystemUser lk_queueitem_modifiedonbehalfby
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.SystemUser>("lk_queueitem_modifiedonbehalfby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_queueitembase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitembase_createdby")]
		public DataverseEntities.SystemUser lk_queueitembase_createdby
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.SystemUser>("lk_queueitembase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_queueitembase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitembase_modifiedby")]
		public DataverseEntities.SystemUser lk_queueitembase_modifiedby
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.SystemUser>("lk_queueitembase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_queueitembase_workerid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitembase_workerid")]
		public DataverseEntities.SystemUser lk_queueitembase_workerid
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.SystemUser>("lk_queueitembase_workerid", null);
			}
			set
			{
				this.SetRelatedEntity<DataverseEntities.SystemUser>("lk_queueitembase_workerid", null, value);
			}
		}
		
		/// <summary>
		/// N:1 organization_queueitems
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_queueitems")]
		public DataverseEntities.Organization organization_queueitems
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.Organization>("organization_queueitems", null);
			}
		}
		
		/// <summary>
		/// N:1 PhoneCall_QueueItem
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PhoneCall_QueueItem")]
		public DataverseEntities.PhoneCall PhoneCall_QueueItem
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.PhoneCall>("PhoneCall_QueueItem", null);
			}
			set
			{
				this.SetRelatedEntity<DataverseEntities.PhoneCall>("PhoneCall_QueueItem", null, value);
			}
		}
		
		/// <summary>
		/// N:1 queue_entries
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_entries")]
		public DataverseEntities.Queue queue_entries
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.Queue>("queue_entries", null);
			}
			set
			{
				this.SetRelatedEntity<DataverseEntities.Queue>("queue_entries", null, value);
			}
		}
		
		/// <summary>
		/// N:1 Task_QueueItem
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Task_QueueItem")]
		public DataverseEntities.Task Task_QueueItem
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.Task>("Task_QueueItem", null);
			}
			set
			{
				this.SetRelatedEntity<DataverseEntities.Task>("Task_QueueItem", null, value);
			}
		}
		
		/// <summary>
		/// N:1 team_queueitembase_workerid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_queueitembase_workerid")]
		public DataverseEntities.Team team_queueitembase_workerid
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.Team>("team_queueitembase_workerid", null);
			}
			set
			{
				this.SetRelatedEntity<DataverseEntities.Team>("team_queueitembase_workerid", null, value);
			}
		}
	}
}
#pragma warning restore CS1591

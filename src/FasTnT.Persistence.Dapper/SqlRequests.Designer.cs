﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FasTnT.Persistence.Dapper {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class SqlRequests {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlRequests() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FasTnT.Persistence.Dapper.SqlRequests", typeof(SqlRequests).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H4sIAAAAAAAA/81b3XKjOBa+jp9Cleqt2LuOy/nrtCc1FxjLCdMOZACnp/eGwiDHVNvg8JOe7KvtxTzSvMIehMCAARObbHeq2p2go6Oj7zs6OkfIf//3r9NTNFWwrCCFv8P3XIuXMadi9hcSxkiUVIT/EBRVQYFHXO8mFlG54QQXSfTCz1a7heDHMlEQwEcoI04nky59GgrY+oogY6G7uuETF73o7qtlP7Wv+h3ES5NJOML6STN0X186T71jk8z1YOkf5zStdc/77rhmgaaz/vnFm3S55MnyQAMxNcdGvrUinq+v1ui75S+cwKdP0H8cmyT90AiPuelEpU1hS/tkqvInv/zikz/9LrKd7+1OJ1LOS6Kiypwgquj44bMWInCMHmThnpO/os/4K2pb5rZo8EwltQSwqSj8PsWoHT/otDqtL4J6h9qSMFLQr2jMTRTcuWm1gFj8wAu1iCVrw6omlkr0XPIcACiV3JqOEayI7WsUrjooxugbwGP9Xm/AnkLI [rest of string was truncated]&quot;;.
        /// </summary>
        public static string CreateDatabaseZipped {
            get {
                return ResourceManager.GetString("CreateDatabaseZipped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H4sIAAAAAAAAC3u/e79LkH+AQrCzh6uvo4Knm4JrhGdwSLBCcVJKhoKzY7Czo4urNS8XdkXJiTk5SYnJ2QQVFpcmFScXZRaUZObnFRM2NqmMoJrUguRMwiaVFqcWIVQBAOPdp4/tAAAA.
        /// </summary>
        public static string DropDatabaseZipped {
            get {
                return ResourceManager.GetString("DropDatabaseZipped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT request.record_time as capture_time, event.id, event_type as type, event.record_time as event_time, action, read_point, event_timezone_offset, disposition, business_location, business_step, transformation_id, event.event_id, declaration_time, reason FROM epcis.event JOIN epcis.request on request.id = event.request_id LEFT JOIN epcis.error_declaration ed ON event.id = ed.event_id /**where**/ /**orderby**/ LIMIT @limit.
        /// </summary>
        public static string EventQuery {
            get {
                return ResourceManager.GetString("EventQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT masterdata_type AS parent_type, masterdata_id AS parent_id, id, value FROM cbv.attribute WHERE masterdata_id = ANY(@Ids).
        /// </summary>
        public static string MasterDataAllAttributeQuery {
            get {
                return ResourceManager.GetString("MasterDataAllAttributeQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO cbv.attribute_field(internal_id, internal_parent_id, masterdata_id, masterdata_type, parent_id, name, namespace, value) VALUES(@Id, @InternalParentId, @MasterdataId, @MasterdataType, @ParentId, @Name, @Namespace, @Value);.
        /// </summary>
        public static string MasterDataAttributeFieldInsert {
            get {
                return ResourceManager.GetString("MasterDataAttributeFieldInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO cbv.attribute(masterdata_id, masterdata_type, id, value) VALUES(@ParentId, @ParentType, @Id, @Value) ON CONFLICT ON CONSTRAINT pk_cbv_masterdata_attribute DO UPDATE SET value = @Value;.
        /// </summary>
        public static string MasterDataAttributeInsert {
            get {
                return ResourceManager.GetString("MasterDataAttributeInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT masterdata_type AS parent_type, masterdata_id AS parent_id, id, value FROM cbv.attribute WHERE masterdata_id = ANY(@Ids) AND id = ANY(@Attributes).
        /// </summary>
        public static string MasterDataAttributeQuery {
            get {
                return ResourceManager.GetString("MasterDataAttributeQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM cbv.attribute_field WHERE masterdata_type = @Type AND masterdata_id = @Id; DELETE FROM cbv.hierarchy WHERE type = @Type AND (parent_id = @Id OR children_id = @Id); DELETE FROM cbv.attribute WHERE masterdata_id = @Id AND masterdata_type = @Type; DELETE FROM cbv.masterdata WHERE id = @Id AND type = @Type;.
        /// </summary>
        public static string MasterDataDelete {
            get {
                return ResourceManager.GetString("MasterDataDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO cbv.hierarchy(type, parent_id, children_id) VALUES(@Type, @ParentId, @ChildrenId) ...;.
        /// </summary>
        public static string MasterDataHierarchyInsert {
            get {
                return ResourceManager.GetString("MasterDataHierarchyInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO cbv.masterdata(id, type, created_on, last_update) VALUES(@Id, @Type, NOW(), NOW()) ON CONFLICT ON CONSTRAINT pk_cbv_masterdata DO UPDATE SET last_update = NOW();.
        /// </summary>
        public static string MasterDataInsert {
            get {
                return ResourceManager.GetString("MasterDataInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT md.type, md.id FROM cbv.masterdata md /**where**/ ORDER BY md.last_update DESC LIMIT @limit.
        /// </summary>
        public static string MasterDataQuery {
            get {
                return ResourceManager.GetString("MasterDataQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT event_id, epc as id, type, is_quantity, quantity, unit_of_measure FROM epcis.epc WHERE event_id = ANY(@EventIds);
        ///SELECT event_id, field_id as id, parent_id, namespace, name, type, text_value, numeric_value, date_value FROM epcis.custom_field WHERE event_id = ANY(@EventIds);
        ///SELECT event_id, transaction_type as type, transaction_id as id FROM epcis.business_transaction WHERE event_id = ANY(@EventIds);
        ///SELECT event_id, type, source_dest_id as id, direction FROM epcis.source_destination WHERE event_ [rest of string was truncated]&quot;;.
        /// </summary>
        public static string RelatedQuery {
            get {
                return ResourceManager.GetString("RelatedQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO epcis.business_transaction(event_id, transaction_type, transaction_id) VALUES (@EventId, @Type, @Id) ...;.
        /// </summary>
        public static string StoreBusinessTransaction {
            get {
                return ResourceManager.GetString("StoreBusinessTransaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO epcis.custom_field(event_id, field_id, parent_id, namespace, name, type, text_value, numeric_value, date_value) VALUES (@EventId, @Id, @ParentId, @Namespace, @Name, @Type, @TextValue, @NumericValue, @DateValue) ...;.
        /// </summary>
        public static string StoreCustomField {
            get {
                return ResourceManager.GetString("StoreCustomField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO epcis.epc(event_id, epc, type, is_quantity, quantity, unit_of_measure) VALUES (@EventId, @Id, @Type, @IsQuantity, @Quantity, @UnitOfMeasure) ...;.
        /// </summary>
        public static string StoreEpcs {
            get {
                return ResourceManager.GetString("StoreEpcs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO epcis.error_declaration(event_id, declaration_time, reason) VALUES(@EventId, @DeclarationTime, @Reason) ...;.
        /// </summary>
        public static string StoreErrorDeclaration {
            get {
                return ResourceManager.GetString("StoreErrorDeclaration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO epcis.error_declaration_eventid(event_id, corrective_eventid) VALUES(@EventId, @CorrectiveId) ...;.
        /// </summary>
        public static string StoreErrorDeclarationIds {
            get {
                return ResourceManager.GetString("StoreErrorDeclarationIds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO epcis.event(id, request_id, record_time, action, event_type, event_timezone_offset, business_location, business_step, disposition, read_point, transformation_id, event_id) VALUES(@Id, @RequestId, @EventTime, @Action, @Type, @EventTimeZoneOffset, @BusinessLocation, @BusinessStep, @Disposition, @ReadPoint, @TransformationId, @EventId) ...;.
        /// </summary>
        public static string StoreEvent {
            get {
                return ResourceManager.GetString("StoreEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO callback.query_callback(id, request_id, subscription_id, callback_type) VALUES(@Id, @RequestId, @SubscriptionId, @CallbackType);.
        /// </summary>
        public static string StoreQueryCallback {
            get {
                return ResourceManager.GetString("StoreQueryCallback", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO epcis.request(id, document_time, record_time, user_id) VALUES(@Id, @DocumentTime, @RecordTime, @UserId);.
        /// </summary>
        public static string StoreRequest {
            get {
                return ResourceManager.GetString("StoreRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO epcis.source_destination(event_id, type, source_dest_id, direction) VALUES (@EventId, @Type, @Id, @Direction) ...;.
        /// </summary>
        public static string StoreSourceDestination {
            get {
                return ResourceManager.GetString("StoreSourceDestination", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO sbdh.standardheader(id, version, standard, type_version, identifier, type, creation_datetime) VALUES(@Id, @Version, @Standard, @TypeVersion, @InstanceIdentifier, @Type, @CreationDateTime);.
        /// </summary>
        public static string StoreStandardHeader {
            get {
                return ResourceManager.GetString("StoreStandardHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO sbdh.contactinformation(id, header_id, type, identifier, contact, email, fax_number, phone_number, type_identifier) VALUES(@Id, @HeaderId, @Type, @Identifier, @Contact, @EmailAddress, @FaxNumber, @TelephoneNumber, @ContactTypeIdentifier) ...;.
        /// </summary>
        public static string StoreStandardHeaderContactInformations {
            get {
                return ResourceManager.GetString("StoreStandardHeaderContactInformations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM subscriptions.pendingrequest WHERE subscription_id = (SELECT id FROM subscriptions.subscription WHERE subscription_id = @SubscriptionId) AND request_id = ANY(@RequestId).
        /// </summary>
        public static string SubscriptionAcknowledgePendingRequests {
            get {
                return ResourceManager.GetString("SubscriptionAcknowledgePendingRequests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE from subscriptions.subscription WHERE subscription_id = @Id;.
        /// </summary>
        public static string SubscriptionDelete {
            get {
                return ResourceManager.GetString("SubscriptionDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT s.id, s.subscription_id, s.query_name, s.active FROM subscriptions.subscription s.
        /// </summary>
        public static string SubscriptionListIds {
            get {
                return ResourceManager.GetString("SubscriptionListIds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT p.subscription_id, p.name, pv.value FROM subscriptions.parameter p INNER JOIN subscriptions.parameter_value pv ON pv.parameter_id = p.id.
        /// </summary>
        public static string SubscriptionListParameters {
            get {
                return ResourceManager.GetString("SubscriptionListParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT pr.request_id FROM subscriptions.pendingrequest pr JOIN subscriptions.subscription s ON s.id = pr.subscription_id WHERE s.subscription_id = @SubscriptionId.
        /// </summary>
        public static string SubscriptionListPendingRequestIds {
            get {
                return ResourceManager.GetString("SubscriptionListPendingRequestIds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT s.id, s.destination, s.subscription_id, s.query_name, s.active, s.trigger, s.report_if_empty, s.schedule_minutes, s.schedule_seconds, s.schedule_hours, s.schedule_month, s.schedule_day_of_month, s.schedule_day_of_week FROM subscriptions.subscription s.
        /// </summary>
        public static string SubscriptionsList {
            get {
                return ResourceManager.GetString("SubscriptionsList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO subscriptions.subscription(id, subscription_id, trigger, initial_record_time, report_if_empty, destination, query_name,  active, schedule_seconds, schedule_minutes, schedule_hours, schedule_month, schedule_day_of_month, schedule_day_of_week) VALUES(@Id, @SubscriptionId, @Trigger, @InitialRecordTime, @ReportIfEmpty, @Destination, @QueryName, @Active, @Second, @Minute, @Hour, @Month, @DayOfMonth, @DayOfWeek);.
        /// </summary>
        public static string SubscriptionStore {
            get {
                return ResourceManager.GetString("SubscriptionStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO subscriptions.parameter(id, subscription_id, name) VALUES(@Id, @SubscriptionId, @Name).
        /// </summary>
        public static string SubscriptionStoreParameter {
            get {
                return ResourceManager.GetString("SubscriptionStoreParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO subscriptions.parameter_value(id, parameter_id, value) VALUES(@Id, @ParameterId, @Value);.
        /// </summary>
        public static string SubscriptionStoreParameterValue {
            get {
                return ResourceManager.GetString("SubscriptionStoreParameterValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO subscriptions.trigger(id, subscription_id, trigger_time, status, reason) VALUES(@Id, (SELECT id FROM subscriptions.subscription WHERE subscription_id = @SubscriptionId), NOW(), @Status, @Reason);.
        /// </summary>
        public static string SubscriptionStoreTrigger {
            get {
                return ResourceManager.GetString("SubscriptionStoreTrigger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT id, username, password FROM users.user WHERE username = @Username.
        /// </summary>
        public static string UserLoadByName {
            get {
                return ResourceManager.GetString("UserLoadByName", resourceCulture);
            }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FasTnT.Data.PostgreSql.Subscriptions {
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
    internal class SubscriptionRequests {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SubscriptionRequests() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FasTnT.Data.PostgreSql.Subscriptions.SubscriptionRequests", typeof(SubscriptionRequests).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM subscriptions.pendingrequest WHERE subscription_id = @SubscriptionId AND request_id = ANY(@RequestIds);.
        /// </summary>
        internal static string AcknowledgePendingRequests {
            get {
                return ResourceManager.GetString("AcknowledgePendingRequests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE from subscriptions.subscription WHERE id = @SubscriptionId;.
        /// </summary>
        internal static string DeleteSubscription {
            get {
                return ResourceManager.GetString("DeleteSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT s.id, s.destination, s.subscription_id, s.query_name, s.active, s.trigger, s.report_if_empty, s.schedule_minutes, s.schedule_seconds, s.schedule_hours, s.schedule_month, s.schedule_day_of_month, s.schedule_day_of_week FROM subscriptions.subscription s;.
        /// </summary>
        internal static string GetAllSubscriptions {
            get {
                return ResourceManager.GetString("GetAllSubscriptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT s.id, s.destination, s.subscription_id, s.query_name, s.active, s.trigger, s.report_if_empty, s.schedule_minutes, s.schedule_seconds, s.schedule_hours, s.schedule_month, s.schedule_day_of_month, s.schedule_day_of_week FROM subscriptions.subscription s WHERE s.subscription_id = @SubscriptionId;.
        /// </summary>
        internal static string GetSubscriptionById {
            get {
                return ResourceManager.GetString("GetSubscriptionById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT p.subscription_id, p.name, pv.value FROM subscriptions.parameter p INNER JOIN subscriptions.parameter_value pv ON pv.parameter_id = p.id WHERE p.subscription_id = ANY(@SubscriptionIds);.
        /// </summary>
        internal static string ListParameters {
            get {
                return ResourceManager.GetString("ListParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT pr.request_id FROM subscriptions.pendingrequest pr JOIN subscriptions.subscription s ON s.id = pr.subscription_id WHERE s.id = @SubscriptionId;.
        /// </summary>
        internal static string ListPendingRequests {
            get {
                return ResourceManager.GetString("ListPendingRequests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT s.subscription_id FROM subscriptions.subscription s WHERE s.active = true;.
        /// </summary>
        internal static string ListSubscriptionIds {
            get {
                return ResourceManager.GetString("ListSubscriptionIds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO subscriptions.trigger(subscription_id, trigger_time, status, reason) VALUES(@SubscriptionId, NOW(), @Result, @Reason);.
        /// </summary>
        internal static string RegisterTrigger {
            get {
                return ResourceManager.GetString("RegisterTrigger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO subscriptions.subscription(subscription_id, trigger, initial_record_time, report_if_empty, destination, query_name,  active, schedule_seconds, schedule_minutes, schedule_hours, schedule_month, schedule_day_of_month, schedule_day_of_week) VALUES(@subscriptionid, @trigger, @initialrecordtime, @reportifempty, @destination, @queryname, @active, @second, @minute, @hour, @month, @dayofmonth, @dayofweek) RETURNING id;.
        /// </summary>
        internal static string Store {
            get {
                return ResourceManager.GetString("Store", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO subscriptions.parameter(subscription_id, name) VALUES(@subscriptionid, @name) ... RETURNING id;.
        /// </summary>
        internal static string StoreParameter {
            get {
                return ResourceManager.GetString("StoreParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO subscriptions.parameter_value(parameter_id, value) VALUES(@parameterid, @value) ...;.
        /// </summary>
        internal static string StoreParameterValue {
            get {
                return ResourceManager.GetString("StoreParameterValue", resourceCulture);
            }
        }
    }
}

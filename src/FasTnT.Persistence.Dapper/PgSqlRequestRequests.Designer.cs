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
    internal class PgSqlRequestRequests {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PgSqlRequestRequests() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FasTnT.Persistence.Dapper.PgSqlRequestRequests", typeof(PgSqlRequestRequests).Assembly);
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
        ///   Looks up a localized string similar to INSERT INTO epcis.request(document_time, record_time, user_id) VALUES(@documenttime, @recordtime, @userid) RETURNING id;.
        /// </summary>
        internal static string Store {
            get {
                return ResourceManager.GetString("Store", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO sbdh.standardheader(id, version, standard, type_version, identifier, type, creation_datetime) VALUES(@id, @version, @standard, @typeversion, @instanceidentifier, @type, @creationdatetime);.
        /// </summary>
        internal static string StoreStandardHeader {
            get {
                return ResourceManager.GetString("StoreStandardHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO sbdh.contactinformation(id, header_id, type, identifier, contact, email, fax_number, phone_number, type_identifier) VALUES(@id, @headerid, @type, @identifier, @contact, @emailaddress, @faxnumber, @telephonenumber, @contacttypeidentifier) ...;.
        /// </summary>
        internal static string StoreStandardHeaderContactInformations {
            get {
                return ResourceManager.GetString("StoreStandardHeaderContactInformations", resourceCulture);
            }
        }
    }
}

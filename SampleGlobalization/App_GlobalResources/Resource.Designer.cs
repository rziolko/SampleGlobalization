//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleGlobalization.App_GlobalResources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SampleGlobalization.App_GlobalResources.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to Demo PL APP.
        /// </summary>
        public static string AppName {
            get {
                return ResourceManager.GetString("AppName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adres email.
        /// </summary>
        public static string EmailName {
            get {
                return ResourceManager.GetString("EmailName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Strona główna.
        /// </summary>
        public static string Index {
            get {
                return ResourceManager.GetString("Index", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Niepoprawnny pseudonim.
        /// </summary>
        public static string InvalidNickName {
            get {
                return ResourceManager.GetString("InvalidNickName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pseudonim.
        /// </summary>
        public static string NickName {
            get {
                return ResourceManager.GetString("NickName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dodaj element.
        /// </summary>
        public static string SimpleFormAdd {
            get {
                return ResourceManager.GetString("SimpleFormAdd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lista elementów.
        /// </summary>
        public static string SimpleFormList {
            get {
                return ResourceManager.GetString("SimpleFormList", resourceCulture);
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.PowerToys.Run.Plugin.Calculator.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.PowerToys.Run.Plugin.Calculator.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Copy failed, please try later.
        /// </summary>
        public static string wox_plugin_calculator_copy_failed {
            get {
                return ResourceManager.GetString("wox_plugin_calculator_copy_failed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Copy this number to the clipboard.
        /// </summary>
        public static string wox_plugin_calculator_copy_number_to_clipboard {
            get {
                return ResourceManager.GetString("wox_plugin_calculator_copy_number_to_clipboard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression wrong or incomplete (Did you forget some parentheses?).
        /// </summary>
        public static string wox_plugin_calculator_expression_not_complete {
            get {
                return ResourceManager.GetString("wox_plugin_calculator_expression_not_complete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not a number (NaN).
        /// </summary>
        public static string wox_plugin_calculator_not_a_number {
            get {
                return ResourceManager.GetString("wox_plugin_calculator_not_a_number", resourceCulture);
            }
        }

        
        /// <summary>
        ///   Looks up a localized string similar to Does mathematical calculations (e.g. 5*3-2)..
        /// </summary>
        public static string wox_plugin_calculator_plugin_description {
            get {
                return ResourceManager.GetString("wox_plugin_calculator_plugin_description", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Calculator.
        /// </summary>
        public static string wox_plugin_calculator_plugin_name {
            get {
                return ResourceManager.GetString("wox_plugin_calculator_plugin_name", resourceCulture);
            }
        }
    }
}

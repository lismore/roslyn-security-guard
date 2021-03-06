﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoslynSecurityGuard {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RoslynSecurityGuard.Messages", typeof(Messages).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to The dynamic value passed to the command execution should be validate..
        /// </summary>
        internal static string CommandInjectionAnalyzer_Message {
            get {
                return ResourceManager.GetString("CommandInjectionAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Potential command injection with Process.Start.
        /// </summary>
        internal static string CommandInjectionAnalyzer_Title {
            get {
                return ResourceManager.GetString("CommandInjectionAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event validation is disabled. The integrity of client-side control will not be validate on postback..
        /// </summary>
        internal static string EnableEventValidationFalse_Message {
            get {
                return ResourceManager.GetString("EnableEventValidationFalse_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event validation is disabled.
        /// </summary>
        internal static string EnableEventValidationFalse_Title {
            get {
                return ResourceManager.GetString("EnableEventValidationFalse_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View state mac is disable. The view state could be altered by an attacker. (This feature cannot be disabled in the recent version of ASP.net).
        /// </summary>
        internal static string EnableViewStateMac_Message {
            get {
                return ResourceManager.GetString("EnableViewStateMac_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View state mac is disabled (Future).
        /// </summary>
        internal static string EnableViewStateMac_Title {
            get {
                return ResourceManager.GetString("EnableViewStateMac_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The dynamic value passed in the SQL query should be validate..
        /// </summary>
        internal static string LinqSqlInjectionAnalyzer_Message {
            get {
                return ResourceManager.GetString("LinqSqlInjectionAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Potential SQL injection with LINQ.
        /// </summary>
        internal static string LinqSqlInjectionAnalyzer_Title {
            get {
                return ResourceManager.GetString("LinqSqlInjectionAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request validation, which provided additionnal protection against Cross-Site Scripting (XSS), has been disabled. .
        /// </summary>
        internal static string ValidateRequestFalse_Message {
            get {
                return ResourceManager.GetString("ValidateRequestFalse_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request validation has been disabled (Future).
        /// </summary>
        internal static string ValidateRequestFalse_Title {
            get {
                return ResourceManager.GetString("ValidateRequestFalse_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View state is not encrypted. Controls may leak sensitive data that could be read client-side..
        /// </summary>
        internal static string ViewStateEncryptionModeFalse_Message {
            get {
                return ResourceManager.GetString("ViewStateEncryptionModeFalse_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View state is not encrypted (Future).
        /// </summary>
        internal static string ViewStateEncryptionModeFalse_Title {
            get {
                return ResourceManager.GetString("ViewStateEncryptionModeFalse_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate Validation has been disable. The communication could be intercepted..
        /// </summary>
        internal static string WeakCertificateValidationAnalyzer_Message {
            get {
                return ResourceManager.GetString("WeakCertificateValidationAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate Validation has been disable.
        /// </summary>
        internal static string WeakCertificateValidationAnalyzer_Title {
            get {
                return ResourceManager.GetString("WeakCertificateValidationAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DES is not considered strong ciphers for modern applications. Currently, NIST recommends the usage of AES block ciphers instead of DES..
        /// </summary>
        internal static string WeakCipherAnalyzer_Message {
            get {
                return ResourceManager.GetString("WeakCipherAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Weak cipher algorithm.
        /// </summary>
        internal static string WeakCipherAnalyzer_Title {
            get {
                return ResourceManager.GetString("WeakCipherAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This specific mode of CBC with PKCS5Padding is susceptible to padding oracle attacks. An adversary could potentially decrypt the message if the system exposed the difference between plaintext with invalid padding or valid padding..
        /// </summary>
        internal static string WeakCipherModeAnalyzerCbc_Message {
            get {
                return ResourceManager.GetString("WeakCipherModeAnalyzerCbc_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CBC mode is weak.
        /// </summary>
        internal static string WeakCipherModeAnalyzerCbc_Title {
            get {
                return ResourceManager.GetString("WeakCipherModeAnalyzerCbc_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ECB mode produce the same result for identical blocks (ie: 16 bytes for AES). An attacker could be able to guess the encrypted message. The use of AES in CBC mode with a HMAC is recommended guaranteeing integrity and confidentiality..
        /// </summary>
        internal static string WeakCipherModeAnalyzerEcb_Message {
            get {
                return ResourceManager.GetString("WeakCipherModeAnalyzerEcb_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ECB mode is weak.
        /// </summary>
        internal static string WeakCipherModeAnalyzerEcb_Title {
            get {
                return ResourceManager.GetString("WeakCipherModeAnalyzerEcb_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ciphertext produced is susceptible to alteration by an adversary. This mean that the cipher provides no way to detect that the data has been tampered with. If the ciphertext can be controlled by an attacker, it could be altered without detection. The use of AES in CBC mode with a HMAC is recommended guaranteeing integrity and confidentiality..
        /// </summary>
        internal static string WeakCipherModeAnalyzerGeneric_Message {
            get {
                return ResourceManager.GetString("WeakCipherModeAnalyzerGeneric_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Weak cipher mode.
        /// </summary>
        internal static string WeakCipherModeAnalyzerGeneric_Title {
            get {
                return ResourceManager.GetString("WeakCipherModeAnalyzerGeneric_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The hashing function &quot;{0}&quot; is no longer recommended for password storage and signature generation..
        /// </summary>
        internal static string WeakHashingAnalyzer_Message {
            get {
                return ResourceManager.GetString("WeakHashingAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Weak hashing function.
        /// </summary>
        internal static string WeakHashingAnalyzer_Title {
            get {
                return ResourceManager.GetString("WeakHashingAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The random numbers generated could be predicted..
        /// </summary>
        internal static string WeakRandomAnalyzer_Message {
            get {
                return ResourceManager.GetString("WeakRandomAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Weak random generator.
        /// </summary>
        internal static string WeakRandomAnalyzer_Title {
            get {
                return ResourceManager.GetString("WeakRandomAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The dynamic value passed to the XPath query should be validate.
        /// </summary>
        internal static string XPathInjectionAnalyzer_Message {
            get {
                return ResourceManager.GetString("XPathInjectionAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Potential XPath injection with XmlDocument.
        /// </summary>
        internal static string XPathInjectionAnalyzer_Title {
            get {
                return ResourceManager.GetString("XPathInjectionAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The XML parser is configured incorrectly. The operation could be vulnerable to XXE..
        /// </summary>
        internal static string XxeAnalyzer_Message {
            get {
                return ResourceManager.GetString("XxeAnalyzer_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to XML parsing vulnerable to XXE.
        /// </summary>
        internal static string XxeAnalyzer_Title {
            get {
                return ResourceManager.GetString("XxeAnalyzer_Title", resourceCulture);
            }
        }
    }
}

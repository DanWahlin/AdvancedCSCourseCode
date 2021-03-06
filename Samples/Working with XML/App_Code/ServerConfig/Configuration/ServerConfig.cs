﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version:2.0.40607.85
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.40607.85.
// 
namespace XmlForAsp.Configuration {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public class ServerConfig {
        
        private Server[] serversField;
        
        private ConnectionString[] connectionStringsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Server[] Servers {
            get {
                return this.serversField;
            }
            set {
                this.serversField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ConnectionString[] ConnectionStrings {
            get {
                return this.connectionStringsField;
            }
            set {
                this.connectionStringsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    public class Server {
        
        private string[] domainsField;
        
        private string nameField;
        
        private ServerType typeField;
        
        private bool typeFieldSpecified;
        
        private ServerEnvironment environmentField;
        
        private bool environmentFieldSpecified;
        
        private string userNameField;
        
        private string passwordField;
        
        private string domainField;
        
        private string ipField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Domain", IsNullable=false)]
        public string[] Domains {
            get {
                return this.domainsField;
            }
            set {
                this.domainsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ServerType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ServerEnvironment Environment {
            get {
                return this.environmentField;
            }
            set {
                this.environmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnvironmentSpecified {
            get {
                return this.environmentFieldSpecified;
            }
            set {
                this.environmentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Domain {
            get {
                return this.domainField;
            }
            set {
                this.domainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IP {
            get {
                return this.ipField;
            }
            set {
                this.ipField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    public enum ServerType {
        
        /// <remarks/>
        Web,
        
        /// <remarks/>
        Proxy,
        
        /// <remarks/>
        Mail,
        
        /// <remarks/>
        Database,
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    public enum ServerEnvironment {
        
        /// <remarks/>
        Development,
        
        /// <remarks/>
        Deployment,
        
        /// <remarks/>
        Production,
    }
    
    /// <remarks/>
    [System.SerializableAttribute()]
    public class ConnectionString {
        
        private string primaryField;
        
        private string secondaryField;
        
        private string developmentField;
        
        private string databaseField;
        
        /// <remarks/>
        public string Primary {
            get {
                return this.primaryField;
            }
            set {
                this.primaryField = value;
            }
        }
        
        /// <remarks/>
        public string Secondary {
            get {
                return this.secondaryField;
            }
            set {
                this.secondaryField = value;
            }
        }
        
        /// <remarks/>
        public string Development {
            get {
                return this.developmentField;
            }
            set {
                this.developmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Database {
            get {
                return this.databaseField;
            }
            set {
                this.databaseField = value;
            }
        }
    }
}

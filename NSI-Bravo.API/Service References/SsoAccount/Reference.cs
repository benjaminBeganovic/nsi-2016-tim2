﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularJSAuthentication.API.SsoAccount {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginRequest", Namespace="http://schemas.datacontract.org/2004/07/SSO.WCFService.DataContracts")]
    [System.SerializableAttribute()]
    public partial class LoginRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActionResult", Namespace="http://schemas.datacontract.org/2004/07/SSO.WCFService.DataContracts")]
    [System.SerializableAttribute()]
    public partial class ActionResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MyFault", Namespace="http://schemas.datacontract.org/2004/07/SSO.WCFService.DataContracts")]
    [System.SerializableAttribute()]
    public partial class MyFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DetailsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Details {
            get {
                return this.DetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailsField, value) != true)) {
                    this.DetailsField = value;
                    this.RaisePropertyChanged("Details");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RegisterRequest", Namespace="http://schemas.datacontract.org/2004/07/SSO.WCFService.DataContracts")]
    [System.SerializableAttribute()]
    public partial class RegisterRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string EmailField;
        
        private string FirstNameField;
        
        private string LastNameField;
        
        private string PasswordField;
        
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthResponse", Namespace="http://schemas.datacontract.org/2004/07/SSO.WCFService.DataContracts")]
    [System.SerializableAttribute()]
    public partial class AuthResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] RolesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Roles {
            get {
                return this.RolesField;
            }
            set {
                if ((object.ReferenceEquals(this.RolesField, value) != true)) {
                    this.RolesField = value;
                    this.RaisePropertyChanged("Roles");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SsoAccount.IAccount")]
    public interface IAccount {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/Login", ReplyAction="http://tempuri.org/IAccount/LoginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AngularJSAuthentication.API.SsoAccount.MyFault), Action="http://tempuri.org/IAccount/LoginMyFaultFault", Name="MyFault", Namespace="http://schemas.datacontract.org/2004/07/SSO.WCFService.DataContracts")]
        AngularJSAuthentication.API.SsoAccount.ActionResult Login(AngularJSAuthentication.API.SsoAccount.LoginRequest loginModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/Login", ReplyAction="http://tempuri.org/IAccount/LoginResponse")]
        System.Threading.Tasks.Task<AngularJSAuthentication.API.SsoAccount.ActionResult> LoginAsync(AngularJSAuthentication.API.SsoAccount.LoginRequest loginModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/Register", ReplyAction="http://tempuri.org/IAccount/RegisterResponse")]
        AngularJSAuthentication.API.SsoAccount.ActionResult Register(AngularJSAuthentication.API.SsoAccount.RegisterRequest registerModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/Register", ReplyAction="http://tempuri.org/IAccount/RegisterResponse")]
        System.Threading.Tasks.Task<AngularJSAuthentication.API.SsoAccount.ActionResult> RegisterAsync(AngularJSAuthentication.API.SsoAccount.RegisterRequest registerModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/ChangePassword", ReplyAction="http://tempuri.org/IAccount/ChangePasswordResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AngularJSAuthentication.API.SsoAccount.MyFault), Action="http://tempuri.org/IAccount/ChangePasswordMyFaultFault", Name="MyFault", Namespace="http://schemas.datacontract.org/2004/07/SSO.WCFService.DataContracts")]
        AngularJSAuthentication.API.SsoAccount.ActionResult ChangePassword();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/ChangePassword", ReplyAction="http://tempuri.org/IAccount/ChangePasswordResponse")]
        System.Threading.Tasks.Task<AngularJSAuthentication.API.SsoAccount.ActionResult> ChangePasswordAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/Auth", ReplyAction="http://tempuri.org/IAccount/AuthResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AngularJSAuthentication.API.SsoAccount.MyFault), Action="http://tempuri.org/IAccount/AuthMyFaultFault", Name="MyFault", Namespace="http://schemas.datacontract.org/2004/07/SSO.WCFService.DataContracts")]
        AngularJSAuthentication.API.SsoAccount.AuthResponse Auth();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/Auth", ReplyAction="http://tempuri.org/IAccount/AuthResponse")]
        System.Threading.Tasks.Task<AngularJSAuthentication.API.SsoAccount.AuthResponse> AuthAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/Logout", ReplyAction="http://tempuri.org/IAccount/LogoutResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AngularJSAuthentication.API.SsoAccount.MyFault), Action="http://tempuri.org/IAccount/LogoutMyFaultFault", Name="MyFault", Namespace="http://schemas.datacontract.org/2004/07/SSO.WCFService.DataContracts")]
        AngularJSAuthentication.API.SsoAccount.ActionResult Logout();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/Logout", ReplyAction="http://tempuri.org/IAccount/LogoutResponse")]
        System.Threading.Tasks.Task<AngularJSAuthentication.API.SsoAccount.ActionResult> LogoutAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/GetOptions", ReplyAction="http://tempuri.org/IAccount/GetOptionsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(AngularJSAuthentication.API.SsoAccount.MyFault), Action="http://tempuri.org/IAccount/GetOptionsMyFaultFault", Name="MyFault", Namespace="http://schemas.datacontract.org/2004/07/SSO.WCFService.DataContracts")]
        void GetOptions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccount/GetOptions", ReplyAction="http://tempuri.org/IAccount/GetOptionsResponse")]
        System.Threading.Tasks.Task GetOptionsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountChannel : AngularJSAuthentication.API.SsoAccount.IAccount, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountClient : System.ServiceModel.ClientBase<AngularJSAuthentication.API.SsoAccount.IAccount>, AngularJSAuthentication.API.SsoAccount.IAccount {
        
        public AccountClient() {
        }
        
        public AccountClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AngularJSAuthentication.API.SsoAccount.ActionResult Login(AngularJSAuthentication.API.SsoAccount.LoginRequest loginModel) {
            return base.Channel.Login(loginModel);
        }
        
        public System.Threading.Tasks.Task<AngularJSAuthentication.API.SsoAccount.ActionResult> LoginAsync(AngularJSAuthentication.API.SsoAccount.LoginRequest loginModel) {
            return base.Channel.LoginAsync(loginModel);
        }
        
        public AngularJSAuthentication.API.SsoAccount.ActionResult Register(AngularJSAuthentication.API.SsoAccount.RegisterRequest registerModel) {
            return base.Channel.Register(registerModel);
        }
        
        public System.Threading.Tasks.Task<AngularJSAuthentication.API.SsoAccount.ActionResult> RegisterAsync(AngularJSAuthentication.API.SsoAccount.RegisterRequest registerModel) {
            return base.Channel.RegisterAsync(registerModel);
        }
        
        public AngularJSAuthentication.API.SsoAccount.ActionResult ChangePassword() {
            return base.Channel.ChangePassword();
        }
        
        public System.Threading.Tasks.Task<AngularJSAuthentication.API.SsoAccount.ActionResult> ChangePasswordAsync() {
            return base.Channel.ChangePasswordAsync();
        }
        
        public AngularJSAuthentication.API.SsoAccount.AuthResponse Auth() {
            return base.Channel.Auth();
        }
        
        public System.Threading.Tasks.Task<AngularJSAuthentication.API.SsoAccount.AuthResponse> AuthAsync() {
            return base.Channel.AuthAsync();
        }
        
        public AngularJSAuthentication.API.SsoAccount.ActionResult Logout() {
            return base.Channel.Logout();
        }
        
        public System.Threading.Tasks.Task<AngularJSAuthentication.API.SsoAccount.ActionResult> LogoutAsync() {
            return base.Channel.LogoutAsync();
        }
        
        public void GetOptions() {
            base.Channel.GetOptions();
        }
        
        public System.Threading.Tasks.Task GetOptionsAsync() {
            return base.Channel.GetOptionsAsync();
        }
    }
}
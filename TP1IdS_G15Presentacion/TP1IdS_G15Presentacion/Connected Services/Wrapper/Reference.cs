﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TP1IdS_G15Presentacion.Wrapper {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Autorizacion", Namespace="http://schemas.datacontract.org/2004/07/SGE.Service.Contracts.Data")]
    [System.SerializableAttribute()]
    public partial class Autorizacion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long CuitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SignField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TokenField;
        
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
        public long Cuit {
            get {
                return this.CuitField;
            }
            set {
                if ((this.CuitField.Equals(value) != true)) {
                    this.CuitField = value;
                    this.RaisePropertyChanged("Cuit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sign {
            get {
                return this.SignField;
            }
            set {
                if ((object.ReferenceEquals(this.SignField, value) != true)) {
                    this.SignField = value;
                    this.RaisePropertyChanged("Sign");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Token {
            get {
                return this.TokenField;
            }
            set {
                if ((object.ReferenceEquals(this.TokenField, value) != true)) {
                    this.TokenField = value;
                    this.RaisePropertyChanged("Token");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ISTP1.Service.Contracts.Service", ConfigurationName="Wrapper.ILoginService")]
    public interface ILoginService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ISTP1.Service.Contracts.Service/ILoginService/SolicitarAutorizacion", ReplyAction="http://ISTP1.Service.Contracts.Service/ILoginService/SolicitarAutorizacionRespons" +
            "e")]
        TP1IdS_G15Presentacion.Wrapper.Autorizacion SolicitarAutorizacion(string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ISTP1.Service.Contracts.Service/ILoginService/SolicitarAutorizacion", ReplyAction="http://ISTP1.Service.Contracts.Service/ILoginService/SolicitarAutorizacionRespons" +
            "e")]
        System.Threading.Tasks.Task<TP1IdS_G15Presentacion.Wrapper.Autorizacion> SolicitarAutorizacionAsync(string codigo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoginServiceChannel : TP1IdS_G15Presentacion.Wrapper.ILoginService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginServiceClient : System.ServiceModel.ClientBase<TP1IdS_G15Presentacion.Wrapper.ILoginService>, TP1IdS_G15Presentacion.Wrapper.ILoginService {
        
        public LoginServiceClient() {
        }
        
        public LoginServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TP1IdS_G15Presentacion.Wrapper.Autorizacion SolicitarAutorizacion(string codigo) {
            return base.Channel.SolicitarAutorizacion(codigo);
        }
        
        public System.Threading.Tasks.Task<TP1IdS_G15Presentacion.Wrapper.Autorizacion> SolicitarAutorizacionAsync(string codigo) {
            return base.Channel.SolicitarAutorizacionAsync(codigo);
        }
    }
}

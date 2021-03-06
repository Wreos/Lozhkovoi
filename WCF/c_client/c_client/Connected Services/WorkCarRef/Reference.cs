﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace c_client.WorkCarRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car", Namespace="http://schemas.datacontract.org/2004/07/b_firstService")]
    [System.SerializableAttribute()]
    public partial class Car : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string categoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string markField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string modelNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string regnumField;
        
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
        public string category {
            get {
                return this.categoryField;
            }
            set {
                if ((object.ReferenceEquals(this.categoryField, value) != true)) {
                    this.categoryField = value;
                    this.RaisePropertyChanged("category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mark {
            get {
                return this.markField;
            }
            set {
                if ((object.ReferenceEquals(this.markField, value) != true)) {
                    this.markField = value;
                    this.RaisePropertyChanged("mark");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string modelName {
            get {
                return this.modelNameField;
            }
            set {
                if ((object.ReferenceEquals(this.modelNameField, value) != true)) {
                    this.modelNameField = value;
                    this.RaisePropertyChanged("modelName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string regnum {
            get {
                return this.regnumField;
            }
            set {
                if ((object.ReferenceEquals(this.regnumField, value) != true)) {
                    this.regnumField = value;
                    this.RaisePropertyChanged("regnum");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WorkCarRef.IWorkCar")]
    public interface IWorkCar {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkCar/AddCars", ReplyAction="http://tempuri.org/IWorkCar/AddCarsResponse")]
        void AddCars(c_client.WorkCarRef.Car machine);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkCar/AddCars", ReplyAction="http://tempuri.org/IWorkCar/AddCarsResponse")]
        System.Threading.Tasks.Task AddCarsAsync(c_client.WorkCarRef.Car machine);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkCar/DelCar", ReplyAction="http://tempuri.org/IWorkCar/DelCarResponse")]
        void DelCar(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkCar/DelCar", ReplyAction="http://tempuri.org/IWorkCar/DelCarResponse")]
        System.Threading.Tasks.Task DelCarAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkCar/GetCars", ReplyAction="http://tempuri.org/IWorkCar/GetCarsResponse")]
        c_client.WorkCarRef.Car[] GetCars();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWorkCar/GetCars", ReplyAction="http://tempuri.org/IWorkCar/GetCarsResponse")]
        System.Threading.Tasks.Task<c_client.WorkCarRef.Car[]> GetCarsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWorkCarChannel : c_client.WorkCarRef.IWorkCar, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WorkCarClient : System.ServiceModel.ClientBase<c_client.WorkCarRef.IWorkCar>, c_client.WorkCarRef.IWorkCar {
        
        public WorkCarClient() {
        }
        
        public WorkCarClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WorkCarClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WorkCarClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WorkCarClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddCars(c_client.WorkCarRef.Car machine) {
            base.Channel.AddCars(machine);
        }
        
        public System.Threading.Tasks.Task AddCarsAsync(c_client.WorkCarRef.Car machine) {
            return base.Channel.AddCarsAsync(machine);
        }
        
        public void DelCar(int id) {
            base.Channel.DelCar(id);
        }
        
        public System.Threading.Tasks.Task DelCarAsync(int id) {
            return base.Channel.DelCarAsync(id);
        }
        
        public c_client.WorkCarRef.Car[] GetCars() {
            return base.Channel.GetCars();
        }
        
        public System.Threading.Tasks.Task<c_client.WorkCarRef.Car[]> GetCarsAsync() {
            return base.Channel.GetCarsAsync();
        }
    }
}

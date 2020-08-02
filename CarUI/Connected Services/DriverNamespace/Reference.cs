﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarUI.DriverNamespace {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DriverNamespace.IDriverServerLogic")]
    public interface IDriverServerLogic {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriverServerLogic/ValidateDriver", ReplyAction="http://tempuri.org/IDriverServerLogic/ValidateDriverResponse")]
        bool ValidateDriver(CarCommon.Driver driver);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriverServerLogic/ValidateDriver", ReplyAction="http://tempuri.org/IDriverServerLogic/ValidateDriverResponse")]
        System.Threading.Tasks.Task<bool> ValidateDriverAsync(CarCommon.Driver driver);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriverServerLogic/UpdateDriver", ReplyAction="http://tempuri.org/IDriverServerLogic/UpdateDriverResponse")]
        void UpdateDriver(CarCommon.Driver driver);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriverServerLogic/UpdateDriver", ReplyAction="http://tempuri.org/IDriverServerLogic/UpdateDriverResponse")]
        System.Threading.Tasks.Task UpdateDriverAsync(CarCommon.Driver driver);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriverServerLogic/DeleteDriver", ReplyAction="http://tempuri.org/IDriverServerLogic/DeleteDriverResponse")]
        void DeleteDriver(CarCommon.Driver driver);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriverServerLogic/DeleteDriver", ReplyAction="http://tempuri.org/IDriverServerLogic/DeleteDriverResponse")]
        System.Threading.Tasks.Task DeleteDriverAsync(CarCommon.Driver driver);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriverServerLogic/SelectDrivers", ReplyAction="http://tempuri.org/IDriverServerLogic/SelectDriversResponse")]
        System.Collections.Generic.List<CarCommon.Driver> SelectDrivers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDriverServerLogic/SelectDrivers", ReplyAction="http://tempuri.org/IDriverServerLogic/SelectDriversResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<CarCommon.Driver>> SelectDriversAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDriverServerLogicChannel : CarUI.DriverNamespace.IDriverServerLogic, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DriverServerLogicClient : System.ServiceModel.ClientBase<CarUI.DriverNamespace.IDriverServerLogic>, CarUI.DriverNamespace.IDriverServerLogic {
        
        public DriverServerLogicClient() {
        }
        
        public DriverServerLogicClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DriverServerLogicClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DriverServerLogicClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DriverServerLogicClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool ValidateDriver(CarCommon.Driver driver) {
            return base.Channel.ValidateDriver(driver);
        }
        
        public System.Threading.Tasks.Task<bool> ValidateDriverAsync(CarCommon.Driver driver) {
            return base.Channel.ValidateDriverAsync(driver);
        }
        
        public void UpdateDriver(CarCommon.Driver driver) {
            base.Channel.UpdateDriver(driver);
        }
        
        public System.Threading.Tasks.Task UpdateDriverAsync(CarCommon.Driver driver) {
            return base.Channel.UpdateDriverAsync(driver);
        }
        
        public void DeleteDriver(CarCommon.Driver driver) {
            base.Channel.DeleteDriver(driver);
        }
        
        public System.Threading.Tasks.Task DeleteDriverAsync(CarCommon.Driver driver) {
            return base.Channel.DeleteDriverAsync(driver);
        }
        
        public System.Collections.Generic.List<CarCommon.Driver> SelectDrivers() {
            return base.Channel.SelectDrivers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<CarCommon.Driver>> SelectDriversAsync() {
            return base.Channel.SelectDriversAsync();
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApplication.ProxyReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyReference.ICalc")]
    public interface ICalc {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Add", ReplyAction="http://tempuri.org/ICalc/AddResponse")]
        int Add(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalcChannel : ClientApplication.ProxyReference.ICalc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcClient : System.ServiceModel.ClientBase<ClientApplication.ProxyReference.ICalc>, ClientApplication.ProxyReference.ICalc {
        
        public CalcClient() {
        }
        
        public CalcClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int x, int y) {
            return base.Channel.Add(x, y);
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClientConsole.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Verifier", ReplyAction="http://tempuri.org/IService1/VerifierResponse")]
        string Verifier(System.DateTime value, string MachineName, string MachineIP, string UserName, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Verifier", ReplyAction="http://tempuri.org/IService1/VerifierResponse")]
        System.Threading.Tasks.Task<string> VerifierAsync(System.DateTime value, string MachineName, string MachineIP, string UserName, System.DateTime date);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WCFClientConsole.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WCFClientConsole.ServiceReference1.IService1>, WCFClientConsole.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Verifier(System.DateTime value, string MachineName, string MachineIP, string UserName, System.DateTime date) {
            return base.Channel.Verifier(value, MachineName, MachineIP, UserName, date);
        }
        
        public System.Threading.Tasks.Task<string> VerifierAsync(System.DateTime value, string MachineName, string MachineIP, string UserName, System.DateTime date) {
            return base.Channel.VerifierAsync(value, MachineName, MachineIP, UserName, date);
        }
    }
}
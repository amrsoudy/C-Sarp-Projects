﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Client.ConversionTempReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConversionTempReference.IconversionService")]
    public interface IconversionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IconversionService/ConvertVersCelsius", ReplyAction="http://tempuri.org/IconversionService/ConvertVersCelsiusResponse")]
        double ConvertVersCelsius(double temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IconversionService/ConvertVersCelsius", ReplyAction="http://tempuri.org/IconversionService/ConvertVersCelsiusResponse")]
        System.Threading.Tasks.Task<double> ConvertVersCelsiusAsync(double temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IconversionService/ConvertVersFahr", ReplyAction="http://tempuri.org/IconversionService/ConvertVersFahrResponse")]
        double ConvertVersFahr(double temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IconversionService/ConvertVersFahr", ReplyAction="http://tempuri.org/IconversionService/ConvertVersFahrResponse")]
        System.Threading.Tasks.Task<double> ConvertVersFahrAsync(double temp);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IconversionServiceChannel : WCF_Client.ConversionTempReference.IconversionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IconversionServiceClient : System.ServiceModel.ClientBase<WCF_Client.ConversionTempReference.IconversionService>, WCF_Client.ConversionTempReference.IconversionService {
        
        public IconversionServiceClient() {
        }
        
        public IconversionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IconversionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IconversionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IconversionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double ConvertVersCelsius(double temp) {
            return base.Channel.ConvertVersCelsius(temp);
        }
        
        public System.Threading.Tasks.Task<double> ConvertVersCelsiusAsync(double temp) {
            return base.Channel.ConvertVersCelsiusAsync(temp);
        }
        
        public double ConvertVersFahr(double temp) {
            return base.Channel.ConvertVersFahr(temp);
        }
        
        public System.Threading.Tasks.Task<double> ConvertVersFahrAsync(double temp) {
            return base.Channel.ConvertVersFahrAsync(temp);
        }
    }
}

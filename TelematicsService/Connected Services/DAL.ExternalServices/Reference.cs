﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Telematics.DAL.ExternalServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://1ckab.ru/telematics/", ConfigurationName="DAL.ExternalServices.GeoServicePortType")]
    public interface GeoServicePortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://1ckab.ru/telematics/#GeoService:PutPosData", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        bool PutPosData(uint Id, System.DateTime Time, float Latitude, float Longitude, ushort Direction, ushort Speed, float Odometer, bool Valid, bool Actual, bool Moving);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GeoServicePortTypeChannel : Telematics.DAL.ExternalServices.GeoServicePortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GeoServicePortTypeClient : System.ServiceModel.ClientBase<Telematics.DAL.ExternalServices.GeoServicePortType>, Telematics.DAL.ExternalServices.GeoServicePortType {
        
        public GeoServicePortTypeClient() {
        }
        
        public GeoServicePortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GeoServicePortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GeoServicePortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GeoServicePortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool PutPosData(uint Id, System.DateTime Time, float Latitude, float Longitude, ushort Direction, ushort Speed, float Odometer, bool Valid, bool Actual, bool Moving) {
            return base.Channel.PutPosData(Id, Time, Latitude, Longitude, Direction, Speed, Odometer, Valid, Actual, Moving);
        }
    }
}

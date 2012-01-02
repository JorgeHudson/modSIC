﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modulo.Collect.Service.Contract
{
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Package", Namespace="http://schemas.datacontract.org/2004/07/Modulo.Collect.Service.Contract")]
    public partial class Package : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private Modulo.Collect.Service.Contract.Request[] CollectRequestsField;
        
        private System.DateTime DateField;
        
        private Modulo.Collect.Service.Contract.DefinitionInfo[] DefinitionsField;
        
        private Modulo.Collect.Service.Contract.ScheduleInformation ScheduleInformationField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Modulo.Collect.Service.Contract.Request[] CollectRequests
        {
            get
            {
                return this.CollectRequestsField;
            }
            set
            {
                this.CollectRequestsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Modulo.Collect.Service.Contract.DefinitionInfo[] Definitions
        {
            get
            {
                return this.DefinitionsField;
            }
            set
            {
                this.DefinitionsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Modulo.Collect.Service.Contract.ScheduleInformation ScheduleInformation
        {
            get
            {
                return this.ScheduleInformationField;
            }
            set
            {
                this.ScheduleInformationField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ScheduleInformation", Namespace="http://schemas.datacontract.org/2004/07/Modulo.Collect.Service.Contract")]
    public partial class ScheduleInformation : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime ScheduleDateField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ScheduleDate
        {
            get
            {
                return this.ScheduleDateField;
            }
            set
            {
                this.ScheduleDateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Request", Namespace="http://schemas.datacontract.org/2004/07/Modulo.Collect.Service.Contract")]
    public partial class Request : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AddressField;
        
        private string CredentialField;
        
        private string DefinitionIdField;
        
        private string ExternalVariablesField;
        
        private string RequestIdField;
        
        private System.Collections.Generic.Dictionary<string, string> TargetParametersField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Credential
        {
            get
            {
                return this.CredentialField;
            }
            set
            {
                this.CredentialField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DefinitionId
        {
            get
            {
                return this.DefinitionIdField;
            }
            set
            {
                this.DefinitionIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExternalVariables
        {
            get
            {
                return this.ExternalVariablesField;
            }
            set
            {
                this.ExternalVariablesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RequestId
        {
            get
            {
                return this.RequestIdField;
            }
            set
            {
                this.RequestIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> TargetParameters
        {
            get
            {
                return this.TargetParametersField;
            }
            set
            {
                this.TargetParametersField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DefinitionInfo", Namespace="http://schemas.datacontract.org/2004/07/Modulo.Collect.Service.Contract")]
    public partial class DefinitionInfo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string IdField;
        
        private string TextField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text
        {
            get
            {
                return this.TextField;
            }
            set
            {
                this.TextField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendRequestResult", Namespace="http://schemas.datacontract.org/2004/07/Modulo.Collect.Service.Contract")]
    public partial class SendRequestResult : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private bool HasErrorsField;
        
        private string MessageField;
        
        private Modulo.Collect.Service.Contract.RequestInfo[] RequestsField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool HasErrors
        {
            get
            {
                return this.HasErrorsField;
            }
            set
            {
                this.HasErrorsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Modulo.Collect.Service.Contract.RequestInfo[] Requests
        {
            get
            {
                return this.RequestsField;
            }
            set
            {
                this.RequestsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RequestInfo", Namespace="http://schemas.datacontract.org/2004/07/Modulo.Collect.Service.Contract")]
    public partial class RequestInfo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ClientRequestIdField;
        
        private string ServiceRequestIdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientRequestId
        {
            get
            {
                return this.ClientRequestIdField;
            }
            set
            {
                this.ClientRequestIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiceRequestId
        {
            get
            {
                return this.ServiceRequestIdField;
            }
            set
            {
                this.ServiceRequestIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Result", Namespace="http://schemas.datacontract.org/2004/07/Modulo.Collect.Service.Contract")]
    public partial class Result : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime DateField;
        
        private Modulo.Collect.Service.Contract.ExecutionLog[] ExecutionLogsField;
        
        private Modulo.Collect.Service.Contract.CollectStatus StatusField;
        
        private string SystemCharacteristicsField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Modulo.Collect.Service.Contract.ExecutionLog[] ExecutionLogs
        {
            get
            {
                return this.ExecutionLogsField;
            }
            set
            {
                this.ExecutionLogsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Modulo.Collect.Service.Contract.CollectStatus Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SystemCharacteristics
        {
            get
            {
                return this.SystemCharacteristicsField;
            }
            set
            {
                this.SystemCharacteristicsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExecutionLog", Namespace="http://schemas.datacontract.org/2004/07/Modulo.Collect.Service.Contract")]
    public partial class ExecutionLog : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime DateField;
        
        private string LogTypeField;
        
        private string MessageField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LogType
        {
            get
            {
                return this.LogTypeField;
            }
            set
            {
                this.LogTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CollectStatus", Namespace="http://schemas.datacontract.org/2004/07/Modulo.Collect.Service.Contract")]
    public enum CollectStatus : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Complete = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Partial = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CollectInfo", Namespace="http://schemas.datacontract.org/2004/07/Modulo.Collect.Service.Contract")]
    public partial class CollectInfo : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string AddressField;
        
        private string CollectRequestIdField;
        
        private System.DateTime ReceivedOnField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CollectRequestId
        {
            get
            {
                return this.CollectRequestIdField;
            }
            set
            {
                this.CollectRequestIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ReceivedOn
        {
            get
            {
                return this.ReceivedOnField;
            }
            set
            {
                this.ReceivedOnField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.SerializableAttribute()]
    public partial class UnauthorizedServiceAccessException : System.ServiceModel.CommunicationException
    {
        
        public UnauthorizedServiceAccessException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICollectService")]
public interface ICollectService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICollectService/SendRequest", ReplyAction="http://tempuri.org/ICollectService/SendRequestResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.ServiceModel.FaultException), Action="http://tempuri.org/ICollectService/SendRequestFaultExceptionFault", Name="FaultException", Namespace="http://schemas.datacontract.org/2004/07/System.ServiceModel")]
    Modulo.Collect.Service.Contract.SendRequestResult SendRequest(Modulo.Collect.Service.Contract.Package collectPackage, string token);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICollectService/GetCertificate", ReplyAction="http://tempuri.org/ICollectService/GetCertificateResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.ServiceModel.FaultException), Action="http://tempuri.org/ICollectService/GetCertificateFaultExceptionFault", Name="FaultException", Namespace="http://schemas.datacontract.org/2004/07/System.ServiceModel")]
    byte[] GetCertificate(string token);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICollectService/GetCollectedResultDocument", ReplyAction="http://tempuri.org/ICollectService/GetCollectedResultDocumentResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.ServiceModel.FaultException), Action="http://tempuri.org/ICollectService/GetCollectedResultDocumentFaultExceptionFault", Name="FaultException", Namespace="http://schemas.datacontract.org/2004/07/System.ServiceModel")]
    Modulo.Collect.Service.Contract.Result GetCollectedResultDocument(string requestId, string token);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICollectService/GetFullCompressedExecutionLog", ReplyAction="http://tempuri.org/ICollectService/GetFullCompressedExecutionLogResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(Modulo.Collect.Service.Contract.UnauthorizedServiceAccessException), Action="http://tempuri.org/ICollectService/GetFullCompressedExecutionLogUnauthorizedServi" +
        "ceAccessExceptionFault", Name="UnauthorizedServiceAccessException", Namespace="http://schemas.datacontract.org/2004/07/Modulo.Collect.Service.Contract")]
    string GetFullCompressedExecutionLog(string requestId, string token);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICollectService/CancelCollect", ReplyAction="http://tempuri.org/ICollectService/CancelCollectResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(Modulo.Collect.Service.Contract.UnauthorizedServiceAccessException), Action="http://tempuri.org/ICollectService/CancelCollectUnauthorizedServiceAccessExceptio" +
        "nFault", Name="UnauthorizedServiceAccessException", Namespace="http://schemas.datacontract.org/2004/07/Modulo.Collect.Service.Contract")]
    bool CancelCollect(string requestId, string token);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICollectService/GetCollectRequestsInExecution", ReplyAction="http://tempuri.org/ICollectService/GetCollectRequestsInExecutionResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.ServiceModel.FaultException), Action="http://tempuri.org/ICollectService/GetCollectRequestsInExecutionFaultExceptionFau" +
        "lt", Name="FaultException", Namespace="http://schemas.datacontract.org/2004/07/System.ServiceModel")]
    Modulo.Collect.Service.Contract.CollectInfo[] GetCollectRequestsInExecution(string token);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICollectService/GetOvalResultDocument", ReplyAction="http://tempuri.org/ICollectService/GetOvalResultDocumentResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.ServiceModel.FaultException), Action="http://tempuri.org/ICollectService/GetOvalResultDocumentFaultExceptionFault", Name="FaultException", Namespace="http://schemas.datacontract.org/2004/07/System.ServiceModel")]
    string GetOvalResultDocument(string requestId, string token);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICollectService/Login", ReplyAction="http://tempuri.org/ICollectService/LoginResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.ServiceModel.FaultException), Action="http://tempuri.org/ICollectService/LoginFaultExceptionFault", Name="FaultException", Namespace="http://schemas.datacontract.org/2004/07/System.ServiceModel")]
    string Login(string username, string password);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICollectService/Logout", ReplyAction="http://tempuri.org/ICollectService/LogoutResponse")]
    void Logout(string token);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICollectService/Heartbeat", ReplyAction="http://tempuri.org/ICollectService/HeartbeatResponse")]
    void Heartbeat();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICollectServiceChannel : ICollectService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CollectServiceClient : System.ServiceModel.ClientBase<ICollectService>, ICollectService
{
    
    public CollectServiceClient()
    {
    }
    
    public CollectServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CollectServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CollectServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CollectServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public Modulo.Collect.Service.Contract.SendRequestResult SendRequest(Modulo.Collect.Service.Contract.Package collectPackage, string token)
    {
        return base.Channel.SendRequest(collectPackage, token);
    }
    
    public byte[] GetCertificate(string token)
    {
        return base.Channel.GetCertificate(token);
    }
    
    public Modulo.Collect.Service.Contract.Result GetCollectedResultDocument(string requestId, string token)
    {
        return base.Channel.GetCollectedResultDocument(requestId, token);
    }
    
    public string GetFullCompressedExecutionLog(string requestId, string token)
    {
        return base.Channel.GetFullCompressedExecutionLog(requestId, token);
    }
    
    public bool CancelCollect(string requestId, string token)
    {
        return base.Channel.CancelCollect(requestId, token);
    }
    
    public Modulo.Collect.Service.Contract.CollectInfo[] GetCollectRequestsInExecution(string token)
    {
        return base.Channel.GetCollectRequestsInExecution(token);
    }
    
    public string GetOvalResultDocument(string requestId, string token)
    {
        return base.Channel.GetOvalResultDocument(requestId, token);
    }
    
    public string Login(string username, string password)
    {
        return base.Channel.Login(username, password);
    }
    
    public void Logout(string token)
    {
        base.Channel.Logout(token);
    }
    
    public void Heartbeat()
    {
        base.Channel.Heartbeat();
    }
}
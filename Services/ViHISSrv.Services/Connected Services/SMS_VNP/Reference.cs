﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ViHISSrv.Services.SMS_VNP {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SMS_VNP.SMS_VNPSoap")]
    public interface SMS_VNPSoap {
        
        // CODEGEN: Generating message contract since element name username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSBrandNameByList", ReplyAction="*")]
        ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListResponse SendSMSBrandNameByList(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSBrandNameByList", ReplyAction="*")]
        System.Threading.Tasks.Task<ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListResponse> SendSMSBrandNameByListAsync(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListRequest request);
        
        // CODEGEN: Generating message contract since element name username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSBrandName", ReplyAction="*")]
        ViHISSrv.Services.SMS_VNP.SendSMSBrandNameResponse SendSMSBrandName(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSBrandName", ReplyAction="*")]
        System.Threading.Tasks.Task<ViHISSrv.Services.SMS_VNP.SendSMSBrandNameResponse> SendSMSBrandNameAsync(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameRequest request);
        
        // CODEGEN: Generating message contract since element name username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSBrandNameWithSchedule", ReplyAction="*")]
        ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleResponse SendSMSBrandNameWithSchedule(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSBrandNameWithSchedule", ReplyAction="*")]
        System.Threading.Tasks.Task<ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleResponse> SendSMSBrandNameWithScheduleAsync(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleRequest request);
        
        // CODEGEN: Generating message contract since element name username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSBrandNameExAsync", ReplyAction="*")]
        ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncResponse SendSMSBrandNameExAsync(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSBrandNameExAsync", ReplyAction="*")]
        System.Threading.Tasks.Task<ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncResponse> SendSMSBrandNameExAsyncAsync(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSBrandNameByListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMSBrandNameByList", Namespace="http://tempuri.org/", Order=0)]
        public ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListRequestBody Body;
        
        public SendSMSBrandNameByListRequest() {
        }
        
        public SendSMSBrandNameByListRequest(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSMSBrandNameByListRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public ViHISSrv.Services.SMS_VNP.ArrayOfString phones;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string message;
        
        public SendSMSBrandNameByListRequestBody() {
        }
        
        public SendSMSBrandNameByListRequestBody(string username, string password, ViHISSrv.Services.SMS_VNP.ArrayOfString phones, string message) {
            this.username = username;
            this.password = password;
            this.phones = phones;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSBrandNameByListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMSBrandNameByListResponse", Namespace="http://tempuri.org/", Order=0)]
        public ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListResponseBody Body;
        
        public SendSMSBrandNameByListResponse() {
        }
        
        public SendSMSBrandNameByListResponse(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSMSBrandNameByListResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ViHISSrv.Services.SMS_VNP.ArrayOfString errorList;
        
        public SendSMSBrandNameByListResponseBody() {
        }
        
        public SendSMSBrandNameByListResponseBody(ViHISSrv.Services.SMS_VNP.ArrayOfString errorList) {
            this.errorList = errorList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSBrandNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMSBrandName", Namespace="http://tempuri.org/", Order=0)]
        public ViHISSrv.Services.SMS_VNP.SendSMSBrandNameRequestBody Body;
        
        public SendSMSBrandNameRequest() {
        }
        
        public SendSMSBrandNameRequest(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSMSBrandNameRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string phone;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string message;
        
        public SendSMSBrandNameRequestBody() {
        }
        
        public SendSMSBrandNameRequestBody(string username, string password, string phone, string message) {
            this.username = username;
            this.password = password;
            this.phone = phone;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSBrandNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMSBrandNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public ViHISSrv.Services.SMS_VNP.SendSMSBrandNameResponseBody Body;
        
        public SendSMSBrandNameResponse() {
        }
        
        public SendSMSBrandNameResponse(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSMSBrandNameResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int SendSMSBrandNameResult;
        
        public SendSMSBrandNameResponseBody() {
        }
        
        public SendSMSBrandNameResponseBody(int SendSMSBrandNameResult) {
            this.SendSMSBrandNameResult = SendSMSBrandNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSBrandNameWithScheduleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMSBrandNameWithSchedule", Namespace="http://tempuri.org/", Order=0)]
        public ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleRequestBody Body;
        
        public SendSMSBrandNameWithScheduleRequest() {
        }
        
        public SendSMSBrandNameWithScheduleRequest(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSMSBrandNameWithScheduleRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string phone;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string message;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string schedule;
        
        public SendSMSBrandNameWithScheduleRequestBody() {
        }
        
        public SendSMSBrandNameWithScheduleRequestBody(string username, string password, string phone, string message, string schedule) {
            this.username = username;
            this.password = password;
            this.phone = phone;
            this.message = message;
            this.schedule = schedule;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSBrandNameWithScheduleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMSBrandNameWithScheduleResponse", Namespace="http://tempuri.org/", Order=0)]
        public ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleResponseBody Body;
        
        public SendSMSBrandNameWithScheduleResponse() {
        }
        
        public SendSMSBrandNameWithScheduleResponse(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSMSBrandNameWithScheduleResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int SendSMSBrandNameWithScheduleResult;
        
        public SendSMSBrandNameWithScheduleResponseBody() {
        }
        
        public SendSMSBrandNameWithScheduleResponseBody(int SendSMSBrandNameWithScheduleResult) {
            this.SendSMSBrandNameWithScheduleResult = SendSMSBrandNameWithScheduleResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSBrandNameExAsyncRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMSBrandNameExAsync", Namespace="http://tempuri.org/", Order=0)]
        public ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncRequestBody Body;
        
        public SendSMSBrandNameExAsyncRequest() {
        }
        
        public SendSMSBrandNameExAsyncRequest(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSMSBrandNameExAsyncRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string phone;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string message;
        
        public SendSMSBrandNameExAsyncRequestBody() {
        }
        
        public SendSMSBrandNameExAsyncRequestBody(string username, string password, string phone, string message) {
            this.username = username;
            this.password = password;
            this.phone = phone;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSBrandNameExAsyncResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMSBrandNameExAsyncResponse", Namespace="http://tempuri.org/", Order=0)]
        public ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncResponseBody Body;
        
        public SendSMSBrandNameExAsyncResponse() {
        }
        
        public SendSMSBrandNameExAsyncResponse(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSMSBrandNameExAsyncResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int SendSMSBrandNameExAsyncResult;
        
        public SendSMSBrandNameExAsyncResponseBody() {
        }
        
        public SendSMSBrandNameExAsyncResponseBody(int SendSMSBrandNameExAsyncResult) {
            this.SendSMSBrandNameExAsyncResult = SendSMSBrandNameExAsyncResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SMS_VNPSoapChannel : ViHISSrv.Services.SMS_VNP.SMS_VNPSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SMS_VNPSoapClient : System.ServiceModel.ClientBase<ViHISSrv.Services.SMS_VNP.SMS_VNPSoap>, ViHISSrv.Services.SMS_VNP.SMS_VNPSoap {
        
        public SMS_VNPSoapClient() {
        }
        
        public SMS_VNPSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SMS_VNPSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SMS_VNPSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SMS_VNPSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListResponse ViHISSrv.Services.SMS_VNP.SMS_VNPSoap.SendSMSBrandNameByList(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListRequest request) {
            return base.Channel.SendSMSBrandNameByList(request);
        }
        
        public ViHISSrv.Services.SMS_VNP.ArrayOfString SendSMSBrandNameByList(string username, string password, ViHISSrv.Services.SMS_VNP.ArrayOfString phones, string message) {
            ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListRequest inValue = new ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListRequest();
            inValue.Body = new ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            inValue.Body.phones = phones;
            inValue.Body.message = message;
            ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListResponse retVal = ((ViHISSrv.Services.SMS_VNP.SMS_VNPSoap)(this)).SendSMSBrandNameByList(inValue);
            return retVal.Body.errorList;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListResponse> ViHISSrv.Services.SMS_VNP.SMS_VNPSoap.SendSMSBrandNameByListAsync(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListRequest request) {
            return base.Channel.SendSMSBrandNameByListAsync(request);
        }
        
        public System.Threading.Tasks.Task<ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListResponse> SendSMSBrandNameByListAsync(string username, string password, ViHISSrv.Services.SMS_VNP.ArrayOfString phones, string message) {
            ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListRequest inValue = new ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListRequest();
            inValue.Body = new ViHISSrv.Services.SMS_VNP.SendSMSBrandNameByListRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            inValue.Body.phones = phones;
            inValue.Body.message = message;
            return ((ViHISSrv.Services.SMS_VNP.SMS_VNPSoap)(this)).SendSMSBrandNameByListAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ViHISSrv.Services.SMS_VNP.SendSMSBrandNameResponse ViHISSrv.Services.SMS_VNP.SMS_VNPSoap.SendSMSBrandName(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameRequest request) {
            return base.Channel.SendSMSBrandName(request);
        }
        
        public int SendSMSBrandName(string username, string password, string phone, string message) {
            ViHISSrv.Services.SMS_VNP.SendSMSBrandNameRequest inValue = new ViHISSrv.Services.SMS_VNP.SendSMSBrandNameRequest();
            inValue.Body = new ViHISSrv.Services.SMS_VNP.SendSMSBrandNameRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            inValue.Body.phone = phone;
            inValue.Body.message = message;
            ViHISSrv.Services.SMS_VNP.SendSMSBrandNameResponse retVal = ((ViHISSrv.Services.SMS_VNP.SMS_VNPSoap)(this)).SendSMSBrandName(inValue);
            return retVal.Body.SendSMSBrandNameResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ViHISSrv.Services.SMS_VNP.SendSMSBrandNameResponse> ViHISSrv.Services.SMS_VNP.SMS_VNPSoap.SendSMSBrandNameAsync(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameRequest request) {
            return base.Channel.SendSMSBrandNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ViHISSrv.Services.SMS_VNP.SendSMSBrandNameResponse> SendSMSBrandNameAsync(string username, string password, string phone, string message) {
            ViHISSrv.Services.SMS_VNP.SendSMSBrandNameRequest inValue = new ViHISSrv.Services.SMS_VNP.SendSMSBrandNameRequest();
            inValue.Body = new ViHISSrv.Services.SMS_VNP.SendSMSBrandNameRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            inValue.Body.phone = phone;
            inValue.Body.message = message;
            return ((ViHISSrv.Services.SMS_VNP.SMS_VNPSoap)(this)).SendSMSBrandNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleResponse ViHISSrv.Services.SMS_VNP.SMS_VNPSoap.SendSMSBrandNameWithSchedule(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleRequest request) {
            return base.Channel.SendSMSBrandNameWithSchedule(request);
        }
        
        public int SendSMSBrandNameWithSchedule(string username, string password, string phone, string message, string schedule) {
            ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleRequest inValue = new ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleRequest();
            inValue.Body = new ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            inValue.Body.phone = phone;
            inValue.Body.message = message;
            inValue.Body.schedule = schedule;
            ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleResponse retVal = ((ViHISSrv.Services.SMS_VNP.SMS_VNPSoap)(this)).SendSMSBrandNameWithSchedule(inValue);
            return retVal.Body.SendSMSBrandNameWithScheduleResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleResponse> ViHISSrv.Services.SMS_VNP.SMS_VNPSoap.SendSMSBrandNameWithScheduleAsync(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleRequest request) {
            return base.Channel.SendSMSBrandNameWithScheduleAsync(request);
        }
        
        public System.Threading.Tasks.Task<ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleResponse> SendSMSBrandNameWithScheduleAsync(string username, string password, string phone, string message, string schedule) {
            ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleRequest inValue = new ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleRequest();
            inValue.Body = new ViHISSrv.Services.SMS_VNP.SendSMSBrandNameWithScheduleRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            inValue.Body.phone = phone;
            inValue.Body.message = message;
            inValue.Body.schedule = schedule;
            return ((ViHISSrv.Services.SMS_VNP.SMS_VNPSoap)(this)).SendSMSBrandNameWithScheduleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncResponse ViHISSrv.Services.SMS_VNP.SMS_VNPSoap.SendSMSBrandNameExAsync(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncRequest request) {
            return base.Channel.SendSMSBrandNameExAsync(request);
        }
        
        public int SendSMSBrandNameExAsync(string username, string password, string phone, string message) {
            ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncRequest inValue = new ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncRequest();
            inValue.Body = new ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            inValue.Body.phone = phone;
            inValue.Body.message = message;
            ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncResponse retVal = ((ViHISSrv.Services.SMS_VNP.SMS_VNPSoap)(this)).SendSMSBrandNameExAsync(inValue);
            return retVal.Body.SendSMSBrandNameExAsyncResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncResponse> ViHISSrv.Services.SMS_VNP.SMS_VNPSoap.SendSMSBrandNameExAsyncAsync(ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncRequest request) {
            return base.Channel.SendSMSBrandNameExAsyncAsync(request);
        }
        
        public System.Threading.Tasks.Task<ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncResponse> SendSMSBrandNameExAsyncAsync(string username, string password, string phone, string message) {
            ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncRequest inValue = new ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncRequest();
            inValue.Body = new ViHISSrv.Services.SMS_VNP.SendSMSBrandNameExAsyncRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            inValue.Body.phone = phone;
            inValue.Body.message = message;
            return ((ViHISSrv.Services.SMS_VNP.SMS_VNPSoap)(this)).SendSMSBrandNameExAsyncAsync(inValue);
        }
    }
}

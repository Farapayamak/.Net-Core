﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReceiveWebService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReceiveWebService.ReceiveSoap")]
    public interface ReceiveSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetInboxCount", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<int> GetInboxCountAsync(string username, string password, bool isRead);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetOutBoxCount", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<int> GetOutBoxCountAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMessages", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseBL))]
        System.Threading.Tasks.Task<ReceiveWebService.MessagesBL[]> GetMessagesAsync(string username, string password, int location, string from, int index, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMessagesWithChangeIsRead", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseBL))]
        System.Threading.Tasks.Task<ReceiveWebService.MessagesBL[]> GetMessagesWithChangeIsReadAsync(string username, string password, int location, string from, int index, int count, bool isRead, bool changeIsRead);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChangeMessageIsRead", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseBL))]
        System.Threading.Tasks.Task<int> ChangeMessageIsReadAsync(string username, string password, string msgIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMessagesByDate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseBL))]
        System.Threading.Tasks.Task<ReceiveWebService.MessagesBL[]> GetMessagesByDateAsync(string username, string password, int location, string from, int index, int count, System.DateTime dateFrom, System.DateTime dateTo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMessagesFilterByDate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseBL))]
        System.Threading.Tasks.Task<ReceiveWebService.MessagesBL[]> GetMessagesFilterByDateAsync(string username, string password, int location, string from, int index, int count, System.DateTime dateFrom, System.DateTime dateTo, bool isRead);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetUsersMessagesByDate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseBL))]
        System.Threading.Tasks.Task<ReceiveWebService.MessagesBL[]> GetUsersMessagesByDateAsync(string username, string password, int location, string from, int index, int count, System.DateTime dateFrom, System.DateTime dateTo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMessageStr", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseBL))]
        System.Threading.Tasks.Task<string> GetMessageStrAsync(string username, string password, int location, string from, int index, int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RemoveMessages", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseBL))]
        System.Threading.Tasks.Task<int> RemoveMessagesAsync(string username, string password, ReceiveWebService.MessageLocation location, string msgIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RemoveMessages2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseBL))]
        System.Threading.Tasks.Task<int> RemoveMessages2Async(string username, string password, int location, string msgIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMessagesReceptions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseBL))]
        System.Threading.Tasks.Task<ReceiveWebService.MsgReceptions[]> GetMessagesReceptionsAsync(string username, string password, int msgId, int fromRows);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMessagesAfterID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseBL))]
        System.Threading.Tasks.Task<ReceiveWebService.MessagesBL[]> GetMessagesAfterIDAsync(string username, string password, int location, string from, int count, int msgId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMessagesAfterIDJson", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseBL))]
        System.Threading.Tasks.Task<string> GetMessagesAfterIDJsonAsync(string username, string password, int location, string from, int count, int msgId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLatestReceiveMsg", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseBL))]
        System.Threading.Tasks.Task<ReceiveWebService.LatestMsgReport> GetLatestReceiveMsgAsync(string username, string password, string sender, string receiver);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class MessagesBL : BaseBL
    {
        
        private long msgIDField;
        
        private int userIDField;
        
        private int linkIDField;
        
        private int numberIDField;
        
        private double tariffField;
        
        private byte msgTypeField;
        
        private string bodyField;
        
        private string udhField;
        
        private System.DateTime sendDateField;
        
        private string senderField;
        
        private string receiverField;
        
        private int firstLocationField;
        
        private int currentLocationField;
        
        private int partsField;
        
        private bool isFlashField;
        
        private bool isReadField;
        
        private bool isUnicodeField;
        
        private double creditField;
        
        private int moduleField;
        
        private int recCountField;
        
        private int recFailedField;
        
        private int recSuccessField;
        
        private bool isMoneyBackField;
        
        private int userStepedMasterField;
        
        private int userMasterField;
        
        private int moneyBackCountField;
        
        private int moneyBackLevelField;
        
        private System.Nullable<bool> autoSpeechTextField;
        
        private System.Nullable<int> shareServiceBodyIDField;
        
        private System.Nullable<int> irancellBackCountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long MsgID
        {
            get
            {
                return this.msgIDField;
            }
            set
            {
                this.msgIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int LinkID
        {
            get
            {
                return this.linkIDField;
            }
            set
            {
                this.linkIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int NumberID
        {
            get
            {
                return this.numberIDField;
            }
            set
            {
                this.numberIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public double Tariff
        {
            get
            {
                return this.tariffField;
            }
            set
            {
                this.tariffField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public byte MsgType
        {
            get
            {
                return this.msgTypeField;
            }
            set
            {
                this.msgTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Udh
        {
            get
            {
                return this.udhField;
            }
            set
            {
                this.udhField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public System.DateTime SendDate
        {
            get
            {
                return this.sendDateField;
            }
            set
            {
                this.sendDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string Sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string Receiver
        {
            get
            {
                return this.receiverField;
            }
            set
            {
                this.receiverField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public int FirstLocation
        {
            get
            {
                return this.firstLocationField;
            }
            set
            {
                this.firstLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public int CurrentLocation
        {
            get
            {
                return this.currentLocationField;
            }
            set
            {
                this.currentLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public int Parts
        {
            get
            {
                return this.partsField;
            }
            set
            {
                this.partsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public bool IsFlash
        {
            get
            {
                return this.isFlashField;
            }
            set
            {
                this.isFlashField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public bool IsRead
        {
            get
            {
                return this.isReadField;
            }
            set
            {
                this.isReadField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public bool IsUnicode
        {
            get
            {
                return this.isUnicodeField;
            }
            set
            {
                this.isUnicodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public double Credit
        {
            get
            {
                return this.creditField;
            }
            set
            {
                this.creditField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public int Module
        {
            get
            {
                return this.moduleField;
            }
            set
            {
                this.moduleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public int RecCount
        {
            get
            {
                return this.recCountField;
            }
            set
            {
                this.recCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public int RecFailed
        {
            get
            {
                return this.recFailedField;
            }
            set
            {
                this.recFailedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public int RecSuccess
        {
            get
            {
                return this.recSuccessField;
            }
            set
            {
                this.recSuccessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public bool IsMoneyBack
        {
            get
            {
                return this.isMoneyBackField;
            }
            set
            {
                this.isMoneyBackField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=23)]
        public int UserStepedMaster
        {
            get
            {
                return this.userStepedMasterField;
            }
            set
            {
                this.userStepedMasterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=24)]
        public int UserMaster
        {
            get
            {
                return this.userMasterField;
            }
            set
            {
                this.userMasterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
        public int MoneyBackCount
        {
            get
            {
                return this.moneyBackCountField;
            }
            set
            {
                this.moneyBackCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=26)]
        public int MoneyBackLevel
        {
            get
            {
                return this.moneyBackLevelField;
            }
            set
            {
                this.moneyBackLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=27)]
        public System.Nullable<bool> AutoSpeechText
        {
            get
            {
                return this.autoSpeechTextField;
            }
            set
            {
                this.autoSpeechTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=28)]
        public System.Nullable<int> ShareServiceBodyID
        {
            get
            {
                return this.shareServiceBodyIDField;
            }
            set
            {
                this.shareServiceBodyIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=29)]
        public System.Nullable<int> IrancellBackCount
        {
            get
            {
                return this.irancellBackCountField;
            }
            set
            {
                this.irancellBackCountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MessagesBL))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class BaseBL
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class LatestMsgReport
    {
        
        private long msgIDField;
        
        private string bodyField;
        
        private int partsField;
        
        private System.DateTime sendDateField;
        
        private string senderField;
        
        private string receiverField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long MsgID
        {
            get
            {
                return this.msgIDField;
            }
            set
            {
                this.msgIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int Parts
        {
            get
            {
                return this.partsField;
            }
            set
            {
                this.partsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime SendDate
        {
            get
            {
                return this.sendDateField;
            }
            set
            {
                this.sendDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Receiver
        {
            get
            {
                return this.receiverField;
            }
            set
            {
                this.receiverField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class MsgReceptions
    {
        
        private string recNumberField;
        
        private string sendDateField;
        
        private string recStatusField;
        
        private string deliveryStatusField;
        
        private string recIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string RecNumber
        {
            get
            {
                return this.recNumberField;
            }
            set
            {
                this.recNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string SendDate
        {
            get
            {
                return this.sendDateField;
            }
            set
            {
                this.sendDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string RecStatus
        {
            get
            {
                return this.recStatusField;
            }
            set
            {
                this.recStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string DeliveryStatus
        {
            get
            {
                return this.deliveryStatusField;
            }
            set
            {
                this.deliveryStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string RecID
        {
            get
            {
                return this.recIDField;
            }
            set
            {
                this.recIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum MessageLocation
    {
        
        /// <remarks/>
        Received,
        
        /// <remarks/>
        Sent,
        
        /// <remarks/>
        Removed,
        
        /// <remarks/>
        Deleted,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface ReceiveSoapChannel : ReceiveWebService.ReceiveSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class ReceiveSoapClient : System.ServiceModel.ClientBase<ReceiveWebService.ReceiveSoap>, ReceiveWebService.ReceiveSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ReceiveSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(ReceiveSoapClient.GetBindingForEndpoint(endpointConfiguration), ReceiveSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ReceiveSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ReceiveSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ReceiveSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ReceiveSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ReceiveSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<int> GetInboxCountAsync(string username, string password, bool isRead)
        {
            return base.Channel.GetInboxCountAsync(username, password, isRead);
        }
        
        public System.Threading.Tasks.Task<int> GetOutBoxCountAsync(string username, string password)
        {
            return base.Channel.GetOutBoxCountAsync(username, password);
        }
        
        public System.Threading.Tasks.Task<ReceiveWebService.MessagesBL[]> GetMessagesAsync(string username, string password, int location, string from, int index, int count)
        {
            return base.Channel.GetMessagesAsync(username, password, location, from, index, count);
        }
        
        public System.Threading.Tasks.Task<ReceiveWebService.MessagesBL[]> GetMessagesWithChangeIsReadAsync(string username, string password, int location, string from, int index, int count, bool isRead, bool changeIsRead)
        {
            return base.Channel.GetMessagesWithChangeIsReadAsync(username, password, location, from, index, count, isRead, changeIsRead);
        }
        
        public System.Threading.Tasks.Task<int> ChangeMessageIsReadAsync(string username, string password, string msgIds)
        {
            return base.Channel.ChangeMessageIsReadAsync(username, password, msgIds);
        }
        
        public System.Threading.Tasks.Task<ReceiveWebService.MessagesBL[]> GetMessagesByDateAsync(string username, string password, int location, string from, int index, int count, System.DateTime dateFrom, System.DateTime dateTo)
        {
            return base.Channel.GetMessagesByDateAsync(username, password, location, from, index, count, dateFrom, dateTo);
        }
        
        public System.Threading.Tasks.Task<ReceiveWebService.MessagesBL[]> GetMessagesFilterByDateAsync(string username, string password, int location, string from, int index, int count, System.DateTime dateFrom, System.DateTime dateTo, bool isRead)
        {
            return base.Channel.GetMessagesFilterByDateAsync(username, password, location, from, index, count, dateFrom, dateTo, isRead);
        }
        
        public System.Threading.Tasks.Task<ReceiveWebService.MessagesBL[]> GetUsersMessagesByDateAsync(string username, string password, int location, string from, int index, int count, System.DateTime dateFrom, System.DateTime dateTo)
        {
            return base.Channel.GetUsersMessagesByDateAsync(username, password, location, from, index, count, dateFrom, dateTo);
        }
        
        public System.Threading.Tasks.Task<string> GetMessageStrAsync(string username, string password, int location, string from, int index, int count)
        {
            return base.Channel.GetMessageStrAsync(username, password, location, from, index, count);
        }
        
        public System.Threading.Tasks.Task<int> RemoveMessagesAsync(string username, string password, ReceiveWebService.MessageLocation location, string msgIds)
        {
            return base.Channel.RemoveMessagesAsync(username, password, location, msgIds);
        }
        
        public System.Threading.Tasks.Task<int> RemoveMessages2Async(string username, string password, int location, string msgIds)
        {
            return base.Channel.RemoveMessages2Async(username, password, location, msgIds);
        }
        
        public System.Threading.Tasks.Task<ReceiveWebService.MsgReceptions[]> GetMessagesReceptionsAsync(string username, string password, int msgId, int fromRows)
        {
            return base.Channel.GetMessagesReceptionsAsync(username, password, msgId, fromRows);
        }
        
        public System.Threading.Tasks.Task<ReceiveWebService.MessagesBL[]> GetMessagesAfterIDAsync(string username, string password, int location, string from, int count, int msgId)
        {
            return base.Channel.GetMessagesAfterIDAsync(username, password, location, from, count, msgId);
        }
        
        public System.Threading.Tasks.Task<string> GetMessagesAfterIDJsonAsync(string username, string password, int location, string from, int count, int msgId)
        {
            return base.Channel.GetMessagesAfterIDJsonAsync(username, password, location, from, count, msgId);
        }
        
        public System.Threading.Tasks.Task<ReceiveWebService.LatestMsgReport> GetLatestReceiveMsgAsync(string username, string password, string sender, string receiver)
        {
            return base.Channel.GetLatestReceiveMsgAsync(username, password, sender, receiver);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ReceiveSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.ReceiveSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ReceiveSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://api.payamak-panel.com/post/receive.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.ReceiveSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://api.payamak-panel.com/post/receive.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            ReceiveSoap,
            
            ReceiveSoap12,
        }
    }
}
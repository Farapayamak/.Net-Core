using System;
using Farapayamak;
using SendWebService;
using ReceiveWebService;
using UsersWebService;
using VoiceWebService;
using ContactsWebService;
using ActionsWebService;
using ScheduleWebService;

namespace FaraPayamak
{
    class Program
    {
        static void Main(string[] args)
        {
            // REST methods
            
             RestClient restClient = new RestClient("username", "password");
            restClient.SendSMS("09123456789", "5000xxx", "test sms");
            string credit = restClient.GetCredit().Value;
            var result = restClient.BaseServiceNumber("test sms", "09123456789", 5555);

            // SOAP methods
            SendSoapClient sendService = new SendSoapClient(SendSoapClient.EndpointConfiguration.SendSoap);
            var SendResult = sendService.SendSimpleSMS2Async("username", "password", "09123456789", "5000xxx", "test sms", false).Result;

            ReceiveSoapClient receiveService = new ReceiveSoapClient(ReceiveSoapClient.EndpointConfiguration.ReceiveSoap);
            UsersSoapClient usersService = new UsersSoapClient(UsersSoapClient.EndpointConfiguration.UsersSoap);
            VoiceSoapClient voiceService = new VoiceSoapClient(VoiceSoapClient.EndpointConfiguration.VoiceSoap);
            ContactsSoapClient contactsService = new ContactsSoapClient(ContactsSoapClient.EndpointConfiguration.ContactsSoap);
            ActionsSoapClient actionsService = new ActionsSoapClient(ActionsSoapClient.EndpointConfiguration.ActionsSoap);
            ScheduleSoapClient scheduleService = new ScheduleSoapClient(ScheduleSoapClient.EndpointConfiguration.ScheduleSoap);
        }
    }
}

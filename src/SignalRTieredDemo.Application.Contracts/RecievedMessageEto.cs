using System;
using System.Collections.Generic;
using System.Text;

namespace SignalRTieredDemo
{
    public class RecievedMessageEto
    {
        public string RecieveText { get; set; }
        public Guid TargetUserId { get; set; }
        public string SendUserName { get; set; }
        public RecievedMessageEto(string recieveText, Guid targetUserId, string sendUserName)
        {
            RecieveText = recieveText;
            TargetUserId = targetUserId;
            SendUserName = sendUserName;
        }


    }
}

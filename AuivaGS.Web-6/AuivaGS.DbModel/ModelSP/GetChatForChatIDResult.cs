﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuivaGS.DbModel.ModelSP
{
    public partial class GetChatForChatIDResult
    {
        public int ID { get; set; }
        public int? User_Sender_ID { get; set; }
        public string UserSenderChat { get; set; }
        public int? User_Resever_ID { get; set; }
        public string UserReseverChat { get; set; }
        public string Massege { get; set; }
        public bool? unread { get; set; }
        public string TimeSend { get; set; }
        public int? User_ID { get; set; }
        public string UserSendMassge { get; set; }
    }
}

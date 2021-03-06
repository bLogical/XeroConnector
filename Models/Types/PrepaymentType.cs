﻿using System.Runtime.Serialization;

namespace XeroConnector.Model.Types
{
    [DataContract(Namespace = "")]
    public enum PrepaymentType
    {
        [EnumMember(Value = "SPEND-PREPAYMENT")]
        SpendPrepayment,
        [EnumMember(Value = "RECEIVE-PREPAYMENT")]
        ReceivePrepayment
    }
}
﻿using System.Runtime.Serialization;

namespace XeroConnector.Model.Types
{
    [DataContract(Namespace = "")]
    public enum UserRole
    {
        [EnumMember(Value = "READONLY")]
        ReadOnly,
        [EnumMember(Value = "INVOICEONLY")]
        InvoiceOnly,
        [EnumMember(Value = "STANDARD")]
        Standard,
        [EnumMember(Value = "FINANCIALADVISER")]
        FinancialAdviser,
        [EnumMember(Value = "MANAGEDCLIENT")]
        ManagedClient,
        [EnumMember(Value = "CASHBOOKCLIENT")]
        CashBookClient
    }
}
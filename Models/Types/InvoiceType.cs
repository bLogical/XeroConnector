using System.Runtime.Serialization;

namespace XeroConnector.Model.Types
{
    [DataContract(Namespace = "")]
    public enum InvoiceType
    {
        [EnumMember(Value = "ACCPAY")]
        AccountsPayable,
        [EnumMember(Value = "ACCREC")]
        AccountsReceivable        
    }
}
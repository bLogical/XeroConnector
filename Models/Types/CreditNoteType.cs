using System.Runtime.Serialization;

namespace XeroConnector.Model.Types
{
    [DataContract(Namespace = "")]
    public enum CreditNoteType
    {
        [EnumMember(Value = "ACCPAYCREDIT")]
        AccountsPayable,
        [EnumMember(Value = "ACCRECCREDIT")]
        AccountsReceivable        
    }
}
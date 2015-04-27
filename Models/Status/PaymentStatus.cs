using System.Runtime.Serialization;

namespace XeroConnector.Model.Status
{
    public enum PaymentStatus
    {
        [EnumMember(Value = "AUTHORISED")]
        Authorised,
        [EnumMember(Value = "DELETED")]
        Deleted
    }
}
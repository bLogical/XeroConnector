using System.Runtime.Serialization;

namespace XeroConnector.Model.Types
{
    [DataContract(Namespace = "")]
    public enum LineAmountType
    {
        [EnumMember]
        Exclusive,
        [EnumMember]
        Inclusive,
        [EnumMember]
        NoTax        
    }
}
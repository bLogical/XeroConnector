using System.Runtime.Serialization;

namespace XeroConnector.Model.Types
{
    [DataContract(Namespace = "")]
    public enum PhoneType
    {
        [EnumMember(Value="DEFAULT")]
        Default,
        [EnumMember(Value = "DDI")]
        DirectDial,
        [EnumMember(Value = "MOBILE")]
        Mobile,
        [EnumMember(Value = "FAX")]
        Fax        
    }
}
using System.Runtime.Serialization;

namespace XeroConnector.Model.Types
{
    [DataContract(Namespace = "")]
    public enum AddressType
    {
        [EnumMember(Value = "POBOX")]
        PostOfficeBox,
        [EnumMember(Value = "STREET")]
        Street
    }
}
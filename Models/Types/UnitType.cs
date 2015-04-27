using System.Runtime.Serialization;

namespace XeroConnector.Model.Types
{
    [DataContract(Namespace = "")]
    public enum UnitType
    {
        [EnumMember(Value = "WEEKLY")]
        Weekly,
        [EnumMember(Value = "MONTHLY")]
        Monthly
    }
}
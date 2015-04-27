using System.Runtime.Serialization;

namespace XeroConnector.Model.Types
{
    [DataContract(Namespace = "")]
    public enum ExternalLinkType
    {
        [EnumMember]
        Website,
        [EnumMember]
        Facebook,
        [EnumMember]
        GooglePlus,
        [EnumMember]
        LinkedIn,
        [EnumMember]
        Twitter,
    }
}
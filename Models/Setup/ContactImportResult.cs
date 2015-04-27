using System.Runtime.Serialization;

namespace XeroConnector.Model.Setup
{
    [DataContract(Namespace = "")]
    public class Contacts
    {
        [DataMember]
        public int New { get; set; }

        [DataMember]
        public int Updated { get; set; }
    }
}
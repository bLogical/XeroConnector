using System.Runtime.Serialization;
using XeroConnector.Model.Types;

namespace XeroConnector.Model
{
    [DataContract(Namespace = "")]
    public class ExternalLink : CoreData
    {
        [DataMember]
        public ExternalLinkType LinkType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Url { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Description { get; set; }
    }
}
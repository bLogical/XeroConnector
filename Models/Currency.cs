using System.Runtime.Serialization;

namespace XeroConnector.Model
{
    [DataContract(Namespace = "")]
    public class Currency : CoreData
    {
        [DataMember(EmitDefaultValue = false)]
        public string Code { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Description { get; set; }
    }
}

using System.Runtime.Serialization;

namespace XeroConnector.Model
{
    [DataContract(Namespace = "")]
    public class PaymentTerms : CoreData
    {
        [DataMember]
        public Terms Bills { get; set; }

        [DataMember]
        public Terms Sales { get; set; }
    }
}
using System.Runtime.Serialization;

namespace XeroConnector.Model.Setup
{
    [DataContract(Namespace = "")]
    public class ConversionDate
    {
        [DataMember]
        public int? Month { get; set; }

        [DataMember]
        public int? Year { get; set; }
    }
}
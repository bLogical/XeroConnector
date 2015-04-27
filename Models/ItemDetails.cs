using System.Runtime.Serialization;

namespace XeroConnector.Model
{
    [DataContract(Namespace = "")]
    public abstract class ItemDetails : CoreData
    {
        [DataMember(EmitDefaultValue = false)]
        public decimal UnitPrice { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string AccountCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string TaxType { get; set; }
    }
}

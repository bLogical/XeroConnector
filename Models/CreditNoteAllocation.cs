using System.Runtime.Serialization;

namespace XeroConnector.Model
{
    [DataContract(Namespace = "", Name = "Allocation")]
    public class CreditNoteAllocation : AllocationBase
    {
        [DataMember(EmitDefaultValue = false)]
        public CreditNote CreditNote { get; set; }
    }
}
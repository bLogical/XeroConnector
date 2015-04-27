using System.Runtime.Serialization;

namespace XeroConnector.Model
{
    [DataContract(Namespace = "", Name = "Allocation")]
    public class PrepaymentAllocation : AllocationBase
    {
        [DataMember(EmitDefaultValue = false)]
        public Prepayment Prepayment { get; set; }
    }
}
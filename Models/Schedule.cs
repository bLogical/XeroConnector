using System;
using System.Runtime.Serialization;
using XeroConnector.Model.Types;

namespace XeroConnector.Model
{
    [DataContract(Namespace = "")]
    public class Schedule : CoreData
    {
        [DataMember(EmitDefaultValue = false)]
        public int Period { get; set; }

        [DataMember]
        public UnitType Unit { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int DueDate { get; set; }

        [DataMember]
        public PaymentTermType DueDateType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? StartDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? NextScheduledDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? EndDate { get; set; }
    }
}
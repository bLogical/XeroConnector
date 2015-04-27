using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using XeroConnector.Model.Status;



namespace XeroConnector.Model
{
    [DataContract(Namespace = "")]
    public class ExpenseClaim : CoreData
    {
        [DataMember(Name = "ExpenseClaimID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public ExpenseClaimStatus Status { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public double Total { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public double AmountDue { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public double AmountPaid { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime PaymentDueDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime ReportingDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public User User { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<Receipt> Receipts { get; set; }
    }
}

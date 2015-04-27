using System;
using System.Runtime.Serialization;

namespace XeroConnector.Model
{
    [Obsolete("Use CreditNoteAllocation")]
    [DataContract(Namespace = "")]
    public class Allocation : CreditNoteAllocation
    {
    }
}
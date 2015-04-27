using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using XeroConnector.Model.Status;
using XeroConnector.Model.Types;

namespace XeroConnector.Model
{
    [DataContract(Namespace = "")]
    public class ManualJournal : CoreData
    {
        [DataMember(Name = "ManualJournalID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public ManualJournalStatus Status { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public LineAmountType LineAmountTypes { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Url { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? ShowOnCashBasisReports { get; set; }

        [DataMember]
        public string Narration { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? HasAttachments { get; set; }

        [DataMember(Name="JournalLines")]
        public List<Line> Lines { get; set; }
    }
}

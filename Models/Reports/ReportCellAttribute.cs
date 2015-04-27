using System.Runtime.Serialization;

namespace XeroConnector.Model.Reports
{
    [DataContract(Namespace = "", Name = "Attribute")]
    public class ReportCellAttribute
    {
        [DataMember]
        public string Value { get; set; }

        [DataMember]
        public string Id { get; set; }
    }
}
using System;
using System.Runtime.Serialization;
using XeroConnector.Model.Status;


namespace XeroConnector.Model
{
    [DataContract(Namespace = "")]
    public class Option : CoreData
    {
        [DataMember(Name = "TrackingOptionID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public TrackingOptionStatus Status { get; set; }
    }
}
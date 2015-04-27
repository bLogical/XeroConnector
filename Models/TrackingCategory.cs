using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using XeroConnector.Model.Status;



namespace XeroConnector.Model
{
    [DataContract(Namespace = "")]
    public class TrackingCategory : CoreData
    {
        [DataMember(Name = "TrackingCategoryID")]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public TrackingCategoryStatus Status { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<Option> Options { get; set; }

        //Added as Journal / JournalLine / TrackingCategory / Option does not exist.
        [DataMember(EmitDefaultValue = false)]
        public string Option { get; set; }
    }
}
using System;
using System.Runtime.Serialization;


namespace XeroConnector.Model
{
    [DataContract(Namespace = "", Name = "TrackingCategory")]
    public class ItemTrackingCategory : CoreData
    {
        [DataMember(Name = "TrackingCategoryID")]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Option { get; set; }
    }
}
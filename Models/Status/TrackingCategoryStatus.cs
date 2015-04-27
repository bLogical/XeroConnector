using System.Runtime.Serialization;

namespace XeroConnector.Model.Status
{
    [DataContract(Namespace = "")]
    public enum TrackingCategoryStatus
    {
        [EnumMember(Value = "ACTIVE")]
        Active,
      
        [EnumMember(Value = "ARCHIVED")]
        Archived,
 
        [EnumMember(Value = "DELETED")]
        Deleted
    }
}
using System;
using System.Runtime.Serialization;
using XeroConnector.Model.Status;



namespace XeroConnector.Model
{
    [DataContract(Namespace = "")]
    public class Employee : CoreData
    {
        [DataMember(Name = "EmployeeID", EmitDefaultValue = false)]
        public Guid Id { get; set; }
        
        [DataMember]
        public EmployeeStatus Status { get; set; }
        
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }
        
        [DataMember(EmitDefaultValue = false)]
        public ExternalLink ExternalLink { get; set; }
    }
}

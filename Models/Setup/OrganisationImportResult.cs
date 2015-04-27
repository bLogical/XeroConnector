using System.Runtime.Serialization;

namespace XeroConnector.Model.Setup
{
    [DataContract(Namespace = "")]
    public class Organisation
    {
        public bool Present { get; set; }
    }
}
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace XeroConnector.Model
{
    [CollectionDataContract(Namespace = "", Name = "Tracking")]
    public class ItemTracking : List<ItemTrackingCategory>
    {        
    }
}
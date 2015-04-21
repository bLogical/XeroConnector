using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroConnector.Models
{
    public class AddressView
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public AddressType AddressType { get; set; }
        public string AttentionTo { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
    }
    public enum AddressType
    {
        PostOfficeBox = 0,
        Street = 1,
    }
}

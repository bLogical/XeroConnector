using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XeroConnector.Models
{
    public class ContactView
    {
        public string AccountNumber { get; set; }
        public string AccountsPayableTaxType { get; set; }
        public string AccountsReceivableTaxType { get; set; }
        //public List<AddressView> Addresses { get; set; }
        //public string BankAccountDetails { get; set; }
        //public BatchPayments BatchPayments { get; set; }
        //public BrandingTheme BrandingTheme { get; set; }
        //public List<ContactGroup> ContactGroups { get; set; }
        public string ContactNumber { get; set; }
        //public List<ContactPerson> ContactPersons { get; set; }
        //public ContactStatus ContactStatus { get; set; }
        public string DefaultCurrency { get; set; }
        public decimal? Discount { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public bool? HasAttachments { get; set; }
        public Guid Id { get; set; }
        public bool? IsCustomer { get; set; }
        public bool? IsSupplier { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        //public PaymentTerms PaymentTerms { get; set; }
        //public List<Phone> Phones { get; set; }
        public string PurchaseAccountCode { get; set; }
        public string SalesAccountCode { get; set; }
        public string SkypeUserName { get; set; }
        public string TaxNumber { get; set; }
        public string Website { get; set; }
        public string XeroNetworkKey { get; set; }
    }
}

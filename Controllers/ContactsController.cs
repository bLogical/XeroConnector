using System;
using System.Collections.Generic;
using System.Web.Http;
using XeroConnector.Helpers;
using XeroConnector.Model;


namespace XeroConnector.Controllers
{
    public class ContactsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            var Contacts = XeroApiHelper.XeroApi.Contacts.Find();
            return XeroApiHelper.Convert<IEnumerable<Contact>>(Contacts);
        }
        [HttpGet]
        public Contact GetById(Guid id)
        {
            var Contact = XeroApiHelper.XeroApi.Contacts.Find(id);
            return XeroApiHelper.Convert<Contact>(Contact);
        }
        [HttpPost]
        public void Create(Contact Contact)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.Contact>(Contact);
            XeroApiHelper.XeroApi.Contacts.Create(xeroObj);
        }
        [HttpPut]
        public void Update(Contact Contact)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.Contact>(Contact);
            XeroApiHelper.XeroApi.Contacts.Update(xeroObj);
        }

    }
}

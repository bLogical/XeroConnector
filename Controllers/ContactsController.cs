using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class ContactsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.Contact> Get()
        {
            var contacts = XeroApiHelper.XeroApi.Contacts.Find();
            //var json = JsonConvert.SerializeObject(contacts);
            //var contantsView = JsonConvert.DeserializeObject<List<XeroConnector.Models.ContactView>>(json);
            return contacts;
        }
        [HttpGet]
        public Xero.Api.Core.Model.Contact Get(Guid id)
        {
            var contact = XeroApiHelper.XeroApi.Contacts.Find(id);
            return contact;
        }
        [HttpPost]
        public Xero.Api.Core.Model.Contact Create(Xero.Api.Core.Model.Contact contact)
        {
            return XeroApiHelper.XeroApi.Contacts.Create(contact);
        }
        [HttpPut]
        public Xero.Api.Core.Model.Contact Update(Xero.Api.Core.Model.Contact contact)
        {
            return XeroApiHelper.XeroApi.Contacts.Update(contact);
        }

    }
}

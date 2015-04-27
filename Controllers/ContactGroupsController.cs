using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;
using XeroConnector.Model;

namespace XeroConnector.Controllers
{
    public class ContactGroupsController : ApiController
    {
        [HttpGet]
        public IEnumerable<ContactGroup> Get()
        {
            var ContactGroups = XeroApiHelper.XeroApi.ContactGroups.Find();
            return XeroApiHelper.Convert<IEnumerable<ContactGroup>>(ContactGroups);
        }
        [HttpGet]
        public ContactGroup GetById(Guid id)
        {
            var ContactGroup = XeroApiHelper.XeroApi.ContactGroups.Find(id);
            return XeroApiHelper.Convert<ContactGroup>(ContactGroup);
        }
        [HttpPost]
        public void Create(ContactGroup ContactGroup)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.ContactGroup>(ContactGroup);
            XeroApiHelper.XeroApi.ContactGroups.Create(xeroObj);
        }
        [HttpPut]
        public void Update(ContactGroup ContactGroup)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.ContactGroup>(ContactGroup);
            XeroApiHelper.XeroApi.ContactGroups.Update(xeroObj);
        }
    }
}

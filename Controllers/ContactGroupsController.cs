using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class ContactGroupsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.ContactGroup> Get()
        {
            var ContactGroups = XeroApiHelper.XeroApi.ContactGroups.Find();
            return ContactGroups;
        }
        [HttpGet]
        public Xero.Api.Core.Model.ContactGroup GetById(Guid id)
        {
            var ContactGroup = XeroApiHelper.XeroApi.ContactGroups.Find(id);
            return ContactGroup;
        }
        [HttpPost]
        public Xero.Api.Core.Model.ContactGroup Create(Xero.Api.Core.Model.ContactGroup ContactGroup)
        {
            return XeroApiHelper.XeroApi.ContactGroups.Create(ContactGroup);
        }
        [HttpPut]
        public Xero.Api.Core.Model.ContactGroup Update(Xero.Api.Core.Model.ContactGroup ContactGroup)
        {
            return XeroApiHelper.XeroApi.ContactGroups.Update(ContactGroup);
        }
    }
}

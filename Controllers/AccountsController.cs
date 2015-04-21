using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class AccountsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.Account> Get()
        {
            var accounts = XeroApiHelper.XeroApi.Accounts.Find();
            return accounts;
        }
        [HttpGet]
        public Xero.Api.Core.Model.Account Get(Guid id)
        {
            var account = XeroApiHelper.XeroApi.Accounts.Find(id);
            return account;
        }
        [HttpPost]
        public Xero.Api.Core.Model.Account Create(Xero.Api.Core.Model.Account contact)
        {
            return XeroApiHelper.XeroApi.Accounts.Create(contact);
        }
    }
}

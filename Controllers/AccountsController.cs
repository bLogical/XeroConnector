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
    public class AccountsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            var accounts = XeroApiHelper.XeroApi.Accounts.Find();
            return XeroApiHelper.Convert<IEnumerable<Account>>(accounts);
        }
        [HttpGet]
        public Account GetById(Guid id)
        {
            var account = XeroApiHelper.XeroApi.Accounts.Find(id);
            return XeroApiHelper.Convert<Account>(account);
        }
        [HttpPost]
        public void Create(Account account)
        {
            var xeroAccount = XeroApiHelper.Convert<Xero.Api.Core.Model.Account>(account);

            XeroApiHelper.XeroApi.Accounts.Create(xeroAccount);
        }
    }
}

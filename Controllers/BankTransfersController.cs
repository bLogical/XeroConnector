using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class BankTransfersController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.BankTransaction> Get()
        {
            var bankTransactions = XeroApiHelper.XeroApi.BankTransactions.Find();
            return bankTransactions;
        }
        [HttpGet]
        public Xero.Api.Core.Model.BankTransaction GetById(Guid id)
        {
            var bankTransaction = XeroApiHelper.XeroApi.BankTransactions.Find(id);
            return bankTransaction;
        }
        [HttpPost]
        public Xero.Api.Core.Model.BankTransaction Create(Xero.Api.Core.Model.BankTransaction bankTransaction)
        {
            return XeroApiHelper.XeroApi.BankTransactions.Create(bankTransaction);
        }
        [HttpPut]
        public Xero.Api.Core.Model.BankTransaction Update(Xero.Api.Core.Model.BankTransaction bankTransaction)
        {
            return XeroApiHelper.XeroApi.BankTransactions.Update(bankTransaction);
        }
    }
}

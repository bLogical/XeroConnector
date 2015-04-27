using Newtonsoft.Json;
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
    public class BankTransfersController : ApiController
    {
        [HttpGet]
        public IEnumerable<BankTransaction> Get()
        {
            var bankTransactions = XeroApiHelper.XeroApi.BankTransactions.Find();
            return XeroApiHelper.Convert<IEnumerable<BankTransaction>>(bankTransactions);
        }
        [HttpGet]
        public BankTransaction GetById(Guid id)
        {
            var bankTransaction = XeroApiHelper.XeroApi.BankTransactions.Find(id);
            return XeroApiHelper.Convert<BankTransaction>(bankTransaction);
        }
        [HttpPost]
        public void Create(BankTransaction bankTransaction)
        {
            var xeroBt = XeroApiHelper.Convert<Xero.Api.Core.Model.BankTransaction>(bankTransaction);
            XeroApiHelper.XeroApi.BankTransactions.Create(xeroBt);
        }
        [HttpPut]
        public void Update(BankTransaction bankTransaction)
        {
            var xeroBt = XeroApiHelper.Convert<Xero.Api.Core.Model.BankTransaction>(bankTransaction);
            XeroApiHelper.XeroApi.BankTransactions.Update(xeroBt);
        }
    }
}

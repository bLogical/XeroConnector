using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class ReceiptsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.Receipt> Get()
        {
            var Receipts = XeroApiHelper.XeroApi.Receipts.Find();
            return Receipts;
        }
        [HttpGet]
        public Xero.Api.Core.Model.Receipt GetById(Guid id)
        {
            var Receipt = XeroApiHelper.XeroApi.Receipts.Find(id);
            return Receipt;
        }
        [HttpPost]
        public Xero.Api.Core.Model.Receipt Create(Xero.Api.Core.Model.Receipt Receipt)
        {
            return XeroApiHelper.XeroApi.Receipts.Create(Receipt);
        }
        [HttpPut]
        public Xero.Api.Core.Model.Receipt Update(Xero.Api.Core.Model.Receipt Receipt)
        {
            return XeroApiHelper.XeroApi.Receipts.Update(Receipt);
        }
    }
}

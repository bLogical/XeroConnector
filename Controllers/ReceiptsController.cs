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
    public class ReceiptsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Receipt> Get()
        {
            var Receipts = XeroApiHelper.XeroApi.Receipts.Find();
            return XeroApiHelper.Convert<IEnumerable<Receipt>>(Receipts);
        }
        [HttpGet]
        public Receipt GetById(Guid id)
        {
            var Receipt = XeroApiHelper.XeroApi.Receipts.Find(id);
            return XeroApiHelper.Convert<Receipt>(Receipt);
        }
        [HttpPost]
        public void Create(Receipt Receipt)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.Receipt>(Receipt);
            XeroApiHelper.XeroApi.Receipts.Create(xeroObj);
        }
        [HttpPut]
        public void Update(Receipt Receipt)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.Receipt>(Receipt);
            XeroApiHelper.XeroApi.Receipts.Update(xeroObj);
        }
    }
}

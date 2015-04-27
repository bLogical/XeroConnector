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
    public class InvoiceController : ApiController
    {
        [HttpGet]
        public IEnumerable<Invoice> Get()
        {
            var Invoices = XeroApiHelper.XeroApi.Invoices.Find();
            return XeroApiHelper.Convert<IEnumerable<Invoice>>(Invoices);
        }
        [HttpGet]
        public Invoice GetById(Guid id)
        {
            var Invoice = XeroApiHelper.XeroApi.Invoices.Find(id);
            return XeroApiHelper.Convert<Invoice>(Invoice);
        }
        [HttpPost]
        public void Create(Invoice Invoice)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.Invoice>(Invoice);
            XeroApiHelper.XeroApi.Invoices.Create(xeroObj);
        }
        [HttpPut]
        public void Update(Invoice Invoice)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.Invoice>(Invoice);
            XeroApiHelper.XeroApi.Invoices.Update(xeroObj);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class IncoicesController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.Invoice> Get()
        {
            var Invoices = XeroApiHelper.XeroApi.Invoices.Find();
            return Invoices;
        }
        [HttpGet]
        public Xero.Api.Core.Model.Invoice GetById(Guid id)
        {
            var Invoice = XeroApiHelper.XeroApi.Invoices.Find(id);
            return Invoice;
        }
        [HttpPost]
        public Xero.Api.Core.Model.Invoice Create(Xero.Api.Core.Model.Invoice Invoice)
        {
            return XeroApiHelper.XeroApi.Invoices.Create(Invoice);
        }
        [HttpPut]
        public Xero.Api.Core.Model.Invoice Update(Xero.Api.Core.Model.Invoice Invoice)
        {
            return XeroApiHelper.XeroApi.Invoices.Update(Invoice);
        }
    }
}

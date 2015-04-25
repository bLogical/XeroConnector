using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class TaxRatesController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.TaxRate> Get()
        {
            var TaxRates = XeroApiHelper.XeroApi.TaxRates.Find();
            return TaxRates;
        }
        [HttpGet]
        public Xero.Api.Core.Model.TaxRate GetById(Guid id)
        {
            var TaxRate = XeroApiHelper.XeroApi.TaxRates.Find(id);
            return TaxRate;
        }
        [HttpPost]
        public Xero.Api.Core.Model.TaxRate Create(Xero.Api.Core.Model.TaxRate TaxRate)
        {
            return XeroApiHelper.XeroApi.TaxRates.Create(TaxRate);
        }
        [HttpPut]
        public Xero.Api.Core.Model.TaxRate Update(Xero.Api.Core.Model.TaxRate TaxRate)
        {
            return XeroApiHelper.XeroApi.TaxRates.Update(TaxRate);
        }
    }
}

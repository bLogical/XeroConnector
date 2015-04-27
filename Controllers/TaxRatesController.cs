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
    public class TaxRatesController : ApiController
    {
        [HttpGet]
        public IEnumerable<TaxRate> Get()
        {
            var TaxRates = XeroApiHelper.XeroApi.TaxRates.Find();
            return XeroApiHelper.Convert<IEnumerable<TaxRate>>(TaxRates);
        }
        [HttpGet]
        public TaxRate GetById(Guid id)
        {
            var TaxRate = XeroApiHelper.XeroApi.TaxRates.Find(id);
            return XeroApiHelper.Convert<TaxRate>(TaxRate);
        }
        [HttpPost]
        public void Create(TaxRate TaxRate)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.TaxRate>(TaxRate);
            XeroApiHelper.XeroApi.TaxRates.Create(xeroObj);
        }
        [HttpPut]
        public void Update(TaxRate TaxRate)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.TaxRate>(TaxRate);
            XeroApiHelper.XeroApi.TaxRates.Update(xeroObj);
        }
    }
}

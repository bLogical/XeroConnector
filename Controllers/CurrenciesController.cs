using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class CurrenciesController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.Currency> Get()
        {
            var Currencies = XeroApiHelper.XeroApi.Currencies.Find();
            return Currencies;
        }
        [HttpGet]
        public Xero.Api.Core.Model.Currency Get(string id)
        {
            var Currency = XeroApiHelper.XeroApi.Currencies.Find(id);
            return Currency;
        }
    }
}

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
    public class CurrenciesController : ApiController
    {
        [HttpGet]
        public IEnumerable<Currency> Get()
        {
            var CreditNotes = XeroApiHelper.XeroApi.CreditNotes.Find();
            return XeroApiHelper.Convert<IEnumerable<Currency>>(CreditNotes);
        }
        [HttpGet]
        public Currency GetById(Guid id)
        {
            var CreditNote = XeroApiHelper.XeroApi.CreditNotes.Find(id);
            return XeroApiHelper.Convert<Currency>(CreditNote);
        }
    }
}

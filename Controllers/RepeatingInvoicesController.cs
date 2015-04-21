using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class RepeatingInvoicesController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.RepeatingInvoice> Get()
        {
            var  RepeatingInvoices = XeroApiHelper.XeroApi.RepeatingInvoices.Find();
            return  RepeatingInvoices;
        }
        [HttpGet]
        public Xero.Api.Core.Model.RepeatingInvoice Get(Guid id)
        {
            var  RepeatingInvoice = XeroApiHelper.XeroApi.RepeatingInvoices.Find(id);
            return  RepeatingInvoice;
        }
    }
}

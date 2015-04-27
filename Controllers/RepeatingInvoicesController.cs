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
    public class RepeatingInvoicesController : ApiController
    {
        [HttpGet]
        public IEnumerable<RepeatingInvoice> Get()
        {
            var RepeatingInvoices = XeroApiHelper.XeroApi.RepeatingInvoices.Find();
            return XeroApiHelper.Convert<IEnumerable<RepeatingInvoice>>(RepeatingInvoices);
        }
        [HttpGet]
        public RepeatingInvoice GetById(Guid id)
        {
            var RepeatingInvoice = XeroApiHelper.XeroApi.RepeatingInvoices.Find(id);
            return XeroApiHelper.Convert<RepeatingInvoice>(RepeatingInvoice);
        }
    }
}

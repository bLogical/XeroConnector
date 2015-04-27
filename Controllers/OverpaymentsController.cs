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
    public class OverpaymentsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Overpayment> Get()
        {
            var Overpayments = XeroApiHelper.XeroApi.Overpayments.Find();
            return XeroApiHelper.Convert<IEnumerable<Overpayment>>(Overpayments);
        }
        [HttpGet]
        public Overpayment GetById(Guid id)
        {
            var Overpayment = XeroApiHelper.XeroApi.Overpayments.Find(id);
            return XeroApiHelper.Convert<Overpayment>(Overpayment);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class OverpaymentsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.Overpayment> Get()
        {
            var Overpayments = XeroApiHelper.XeroApi.Overpayments.Find();
            return Overpayments;
        }
        [HttpGet]
        public Xero.Api.Core.Model.Overpayment GetById(Guid id)
        {
            var Overpayment = XeroApiHelper.XeroApi.Overpayments.Find(id);
            return Overpayment;
        }
    }
}

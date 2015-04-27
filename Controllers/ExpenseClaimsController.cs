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
    public class ExpenseClaimsController : ApiController
    {
        [HttpGet]
        public IEnumerable<ExpenseClaim> Get()
        {
            var ExpenseClaims = XeroApiHelper.XeroApi.ExpenseClaims.Find();
            return XeroApiHelper.Convert<IEnumerable<ExpenseClaim>>(ExpenseClaims);
        }
        [HttpGet]
        public ExpenseClaim GetById(Guid id)
        {
            var ExpenseClaim = XeroApiHelper.XeroApi.ExpenseClaims.Find(id);
            return XeroApiHelper.Convert<ExpenseClaim>(ExpenseClaim);
        }
        [HttpPost]
        public void Create(ExpenseClaim ExpenseClaim)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.ExpenseClaim>(ExpenseClaim);
            XeroApiHelper.XeroApi.ExpenseClaims.Create(xeroObj);
        }
        [HttpPut]
        public void Update(ExpenseClaim ExpenseClaim)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.ExpenseClaim>(ExpenseClaim);
            XeroApiHelper.XeroApi.ExpenseClaims.Update(xeroObj);
        }
    }
}

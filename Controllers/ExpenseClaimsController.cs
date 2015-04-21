using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class ExpenseClaimsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.ExpenseClaim> Get()
        {
            var ExpenseClaims = XeroApiHelper.XeroApi.ExpenseClaims.Find();
            return ExpenseClaims;
        }
        [HttpGet]
        public Xero.Api.Core.Model.ExpenseClaim Get(Guid id)
        {
            var ExpenseClaim = XeroApiHelper.XeroApi.ExpenseClaims.Find(id);
            return ExpenseClaim;
        }
        [HttpPost]
        public Xero.Api.Core.Model.ExpenseClaim Create(Xero.Api.Core.Model.ExpenseClaim ExpenseClaim)
        {
            return XeroApiHelper.XeroApi.ExpenseClaims.Create(ExpenseClaim);
        }
        [HttpPut]
        public Xero.Api.Core.Model.ExpenseClaim Update(Xero.Api.Core.Model.ExpenseClaim ExpenseClaim)
        {
            return XeroApiHelper.XeroApi.ExpenseClaims.Update(ExpenseClaim);
        }
    }
}

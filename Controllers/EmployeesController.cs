using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class EmployeesController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.Employee> Get()
        {
            var Employees = XeroApiHelper.XeroApi.Employees.Find();
            return Employees;
        }
        [HttpGet]
        public Xero.Api.Core.Model.Employee GetById(Guid id)
        {
            var Employee = XeroApiHelper.XeroApi.Employees.Find(id);
            return Employee;
        }
        [HttpPost]
        public Xero.Api.Core.Model.Employee Create(Xero.Api.Core.Model.Employee Employee)
        {
            return XeroApiHelper.XeroApi.Employees.Create(Employee);
        }
        [HttpPut]
        public Xero.Api.Core.Model.Employee Update(Xero.Api.Core.Model.Employee Employee)
        {
            return XeroApiHelper.XeroApi.Employees.Update(Employee);
        }
    }
}

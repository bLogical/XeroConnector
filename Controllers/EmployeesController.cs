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
    public class EmployeesController : ApiController
    {
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            var Employees = XeroApiHelper.XeroApi.Employees.Find();
            return XeroApiHelper.Convert<IEnumerable<Employee>>(Employees);
        }
        [HttpGet]
        public Employee GetById(Guid id)
        {
            var Employee = XeroApiHelper.XeroApi.Employees.Find(id);
            return XeroApiHelper.Convert<Employee>(Employee);
        }
        [HttpPost]
        public void Create(Employee Employee)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.Employee>(Employee);
            XeroApiHelper.XeroApi.Employees.Create(xeroObj);
        }
        [HttpPut]
        public void Update(Employee Employee)
        {
            var xeroObj = XeroApiHelper.Convert<Xero.Api.Core.Model.Employee>(Employee);
            XeroApiHelper.XeroApi.Employees.Update(xeroObj);
        }
    }
}

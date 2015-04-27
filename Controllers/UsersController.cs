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
    public class UsersController : ApiController
    {
        [HttpGet]
        public IEnumerable<User> Get()
        {
            var Users = XeroApiHelper.XeroApi.Users.Find();
            return XeroApiHelper.Convert<IEnumerable<User>>(Users);
        }
        [HttpGet]
        public User GetById(Guid id)
        {
            var User = XeroApiHelper.XeroApi.Users.Find(id);
            return XeroApiHelper.Convert<User>(User);
        }
    }
}

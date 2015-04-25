using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XeroConnector.Helpers;

namespace XeroConnector.Controllers
{
    public class UsersController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xero.Api.Core.Model.User> Get()
        {
            var Users = XeroApiHelper.XeroApi.Users.Find();
            return Users;
        }
        [HttpGet]
        public Xero.Api.Core.Model.User GetById(Guid id)
        {
            var User = XeroApiHelper.XeroApi.Users.Find(id);
            return User;
        }
    }
}

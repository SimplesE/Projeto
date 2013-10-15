using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.ServiceModel;
using SimplesE.Business;
using SimplesE.Model.Core;

namespace SimplesE.API.Controllers
{
    public class UserController : ApiController
    {
        // GET api/user
        public IEnumerable<User> GetAll()
        {
            var ruler = new UserRuler();

            var result = ruler.GetAll();

            return result;
        }
    }
}

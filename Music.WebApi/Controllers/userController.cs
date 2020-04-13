using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;

namespace Music.WebApi.Controllers
{
    public class userController : ApiController
    {
        // GET: api/user
        MusicBLL bll = new MusicBLL();
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/user/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/user
        public int Post([FromBody]UserModel u)
        {
            return bll.Login(u);
        }

        // PUT: api/user/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/user/5
        public void Delete(int id)
        {
        }
    }
}

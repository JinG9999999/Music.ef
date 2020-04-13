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
    public class corpController : ApiController
    {
        // GET: api/corp
        MusicBLL bll = new MusicBLL();
        public IEnumerable<CorpModel> Get()
        {
            return bll.bandsel();
        }

        // GET: api/corp/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/corp
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/corp/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/corp/5
        public void Delete(int id)
        {
        }
    }
}

using BLL;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Music.WebApi.Controllers
{
    public class musicController : ApiController
    {
        // GET: api/music
        MusicBLL bll = new MusicBLL();
        public PagedInfo Get(string Name = null, string Cid = null, int index = 1, int PageSize = 3)
        {
            var list = bll.Show();
            if (!string.IsNullOrEmpty(Name))
            {
                list = list.Where(s => s.CorpName.Contains(Name)).ToList();
            }
            if (!string.IsNullOrEmpty(Cid))
            {
                list = list.Where(s => s.CorpModelCid == int.Parse(Cid)).ToList();
            }
            PagedInfo pInfo = new PagedInfo();
            pInfo.TotalConut = list.Count;
            if (pInfo.TotalConut % PageSize == 0)
            {
                pInfo.TotalPage = pInfo.TotalConut / PageSize;
            }
            else
            {
                pInfo.TotalPage = (pInfo.TotalConut / PageSize) + 1;
            }
            if (index < 1)
            {
                index = 1;
            }
            if (index > pInfo.TotalPage)
            {
                index = pInfo.TotalPage;
            }
            pInfo.musics = list.Skip(PageSize * (index - 1)).Take(PageSize).ToList();
            pInfo.currentPage = index;
            return pInfo;
        }

        // GET: api/music/5
        public MusicModel Get(int id)
        {
            return bll.Find(id);
        }

        // POST: api/music
        public int Post([FromBody]MusicModel m)
        {
            return bll.Add(m);
        }

        // PUT: api/music/5
        public int Put([FromBody]MusicModel m)
        {
            return bll.Upt(m);
        }

        // DELETE: api/music/5
        public int Delete(int id)
        {
            return bll.Del(id);
        }
    }
}

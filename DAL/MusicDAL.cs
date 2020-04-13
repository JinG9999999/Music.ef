using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class MusicDAL
    {
        MusicDataContext mc = new MusicDataContext();
        public List<MusicModel> Show()
        {
            return mc.Musics.ToList();
        }
        public List<CorpModel> bandsel()
        {
            return mc.Corps.ToList();
        }
        public MusicModel Find(int id)
        {
            return mc.Musics.Find(id);
        }
        public int Add(MusicModel m)
        {
            mc.Musics.Add(m);
            return mc.SaveChanges();
        }
        public int Del(int id)
        {
            var s = mc.Musics.Find(id);
            mc.Musics.Remove(s);
            return mc.SaveChanges();
        }
        public int Upt(MusicModel m)
        {
            mc.Musics.Attach(m);
            mc.Entry(m).State = System.Data.Entity.EntityState.Modified;
            return mc.SaveChanges();
        }

        public int Login(UserModel u)
        {
            return mc.Users.Where(s => s.UserName == u.UserName && s.Password == u.Password).Count();

        }
    }
}

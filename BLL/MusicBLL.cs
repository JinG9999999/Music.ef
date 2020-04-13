using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class MusicBLL
    {
        MusicDAL dal = new MusicDAL();
        public List<MusicModel> Show()
        {
            return dal.Show();
        }
        public List<CorpModel> bandsel()
        {
            return dal.bandsel();
        }
        public MusicModel Find(int id)
        {
            return dal.Find(id);
        }
        public int Add(MusicModel m)
        {

            return dal.Add(m);
        }
        public int Del(int id)
        {

            return dal.Del(id);
        }
        public int Upt(MusicModel m)
        {

            return dal.Upt(m);
        }

        public int Login(UserModel u)
        {
            return dal.Login(u);
        }
    }
}

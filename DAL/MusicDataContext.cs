using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;

namespace DAL
{
    public class MusicDataContext : DbContext
    {
        public MusicDataContext() : base("conn") { }
        public DbSet<MusicModel> Musics { get; set; }
        public DbSet<CorpModel> Corps { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}

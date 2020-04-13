using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MusicModel //唱片表
    {
        [Key]
        public int Mid { get; set; }
        public string CorpName { get; set; } //音乐名称
        public string Cover { get; set; } //唱片封面
        public string Tags { get; set; } //唱片标签
        public string Maker { get; set; } //制作人
        public string Singer { get; set; } //演唱
        public int CorpModelCid { get; set; } //音乐公司 外键
        public DateTime ReleaseDate { get; set; } //发布日期
        public int Price { get; set; } //价格
        public string Adder { get; set; } //添加人姓名
        public string CdDetail { get; set; } //唱片详情
        public virtual CorpModel CorpModels { get; set; }
    }
    public class CorpModel //唱片公司表
    {
        [Key]
        public int Cid { get; set; }
        public string CorpName { get; set; } //音乐公司
        public string Location { get; set; } //公司地址
        [NotMapped]
        public virtual ICollection<MusicModel> MusicModels { get; set; }
    }

    public class UserModel //登录表
    {
        [Key]
        public int Uid { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class PagedInfo
    {
        public List<MusicModel> musics { get; set; }
        public int TotalConut { get; set; }   //记录条数
        public int TotalPage { get; set; }    //总页数
        public int currentPage { get; set; }  //当前页
    }
}

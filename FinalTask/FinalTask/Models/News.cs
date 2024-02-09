using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Brief { get; set; }
        public string Desc { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan Time { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }


        [ForeignKey("AuthorObj")]
        public int Auth_Id { get; set; }

        [ForeignKey("CatalogObj")]
        public int Cat_Id { get; set; }
        public virtual Author AuthorObj { get; set; }
        public virtual Catalog CatalogObj { get; set; }
    }
}

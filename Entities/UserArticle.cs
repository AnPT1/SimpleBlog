using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBlog2.Entities
{
    public class UserArticle : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(("User"))]
        public User UserId { get; set; }

        [ForeignKey("Article")]
        public Article ArticleId { get; set; }
    }
}

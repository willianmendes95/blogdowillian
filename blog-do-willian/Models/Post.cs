using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace blog_do_willian.Models
{
    public class Post
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(500)]
        public string Title { get; set; }

        public DateTime DataAdded { get; set; }

        public DateTime? DataUpdate { get; set; }

        [Required]
        [StringLength(3000)]
        public string PostingBody { get; set; }

    }
}
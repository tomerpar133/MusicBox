using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicBox.Models
{
    public class Comment
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        [DisplayName("Commemt")]
        public string Text { get; set; }

        [Required]
        [DisplayName("user Name")]
        public User User { get; set; }

        [Required]

        [DisplayName("Date")]
        public DateTime PublishDate { get; set; }

        [Required]
        [DisplayName("Post")]
        public virtual MusicPost Post { get; set; }
    }
}
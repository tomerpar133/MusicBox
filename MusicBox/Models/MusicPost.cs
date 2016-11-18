using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicBox.Models
{
    public class MusicPost
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        [MaxLength(5000)]
        [DisplayName("Description")]
        public string Desc { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Created at")]
        public DateTime PublishDate { get; set; }

        [Required]
        [DisplayName("User Name")]
        public User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicBox.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(20)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        [DisplayName("First Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Sex")]
        public SexType Sex { get; set; }

        [Required]
        [MaxLength(20)]
        [DisplayName("Address")]
        public string Address { get; set; }

        [Required]
        [DefaultValue(false)]
        [DisplayName("Admin")]
        public bool isAdmin { get; set; }

        [Required]
        [MaxLength(6)]
        [DisplayName("Password")]
        public string Password { get; set; }

        public enum SexType
        {
            Man,
            Female
        };

    }
}
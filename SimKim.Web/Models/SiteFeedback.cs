using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimKim.Web.Models
{
    public class SiteFeedback
    {
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Phone")]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [StringLength(500)]
        [Display(Name = "Feedback")]
        public string Feedback { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RugbyApp.Models.Seniors
{
    public class Seniors
    {
        [Key]
        public int SruNumber { get; set; }
        [Required]
        [Display(Name = "Member Forename")]
        public string FName { get; set; }
        [Required]
        [Display(Name = "Member Surname")]
        public string LName { get; set; }
        [Required]
        [Display(Name = "Member DOB")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }
        [Required]
        [Display(Name = "Member Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Member Phone number")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Member Email")]
        public string Email { get; set; }
        public string Position { get; set; }

        [NotMapped]
        public NextOfKin nextOfKin;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RugbyApp.Models.Juniors
{
    public class ParentsDetails
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "First name required")]  //Null values not accepted
        [Display(Name = "Parent 1 Forename")] //Sets the output of the following variable being declared.
        public string p1FName { get; set; }
        [Required(ErrorMessage = "Surname required")]  //Null values not accepted
        [Display(Name = "Parent 1 Surname")] //Sets the output of the following variable being declared.
        public string p1SName { get; set; }
        [Required(ErrorMessage = "Relationship to player required")]  //Null values not accepted
        [Display(Name = "Parent 1 Relation")] //Sets the output of the following variable being declared.
        public string p1Relation { get; set; }
        [Required(ErrorMessage = "Address required")]  //Null values not accepted
        [Display(Name = "Parent 1 Address")] //Sets the output of the following variable being declared.
        public string p1Address { get; set; }
        [Required(ErrorMessage = "Phone number required")]  //Null values not accepted
        [Display(Name = "Parent 1 Phone number")] //Sets the output of the following variable being declared.
        public string p1PhoneNumber { get; set; }
        [Required(ErrorMessage = "Surname required")]  //Null values not accepted
        [Display(Name = "Parent 2 Surname")] //Sets the output of the following variable being declared.
        public string p2Sname { get; set; }
        public string p2Relation { get; set; }
        public string p2Address { get; set; }
        public string p2PhoneNumber { get; set; }

        public int JuniorId { get; set; }
        public JuniorsDetails juniors { get; set; }
    }
}
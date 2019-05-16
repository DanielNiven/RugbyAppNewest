using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RugbyApp.Models.Juniors
{
    public class JuniorsDetails
    {
        //Declaring Variables
        [Key] //Sets Primary key as SruNumber
        public int SruNumber { get; set; } //int instead of integer declared
        [Required(ErrorMessage = "First name required")]  //Null values not accepted
        [Display(Name = "Member Forename")] //Sets the output of the following variable being declared.
        public string FName { get; set; } //String FName(Forename) declared
        [Required(ErrorMessage = "Surname required")]  //Null values not accepted
        [Display(Name = "Member Surname")] //Sets the output of the following variable being declared.
        public string LName { get; set; } //String LName(Surname) declared
        [Required(ErrorMessage = "Date of Birth required")]  //Null values not accepted
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Member DOB")] //Sets the output of the following variable being declared.

        public DateTime DOB { get; set; } //DateTime DOB(Date of Birth)
        [Required] //Null values not accepted
        [Display(Name = "Member Address")] //Sets the output of the following variable being declared.
        public string Address { get; set; } //String Address declared
        [Required] //Null values not accepted
        [Display(Name = "Member Phone number")] //Sets the output of the following variable being declared.
        public string PhoneNumber { get; set; } //String PhoneNumber declared
        [Required] //Null values not accepted
        [Display(Name = "Member Email")] //Sets the output of the following variable being declared.
        public string Email { get; set; } //String email declared
        public string Position { get; set; } //String position declared

        [NotMapped] //This overrides the normal convention
        public ParentsDetails parents; //Calls the parent 
    }
}
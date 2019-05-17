using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RugbyApp.Models
{
    public class Results
    {
        //Variables for results page declared
        public int ID { get; set; }
        public String Home { get; set; }
        public String VS { get; set; }
        public String Away { get; set; }
        [Required(ErrorMessage = "Field is required ")]
        [Display(Name = "Date of Match")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RugbyApp.Models
{
    public class Training
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Enter a value 1 to 10  ")]
        public int KickDrop { get; set; }
        [Required(ErrorMessage = "Enter a value 1 to 10  ")]
        public int PassStandard { get; set; }
    }
}
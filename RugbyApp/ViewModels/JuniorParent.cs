using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RugbyApp.Models;
using System.Collections;
using RugbyApp.Models.Juniors;
using System.ComponentModel.DataAnnotations;
namespace RugbyApp.ViewModels
{
    public class JuniorParent
    {
        [Key]
        public int id { get; set; }
        public JuniorsDetails juniors { get; set; }
        public ParentsDetails parents { get; set; }
    }
}
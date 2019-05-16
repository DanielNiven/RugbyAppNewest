using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RugbyApp.Models.Juniors;

namespace RugbyApp.Views.ViewModels
{
    public class JuniorParentCombo
    {
        public JuniorsDetails juniors { get; set; }
        public ParentsDetails parents { get; set; }
    }
}
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimbaApp.Models.ViewModels
{
    public class HTMLCeptionvIEWmODEL
    {
        public string Text {get; set;}
        public HTMLCeptionvIEWmODEL()
        {
            Text = "This is an <em>HTML</em> text. <b>Enjoy yourself!</b>";
        }
    }
}

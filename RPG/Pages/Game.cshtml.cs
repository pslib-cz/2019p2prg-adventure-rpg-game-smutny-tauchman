using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPG.Services;

namespace RPG_adventura.Pages
{
    public class setKeyLocationModel : PageModel
    {
        public readonly SessionStorage _ss;
        public readonly Locations _lo;
        public setKeyLocationModel(SessionStorage ss)
        {
            _ss = ss;
            _lo = new Locations(ss);
        }
        public void OnGet()
        {
         
        }
        public void OnPost()
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RPG.Services;

namespace RPG
{
    public class IndexModel : PageModel
    {
        public readonly SessionStorage _ss;
        private static Random _random = new Random();
        public int? secretRoomNumber { get; set; }
        public IndexModel(SessionStorage ss)
        {
            _ss = ss;

        }

        public void OnGet()
        {
            _ss.setKeyLocation(1);
        }
        public ActionResult OnPost() { 
            return RedirectToPage("./setKeyLocation");        
        }
    }
}
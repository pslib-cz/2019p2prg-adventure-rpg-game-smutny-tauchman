using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPG.Services;

namespace RPG.Pages
{
    public class Game : PageModel
    {
        public readonly SessionStorage _ss;
        public readonly Locations _lo;
        [BindProperty]
        public int index { get; set; }
        [BindProperty]
        public bool key { get; set; }
        private List<bool> raided { get; set; }
        public Game(SessionStorage ss)
        {
            key = false;
            _ss = ss;
            raided = _ss.getRaidArray();
            _lo = new Locations(ss);
            index = 0;
        }
        public void OnGet()
        {
         
        }
        public void OnPost()
        {
            raided[index] = true;
            _ss.setRaidArray(raided);
        }
    }
}
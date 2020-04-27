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
        public static Random random = new Random();
        public readonly SessionStorage _ss;
        public readonly Locations _lo;
        public List<Locations> rooms {  get; set;  }
        public int? Location;
        [BindProperty]
        public int index { get; set; }
        [BindProperty]
        public bool key { get; set; }
        [BindProperty]
        public string message { get; set; }
        [BindProperty]
        public bool keyCaptured { get; set; }
        public setKeyLocationModel(SessionStorage ss)
        {
            key = false;
            _ss = ss;
            index = 0;
            _lo = new Locations(_ss);
        }
        public void OnGet()
        {
         
        }
        public void OnPost()
        {
            _lo.Rooms[index].raided = true;
            if(_lo.Rooms[index].containsKey == true && _lo.Rooms[index].raided == false)
            {
                key = true;
                message = "Našel jsi klíč";
            }
            else
            {
                message = "";
            }
        }
    }
}
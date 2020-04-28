using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RPG.Services;
using RPG.Models;

namespace RPG.Pages
{
    public class IndexModel : PageModel
    {
        public readonly SessionStorage _ss;
        private static Random _random;
        public List<bool> enemies { get; set; }
        private List<bool> raided { get; set; }
        private GameState gameState { get; set; }
        public IndexModel(SessionStorage ss)
        {
            _ss = ss;
            _random = new Random();
            enemies = new List<bool>();
            raided = new List<bool>();
            gameState = new GameState();
            gameState.HP = 100;
        }

        public void OnGet()
        {
            for  (int i = 0; i < 15; i++)
            {
                enemies.Add(_random.Next(0, 11) == 5 || _random.Next(0, 11) == 4 || _random.Next(0, 11) == 3 ? true : false);
                raided.Add(false);
            }
            _ss.setEnemyArray(enemies);
            _ss.setRaidArray(raided);
            _ss.setKeyLocation(1);
            _ss.setGameState(gameState);
        }
        public ActionResult OnPost()
        {
            return RedirectToPage("./Game");
        }
    }
}

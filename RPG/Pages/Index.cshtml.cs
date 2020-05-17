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
        private List<Room> _locationsArr { get; set; }
        private Locations _lo { get; set; }
        public GameState gameState { get; set; }
        [BindProperty]
        public int Difficulty { get; set; }
        public IndexModel(SessionStorage ss)
        {
            _ss = ss;
            _lo = new Locations(ss);
            _random = new Random();
            gameState = new GameState();
            gameState.HP = 100;
        }

        public void OnGet()
        {
            _ss.setGameState(gameState);
        }
        public ActionResult OnPost()
        {
            _locationsArr = _ss.getLocations();
            if(Difficulty == 1)
            {
                for (int i = 1; i < _locationsArr.Count - 1; i++)
                {
                    _locationsArr[i].containsEnemy = _random.Next(0, 11) == 5 || _random.Next(0, 11) == 4 || _random.Next(0, 11) == 3 ? true : false;
                }
                gameState.EnemyDamage = 10;
            }
            else if (Difficulty == 2)
            {
                for (int i = 1; i < _locationsArr.Count - 1; i++)
                {
                    _locationsArr[i].containsEnemy = _random.Next(0, 11) == 5 || _random.Next(0, 11) == 4 || _random.Next(0, 11) == 3 || _random.Next(0, 11) == 2 ? true : false;

                }
                gameState.EnemyDamage = 20;
            }
            else if(Difficulty == 3)
            {
                for (int i = 1; i < _locationsArr.Count - 1; i++)
                {
                    _locationsArr[i].containsEnemy = _random.Next(0, 11) == 5 || _random.Next(0, 11) == 4 || _random.Next(0, 11) == 3 || _random.Next(0, 11) == 2 || _random.Next(0, 11) == 1 ? true : false;
                }
                gameState.EnemyDamage = 30;
            }
            else
            {
                for (int i = 1; i < _locationsArr.Count - 1; i++)
                {
                    _locationsArr[i].containsEnemy = _random.Next(0, 11) == 5 || _random.Next(0, 11) == 4 || _random.Next(0, 11) == 3 ? true : false;
                }
                gameState.EnemyDamage = 100;
            }
            _ss.setLocations(_locationsArr);
            _ss.setIndex(0);
            _ss.setGameState(gameState);
            return RedirectToPage("./Game");
        }
    }
}

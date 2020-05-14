using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPG.Services;
using RPG.Models;

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
        public GameState gameState { get; set; }
        public Game(SessionStorage ss)
        {
            key = false;
            _ss = ss;
            raided = _ss.getRaidArray();
            _lo = new Locations(ss);
            index = 0;
            gameState = _ss.getGameState();
        }
        public void OnGet()
        {
         
        }
        public void OnPost()
        {
            gameState = _ss.getGameState();
            if(_lo.Rooms[index].containsEnemy == true && _lo.Rooms[index].raided == false)
            {
                gameState.HP = gameState.HP - gameState.EnemyDamage;
                _ss.setGameState(gameState);
            }
            raided[index] = true;
            _ss.setRaidArray(raided);
            if (gameState.HP <= 0)
            {
                gameState.HP = 0;
            }
        }
        public ActionResult OnPostNewgame()
        {
            return RedirectToPage("./Index");
        }
    }
}
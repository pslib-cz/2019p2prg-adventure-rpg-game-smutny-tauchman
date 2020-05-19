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
        public List<Room> rooms;
        [BindProperty]
        public int index { get; set; }
        [BindProperty]
        public bool key { get; set; }
        public GameState gameState { get; set; }
        public Game(SessionStorage ss)
        {
            _ss = ss;
            gameState = _ss.getGameState();
            gameState.Key = false;
            rooms = _ss.getLocations();
            index = (int)_ss.getIndex();
            rooms[index].raided = true;
        }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            gameState = _ss.getGameState();
            if(rooms[index].containsEnemy == true && rooms[index].raided == false)
            {
                gameState.HP = gameState.HP - gameState.EnemyDamage;
            }
            if(index == _ss.getKeyLocation())
            {
                gameState.Key = true;
            }
            if (rooms[index].containsMap == true)
            {
                gameState.Map = true;
            }
            if (gameState.HP <= 0)
            {
                gameState.HP = 0;
            }
            _ss.setGameState(gameState);
            _ss.setLocations(rooms);
            _ss.setIndex(index);
        }
        public ActionResult OnPostNewgame()
        {
            return RedirectToPage("./Index");
        }
    }
}
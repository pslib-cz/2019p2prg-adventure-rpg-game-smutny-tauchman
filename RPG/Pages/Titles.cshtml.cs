using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RPG.Models;
using RPG.Services;

namespace RPG.Pages
{
    public class Titles : PageModel
    {
        private readonly ILogger<Titles> _logger;
        public readonly SessionStorage ss;
        public GameState gameState { get; set; }

        public Titles(SessionStorage _ss)
        {
            ss = _ss;
            gameState = new GameState();
            gameState.HP = ss.getGameState().HP;
        }

        public void OnGet()
        {

        }
    }
}

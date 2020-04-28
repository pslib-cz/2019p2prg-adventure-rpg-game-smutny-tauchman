using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG.Helpers;
using RPG.Models;

namespace RPG.Services
{
    public class SessionStorage
    {
        readonly ISession _session;
        public Random random = new Random();
        const string KEYLOCATION = "Poloha Klíče";
        private int keyLocation { get; set; }

        const string ENEMYLOCATION = "Přítomnost nepřítele";
        private List<bool> enemyLocation { get; set; }

        const string RAIDED = "Přítomnost hráče";
        private List<bool> raidedRooms { get; set; }

        const string GAMESTATE = "Stav hry";
        private GameState gameState { get; set; }

        public SessionStorage(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;
            enemyLocation = new List<bool>();
            raidedRooms = new List<bool>();
            
        }
        public int? getKeyLocation()
        {
            return _session.GetInt32(KEYLOCATION);
        }
        public void setKeyLocation(int number)
        {
            _session.SetInt32(KEYLOCATION, number);
            keyLocation = number;
        }

        public List<bool> getEnemyArray()
        {
            return _session.Get<List<bool>>(ENEMYLOCATION);
        }
        public void setEnemyArray(List<bool> enemyArray)
        {
            _session.Set(ENEMYLOCATION, enemyArray);
            enemyLocation = enemyArray;
        }

        public List<bool> getRaidArray()
        {
            return _session.Get<List<bool>>(RAIDED);
        }
        public void setRaidArray(List<bool> raidedArray)
        {
            _session.Set(RAIDED, raidedArray);
            raidedRooms = raidedArray;
        }

        public void setGameState(GameState state)
        {
            _session.Set(GAMESTATE, state);
            gameState = state;
        }
        public GameState getGameState()
        {
            return _session.Get<GameState>(GAMESTATE);
        }
    }
}

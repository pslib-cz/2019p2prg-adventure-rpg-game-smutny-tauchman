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

        const string LOCATIONS = "Místnosti";

        const string GAMESTATE = "Stav hry";

        const string INDEX = "Index aktuální místnosti";

        public SessionStorage(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;          
        }
        public int? getKeyLocation()
        {
            return _session.GetInt32(KEYLOCATION);
        }
        public void setKeyLocation(int number)
        {
            _session.SetInt32(KEYLOCATION, number);
        }

        public List<Room> getLocations()
        {
            return _session.Get<List<Room>>(LOCATIONS);
        }
        public void setLocations(List<Room> enemyArray)
        {
            _session.Set(LOCATIONS, enemyArray);
        }

        public void setGameState(GameState state)
        {
            _session.Set(GAMESTATE, state);
        }
        public GameState getGameState()
        {
            return _session.Get<GameState>(GAMESTATE);
        }
        public int? getIndex()
        {
            return _session.GetInt32(INDEX);
        }
        public void setIndex(int index)
        {
            _session.SetInt32(INDEX, index);
        }
    }
}

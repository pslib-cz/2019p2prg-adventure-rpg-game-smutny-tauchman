using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG.Helpers;

namespace RPG.Services
{
    public class SessionStorage
    {
        readonly ISession _session;
        public Random random = new Random();
        const string KEYLOCATION = "Poloha Klíče";
        private int keyLocation { get; set; }

        const string ENEMYLOCATION = "Přítomnost nepřítele";
        private bool[] enemyLocation { get; set; }

        const string RAIDED = "Přítomnost hráče";
        private bool[] raidedRooms { get; set; }

        public SessionStorage(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;
            
        }
        public int? getKeyLocation()
        {
            return keyLocation;
        }
        public void setKeyLocation(int number)
        {
            _session.SetInt32(KEYLOCATION, number);
            keyLocation = number;
        }

        public bool[] getEnemyArray()
        {
            return enemyLocation;
        }
        public void setEnemyArray(bool[] enemyArray)
        {
            _session.Set(ENEMYLOCATION, enemyArray);
            enemyLocation = enemyArray;
        }

        public bool[] getRaidArray()
        {
            return raidedRooms;
        }
        public void setRaidArray(bool[] raidedArray)
        {
            _session.Set(RAIDED, raidedArray);
            raidedRooms = raidedArray;
        }
    }
}

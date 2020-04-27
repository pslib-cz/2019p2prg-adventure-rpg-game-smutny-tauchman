using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Services
{
    public class SessionStorage
    {
        readonly ISession _session;
        public Random random = new Random();
        const string KEYLOCATION = "Poloha Klíče";
        private int keyLocation { get; set; }
        public bool isSet { get; set; }

        public SessionStorage(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;
            int? location = _session.GetInt32(KEYLOCATION);
            if (location != default)
            {
                keyLocation = (int)location;  
            }     
        }
        public int? getKeyLocation()
        {
            return keyLocation;
        }
        public void setKeyLocation(int number)
        {
            _session.SetInt32(KEYLOCATION, number);
            keyLocation = number;
            isSet = true;
        }
        public void ResetKeyLocation()
        {
            _session.SetString(KEYLOCATION, null);
            isSet = false;
        }
    }
}
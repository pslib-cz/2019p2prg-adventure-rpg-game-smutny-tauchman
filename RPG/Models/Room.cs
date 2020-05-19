using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Models
{
    public class Room
    {
        public int id { get; set; }
        public string description { get; set; }
        public string button { get; set; }
        public bool containsKey { get; set; }
        public bool containsEnemy { get; set; }
        public bool containsMap { get; set; }
        public int[] rooms { get; set; }
        public bool raided { get; set; }
        public Room(int id, string description, string button, int[] rooms, bool containsEnemy = false, bool raided = false, bool containsKey = false, bool containsMap = false)
        {
            this.id = id;
            this.description = description;
            this.button = button;
            this.containsKey = containsKey;
            this.containsEnemy = containsEnemy;
            this.rooms = rooms;
            this.raided = raided;
            this.containsMap = containsMap;
        }
    }
}

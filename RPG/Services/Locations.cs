using RPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Services
{
    public class Locations
    {
        private readonly SessionStorage _ss;
        private static Random rnd;
        public List<Room> Rooms { get; set; }
        public Locations(SessionStorage ss)
        {
            _ss = ss;
            rnd = new Random();
            Rooms = new List<Room>();
            Rooms.Add(new Room(0, "Jsi na začátku chodby. Světla jsou zhasnutá, jen v dálce visí za několik drátů lustr, který mírně problikává. Na konci chodby vidíš nějakou osobu. S dalším probliknutím světla je ale pryč. Dveře na svobodu, které máš za zády, jsou zamčené. Pokus se najít klíč.", "Jít na začátek chodby", false, false, new int[] { 1, 14 }));             //START
            Rooms.Add(new Room(1, "Pokračuješ dále v chodbě. Po své pravé ruce vidíš zavřené, avšak nezamčené, dveře. Nalevo jsou pootevřené dveře, za nimiž vidíš slabé světlo z rozbité lampy. Rovně pokračuje temná chodba.", "Jít do přední části chodby", false, true, new int[] { 0,2,5,11 }));
            Rooms.Add(new Room(2, "Zatáhl jsi za kliku pravých dveří. Stojíš v menší předsíni, která se dále větví na dvě místnosti.", "Jít do pravých (předsíň). ", false, setEnemy(), new int[] { 1,3,4 }));
            Rooms.Add(new Room(3, "Místnost 3", "Pokračovat z předsíně do prvních dveří.", false, setEnemy(), new int[] { 2 }));
            Rooms.Add(new Room(4, "Místnost 4", "Pokračovat z předsíně do druhých dveří", false, setEnemy(), new int[] { 2 }));
            Rooms.Add(new Room(5, "Pokračuješ dále v chodbě. Po pravé ruce máš průchod do další místnosti.", "Jít do prostřední části chodby", false, setEnemy(), new int[] { 1,6,8 }));
            Rooms.Add(new Room(6, "Nyní jsi v průchodu. Za zády máš chodbu a před sebou další místnost.", "Jít do průchodu", false, setEnemy(), new int[] { 5,7 }));
            Rooms.Add(new Room(7, "Místnost 7", "Jít do zadní místnosti", false, setEnemy(), new int[] { 6 }));
            Rooms.Add(new Room(8, "Došel jsi na konec chodby. Na obou stranách jsou dveře.", "Jít do zadní části chodby", false, setEnemy(), new int[] { 5,9,10 }));
            Rooms.Add(new Room(9, "Místnost 9", "Jít do pravé místnosti", false, setEnemy(), new int[] { 8 }));
            Rooms.Add(new Room(10, "Místnost 10", "Jít do levé místnosti", false, setEnemy(), new int[] { 8 }));
            Rooms.Add(new Room(11, "Lampa právě přestala svítit. Na pravé straně jsou dveře, stejně tak, jako před tebou.", "Jít do levých dveří (předsíň)", false, setEnemy(), new int[] { 1,12,13 }));
            Rooms.Add(new Room(12, "Místnost 12", "Jít do pravých dveří (secret)", false, setEnemy(), new int[] { 11 }));
            Rooms.Add(new Room(13, "Místnost 13", "Pokračovat do levých dveří", false, setEnemy(), new int[] { 11 }));
            Rooms.Add(new Room(14, "K odemčení dveří potřebuješ klíč!", "Pokusit se odemknout dveře", false, false, new int[] { 0 }));      //GAME OVER
            Rooms[(int)_ss.getKeyLocation()].containsKey = true;
        }
       private bool setEnemy()
        {
            int chance = rnd.Next(0, 10);
            bool result = chance == 5 ? true : false;
            return result;
        }

    }
}

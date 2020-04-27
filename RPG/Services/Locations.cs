﻿using RPG.Models;
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
            Rooms.Add(new Room(0, "Jsi na začátku chodby. Světla jsou zhasnutá, jen v dálce visí za několik drátů lustr, který mírně problikává. Na konci chodby vidíš nějakou osobu. S dalším probliknutím světla je ale pryč. Dveře na svobodu, které máš za zády, jsou zamčené. Pokus se najít klíč.", "Jít na začátek chodby", false, false, new int[] { 1, 14 }, true));             //START
            Rooms.Add(new Room(1, "Pokračuješ dále v chodbě. Po své pravé ruce vidíš zavřené, avšak nezamčené, dveře. Nalevo jsou pootevřené dveře, za nimiž vidíš slabé světlo z rozbité lampy. Rovně pokračuje temná chodba.", "Jít do přední části chodby", false, _ss.getEnemyArray()[1], new int[] { 0, 2, 5, 11 }, _ss.getRaidArray()[1]));
            Rooms.Add(new Room(2, "Zatáhl jsi za kliku pravých dveří. Stojíš v menší předsíni, která se dále větví na dvě místnosti.", "Jít do pravých (předsíň). ", false, _ss.getEnemyArray()[2], new int[] { 1, 3, 4 }, _ss.getRaidArray()[2]));
            Rooms.Add(new Room(3, "Místnost 3", "Pokračovat z předsíně do prvních dveří.", false, _ss.getEnemyArray()[3], new int[] { 2 }, _ss.getRaidArray()[3]));
            Rooms.Add(new Room(4, "Místnost 4", "Pokračovat z předsíně do druhých dveří", false, _ss.getEnemyArray()[4], new int[] { 2 }, _ss.getRaidArray()[4]));
            Rooms.Add(new Room(5, "Pokračuješ dále v chodbě. Po pravé ruce máš průchod do další místnosti.", "Jít do prostřední části chodby", false, _ss.getEnemyArray()[5], new int[] { 1, 6, 8 }, _ss.getRaidArray()[5]));
            Rooms.Add(new Room(6, "Nyní jsi v průchodu. Za zády máš chodbu a před sebou další místnost.", "Jít do průchodu", false, _ss.getEnemyArray()[6], new int[] { 5, 7 }, _ss.getRaidArray()[6]));
            Rooms.Add(new Room(7, "Místnost 7", "Jít do zadní místnosti", false, _ss.getEnemyArray()[7], new int[] { 6 }, _ss.getRaidArray()[7]));
            Rooms.Add(new Room(8, "Došel jsi na konec chodby. Na obou stranách jsou dveře.", "Jít do zadní části chodby", false, _ss.getEnemyArray()[8], new int[] { 5, 9, 10 }, _ss.getRaidArray()[8]));
            Rooms.Add(new Room(9, "Místnost 9", "Jít do pravé místnosti", false, _ss.getEnemyArray()[9], new int[] { 8 }, _ss.getRaidArray()[9]));
            Rooms.Add(new Room(10, "Místnost 10", "Jít do levé místnosti", false, _ss.getEnemyArray()[10], new int[] { 8 }, _ss.getRaidArray()[10]));
            Rooms.Add(new Room(11, "Lampa právě přestala svítit. Na pravé straně jsou dveře, stejně tak, jako před tebou.", "Jít do levých dveří (předsíň)", false, _ss.getEnemyArray()[11], new int[] { 1, 12, 13 }, _ss.getRaidArray()[11]));
            Rooms.Add(new Room(12, "Místnost 12", "Jít do pravých dveří (secret)", false, _ss.getEnemyArray()[12], new int[] { 11 }, _ss.getRaidArray()[12]));
            Rooms.Add(new Room(13, "Místnost 13", "Pokračovat do levých dveří", false, _ss.getEnemyArray()[13], new int[] { 11 }, _ss.getRaidArray()[13]));
            Rooms.Add(new Room(14, "K odemčení dveří potřebuješ klíč!", "Pokusit se odemknout dveře", false, false, new int[] { 0 }, _ss.getRaidArray()[14]));      //GAME OVER
            Rooms[(int)_ss.getKeyLocation()].containsKey = true;
        }

    }
}

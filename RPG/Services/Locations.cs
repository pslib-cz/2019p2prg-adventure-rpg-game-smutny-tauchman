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
            Rooms.Add(new Room(0, "Jsi na začátku hrůzyplné chodby. Světla jsou zhasnutá, jen v dálce visí za několik drátů lustr, který mírně problikává. Na konci chodby vidíš nějakou osobu. S dalším probliknutím světla je ale pryč. Ocelové dveře na svobodu, které máš za zády, jsou zamčené. Pokus se najít klíč.", "Jít na začátek chodby", new int[] { 1, 14 }, false, true));             //START
            Rooms.Add(new Room(1, "Pokračuješ dále v chodbě. Po své pravé ruce vidíš zavřené, avšak nezamčené, dveře. Nalevo jsou pootevřené děravé dveře, za nimiž vidíš slabé světlo z rozbité lampy. Rovně pokračuje temná chodba.", "Jít do přední části chodby", new int[] { 0, 2, 5, 11 }));
            Rooms.Add(new Room(2, "Zatáhl jsi za studenou kliku pravých dveří. Stojíš v menší předsíni, která se dále větví na dvě místnosti osvícené lampou.", "Jít do pravých (předsíň). ", new int[] { 1, 3, 4 }));
            Rooms.Add(new Room(3, "Poté, co jsi vkročil do této místnosti, jsi jako první uviděl lůžko od krve. Blikalo tam lehce světlo. Místnost alespoň stála za prohledání.", "Pokračovat z předsíně do prvních dveří.", new int[] { 2 }));
            Rooms.Add(new Room(4, "Vcházíš do velice studené místnosti. Je tu otevřené staré okno. Podíváš se ven, ale zjistíš, že na zem přes mlhu ani nedohlédneš. Sešplnat dolů nepřipadá v úvahu.", "Pokračovat z předsíně do druhých dveří", new int[] { 2 }));
            Rooms.Add(new Room(5, "Pokračuješ dále v chodbě. Po pravé ruce máš průchod do další místnosti.", "Jít do prostřední části chodby", new int[] { 1, 6, 8 }));
            Rooms.Add(new Room(6, "Nyní jsi v průchodu. Za zády máš chodbu a před sebou další místnost.", "Jít do průchodu", new int[] { 5, 7 }));
            Rooms.Add(new Room(7, "Prošel jsi průchodem až sem. Je tu stůl a v něm několik zavřených šupíků. Jinak nic zajímavého.", "Jít do zadní místnosti", new int[] { 6 }));
            Rooms.Add(new Room(8, "Došel jsi na konec chodby. Na obou stranách jsou dveře.", "Jít do zadní části chodby", new int[] { 5, 9, 10 }));
            Rooms.Add(new Room(9, "Na stěně vidíš krví nakresleného krvavého smajlíka. Jen se tu rychle porozhlédneš a rychle z této místnosti mizíš.", "Jít do pravé místnosti", new int[] { 8 }));
            Rooms.Add(new Room(10, "V této místnosti určitě někdo nedávno byl. Na podlaze totiž vidíš stopy od bahna.", "Jít do levé místnosti", new int[] { 8 }));
            Rooms.Add(new Room(11, "Na pravé straně jsou dveře, stejně tak, jako před tebou.", "Jít do levých dveří (předsíň)", new int[] { 1, 12, 13 }));
            Rooms.Add(new Room(12, "Vstupuješ do temné místnosti. Vypadá to, že odsud někdo všechen nábytek odnesl. Prakticky nic tu není. Jen stará prkna a hromádky suti.", "Pokračovat do levých dveří", new int[] { 11 }));
            Rooms.Add(new Room(13, "Jdeš do pravých dveří. Na zaprášené zemi ve světle rozbité lampy leží kus potrhaného papíru. Při bližším pohledu zjišťuješ, že je to stará mapa!", "Jít do pravých dveří", new int[] { 11 }, false, false, false, true)); //SECRET
            Rooms.Add(new Room(14, "K odemčení dveří potřebuješ klíč!", "Pokusit se odemknout dveře", new int[] { 0 }, false));      //GAME OVER
            _ss.setKeyLocation(rnd.Next(2, Rooms.Count - 1));
            Rooms[(int)_ss.getKeyLocation()].containsKey = true;
            _ss.setLocations(Rooms);           
        }

    }
}

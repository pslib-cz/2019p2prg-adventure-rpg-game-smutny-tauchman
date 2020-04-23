using Adventure2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure2020.Services
{
    public class LocationProvider : ILocationProvider
    {
        private Dictionary<int, ILocation> _locations;
        private List<Connection> _map;

        public LocationProvider()
        {
            _locations = new Dictionary<int, ILocation>();
            _map = new List<Connection>();
            _locations.Add(0, new Location { Description = "Jsi na začátku chodby. Světla jsou zhasnutá, jen v dálce visí za několik drátů lustr, který mírně problikává. Na konci chodby vidíš nějakou osobu. S dalším probliknutím světla je ale pryč. Dveře na svobodu, které máš za zády, jsou zamčené. Pokus se najít klíč." }); // Game starts
            _locations.Add(1, new Location { Description = "Pokračuješ dále v chodbě. Po své pravé ruce vidíš zavřené, avšak nezamčené, dveře. Nalevo jsou pootevřené dveře, za nimiž vidíš slabé světlo z rozbité lampy. Rovně pokračuje temná chodba." });
            _locations.Add(2, new Location { Description = "Zatáhl jsi za kliku pravých dveří. Stojíš v menší předsíni, která se dále větví na dvě místnosti." });
            _locations.Add(3, new Location { Description = "Místnost 3" });
            _locations.Add(4, new Location { Description = "Místnost 4" });
            _locations.Add(5, new Location { Description = "Pokračuješ dále v chodbě. Po pravé ruce máš průchod do další místnosti." });
            _locations.Add(6, new Location { Description = "Nyní jsi v průchodu. Za zády máš chodbu a před sebou další místnost." });
            _locations.Add(7, new Location { Description = "Místnost 7" }); // game over
            _locations.Add(8, new Location { Description = "Došel jsi na konec chodby. Na obou stranách jsou dveře." });
            _locations.Add(9, new Location { Description = "Místnost 9" });
            _locations.Add(10, new Location { Description = "Místnost 10" });
            _locations.Add(11, new Location { Description = "Lampa právě přestala svítit. Na pravé straně jsou dveře, stejně tak, jako před tebou." });
            _locations.Add(12, new Location { Description = "Místnost 12" });
            _locations.Add(13, new Location { Description = "Místnost 13" });
            _locations.Add(14, new Location { Description = "Odemykáš dveře..... Zámek zaskřípal a dveře se otevřely. Jsi volný!" });


            _map.Add(new Connection(0, 1, "Pokračovat do chodby"));
            _map.Add(new Connection(1, 2, "Jít do pravého pokoje"));
            _map.Add(new Connection(2, 3, "Jít do první místnosti"));
            _map.Add(new Connection(2, 4, "Jít do druhé místnosti"));
            _map.Add(new Connection(1, 5, "Pokračovat do chodby"));
            _map.Add(new Connection(5, 6, "Jít do pravého pokoje"));
            _map.Add(new Connection(6, 7, "Jít do první místnosti"));
            _map.Add(new Connection(5, 8, "Pokračovat na konec chodby"));
            _map.Add(new Connection(8, 9, "Jít do pravého pokoje"));
            _map.Add(new Connection(8, 10, "Jít do levého pokoje"));
            _map.Add(new Connection(1, 11, "Jít do levého pokoje"));
            _map.Add(new Connection(11, 12, "Jít do prvního pokoje"));
            _map.Add(new Connection(11, 13, "Jít do druhého pokoje"));
            _map.Add(new Connection(0, 14, "Otevřít dveře na svobodu", (gs) => { if (gs.key == true) return true; return false; }));

        }

        public bool ExistsLocation(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Connection> GetConnectionsFrom(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Connection> GetConnectionsTo(int id)
        {
            throw new NotImplementedException();
        }

        public ILocation GetLocation(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsNavigationLegit(int from, int to, GameState state)
        {
            throw new NotImplementedException();
        }
    }
}

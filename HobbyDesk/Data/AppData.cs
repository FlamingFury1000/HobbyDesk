using HobbyDesk.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyDesk.Data
{
    /// <summary>
    /// Uchovává vešekerá data, aby byla konzistentní a snadno přístupná z různých částí aplikace.
    /// </summary>
    public class AppData
    {
        public List<Produkt> Produkty { get; set; } = new List<Produkt>();
        public List<Kategorie> Kategorie { get; set; } = new List<Kategorie>();
        public List<Vyrobce> Vyrobci { get; set; } = new List<Vyrobce>();
    }
}

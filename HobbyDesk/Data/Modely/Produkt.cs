using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyDesk.Data
{
    /// <summary>
    /// Produkt je hlavním objektem, který reprezentuje jednotlivé položky v databázi.
    /// </summary>
    public class Produkt
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public int Pocet { get; set; }
        public int IdKategorie { get; set; }
        public int IdVyrobce { get; set; }
        public string CestaObrazku { get; set; } = "default.png";

        public Produkt() { }
        public Produkt(int id, string nazev, int pocet, int idKategorie, int idVyrobce, string cestaObrazku)
        {
            Id = id;
            Nazev = nazev;
            Pocet = pocet;
            IdKategorie = idKategorie;
            IdVyrobce = idVyrobce;
            CestaObrazku = cestaObrazku;
        }

        public override string ToString()
        {
            return $"{Nazev} (Kategorie: {IdKategorie}, Výrobce: {IdVyrobce}, Počet: {Pocet})";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyDesk.Data
{
    /// <summary>
    /// Kategorie představuje skupinu, do které mohou být produkty zařazeny. Je to nedílná součást produktů.
    /// </summary>
    public class Kategorie
    {
        public int Id { get; set; }
        public string Nazev { get; set; }

        public Kategorie() { }

        Kategorie(int id, string nazev)
        {
            this.Id = id;
            this.Nazev = nazev;
        }

        public override string ToString()
        {
            return Nazev;
        }
    }
}

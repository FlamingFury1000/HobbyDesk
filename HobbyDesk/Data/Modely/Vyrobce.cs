using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyDesk.Data
{
    /// <summary>
    /// Výrobce představuje skupinu, která vyrábí produkty. Je to nedílná součást produktů.
    /// </summary>
    public class Vyrobce
    {
        public int Id { get; set; }
        public string Nazev { get; set; }

        public Vyrobce() { }

        public Vyrobce(int id, string nazev)
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

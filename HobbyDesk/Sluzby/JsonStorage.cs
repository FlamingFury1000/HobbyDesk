using HobbyDesk.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HobbyDesk.Sluzby
{
    /// <summary>
    /// Služba, která umožňuje načítat a ukládat data do JSON za pomocí AppData.
    /// </summary>
    public class JsonStorage
    {
        private string cesta = "data.json";

        /// <summary>
        /// Metoda pro načítání dat z JSON souboru. Pokud soubor neexistuje, vrátí prázdný AppData objekt.
        /// </summary>
        /// <returns>Data v podobě AppData</returns>
        public AppData Nacti()
        {
            if (!File.Exists(cesta))
            {
                return new AppData();
            }
            string json = File.ReadAllText(cesta);
            return JsonSerializer.Deserialize<AppData>(json) ?? new AppData();
        }

        /// <summary>
        /// Metoda pro ukládání dat do JSON souboru. Přijímá AppData objekt a serializuje ho do JSON formátu, který následně uloží do souboru.
        /// </summary>
        /// <param name="data"></param>
        public void Uloz(AppData data)
        {
            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(cesta, json);
        }
    }
}

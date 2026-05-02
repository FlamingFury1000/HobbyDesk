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
        private string vychoziCesta = "data.json";

        /// <summary>
        /// Metoda pro načítání dat z výchozího JSON souboru.
        /// </summary>
        /// <returns>Data v podobě AppData</returns>
        public AppData Nacti()
        {
            return NactiZeSouboru(vychoziCesta);
        }

        /// <summary>
        /// Metoda pro uložení dat do výchozího JSON souboru.
        /// </summary>
        /// <param name="data">Data, která mají být uložena</param>
        public void Uloz(AppData data)
        {
            UlozDoSouboru(vychoziCesta, data);
        }

        /// <summary>
        /// Metoda pro načítání dat z JSON souboru. Pokud soubor neexistuje, vrátí prázdný AppData objekt.
        /// </summary>
        /// <param name="cesta">Cesta k souboru, ze kterého se data načítají</param>
        /// <returns>Data v podobě AppData</returns>
        public AppData NactiZeSouboru(string cesta)
        {
            // Pokud soubor neexistuje, vrátí prázdný AppData objekt
            if (!File.Exists(cesta))
            {
                return new AppData();
            }

            // Načte obsah souboru
            string json = File.ReadAllText(cesta);

            // Deserializuje JSON do AppData objektu. Pokud deserializace selže, vrátí prázdný AppData objekt.
            return JsonSerializer.Deserialize<AppData>(json) ?? new AppData();
        }

        /// <summary>
        /// Metoda pro ukládání dat do JSON souboru. Přijímá AppData objekt a serializuje ho do JSON formátu, který následně uloží do souboru.
        /// </summary>
        /// <param name="data">Data, která mají být uložena</param>
        /// <param name="cesta">Cesta k souboru, kam se data uloží</param>
        public void UlozDoSouboru(string cesta, AppData data)
        {
            // Serializuje AppData objekt do JSON formátu s odsazením pro lepší čitelnost
            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            // Uloží JSON do souboru
            File.WriteAllText(cesta, json);
        }
    }
}

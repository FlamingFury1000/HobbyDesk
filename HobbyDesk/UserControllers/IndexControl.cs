using HobbyDesk.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HobbyDesk
{
    public partial class IndexControl : UserControl
    {
        public IndexControl()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Metoda, která aktualizuje grafy a labely na domovské stránce.
        /// </summary>
        /// <param name="appData">Data aplikace obsahující produkty, kategorie a výrobce.</param>
        public void AktualizujGrafy(AppData appData)
        {
            // Pokud data neexistují, nic nedělej.
            if (appData == null)
            {
                return;
            }

            // Aktualizuj počet produktů a grafy podle kategorií a výrobců.
            labelPocetProduktu.Text = $"Aktuální počet produktů:\n{appData.Produkty.Count}";
            AktualizujKategorieGraf(appData);
            labelPocetKategorii.Text = $"{appData.Kategorie.Count}";
            AktualizujVyrobciGraf(appData);
            labelPocetVyrobcu.Text = $"{appData.Vyrobci.Count}";
        }

        /// <summary>
        /// Metoda, která aktualizuje graf kategorií na domovské stránce.
        /// </summary>
        /// <param name="appData">Data aplikace obsahující produkty, kategorie a výrobce.</param>
        private void AktualizujKategorieGraf(AppData appData)
        {
            // Vymaž všechny body grafu.
            chartKategorie.Series[0].Points.Clear();

            // Seskup všechny produkty podle jejich kategorie a spočítej počet produktů v každé kategorii.
            var data = appData.Produkty
                .GroupBy(produkt => produkt.IdKategorie)
                .Select(skupina => new
                {
                    IdKategorie = skupina.Key,
                    Pocet = skupina.Count()
                })
                .OrderByDescending(prvek => prvek.Pocet)
                .ToList();

            // Zobraz pouze top 5 kategorií
            int top = 5;

            // Vlož do proměnné top 5 kategorií s největším počtem produktů.
            var topKategorie = data.Take(top).ToList();
            // Spočítej počet produktů v ostatních kategoriích.
            var ostatniKategorie = data.Skip(top).Sum(prvek => prvek.Pocet);

            // Pro každou kategorii v top 5 kategorií
            foreach (var item in topKategorie)
            {
                // Najdi název kategorie podle jejího ID. Pokud není nalezen, použij "Neznámá".
                string nazevKategorie = appData.Kategorie
                    .FirstOrDefault(kategorie => kategorie.Id == item.IdKategorie)?.Nazev ?? "Neznámá";

                // Přidej bod do grafu s názvem kategorie a počtem produktů v této kategorii.
                chartKategorie.Series[0].Points.AddXY(nazevKategorie, item.Pocet);
            }

            // Pokud existují produkty v ostatních kategoriích
            if (ostatniKategorie > 0)
            {
                // Přidej bod do grafu pro ostatní kategorie s celkovým počtem produktů v těchto kategoriích.
                chartKategorie.Series[0].Points.AddXY("Ostatní", ostatniKategorie);
            }
        }

        /// <summary>
        /// Metoda, která aktualizuje graf výrobců na domovské stránce.
        /// </summary>
        /// <param name="appData">Data aplikace obsahující produkty, kategorie a výrobce.</param>
        private void AktualizujVyrobciGraf(AppData appData)
        {
            // Vymaž všechny body grafu.
            chartVyrobci.Series[0].Points.Clear();

            // Seskup všechny produkty podle jejich výrobce a spočítej počet produktů pro každého výrobce.
            var data = appData.Produkty
                .GroupBy(produkt => produkt.IdVyrobce)
                .Select(skupina => new
                {
                    IdVyrobce = skupina.Key,
                    Pocet = skupina.Count()
                })
                .OrderByDescending(x => x.Pocet)
                .ToList();

            // Zobraz pouze top 5 výrobců
            int top = 5;

            // Vlož do proměnné top 5 výrobců s největším počtem produktů.
            var topVyrobci = data.Take(top).ToList();
            // Spočítej počet produktů u ostatních výrobců.
            var ostatniVyrobci = data.Skip(top).Sum(prvek => prvek.Pocet);

            // Pro každého výrobce v top 5 výrobců
            foreach (var item in topVyrobci)
            {
                // Najdi název výrobce podle jeho ID. Pokud není nalezen, použij "Neznámý".
                string nazevVyrobce = appData.Vyrobci
                    .FirstOrDefault(vyrobce => vyrobce.Id == item.IdVyrobce)?.Nazev ?? "Neznámý";

                // Přidej bod do grafu s názvem výrobce a počtem produktů od tohoto výrobce.
                chartVyrobci.Series[0].Points.AddXY(nazevVyrobce, item.Pocet);
            }

            // Pokud existují produkty od ostatních výrobců
            if (ostatniVyrobci > 0)
            {
                // Přidej bod do grafu pro ostatní výrobce s celkovým počtem produktů od těchto výrobců.
                chartVyrobci.Series[0].Points.AddXY("Ostatní", ostatniVyrobci);
            }
        }
    }
}

using HobbyDesk.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HobbyDesk.UserControllers
{
    /// <summary>
    /// UserControl, který zobrazuje seznam produktů v ListView.
    /// </summary>
    public partial class SeznamControl : UserControl
    {
        private AppData appData;
        private List<Produkt> filtrovaneProdukty;
        ImageList imageList = new ImageList();

        public SeznamControl(AppData appData)
        {
            InitializeComponent();
            // Přiřaď appData z Form1 do této třídy a odkaž na produkty, které se budou zobrazovat v ListView.
            this.appData = appData;
            filtrovaneProdukty = appData.Produkty;
            listViewSeznam.Columns.Clear();
            // Přidej sloupce do ListView pro zobrazení názvu produktu, kategorie a výrobce. První column je vyhrazen pro obrázek.
            listViewSeznam.Columns.Add("", 70);
            listViewSeznam.Columns.Add("Název", 200);
            listViewSeznam.Columns.Add("Kategorie", 120);
            listViewSeznam.Columns.Add("Výrobce", 120);
            // Nastav zobrazení ListView na Details, aby se zobrazily sloupce, a povolí výběr celých řádků.
            listViewSeznam.View = View.Details;
            listViewSeznam.FullRowSelect = true;
            // Nastav ImageList pro ListView a definuj velikost obrázků.
            imageList.ImageSize = new Size(64, 64);
            listViewSeznam.SmallImageList = imageList;
            listViewSeznam.LargeImageList = imageList;

            aktualizujSeznam();
        }

        private void aktualizujSeznam()
        {
            listViewSeznam.Items.Clear();
            imageList.Images.Clear();

            foreach (Produkt produkt in filtrovaneProdukty)
            {
                // Přiřaď k ID kategorii název kategorie
                string nazevKategorie = "";
                foreach (Kategorie kategorie in appData.Kategorie)
                {
                    if (kategorie.Id == produkt.IdKategorie)
                    {
                        nazevKategorie = kategorie.Nazev;
                        break;
                    }
                }

                // Přiřaď k ID výrobce název výrobce
                string nazevVyrobce = "";
                foreach (Vyrobce vyrobce in appData.Vyrobci)
                {
                    if (vyrobce.Id == produkt.IdVyrobce)
                    {
                        nazevVyrobce = vyrobce.Nazev;
                        break;
                    }
                }

                // Přiřaď k produktu cestu k obrázku, pokud není prázdná, jinak použij výchozí obrázek.
                string cesta = produkt.CestaObrazku;

                // Pokud cesta k obrázku není prázdná, načti obrázek do ImageList a přiřaď ho k ListViewItem.
                if (string.IsNullOrEmpty(cesta) || !File.Exists(cesta))
                {
                    cesta = "Obrazky/default.png";
                }

                // Načti obrázek a přidej ho do ImageList s klíčem
                Image obrazek = Image.FromFile(cesta);
                string klic = produkt.Id.ToString();
                imageList.Images.Add(klic, obrazek);

                // Vytvoř item a přiřaď mu veškeré potřebné informace
                ListViewItem item = new ListViewItem("");
                item.SubItems.Add(produkt.Nazev);
                item.SubItems.Add(nazevKategorie);
                item.SubItems.Add(nazevVyrobce);
                item.Tag = produkt;
                item.ImageKey = klic;
                listViewSeznam.Items.Add(item);
            }
        }
    }
}

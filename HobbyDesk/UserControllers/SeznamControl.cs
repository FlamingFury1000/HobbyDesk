using HobbyDesk.Data;
using HobbyDesk.Forms;
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
        private bool zobrazovatIkony;

        public SeznamControl(AppData appData)
        {
            InitializeComponent();

            // Povol zobrazení ikon pro list.
            zobrazovatIkony = true;

            // Inicialiuje event handler pro dynamickou změnu velikosti ListView.
            ListViewSeznamResize(null, null);

            // Přiřaď appData z Form1 do této třídy a odkaž na produkty, které se budou zobrazovat v ListView.
            this.appData = appData;
            filtrovaneProdukty = appData.Produkty;
            listViewSeznam.Columns.Clear();

            // Zavolej metodu která nastaví sloupce v ListView podle aktuálního stavu zobrazování ikon.
            NastavSloupce();

            // Přidej možnosti zobrazení do ComboBoxu pro změnu zobrazení ListView.
            comboBoxZobrazeni.Items.Add("Tabulka");
            comboBoxZobrazeni.Items.Add("Dlaždice");
            comboBoxZobrazeni.Items.Add("Velké ikony");
            comboBoxZobrazeni.SelectedIndex = 0;

            // Nastav ImageList pro ListView a definuj velikost obrázků. Také nastav barevnou hloubku.
            imageList.ImageSize = new Size(64, 64);
            imageList.ColorDepth = ColorDepth.Depth32Bit;

            // SmallImageList = Detail | LargeImageList = Tile, LargeIcon
            listViewSeznam.SmallImageList = imageList;
            listViewSeznam.LargeImageList = imageList;

            AktualizujSeznam();
        }

        private void NastavSloupce()
        {
            // Vyčisti všechny sloupce v ListView
            listViewSeznam.Columns.Clear();

            // Pokud je checkbox pro zobrazení ikon zaškrtnutý, přidej první sloupec pro zobrazení ikon.
            if (zobrazovatIkony == true)
            {
                listViewSeznam.Columns.Add("", 70);
            }

            // Přidej sloupce do ListView pro zobrazení věskerých parametrů produktu.
            listViewSeznam.Columns.Add("Název", 200);
            listViewSeznam.Columns.Add("Počet", 70);
            listViewSeznam.Columns.Add("Kategorie", 120);
            listViewSeznam.Columns.Add("Výrobce", 120);
            listViewSeznam.Columns.Add("ID", 50);
        }

        /// <summary>
        /// Při volání aktualizuje seznam produktů v ListView dle aktuálního stavu filtrovaneProdukty.
        /// </summary>
        private void AktualizujSeznam()
        {
            // Všechny položky a obrázky v ListView nejprve vyčisti.
            listViewSeznam.Items.Clear();
            imageList.Images.Clear();

            foreach (Produkt produkt in filtrovaneProdukty)
            {
                // Přiřaď k ID kategorii název kategorie.
                string nazevKategorie = "";
                foreach (Kategorie kategorie in appData.Kategorie)
                {
                    if (kategorie.Id == produkt.IdKategorie)
                    {
                        nazevKategorie = kategorie.Nazev;
                        break;
                    }
                }

                // Přiřaď k ID výrobce název výrobce.
                string nazevVyrobce = "";
                foreach (Vyrobce vyrobce in appData.Vyrobci)
                {
                    if (vyrobce.Id == produkt.IdVyrobce)
                    {
                        nazevVyrobce = vyrobce.Nazev;
                        break;
                    }
                }

                // Ulož cestu k obrázku z produktu. Může být null.
                string cesta = produkt.CestaObrazku;

                // Pokud cesta k obrázku je prázdná, nebo soubor neexistuje, použij defaultní obrázek.
                if (string.IsNullOrEmpty(cesta) || !File.Exists(cesta))
                {
                    cesta = "Obrazky/default.png";
                }

                // Načti obrázek a a pokud je checkbox pro zobrazení ikon zaškrtnutý, přidej ho do ImageListu s klíčem.
                Image obrazek = Image.FromFile(cesta);
                string klic = produkt.Id.ToString();

                if (zobrazovatIkony == true)
                {
                    imageList.Images.Add(klic, obrazek);
                }

                // Vytvoř item a přiřaď mu veškeré potřebné informace
                ListViewItem item;

                // Pokud je zobrazení nastaveno na "Tabulka", přidej všechny parametry jako subitems bez popisků.
                if (listViewSeznam.View == View.Details)
                {
                    // Pokud je checkbox pro zobrazení ikon zaškrtnutý, nastav první subitem jako prázdný pro zobrazení ikony.
                    if (zobrazovatIkony == true)
                    {
                        item = new ListViewItem("");
                        item.SubItems.Add(produkt.Nazev);

                    }
                    // Jinak nastav první subitem jako název produktu.
                    else
                    {
                        item = new ListViewItem(produkt.Nazev);
                    }
                    item.SubItems.Add(produkt.Pocet.ToString());
                    item.SubItems.Add(nazevKategorie);
                    item.SubItems.Add(nazevVyrobce);
                    item.SubItems.Add(produkt.Id.ToString());
                }
                // Jinak přidej parametry jak subitems přímo i s popisky.
                else
                {
                    item = new ListViewItem(produkt.Nazev);

                    item.SubItems.Add("Počet: " + produkt.Pocet.ToString());
                    item.SubItems.Add("Kategorie: " + nazevKategorie);
                    item.SubItems.Add("Výrobce: " + nazevVyrobce);
                    item.SubItems.Add("ID: " + produkt.Id.ToString());
                }

                // Pokud je checkbox pro zobrazení ikon zaškrtnutý, přiřaď klíč obrázku k položce pro zobrazení ikony.
                if (zobrazovatIkony == true)
                {
                    item.ImageKey = klic;
                }

                // Přiřaď produkt jako Tag položky pro pozdější identifikaci.
                item.ToolTipText = $"Počet: {produkt.Pocet}\nKategorie: {nazevKategorie}\nVýrobce: {nazevVyrobce}";
                item.Tag = produkt;
                listViewSeznam.Items.Add(item);
            }
        }

        /// <summary>
        /// Řeší kliknutí na položku "Smazat" v kontextovém menu. Otevře tím dialog pro potvrzení smazání produktu.
        /// </summary>
        private void ToolStripMenuItemSmazat_Click(object sender, EventArgs e)
        {
            // Pokud ListView nemá žádné vybrané položky, neprováděj žádnou akci.
            if (listViewSeznam.SelectedItems.Count == 0)
            {
                return;
            }

            // Vyber vybranou položku.
            Produkt vybranyProdukt = (Produkt)listViewSeznam.SelectedItems[0].Tag;

            // Zobraz potvrzovací dialog pro smazání produktu.
            DialogResult dialogResult = MessageBox.Show($"Opravdu chcete smazat produkt '{vybranyProdukt.Nazev}'?", 
                "Potvrzení smazání", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning
            );

            // Pokud je odpověď dialogu ano, smaž produkt z appData a filtrovaných produktů a aktualizuj seznam.
            if ( dialogResult == DialogResult.Yes ) {
                appData.Produkty.Remove(vybranyProdukt);
                filtrovaneProdukty.Remove(vybranyProdukt);
                AktualizujSeznam();
            }
        }

        /// <summary>
        /// Řeší kliknutí na položku "Upravit" v kontextovém menu. Otevře tím formulář pro úpravu produktu.
        /// </summary>
        private void ToolStripMenuItemUpravitClick(object sender, EventArgs e)
        {
            // Pokud ListView nemá žádné vybrané položky, neprováděj žádnou akci.
            if (listViewSeznam.SelectedItems.Count == 0)
            {
                return;
            }

            // Vyber vybranou položku.
            Produkt vybranyProdukt = (Produkt)listViewSeznam.SelectedItems[0].Tag;

            // Otevři formulář pro úpravu produktu.
            UpravProduktForm upravProduktForm = new UpravProduktForm(vybranyProdukt, appData);
            if (upravProduktForm.ShowDialog() == DialogResult.OK)
            {
                AktualizujSeznam();
            }
        }

        /// <summary>
        /// Řeší dvojité pokliknutí na položku v ListView. Otevře tím formulář pro úpravu produktu.
        /// </summary>
        private void ListViewSeznamDoubleClick(object sender, EventArgs e)
        {
            // Pokud ListView nemá žádné sloupce, neupravuj jejich šířku.
            if (listViewSeznam.Columns.Count == 0)
            {
                return;
            }

            // Vyber vybranou položku.
            Produkt vybranyProdukt = (Produkt)listViewSeznam.SelectedItems[0].Tag;

            // Otevři formulář pro úpravu produktu.
            UpravProduktForm upravProduktForm = new UpravProduktForm(vybranyProdukt, appData);
            if (upravProduktForm.ShowDialog() == DialogResult.OK)
            {
                AktualizujSeznam();
            }
        }

        /// <summary>
        /// Dynamicky přizpůsobí šířku sloupců k šířce ListView
        /// </summary>
        private void ListViewSeznamResize(object sender, EventArgs e)
        {
            // Pokud ListView nemá žádné sloupce, neupravuj jejich šířku.
            if (listViewSeznam.Columns.Count == 0)
            {
                return;
            }

            // Získej aktuální šířku ListView.
            int sirka = listViewSeznam.ClientSize.Width;

            // Inicializuj proměnné pro výpočet šířky sloupců.
            int startIndex = 0;
            int odebrat = 0;

            // Pokud je checkbox pro zobrazení ikon zaškrtnutý, přidej pevnou šířku pro zobrazení ikon a posuň index pro ostatní sloupce.
            if (zobrazovatIkony == true)
            {
                // Pozor, pokud počet sloupců je menší než 6, něco se pokazilo, a nic neprováděj.
                if (listViewSeznam.Columns.Count < 6)
                {
                    return;
                }
                listViewSeznam.Columns[0].Width = 70;
                startIndex = 1;
                odebrat = 70;
            }

            // Odečti od celkové šířky pevnou šířku pro obrázky. Pokud je zbytek menší než 0, nastav ho na 0.
            int zbytek = sirka - odebrat;
            if (zbytek < 0)
            {
                zbytek = 0;
            }

            // Nastav šířku jednotlivých sloupců podle procentuálního rozdělení zbytku šířky.
            listViewSeznam.Columns[startIndex + 0].Width = (int)(zbytek * 0.40); // Název
            listViewSeznam.Columns[startIndex + 1].Width = (int)(zbytek * 0.10); // Počet
            listViewSeznam.Columns[startIndex + 2].Width = (int)(zbytek * 0.20); // Kategorie
            listViewSeznam.Columns[startIndex + 3].Width = (int)(zbytek * 0.20); // Výrobce
            listViewSeznam.Columns[startIndex + 4].Width = (int)(zbytek * 0.10); // ID
        }

        /// <summary>
        /// Zaměňuje filtrované Produkty za produkty, které obsahují hledaný text v názvu.
        /// </summary>
        private void TextBoxHledaniTextChanged(object sender, EventArgs e)
        {
            // Ulož hledaný text jako shodu pro hledání.
            string hledanyText = textBoxHledani.Text.ToLower();

            // Vyčisti filtrovaneProdukty a přidej produkty, které obsahují hledaný text v názvu.
            filtrovaneProdukty = new List<Produkt>();
            foreach (Produkt produkt in appData.Produkty)
            {
                if (produkt.Nazev != null && produkt.Nazev.ToLower().Contains(hledanyText))
                {
                    filtrovaneProdukty.Add(produkt);
                }
            }

            // Aktualizuj seznam v ListView podle nově filtrovaných produktů.
            AktualizujSeznam();
        }

        /// <summary>
        /// Znemožňuje uživateli měnit šířku sloupců.
        /// </summary>
        private void ListViewSeznamColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            // Zruš změnu šířky sloupce
            e.Cancel = true;
            // Nastav ji zpět na aktuální šířku, aby uživatel nemohl měnit šířku sloupců.
            e.NewWidth = listViewSeznam.Columns[e.ColumnIndex].Width;
        }

        private bool bylyIkonyListuZobrazeny = true;

        /// <summary>
        /// Mění způsob zobrazení položek v ListView podle výběru v ComboBoxu.
        /// </summary>
        private void ComboBoxZobrazeniSelectedIndexChanged(object sender, EventArgs e)
        {
            string vyber = comboBoxZobrazeni.SelectedItem.ToString();

            switch (vyber)
            {
                case "Tabulka":
                    listViewSeznam.View = View.Details;
                    checkBoxSeznamIkony.Enabled = true;
                    imageList.ImageSize = new Size(64, 64);
                    listViewSeznam.ShowItemToolTips = false;
                    if (bylyIkonyListuZobrazeny == true) {
                        zobrazovatIkony = true;
                    } else
                    {
                        checkBoxSeznamIkony.Checked = false;
                        zobrazovatIkony = false;
                    }
                    break;

                case "Dlaždice":
                    listViewSeznam.View = View.Tile;
                    checkBoxSeznamIkony.Enabled = false;
                    checkBoxSeznamIkony.Checked = true;
                    imageList.ImageSize = new Size(64, 64);
                    listViewSeznam.ShowItemToolTips = false;
                    zobrazovatIkony = true;
                    break;

                case "Velké ikony":
                    listViewSeznam.View = View.LargeIcon;
                    checkBoxSeznamIkony.Enabled = false;
                    checkBoxSeznamIkony.Checked = true;
                    imageList.ImageSize = new Size(96, 96);
                    listViewSeznam.ShowItemToolTips = true;
                    zobrazovatIkony = true;
                    break;
            }

            ZmenKrytiObrazku();
        }

        /// <summary>
        /// Změní stav zobrazování ikon podle zaškrtnutí CheckBoxu. Primární využití je v zobrazení "Tabulka".
        /// </summary>
        private void CheckBoxSeznamIkonyClick(object sender, EventArgs e)
        {
            zobrazovatIkony = checkBoxSeznamIkony.Checked;
            bylyIkonyListuZobrazeny = false;
            ZmenKrytiObrazku();
        }

        /// <summary>
        /// Převážně aktualizuje zobrazení ikon v ListView podle aktuálního stavu zobrazovatIkony.
        /// Pro správné fungování aktualizuje přepočítá sloupce a znovu načítá seznam, aby se změny projevily. 
        /// Také volá ListViewSeznamResize pro přizpůsobení šířky sloupců.
        /// </summary>
        private void ZmenKrytiObrazku()
        {
            // Aktualizuj zobrazení ikon v ListView podle aktuálního stavu zobrazovatIkony.
            AktualizaceKrytiObrazku(listViewSeznam.View);

            // Nastav sloupce znovu, aby se přizpůsobily změně zobrazení ikon.
            NastavSloupce();

            // Aktualizuj seznam v ListView, aby se změny projevily.
            AktualizujSeznam();

            // Přizpůsob šířku sloupců nové situaci.
            ListViewSeznamResize(null, null);
        }

        /// <summary>
        /// Pomocná metoda, která umožňuje aktualizovat zobrazení ikon v ListView bez ohledu na aktuální zobrazení.
        /// </summary>
        /// <param name="puvodniZobrazeni">Aktuální způsob zobrazení položek v ListView.</param>
        private void AktualizaceKrytiObrazku(View puvodniZobrazeni)
        {
            // Pokud mají být ikony zobrazovány, přiřaď ImageList k ListView pro zobrazení ikon.
            if (zobrazovatIkony)
            {
                listViewSeznam.SmallImageList = imageList;
                listViewSeznam.LargeImageList = imageList;
            }
            // Jinak odstraň ImageList z ListView, aby se ikony nezobrazovaly.
            else
            {
                listViewSeznam.SmallImageList = null;
                listViewSeznam.LargeImageList = null;
            }

            // Pro aktualizaci zobrazení ListView přepni do jiného zobrazení a zpět. (Trochu hack..)
            listViewSeznam.View = View.List;
            listViewSeznam.View = puvodniZobrazeni;
        }
    }
}

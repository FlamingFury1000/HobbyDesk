using HobbyDesk.Data;
using HobbyDesk.Enums;
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
        private string hledanyText = "";
        private int? vybranaKategorieId = null;
        private int? vybranyVyrobceId = null;
        private bool ignorujEventy = false;

        public SeznamControl(AppData appData)
        {
            InitializeComponent();

            // Přiřaď appData z Form1 do této třídy a odkaž na produkty, které se budou zobrazovat v ListView.
            this.appData = appData;
            filtrovaneProdukty = appData.Produkty;
            listViewSeznam.Columns.Clear();

            // Přidej kategorie do ComboBoxu pro filtrování podle kategorie.
            comboBoxKategorie.Items.Add("");
            comboBoxKategorie.Items.AddRange(appData.Kategorie.ToArray());
            comboBoxKategorie.DisplayMember = "Nazev";
            comboBoxKategorie.SelectedIndex = 0;

            // Přidej výrobce do ComboBoxu pro filtrování podle výrobce.
            comboBoxVyrobci.Items.Add("");
            comboBoxVyrobci.Items.AddRange(appData.Vyrobci.ToArray());
            comboBoxVyrobci.DisplayMember = "Nazev";
            comboBoxVyrobci.SelectedIndex = 0;

            // Přidej sloupce do ListView pro zobrazení věskerých parametrů produktu.
            listViewSeznam.Columns.Add("", 70);
            listViewSeznam.Columns.Add("Název", 200);
            listViewSeznam.Columns.Add("Počet", 70);
            listViewSeznam.Columns.Add("Kategorie", 120);
            listViewSeznam.Columns.Add("Výrobce", 120);
            listViewSeznam.Columns.Add("ID", 50);

            // Přidej možnosti zobrazení do ComboBoxu pro změnu zobrazení ListView.
            comboBoxZobrazeni.Items.Add("Tabulka");
            comboBoxZobrazeni.Items.Add("Dlaždice");
            comboBoxZobrazeni.Items.Add("Velké ikony");
            comboBoxZobrazeni.SelectedIndex = 0;

            // Nastav obrázkům barevnou hloubku.
            imageList.ColorDepth = ColorDepth.Depth32Bit;

            // SmallImageList = Detail | LargeImageList = Tile, LargeIcon
            listViewSeznam.SmallImageList = imageList;
            listViewSeznam.LargeImageList = imageList;

            AktualizujSeznam();
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

                // Přidej obrázek do ImageListu a přiřaď mu klíč podle ID produktu.
                Image obrazek = Image.FromFile(cesta);
                string klic = produkt.Id.ToString();
                imageList.Images.Add(klic, obrazek);

                // Vytvoř item a přiřaď mu veškeré potřebné informace
                ListViewItem item;

                // Pokud je zobrazení nastaveno na "Tabulka", přidej všechny parametry jako subitems bez popisků.
                if (listViewSeznam.View == View.Details)
                {
                    item = new ListViewItem("");

                    item.SubItems.Add(produkt.Nazev);
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

                // Přiřaď klíč obrázku k položce pro zobrazení ikony.
                item.ImageKey = klic;

                // Přiřaď produkt jako Tag položky pro pozdější identifikaci.
                item.ToolTipText = $"Počet: {produkt.Pocet}\nKategorie: {nazevKategorie}\nVýrobce: {nazevVyrobce}";
                item.Tag = produkt;
                listViewSeznam.Items.Add(item);
            }

            // Aktualizuj počet zobrazených položek v labelu.
            AktualizujPocetPolozekLabel();
        }

        /// <summary>
        /// Řeší kliknutí na položku "Smazat" v kontextovém menu. Otevře tím dialog pro potvrzení smazání produktu.
        /// </summary>
        private void ToolStripMenuItemSmazatClick(object sender, EventArgs e)
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
            if (dialogResult == DialogResult.Yes)
            {
                appData.Produkty.Remove(vybranyProdukt);
                filtrovaneProdukty.Remove(vybranyProdukt);

                // Nastav v Form1 příznak neuložených změn.
                ((Form1)this.ParentForm).NastavNeulozeneZmeny();

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
            upravProduktForm.Text = $"Úprava produktu - {vybranyProdukt.Nazev}";
            if (upravProduktForm.ShowDialog() == DialogResult.OK)
            {
                // Nastav v Form1 příznak neuložených změn.
                ((Form1)this.ParentForm).NastavNeulozeneZmeny();
                AktualizujSeznam();
            }
        }

        /// <summary>
        /// Řeší dvojité pokliknutí na položku v ListView. Otevře tím formulář pro úpravu produktu.
        /// </summary>
        private void ListViewSeznamDoubleClick(object sender, EventArgs e)
        {
            ToolStripMenuItemUpravitClick(sender, e);
        }

        /// <summary>
        /// Dynamicky přizpůsobí šířku sloupců k šířce ListView
        /// </summary>
        private void ListViewSeznamResize(object sender, EventArgs e)
        {
            // Dokud ListView nemá všechny potřebné sloupce, neprováděj žádnou akci.
            if (listViewSeznam.Columns.Count < 6)
            {
                return;
            }

            // Získej celkovou šířku ListView a definuj pevnou šířku pro sloupec s obrázkem.
            int sirkaListu = listViewSeznam.ClientSize.Width;
            listViewSeznam.Columns[0].Width = 70; // Obrázek

            // Odečti od celkové šířky pevnou šířku pro obrázky.
            int zbytek = sirkaListu - 70;

            // Nastav šířku jednotlivých sloupců podle procentuálního rozdělení zbytku šířky.
            listViewSeznam.Columns[1].Width = (int)(zbytek * 0.40); // Název
            listViewSeznam.Columns[2].Width = (int)(zbytek * 0.10); // Počet
            listViewSeznam.Columns[3].Width = (int)(zbytek * 0.20); // Kategorie
            listViewSeznam.Columns[4].Width = (int)(zbytek * 0.20); // Výrobce
            listViewSeznam.Columns[5].Width = (int)(zbytek * 0.10); // ID
        }

        /// <summary>
        /// Zaměňuje filtrované Produkty za produkty, které obsahují hledaný text v názvu.
        /// </summary>
        private void TextBoxHledaniTextChanged(object sender, EventArgs e)
        {
            // Zamezuje kaskádnímu volání eventů při resetování filtrů.
            if (ignorujEventy == true)
            {
                return;
            }

            // Ulož hledaný text jako shodu pro hledání.
            hledanyText = textBoxHledani.Text.ToLower();

            AplikujFiltry();
        }

        /// <summary>
        /// ComboBox pro výběr kategorie při změně výběru aktualizuje filtrované produkty s vybranou kategorií.
        /// </summary>
        private void ComboBoxKategorieSelectedIndexChanged(object sender, EventArgs e)
        {
            // Zamezuje kaskádnímu volání eventů při resetování filtrů.
            if (ignorujEventy == true)
            {
                return;
            }

            // Pokud je vybraná položka v ComboBoxu kategorie, ulož její ID jako shodu pro hledání. Jinak nic.
            if (comboBoxKategorie.SelectedItem is Kategorie kategorie)
            {
                vybranaKategorieId = kategorie.Id;

            }
            else
            {
                vybranaKategorieId = null;
            }
            AplikujFiltry();
        }

        /// <summary>
        /// ComboBox pro výběr výrobce při změně výběru aktualizuje filtrované produkty s vybraným výrobcem.
        /// </summary>
        private void ComboBoxVyrobciSelectedIndexChanged(object sender, EventArgs e)
        {
            // Zamezuje kaskádnímu volání eventů při resetování filtrů.
            if (ignorujEventy == true)
            {
                return;
            }

            // Pokud je vybraná položka v ComboBoxu výrobce, ulož její ID jako shodu pro hledání. Jinak nic.
            if (comboBoxVyrobci.SelectedItem is Vyrobce vyrobce)
            {
                vybranyVyrobceId = vyrobce.Id;
            }
            else
            {
                vybranyVyrobceId = null;
            }
            AplikujFiltry();
        }

        /// <summary>
        /// Applikuje aktuálně nastavené filtry na kolekci produktů a aktualizuje zobrazený seznam podle výsledků filtrování.
        /// </summary>
        private void AplikujFiltry()
        {
            List<Produkt> vysledek = new List<Produkt>();

            foreach (Produkt produkt in appData.Produkty)
            {
                bool odpovida = true;

                // Pokud je hledaný text neprázdný, zkontroluj, zda název produktu obsahuje hledaný text.
                if (!string.IsNullOrWhiteSpace(hledanyText))
                {
                    if (produkt.Nazev == null || !produkt.Nazev.ToLower().Contains(hledanyText.ToLower()))
                    {
                        odpovida = false;
                    }
                }

                // Pokud je vybraná kategorie, zkontroluj, zda ID kategorie produktu odpovídá vybrané kategorii.
                if (vybranaKategorieId.HasValue)
                {
                    if (produkt.IdKategorie != vybranaKategorieId.Value)
                    {
                        odpovida = false;
                    }
                }

                // Pokud je vybraný výrobce, zkontroluj, zda ID výrobce produktu odpovídá vybranému výrobci.
                if (vybranyVyrobceId.HasValue)
                {
                    if (produkt.IdVyrobce != vybranyVyrobceId.Value)
                    {
                        odpovida = false;
                    }
                }

                // Pokud produkt odpovídá všem aktivním filtrům, přidej ho do výsledku.
                if (odpovida)
                {
                    vysledek.Add(produkt);
                }
            }

            filtrovaneProdukty = vysledek;

            AktualizujSeznam();
        }

        /// <summary>
        /// Tlačítko, které po kliknutí kompletně resetuje všechny filtry.
        /// </summary>
        private void ButtonResetFiltryClick(object sender, EventArgs e)
        {
            // Uzamkni eventy, aby se při resetování filtrů nespouštěly zbytečně.
            ignorujEventy = true;

            // Kompletně resetuj všechny filtry na výchozí hodnoty.
            hledanyText = "";
            vybranaKategorieId = null;
            vybranyVyrobceId = null;

            comboBoxKategorie.SelectedIndex = 0;
            comboBoxVyrobci.SelectedIndex = 0;
            textBoxHledani.Text = "";

            // Znovu je odemkni, aby se eventy spouštěly normálně.
            ignorujEventy = false;

            AplikujFiltry();
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

        /// <summary>
        /// Mění způsob zobrazení položek v ListView podle výběru v ComboBoxu.
        /// </summary>
        private void ComboBoxZobrazeniSelectedIndexChanged(object sender, EventArgs e)
        {
            // Získej aktuální výběr z ComboBoxu pro zobrazení.
            string vyber = comboBoxZobrazeni.SelectedItem.ToString();

            switch (vyber)
            {
                case "Tabulka":
                    listViewSeznam.View = View.Details;
                    listViewSeznam.ShowItemToolTips = false;
                    imageList.ImageSize = new Size(64, 64);
                    break;
                case "Dlaždice":
                    listViewSeznam.View = View.Tile;
                    listViewSeznam.ShowItemToolTips = false;
                    imageList.ImageSize = new Size(64, 64);
                    break;

                case "Velké ikony":
                    listViewSeznam.View = View.LargeIcon;
                    imageList.ImageSize = new Size(64, 64);
                    listViewSeznam.ShowItemToolTips = true;
                    break;
            }
            AktualizujSeznam();
        }

        /// <summary>
        /// Otevře formulář pro přidání nového produktu.
        /// </summary>
        private void ButtonPridejClick(object sender, EventArgs e)
        {
            // Vytvoř nový produkt s defaultními hodnotami
            Produkt novyProdukt = new Produkt();
            novyProdukt.Pocet = 1;
            novyProdukt.IdKategorie = appData.Kategorie[0].Id;
            novyProdukt.IdVyrobce = appData.Vyrobci[0].Id;

            // Nastav mu nové ID (nejvyšší ID + 1)
            if (appData.Produkty.Count > 0)
            {
                novyProdukt.Id = appData.Produkty.Max(p => p.Id) + 1;
            }
            else
            {
                novyProdukt.Id = 1;
            }

            // Otevři formulář jako při editaci
            UpravProduktForm upravProduktForm = new UpravProduktForm(novyProdukt, appData);
            upravProduktForm.Text = "Přidat nový produkt";

            if (upravProduktForm.ShowDialog() == DialogResult.OK)
            {
                // Přidej produkt do databáze (kolekce)
                appData.Produkty.Add(novyProdukt);

                // Nastav v Form1 příznak neuložených změn.
                ((Form1)this.ParentForm).NastavNeulozeneZmeny();

                // Aktualizuj filtrování a seznam
                AplikujFiltry();
            }
        }

        /// <summary>
        /// Tlačítko, které zastupuje funkci "Upravit" z kontextového menu.
        /// </summary>
        private void ButtonUpravClick(object sender, EventArgs e)
        {
            ToolStripMenuItemUpravitClick(sender, e);
        }

        /// <summary>
        /// Tlačítko, které zastupuje funkci "Smazat" z kontextového menu.
        /// </summary>
        private void ButtonOdeberClick(object sender, EventArgs e)
        {
            ToolStripMenuItemSmazatClick(sender, e);
        }

        /// <summary>
        /// Tlačítko, které kompletně promaže všechny produkty z appData.
        /// </summary>
        private void buttonOdeberVseClick(object sender, EventArgs e)
        {
            // Pokud není žádný produkt k odebrání, zobraz informaci a neprováděj žádnou akci.
            if (appData.Produkty.Count == 0)
            {
                MessageBox.Show("Žádné produkty k odebrání.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Zobraz potvrzovací dialog pro smazání všech produktů.
            DialogResult result = MessageBox.Show(
                "Opravdu chcete smazat všechny produkty?\n Tato akce nelze vrátit zpět.",
                "Potvrzení smazání všech produktů",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // Pokud je odpověď dialogu ne, neprováděj žádnou akci.
            if (result == DialogResult.No)
            {
                return;
            }

            // Jinak smaž všechny produkty z appData a filtrovaných produktů a aktualizuj seznam.
            appData.Produkty.Clear();
            filtrovaneProdukty.Clear();

            // Nastav v Form1 příznak neuložených změn.
            ((Form1)this.ParentForm).NastavNeulozeneZmeny();

            ButtonResetFiltryClick(sender, e);
        }

        /// <summary>
        /// Dynamicky aktualizuje text v labely, který zobrazuje počet aktuálně zobrazených položek.
        /// </summary>
        private void AktualizujPocetPolozekLabel()
        {
            LabelPocetPrvku.Text = $"Aktuálně zobrazeno: {filtrovaneProdukty.Count} / {appData.Produkty.Count}";
        }

        /// <summary>
        /// Tlačítko, které otevře formulář pro správu kategorií. 
        /// </summary>
        private void ButtonEditKategorieClick(object sender, EventArgs e)
        {
            // Otevři formulář pro správu kategorií.
            SpravaFiltruForm form = new SpravaFiltruForm(appData, RezimFiltru.Kategorie);
            form.Owner = this.FindForm();
            form.ShowDialog();

            // Aktualizuj ComboBox pro kategorie a znovu aplikuj filtry.
            AktualizujComboBoxKategorie();
            AplikujFiltry();
        }

        /// <summary>
        /// Tlačítko, které otevře formulář pro správu výrobců.
        /// </summary>
        private void ButtonEditVyrobceClick(object sender, EventArgs e)
        {
            // Otevři formulář pro správu výrobců.
            SpravaFiltruForm form = new SpravaFiltruForm(appData, RezimFiltru.Vyrobce);
            form.Owner = this.FindForm();
            form.ShowDialog();

            // Aktualizuj ComboBox pro výrobce a znovu aplikuj filtry.
            AktualizujComboBoxVyrobci();
            AplikujFiltry();
        }

        /// <summary>
        /// Aktualizuje položky v ComboBoxu pro kategorie podle aktuálního stavu kategorií v appData.
        /// </summary>
        private void AktualizujComboBoxKategorie()
        {
            ignorujEventy = true;

            // Vymaž všechny položky v ComboBoxu a znovu je přidej z appData, aby se aktualizoval seznam kategorií.
            comboBoxKategorie.Items.Clear();
            comboBoxKategorie.Items.Add("");
            comboBoxKategorie.Items.AddRange(appData.Kategorie.ToArray());
            comboBoxKategorie.DisplayMember = "Nazev";
            comboBoxKategorie.SelectedIndex = 0;

            vybranaKategorieId = null;

            ignorujEventy = false;
        }

        /// <summary>
        /// Aktualizuje položky v ComboBoxu pro výrobce podle aktuálního stavu výrobců v appData.
        /// </summary>
        private void AktualizujComboBoxVyrobci()
        {
            ignorujEventy = true;

            // Vymaž všechny položky v ComboBoxu a znovu je přidej z appData, aby se aktualizoval seznam výrobců.
            comboBoxVyrobci.Items.Clear();
            comboBoxVyrobci.Items.Add("");
            comboBoxVyrobci.Items.AddRange(appData.Vyrobci.ToArray());
            comboBoxVyrobci.DisplayMember = "Nazev";
            comboBoxVyrobci.SelectedIndex = 0;

            vybranyVyrobceId = null;

            ignorujEventy = false;
        }
    }
}


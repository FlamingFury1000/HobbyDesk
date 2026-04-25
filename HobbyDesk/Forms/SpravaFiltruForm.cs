using HobbyDesk.Data;
using HobbyDesk.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HobbyDesk.Forms
{
    /// <summary>
    /// Formulář pro správu kategorií a výrobců, tedy obecně filtrů.
    /// </summary>
    public partial class SpravaFiltruForm : Form
    {
        private AppData appData;
        private RezimFiltru rezim;

        public SpravaFiltruForm(AppData appData, RezimFiltru rezim)
        {
            InitializeComponent();

            // Hack pro zvětšení výšky řádku v ListView, protože standardně je příliš malá a text se špatně čte.
            ImageList dummy = new ImageList();
            dummy.ImageSize = new Size(1, 24); // výška řádku
            listViewFiltry.SmallImageList = dummy;

            // Uložení reference na data a režim, ve kterém se formulář nachází (kategorie nebo výrobci).
            this.appData = appData;
            this.rezim = rezim;

            // Pokud je režim pro kategorie, nastaví název formuláře na "Správa Kategorií", jinak na "Správa Výrobců".
            if (rezim == RezimFiltru.Kategorie)
            {
                this.Text = "Správa Kategorií";
            } 
            else
            {
                this.Text = "Správa Výrobců";
            }

            // Nastavení sloupců ListView pro zobrazení názvu a ID kategorie/výrobce.
            listViewFiltry.Columns.Clear();
            listViewFiltry.Columns.Add("Název", 220);
            listViewFiltry.Columns.Add("ID", 50);

            // Načti data do ListView.
            AktualizujSeznam();
        }

        /// <summary>
        /// Aktualizuje ListView podle aktualního režimu (kategorie nebo výrobci)
        /// </summary>
        private void AktualizujSeznam()
        {
            listViewFiltry.Items.Clear();

            // Pokud je režim pro Kategorie.
            if (rezim == RezimFiltru.Kategorie)
            {
                // Pro každou kategorii v datech vytvoř nový ListViewItem a nastav mu správné hodnoty.
                foreach (Kategorie kategorie in appData.Kategorie)
                {
                    ListViewItem item = new ListViewItem(kategorie.Nazev);
                    item.SubItems.Add(kategorie.Id.ToString());
                    item.Tag = kategorie;
                    listViewFiltry.Items.Add(item);
                }
            }
            // Pokud je režim pro Výrobce.
            else
            {
                // Pro každého výrobce v datech vytvoř nový ListViewItem a nastav mu správné hodnoty.
                foreach (Vyrobce vyrobce in appData.Vyrobci)
                {
                    ListViewItem item = new ListViewItem(vyrobce.Nazev);
                    item.SubItems.Add(vyrobce.Id.ToString());
                    item.Tag = vyrobce;
                    listViewFiltry.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Tlačítko pro přidání nové kategorie nebo výrobce. 
        /// </summary>
        private void ButtonPridejClick(object sender, EventArgs e)
        {
            string titulek;

            // Rozhodni, jaký titulek použít pro formulář pro úpravu filtru.
            if (rezim == RezimFiltru.Kategorie)
            {
                titulek = "Přidat kategorii";
            }
            else
            {
                titulek = "Přidat výrobce";
            }

            // Otevři formulář pro úpravu filtru s prázdným názvem, protože přidáváme nový filtr.
            UpravFiltrForm form = new UpravFiltrForm(titulek, "");

            // Pokud uživatel potvrdí přidání.
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Pokud je režim pro Kategorie.
                if (rezim == RezimFiltru.Kategorie)
                {
                    int noveId;

                    // Pokud není žádná kategorie, začni ID od 1.
                    if (appData.Kategorie.Count == 0)
                    {
                        noveId = 1;
                    }
                    // Jinak začni ID od nejvyššího existujícího ID + 1.
                    else
                    {
                        noveId = appData.Kategorie.Max(k => k.Id) + 1;
                    }

                    // Vytvoř novou kategorii s novým ID a názvem z formuláře.
                    Kategorie nova = new Kategorie();
                    nova.Id = noveId;
                    nova.Nazev = form.NazevFiltru;

                    // Přidej novou kategorii do dat.
                    appData.Kategorie.Add(nova);
                }
                // Pokud je režim pro Výrobce.
                else
                {
                    int noveId;

                    // Pokud není žádný výrobce, začni ID od 1.
                    if (appData.Kategorie.Count == 0)
                    {
                        noveId = 1;
                    }
                    // Jinak začni ID od nejvyššího existujícího ID + 1.
                    else
                    {
                        noveId = appData.Vyrobci.Max(k => k.Id) + 1;
                    }

                    // Vytvoř nového výrobce s novým ID a názvem z formuláře.
                    Vyrobce novy = new Vyrobce();
                    novy.Id = noveId;
                    novy.Nazev = form.NazevFiltru;

                    // Přidej nového výrobce do dat.
                    appData.Vyrobci.Add(novy);
                }

                // Po přidání nové kategorie nebo výrobce aktualizuj seznam v ListView.
                AktualizujSeznam();
            }
        }

        /// <summary>
        /// Řeší kliknutí na položku "Upravit" v kontextovém menu. Otevře tím formulář pro úpravu filtru.
        /// </summary>
        private void ToolStripMenuItemUpravitClick(object sender, EventArgs e)
        {
            // Pokud není žádná položka vybraná, nedělej nic.
            if (listViewFiltry.SelectedItems.Count == 0)
            {
                return;
            }

            // Pokud je režim pro Kategorie.
            if (rezim == RezimFiltru.Kategorie)
            {
                // Získej vybranou kategorii z Tagu ListViewItemu.
                Kategorie kategorie = (Kategorie)listViewFiltry.SelectedItems[0].Tag;

                // Otevři formulář pro úpravu filtru s aktuálním názvem kategorie.
                UpravFiltrForm form = new UpravFiltrForm("Upravit kategorii", kategorie.Nazev);

                // Pokud uživatel potvrdí úpravu.
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Aktualizuj název kategorie podle názvu z formuláře.
                    kategorie.Nazev = form.NazevFiltru;
                    AktualizujSeznam();
                }
            }
            // Pokud je režim pro Výrobce.
            else
            {
                // Získej vybraného výrobce z Tagu ListViewItemu.
                Vyrobce vyrobce = (Vyrobce)listViewFiltry.SelectedItems[0].Tag;

                // Otevři formulář pro úpravu filtru s aktuálním názvem výrobce.
                UpravFiltrForm form = new UpravFiltrForm("Upravit výrobce", vyrobce.Nazev);

                // Pokud uživatel potvrdí úpravu.
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Aktualizuj název výrobce podle názvu z formuláře.
                    vyrobce.Nazev = form.NazevFiltru;
                    AktualizujSeznam();
                }
            }
        }

        /// <summary>
        /// Řeší kliknutí na položku "Smazat" v kontextovém menu. Otevře tím dialog pro potvrzení smazání filtru, nebo mazání odepře..
        /// </summary>
        private void ToolStripMenuItemSmazatClick(object sender, EventArgs e)
        {
            // Pokud není žádná položka vybraná, nedělej nic.
            if (listViewFiltry.SelectedItems.Count == 0)
            {
                return;
            }

            // Pokud je režim pro Kategorie.
            if (rezim == RezimFiltru.Kategorie)
            {
                // Získej vybranou kategorii z Tagu ListViewItemu.
                Kategorie kategorie = (Kategorie)listViewFiltry.SelectedItems[0].Tag;

                // Zkontroluj, jestli nějaký produkt používá tuto kategorii.
                bool pouzivaSe = appData.Produkty.Any(p => p.IdKategorie == kategorie.Id);

                // Pokud ano, zobraz chybovou zprávu a nedovol smazat kategorii.
                if (pouzivaSe == true)
                {
                    MessageBox.Show($"Nelze smazat kategorii '{kategorie.Nazev}', protože ji používá alespoň jeden produkt.", "Nelze smazat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Pokud kategorie není používána, zobraz dialog pro potvrzení smazání.
                DialogResult result = MessageBox.Show($"Opravdu chcete smazat kategorii '{kategorie.Nazev}'?", "Potvrzení smazání", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Pokud uživatel zvolí "Ne", nedělej nic.
                if (result == DialogResult.No)
                {
                    return;
                }

                // Pokud uživatel zvolí "Ano", smaž kategorii z dat.
                appData.Kategorie.Remove(kategorie);
            }
            else
            // Pokud je režim pro Výrobce.
            {
                // Získej vybraného výrobce z Tagu ListViewItemu.
                Vyrobce vyrobce = (Vyrobce)listViewFiltry.SelectedItems[0].Tag;

                // Zkontroluj, jestli nějaký produkt používá tohoto výrobce.
                bool pouzivaSe = appData.Produkty.Any(p => p.IdVyrobce == vyrobce.Id);

                // Pokud ano, zobraz chybovou zprávu a nedovol smazat výrobce.
                if (pouzivaSe == true) {
                    MessageBox.Show($"Nelze smazat výrobce '{vyrobce.Nazev}', protože ji používá alespoň jeden produkt.", "Nelze smazat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Pokud výrobce není používán, zobraz dialog pro potvrzení smazání.
                DialogResult result = MessageBox.Show($"Opravdu chcete smazat výrobce '{vyrobce.Nazev}'?", "Potvrzení smazání", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Pokud uživatel zvolí "Ne", nedělej nic.
                if (result == DialogResult.No)
                {
                    return;
                }

                // Pokud uživatel zvolí "Ano", smaž výrobce z dat.
                appData.Vyrobci.Remove(vyrobce);
            }

            // Po smazání kategorie nebo výrobce aktualizuj seznam v ListView.
            AktualizujSeznam();
        }

        /// <summary>
        /// Řeší dvojité pokliknutí na položku v ListView. Otevře tím formulář pro úpravu filtru.
        /// </summary>
        private void ListViewFiltryMouseDoubleClick(object sender, MouseEventArgs e)
        {
            ToolStripMenuItemUpravitClick(sender, e);
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
        /// Tlačítko, které zavře tento formulář a vrátí uživatele zpět na hlavní obrazovku.
        /// </summary>
        private void ButtonZavriClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace HobbyDesk.Forms
{
    /// <summary>
    /// Form, který umožňuje upravovat existující produkt.
    /// </summary>
    public partial class UpravProduktForm : Form
    {
        private Produkt produkt;
        private AppData appData;

        public UpravProduktForm(Produkt produkt, AppData appData)
        {
            InitializeComponent();

            this.produkt = produkt;
            this.appData = appData;

            // Naplnění kategorii do comboBoxu.
            comboBoxKategorie.DataSource = appData.Kategorie;
            comboBoxKategorie.DisplayMember = "Nazev";
            comboBoxKategorie.ValueMember = "Id";

            // Naplnění výrobců do comboBoxu.
            comboBoxVyrobce.DataSource = appData.Vyrobci;
            comboBoxVyrobce.DisplayMember = "Nazev";
            comboBoxVyrobce.ValueMember = "Id";

            // Načtení hodnot produktu do polí formuláře.
            textBoxNazev.Text = produkt.Nazev;
            numericUpDownPocet.Value = produkt.Pocet;
            numericUpDownID.Value = produkt.Id;

            comboBoxKategorie.SelectedValue = produkt.IdKategorie;
            comboBoxVyrobce.SelectedValue = produkt.IdVyrobce;

            NactiObrazek();
        }

        /// <summary>
        /// Načte obrázek produktu do PictureBoxu. Pokud cesta k obrázku není validní, načte defaultní obrázek.
        /// </summary>
        private void NactiObrazek()
        {
            // Ulož cestu k obrázku z produktu. Může být null.
            string cesta = produkt.CestaObrazku;

            // Pokud cesta k obrázku je prázdná, nebo soubor neexistuje, použij defaultní obrázek.
            if (string.IsNullOrEmpty(cesta) || !File.Exists(cesta))
            {
                cesta = "Obrazky/default.png";
            }

            // Načti obrázek a zobraz ho v PictureBoxu.
            pictureBoxObrazek.Image = Image.FromFile(cesta);
            pictureBoxObrazek.SizeMode = PictureBoxSizeMode.Zoom;
        }

        /// <summary>
        /// Řeší kliknutí na tlačítko pro výběr obrázku. Otevře dialog pro výběr souboru, kde uživatel může vybrat nový obrázek pro produkt.
        /// </summary>
        private void ButtonVyberObrazek_Click(object sender, EventArgs e)
        {
            // Definuj filter pro OpenFileDialog, aby uživatel mohl vybírat pouze obrázky platného formátu.
            openFileDialog1.Filter = "Obrázky (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Ulož cestu k vybranému obrázku do produktu a zobrat nový obrázek v PictureBoxu.
                produkt.CestaObrazku = openFileDialog1.FileName;
                NactiObrazek();
            }
        }

        /// <summary>
        /// Řeší kliknutí na tlačítko pro zrušení obrázku. Ruší produktu přiřazenou cestu k obrázku, tedy produkt bude zobrazen s defaultním obrázkem.
        /// </summary>
        private void ButtonZrusObrazek_Click(object sender, EventArgs e)
        {
            // Zruš cestu k obrázku v produktu a načti defaultní obrázek do PictureBoxu.
            produkt.CestaObrazku = null;
            NactiObrazek();
        }

        /// <summary>
        /// Řeší kliknutí na tlačítko pro zrušení úprav. Zavře formulář bez uložení změn.
        /// </summary>
        private void ButtonZrus_Click(object sender, EventArgs e)
        {
            // Výsledek dialogu bude cancel, a zavři formulář bez uložení změn.
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Řeší kliknutí na tlačítko pro uložení úprav. Kontroluje vstupy, a při validním výsledku aktualizuje hodnoty produktu a formulář zavře.
        /// </summary>
        private void ButtonUloz_Click(object sender, EventArgs e)
        {
            // Název produktu nesmí být prázdný.
            if (string.IsNullOrEmpty(textBoxNazev.Text))
            {
                MessageBox.Show("Název produktu nesmí být prázdný.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nové ID produktu se nesmí schodovat s ID jiného produktu.
            int noveId = (int)numericUpDownID.Value;
            foreach (var produkt in appData.Produkty)
            {
                if (produkt.Id == noveId && produkt != this.produkt)
                {
                    MessageBox.Show("ID produktu musí být unikátní. Zadejte jiné ID.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Vše prošlo správně, aktualizuj hodnoty produktu z formuláře.
            produkt.Nazev = textBoxNazev.Text;
            produkt.Pocet = (int)numericUpDownPocet.Value;
            produkt.IdKategorie = (int)comboBoxKategorie.SelectedValue;
            produkt.IdVyrobce = (int)comboBoxVyrobce.SelectedValue;
            produkt.Id = noveId;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

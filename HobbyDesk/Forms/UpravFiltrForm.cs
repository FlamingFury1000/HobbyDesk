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
    /// Dialog pro úpravu názvu filtru. Používá se při vytváření nového filtru i při přejmenovávání existujícího.
    /// </summary>
    public partial class UpravFiltrForm : Form
    {
        // Výsledný název filtru, který zadal uživatel.
        public string NazevFiltru { get; private set; }

        public UpravFiltrForm(string titulek, string vychoziNazev)
        {
            InitializeComponent();

            // Nastavení titulku okna
            this.Text = titulek;

            // předvyplnění textového pole s názvem filtru.
            textBoxNazev.Text = vychoziNazev;
        }

        /// <summary>
        /// Tlačítko, které uloží zadaný název filtru a dialog následně zavře.
        /// </summary>
        private void ButtonUlozClick(object sender, EventArgs e)
        {
            // Pokud je název prázdný nebo obsahuje pouze mezery, zobrazí se varování a dialog zůstane otevřený.
            if (string.IsNullOrWhiteSpace(textBoxNazev.Text))
            {
                MessageBox.Show("Musíš zadat název.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nastaví vlastnost NazevFiltru na zadaný název a zavře dialog s výsledkem OK.
            NazevFiltru = textBoxNazev.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Tlačítko, které zruší úpravu a zavře dialog bez uložení změn.
        /// </summary>
        private void ButtonZrusClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

using HobbyDesk.UserControllers;
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
using System.Data.SqlTypes;
using HobbyDesk.Sluzby;

namespace HobbyDesk
{
    public partial class Form1 : Form
    {
        private AppData appData;
        private JsonStorage storage = new JsonStorage();

        private IndexControl indexControl;
        private SeznamControl seznamControl;

        private bool jsouNeulozeneZmeny = false;

        public Form1()
        {
            InitializeComponent();
            appData = storage.Nacti();

            seznamControl = new SeznamControl(appData);
            indexControl = new IndexControl();
            indexControl.AktualizujGrafy(appData);

            NactiUserControls(indexControl);
        }

        /// <summary>
        /// Načte zadaný UserControl do panelu Obsah a nastaví jeho Dock na Fill, aby zabíral celý prostor panelu.
        /// </summary>
        /// <param name="userControl"></param>
        private void NactiUserControls(UserControl userControl)
        {
            panelObsah.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelObsah.Controls.Add(userControl);
        }

        /// <summary>
        /// Po kliknutí na tlačítko se načte hlavní stránka v panelu Obsah.
        /// </summary>
        private void ButtonIndexClick(object sender, EventArgs e)
        {
            indexControl.AktualizujGrafy(appData);
            NactiUserControls(indexControl);
        }

        /// <summary>
        /// Po kliknutí na tlačítko se načte stránka seznamu v panelu Obsah.
        /// </summary>
        private void buttonSeznamClick(object sender, EventArgs e)
        {
            NactiUserControls(seznamControl);
        }

        /// <summary>
        /// Po kliknutí na tlačítko uživatel uloží aktuální data do zabudovaného JSON souboru.
        /// </summary>
        private void buttonUlozClick(object sender, EventArgs e)
        {
            storage.Uloz(appData);

            NastavUlozeno();

            MessageBox.Show("Data byla úspěšně uložena.", "Uloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Po kliknutí na tlačítko se otevře dialog pro uložení souboru, kde uživatel může zvolit umístění a název pro uložení dat do JSON souboru.
        /// </summary>
        private void buttonUlozitJakoClick(object sender, EventArgs e)
        {
            // Otevře dialog pro uložení souboru.
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON soubory (*.json)|*.json";
            dialog.Title = "Vyber umístění pro uložení JSON souboru";
            dialog.FileName = "data.json";

            // Pokud uživatel potvrdí výběr, uloží data do zvoleného souboru.
            if (dialog.ShowDialog() == DialogResult.OK) {
                storage.UlozDoSouboru(dialog.FileName, appData);

                NastavUlozeno();

                MessageBox.Show("Data byla úspěšně uložena.", "Uloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Po kliknutí na tlačítko se otevře dialog pro výběr souboru, kde uživatel může zvolit JSON soubor pro načtení dat. 
        /// </summary>
        private void buttonNactiClick(object sender, EventArgs e)
        {
            // Pokud jsou v aplikaci neuložené změny.
            if (jsouNeulozeneZmeny == true)
            {
                // Zeptá se uživatele, zda chce načíst nový soubor a ztratit neuložené změny.
                DialogResult potvrzeni = MessageBox.Show (
                    "Máte neuložené změny.\nOpravdu chcete načíst nový soubor a ztratit tyto změny?",
                    "Neuložené změny",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Pokud uživatel zvolí "Ne", vrátí se zpět do aplikace a načítání se zruší.
                if (potvrzeni == DialogResult.No)
                {
                    return;
                }
            }

            // Otevře dialog pro výběr souboru.
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON soubory (*.json)|*.json";
            dialog.Title = "Vyber JSON soubor pro načtení";

            // Pokud uživatel potvrdí výběr, načte data ze zvoleného souboru.
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                appData = storage.NactiZeSouboru(dialog.FileName);

                seznamControl = new SeznamControl(appData);

                indexControl.AktualizujGrafy(appData);

                NactiUserControls(seznamControl);

                NastavNeulozeneZmeny();

                MessageBox.Show("Data byla úspěšně načtena.", "Načteno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Po kliknutí na tlačítko se aplikace ukončí.
        /// </summary>
        private void buttonUkonciClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Označí aplikaci jako "Neuloženou".
        /// </summary>
        public void NastavNeulozeneZmeny()
        {
            jsouNeulozeneZmeny = true;
            this.Text = "HobbyDesk v1.0 *";
        }

        /// <summary>
        /// Označí aplikaci jako "Uloženou".
        /// </summary>
        public void NastavUlozeno()
        {
            jsouNeulozeneZmeny = false;
            this.Text = "HobbyDesk 1.0";
        }

        /// <summary>
        /// Chrání uživatele před ztrátou neuložených změn při pokusu o zavření aplikace.
        /// </summary>
        private void Form1FormClosing(object sender, FormClosingEventArgs e)
        {
            if (jsouNeulozeneZmeny == true)
            {
                DialogResult potvrzeni = MessageBox.Show(
                    "Máte neuložené změny.\nOpravdu chcete ukončit aplikaci a ztratit tyto změny?",
                    "Neuložené změny",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (potvrzeni == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

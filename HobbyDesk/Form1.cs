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

        private IndexControl indexControl = new IndexControl();
        private SeznamControl seznamControl;
        private VlozControl vlozControl = new VlozControl();
        private UlozControl ulozControl = new UlozControl();

        public Form1()
        {
            InitializeComponent();
            appData = storage.Nacti();

            // Testovací data, POTOM VYMAŽ
            VytvorTestData();

            seznamControl = new SeznamControl(appData);
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
        private void buttonIndex_Click(object sender, EventArgs e)
        {
            NactiUserControls(indexControl);
        }

        /// <summary>
        /// Po kliknutí na tlačítko se načte stránka seznamu v panelu Obsah.
        /// </summary>
        private void buttonSeznam_Click(object sender, EventArgs e)
        {
            NactiUserControls(seznamControl);
        }

        private void buttonVloz_Click(object sender, EventArgs e)
        {
            NactiUserControls(vlozControl);
        }

        private void buttonUloz_Click(object sender, EventArgs e)
        {
            NactiUserControls(ulozControl);
        }

        private void buttonUkonci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Testovací data, POTOM VYMAŽ
        private void VytvorTestData()
        {
            // Kategorie
            appData.Kategorie.AddRange(new List<Kategorie>
            {
                new Kategorie { Id = 1, Nazev = "Nástroje" },
                new Kategorie { Id = 2, Nazev = "Barvy" },
                new Kategorie { Id = 3, Nazev = "Ředidla" },
                new Kategorie { Id = 4, Nazev = "Patinátory" }
            });

            // Výrobci
            appData.Vyrobci.AddRange(new List<Vyrobce>
            {
                new Vyrobce { Id = 1, Nazev = "Tamiya" },
                new Vyrobce { Id = 2, Nazev = "Revell" },
                new Vyrobce { Id = 3, Nazev = "Humbrol" },
                new Vyrobce { Id = 4, Nazev = "Vallejo" },
                new Vyrobce { Id = 5, Nazev = "Mr. Hobby" },
                new Vyrobce { Id = 6, Nazev = "AK Interactive" },
                new Vyrobce { Id = 7, Nazev = "Citadel" },
                new Vyrobce { Id = 8, Nazev = "Scale75" },
                new Vyrobce { Id = 9, Nazev = "Revell Contacta" },
                new Vyrobce { Id = 10, Nazev = "Testors" }
            });

            // Produkty
            appData.Produkty.AddRange(new List<Produkt>
            {
                new Produkt(1, "Štětec 0", 5, 1, 1, null),
                new Produkt(2, "Štětec 1", 3, 1, 2, null),
                new Produkt(3, "Barva červená", 10, 2, 3, null),
                new Produkt(4, "Barva modrá", 8, 2, 4, null),
                new Produkt(5, "Barva zelená", 12, 2, 5, null),
                new Produkt(6, "Ředidlo 1", 7, 3, 6, null),
                new Produkt(7, "Ředidlo 2", 6, 3, 7, null),
                new Produkt(8, "Patinátor kov", 4, 4, 8, null),
                new Produkt(9, "Patinátor rez", 2, 4, 9, null),
                new Produkt(10, "Štětec 2", 9, 1, 10, null),
                new Produkt(11, "Barva žlutá", 11, 2, 1, null),
                new Produkt(12, "Barva černá", 15, 2, 2, null),
                new Produkt(13, "Štětec 3", 4, 1, 3, null),
                new Produkt(14, "Ředidlo 3", 5, 3, 4, null),
                new Produkt(15, "Patinátor bronz", 3, 4, 5, null),
                new Produkt(16, "Štětec 4", 7, 1, 6, null),
                new Produkt(17, "Barva bílá", 10, 2, 7, null),
                new Produkt(18, "Ředidlo 4", 6, 3, 8, null),
                new Produkt(19, "Patinátor měď", 2, 4, 9, null),
                new Produkt(20, "Štětec 5", 8, 1, 10, null)
            });
        }
    }
}

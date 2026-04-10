namespace HobbyDesk.UserControllers
{
    partial class SeznamControl
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewSeznam = new System.Windows.Forms.ListView();
            this.contextMenuProdukty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemUpravit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSmazat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHledani = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxZobrazeni = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxKategorie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxVyrobci = new System.Windows.Forms.ComboBox();
            this.buttonResetFiltry = new System.Windows.Forms.Button();
            this.contextMenuProdukty.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSeznam
            // 
            this.listViewSeznam.ContextMenuStrip = this.contextMenuProdukty;
            this.listViewSeznam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSeznam.FullRowSelect = true;
            this.listViewSeznam.GridLines = true;
            this.listViewSeznam.HideSelection = false;
            this.listViewSeznam.Location = new System.Drawing.Point(0, 152);
            this.listViewSeznam.MultiSelect = false;
            this.listViewSeznam.Name = "listViewSeznam";
            this.listViewSeznam.Size = new System.Drawing.Size(1055, 617);
            this.listViewSeznam.TabIndex = 0;
            this.listViewSeznam.UseCompatibleStateImageBehavior = false;
            this.listViewSeznam.View = System.Windows.Forms.View.Details;
            this.listViewSeznam.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListViewSeznamColumnWidthChanging);
            this.listViewSeznam.DoubleClick += new System.EventHandler(this.ListViewSeznamDoubleClick);
            this.listViewSeznam.Resize += new System.EventHandler(this.ListViewSeznamResize);
            // 
            // contextMenuProdukty
            // 
            this.contextMenuProdukty.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuProdukty.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUpravit,
            this.toolStripMenuItemSmazat});
            this.contextMenuProdukty.Name = "contextMenuProdukty";
            this.contextMenuProdukty.Size = new System.Drawing.Size(143, 68);
            // 
            // toolStripMenuItemUpravit
            // 
            this.toolStripMenuItemUpravit.Name = "toolStripMenuItemUpravit";
            this.toolStripMenuItemUpravit.Size = new System.Drawing.Size(142, 32);
            this.toolStripMenuItemUpravit.Text = "Upravit";
            this.toolStripMenuItemUpravit.Click += new System.EventHandler(this.ToolStripMenuItemUpravitClick);
            // 
            // toolStripMenuItemSmazat
            // 
            this.toolStripMenuItemSmazat.Name = "toolStripMenuItemSmazat";
            this.toolStripMenuItemSmazat.Size = new System.Drawing.Size(142, 32);
            this.toolStripMenuItemSmazat.Text = "Smazat";
            this.toolStripMenuItemSmazat.Click += new System.EventHandler(this.ToolStripMenuItemSmazat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewSeznam);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 769);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 152);
            this.panel2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.textBoxHledani);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxZobrazeni);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxKategorie);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxVyrobci);
            this.flowLayoutPanel1.Controls.Add(this.buttonResetFiltry);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(58);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1055, 152);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 9, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vyhledávání:";
            // 
            // textBoxHledani
            // 
            this.textBoxHledani.Location = new System.Drawing.Point(170, 63);
            this.textBoxHledani.Margin = new System.Windows.Forms.Padding(3, 5, 8, 3);
            this.textBoxHledani.Name = "textBoxHledani";
            this.textBoxHledani.Size = new System.Drawing.Size(316, 26);
            this.textBoxHledani.TabIndex = 2;
            this.textBoxHledani.TextChanged += new System.EventHandler(this.TextBoxHledaniTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zobrazení:";
            // 
            // comboBoxZobrazeni
            // 
            this.comboBoxZobrazeni.FormattingEnabled = true;
            this.comboBoxZobrazeni.Location = new System.Drawing.Point(592, 61);
            this.comboBoxZobrazeni.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.comboBoxZobrazeni.Name = "comboBoxZobrazeni";
            this.comboBoxZobrazeni.Size = new System.Drawing.Size(121, 28);
            this.comboBoxZobrazeni.TabIndex = 3;
            this.comboBoxZobrazeni.SelectedIndexChanged += new System.EventHandler(this.ComboBoxZobrazeniSelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(724, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategorie:";
            // 
            // comboBoxKategorie
            // 
            this.comboBoxKategorie.FormattingEnabled = true;
            this.comboBoxKategorie.Location = new System.Drawing.Point(816, 61);
            this.comboBoxKategorie.Name = "comboBoxKategorie";
            this.comboBoxKategorie.Size = new System.Drawing.Size(121, 28);
            this.comboBoxKategorie.TabIndex = 5;
            this.comboBoxKategorie.SelectedIndexChanged += new System.EventHandler(this.ComboBoxKategorieSelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Výrobci: ";
            // 
            // comboBoxVyrobci
            // 
            this.comboBoxVyrobci.FormattingEnabled = true;
            this.comboBoxVyrobci.Location = new System.Drawing.Point(141, 95);
            this.comboBoxVyrobci.Name = "comboBoxVyrobci";
            this.comboBoxVyrobci.Size = new System.Drawing.Size(121, 28);
            this.comboBoxVyrobci.TabIndex = 6;
            this.comboBoxVyrobci.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVyrobciSelectedIndexChanged);
            // 
            // buttonResetFiltry
            // 
            this.buttonResetFiltry.Location = new System.Drawing.Point(268, 95);
            this.buttonResetFiltry.Name = "buttonResetFiltry";
            this.buttonResetFiltry.Size = new System.Drawing.Size(160, 33);
            this.buttonResetFiltry.TabIndex = 11;
            this.buttonResetFiltry.Text = "Resetuj filtry";
            this.buttonResetFiltry.UseVisualStyleBackColor = true;
            this.buttonResetFiltry.Click += new System.EventHandler(this.ButtonResetFiltryClick);
            // 
            // SeznamControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SeznamControl";
            this.Size = new System.Drawing.Size(1055, 769);
            this.contextMenuProdukty.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewSeznam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuProdukty;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpravit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSmazat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHledani;
        private System.Windows.Forms.ComboBox comboBoxZobrazeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxKategorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxVyrobci;
        private System.Windows.Forms.Button buttonResetFiltry;
    }
}

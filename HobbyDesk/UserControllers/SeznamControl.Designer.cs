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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeznamControl));
            this.listViewSeznam = new System.Windows.Forms.ListView();
            this.contextMenuProdukty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemUpravit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSmazat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelPocetPrvku = new System.Windows.Forms.Label();
            this.comboBoxZobrazeni = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonOdeberVse = new System.Windows.Forms.Button();
            this.imageListTlacitka = new System.Windows.Forms.ImageList(this.components);
            this.buttonEditVyrobce = new System.Windows.Forms.Button();
            this.imageListFiltry = new System.Windows.Forms.ImageList(this.components);
            this.buttonEditKategorie = new System.Windows.Forms.Button();
            this.buttonOdeber = new System.Windows.Forms.Button();
            this.buttonUprav = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHledani = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxKategorie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxVyrobci = new System.Windows.Forms.ComboBox();
            this.buttonResetFiltry = new System.Windows.Forms.Button();
            this.buttonPridej = new System.Windows.Forms.Button();
            this.contextMenuProdukty.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.listViewSeznam.Size = new System.Drawing.Size(1055, 572);
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
            this.contextMenuProdukty.Size = new System.Drawing.Size(151, 68);
            // 
            // toolStripMenuItemUpravit
            // 
            this.toolStripMenuItemUpravit.Image = global::HobbyDesk.Properties.Resources.ikona_edit;
            this.toolStripMenuItemUpravit.Name = "toolStripMenuItemUpravit";
            this.toolStripMenuItemUpravit.Size = new System.Drawing.Size(150, 32);
            this.toolStripMenuItemUpravit.Text = "Upravit";
            this.toolStripMenuItemUpravit.Click += new System.EventHandler(this.ToolStripMenuItemUpravitClick);
            // 
            // toolStripMenuItemSmazat
            // 
            this.toolStripMenuItemSmazat.Image = global::HobbyDesk.Properties.Resources.ikona_delete;
            this.toolStripMenuItemSmazat.Name = "toolStripMenuItemSmazat";
            this.toolStripMenuItemSmazat.Size = new System.Drawing.Size(150, 32);
            this.toolStripMenuItemSmazat.Text = "Smazat";
            this.toolStripMenuItemSmazat.Click += new System.EventHandler(this.ToolStripMenuItemSmazatClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewSeznam);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 769);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LabelPocetPrvku);
            this.panel3.Controls.Add(this.comboBoxZobrazeni);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 724);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1055, 45);
            this.panel3.TabIndex = 6;
            // 
            // LabelPocetPrvku
            // 
            this.LabelPocetPrvku.AutoSize = true;
            this.LabelPocetPrvku.Location = new System.Drawing.Point(8, 12);
            this.LabelPocetPrvku.Margin = new System.Windows.Forms.Padding(3, 8, 8, 0);
            this.LabelPocetPrvku.Name = "LabelPocetPrvku";
            this.LabelPocetPrvku.Size = new System.Drawing.Size(155, 20);
            this.LabelPocetPrvku.TabIndex = 6;
            this.LabelPocetPrvku.Text = "Aktuálně zobrazeno:";
            // 
            // comboBoxZobrazeni
            // 
            this.comboBoxZobrazeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxZobrazeni.FormattingEnabled = true;
            this.comboBoxZobrazeni.Location = new System.Drawing.Point(921, 7);
            this.comboBoxZobrazeni.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.comboBoxZobrazeni.Name = "comboBoxZobrazeni";
            this.comboBoxZobrazeni.Size = new System.Drawing.Size(121, 28);
            this.comboBoxZobrazeni.TabIndex = 3;
            this.comboBoxZobrazeni.SelectedIndexChanged += new System.EventHandler(this.ComboBoxZobrazeniSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(826, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zobrazení:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonOdeberVse);
            this.panel2.Controls.Add(this.buttonEditVyrobce);
            this.panel2.Controls.Add(this.buttonEditKategorie);
            this.panel2.Controls.Add(this.buttonOdeber);
            this.panel2.Controls.Add(this.buttonUprav);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxHledani);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBoxKategorie);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBoxVyrobci);
            this.panel2.Controls.Add(this.buttonResetFiltry);
            this.panel2.Controls.Add(this.buttonPridej);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 152);
            this.panel2.TabIndex = 5;
            // 
            // buttonOdeberVse
            // 
            this.buttonOdeberVse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOdeberVse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOdeberVse.ImageIndex = 4;
            this.buttonOdeberVse.ImageList = this.imageListTlacitka;
            this.buttonOdeberVse.Location = new System.Drawing.Point(948, 12);
            this.buttonOdeberVse.Name = "buttonOdeberVse";
            this.buttonOdeberVse.Size = new System.Drawing.Size(94, 94);
            this.buttonOdeberVse.TabIndex = 17;
            this.buttonOdeberVse.Text = "Odeber vše";
            this.buttonOdeberVse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOdeberVse.UseVisualStyleBackColor = true;
            this.buttonOdeberVse.Click += new System.EventHandler(this.buttonOdeberVseClick);
            // 
            // imageListTlacitka
            // 
            this.imageListTlacitka.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTlacitka.ImageStream")));
            this.imageListTlacitka.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTlacitka.Images.SetKeyName(0, "ikona_plus.png");
            this.imageListTlacitka.Images.SetKeyName(1, "ikona_reset.png");
            this.imageListTlacitka.Images.SetKeyName(2, "ikona_edit.png");
            this.imageListTlacitka.Images.SetKeyName(3, "ikona_delete.png");
            this.imageListTlacitka.Images.SetKeyName(4, "ikona_clear.png");
            // 
            // buttonEditVyrobce
            // 
            this.buttonEditVyrobce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditVyrobce.ImageIndex = 0;
            this.buttonEditVyrobce.ImageList = this.imageListFiltry;
            this.buttonEditVyrobce.Location = new System.Drawing.Point(807, 63);
            this.buttonEditVyrobce.Name = "buttonEditVyrobce";
            this.buttonEditVyrobce.Size = new System.Drawing.Size(36, 37);
            this.buttonEditVyrobce.TabIndex = 16;
            this.buttonEditVyrobce.UseVisualStyleBackColor = true;
            this.buttonEditVyrobce.Click += new System.EventHandler(this.ButtonEditVyrobceClick);
            // 
            // imageListFiltry
            // 
            this.imageListFiltry.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFiltry.ImageStream")));
            this.imageListFiltry.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFiltry.Images.SetKeyName(0, "ikona_edit.png");
            // 
            // buttonEditKategorie
            // 
            this.buttonEditKategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditKategorie.ImageIndex = 0;
            this.buttonEditKategorie.ImageList = this.imageListFiltry;
            this.buttonEditKategorie.Location = new System.Drawing.Point(807, 23);
            this.buttonEditKategorie.Name = "buttonEditKategorie";
            this.buttonEditKategorie.Size = new System.Drawing.Size(36, 37);
            this.buttonEditKategorie.TabIndex = 15;
            this.buttonEditKategorie.UseVisualStyleBackColor = true;
            this.buttonEditKategorie.Click += new System.EventHandler(this.ButtonEditKategorieClick);
            // 
            // buttonOdeber
            // 
            this.buttonOdeber.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOdeber.ImageIndex = 3;
            this.buttonOdeber.ImageList = this.imageListTlacitka;
            this.buttonOdeber.Location = new System.Drawing.Point(211, 12);
            this.buttonOdeber.Name = "buttonOdeber";
            this.buttonOdeber.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonOdeber.Size = new System.Drawing.Size(94, 94);
            this.buttonOdeber.TabIndex = 14;
            this.buttonOdeber.Text = "Odeber";
            this.buttonOdeber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOdeber.UseVisualStyleBackColor = true;
            this.buttonOdeber.Click += new System.EventHandler(this.ButtonOdeberClick);
            // 
            // buttonUprav
            // 
            this.buttonUprav.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUprav.ImageIndex = 2;
            this.buttonUprav.ImageList = this.imageListTlacitka;
            this.buttonUprav.Location = new System.Drawing.Point(112, 12);
            this.buttonUprav.Name = "buttonUprav";
            this.buttonUprav.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonUprav.Size = new System.Drawing.Size(94, 94);
            this.buttonUprav.TabIndex = 13;
            this.buttonUprav.Text = "Uprav";
            this.buttonUprav.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUprav.UseVisualStyleBackColor = true;
            this.buttonUprav.Click += new System.EventHandler(this.ButtonUpravClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 9, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vyhledávání:";
            // 
            // textBoxHledani
            // 
            this.textBoxHledani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHledani.Location = new System.Drawing.Point(125, 112);
            this.textBoxHledani.Margin = new System.Windows.Forms.Padding(3, 5, 8, 3);
            this.textBoxHledani.Name = "textBoxHledani";
            this.textBoxHledani.Size = new System.Drawing.Size(918, 26);
            this.textBoxHledani.TabIndex = 2;
            this.textBoxHledani.TextChanged += new System.EventHandler(this.TextBoxHledaniTextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategorie:";
            // 
            // comboBoxKategorie
            // 
            this.comboBoxKategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxKategorie.FormattingEnabled = true;
            this.comboBoxKategorie.Location = new System.Drawing.Point(679, 25);
            this.comboBoxKategorie.Name = "comboBoxKategorie";
            this.comboBoxKategorie.Size = new System.Drawing.Size(121, 28);
            this.comboBoxKategorie.TabIndex = 5;
            this.comboBoxKategorie.SelectedIndexChanged += new System.EventHandler(this.ComboBoxKategorieSelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Výrobci: ";
            // 
            // comboBoxVyrobci
            // 
            this.comboBoxVyrobci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxVyrobci.FormattingEnabled = true;
            this.comboBoxVyrobci.Location = new System.Drawing.Point(679, 65);
            this.comboBoxVyrobci.Name = "comboBoxVyrobci";
            this.comboBoxVyrobci.Size = new System.Drawing.Size(121, 28);
            this.comboBoxVyrobci.TabIndex = 6;
            this.comboBoxVyrobci.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVyrobciSelectedIndexChanged);
            // 
            // buttonResetFiltry
            // 
            this.buttonResetFiltry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetFiltry.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonResetFiltry.ImageIndex = 1;
            this.buttonResetFiltry.ImageList = this.imageListTlacitka;
            this.buttonResetFiltry.Location = new System.Drawing.Point(848, 12);
            this.buttonResetFiltry.Name = "buttonResetFiltry";
            this.buttonResetFiltry.Size = new System.Drawing.Size(94, 94);
            this.buttonResetFiltry.TabIndex = 11;
            this.buttonResetFiltry.Text = "Resetuj filtry";
            this.buttonResetFiltry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonResetFiltry.UseVisualStyleBackColor = true;
            this.buttonResetFiltry.Click += new System.EventHandler(this.ButtonResetFiltryClick);
            // 
            // buttonPridej
            // 
            this.buttonPridej.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPridej.ImageIndex = 0;
            this.buttonPridej.ImageList = this.imageListTlacitka;
            this.buttonPridej.Location = new System.Drawing.Point(12, 12);
            this.buttonPridej.Name = "buttonPridej";
            this.buttonPridej.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonPridej.Size = new System.Drawing.Size(94, 94);
            this.buttonPridej.TabIndex = 12;
            this.buttonPridej.Text = "Přidej";
            this.buttonPridej.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPridej.UseVisualStyleBackColor = true;
            this.buttonPridej.Click += new System.EventHandler(this.ButtonPridejClick);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewSeznam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuProdukty;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpravit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSmazat;
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
        private System.Windows.Forms.Button buttonPridej;
        private System.Windows.Forms.ImageList imageListTlacitka;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonOdeber;
        private System.Windows.Forms.Button buttonUprav;
        private System.Windows.Forms.Label LabelPocetPrvku;
        private System.Windows.Forms.Button buttonEditKategorie;
        private System.Windows.Forms.Button buttonEditVyrobce;
        private System.Windows.Forms.ImageList imageListFiltry;
        private System.Windows.Forms.Button buttonOdeberVse;
    }
}

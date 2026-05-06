namespace HobbyDesk
{
    partial class Form1
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

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.layoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelObsah = new System.Windows.Forms.Panel();
            this.panelTlacitka = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.imageListTlacitkaPanely = new System.Windows.Forms.ImageList(this.components);
            this.imageListTlacitkaMoznosti = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonIndex = new System.Windows.Forms.Button();
            this.buttonSeznam = new System.Windows.Forms.Button();
            this.buttonUloz = new System.Windows.Forms.Button();
            this.buttonUlozitJako = new System.Windows.Forms.Button();
            this.buttonNacti = new System.Windows.Forms.Button();
            this.buttonUkonci = new System.Windows.Forms.Button();
            this.layoutPanelMenu.SuspendLayout();
            this.panelTlacitka.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutPanelMenu
            // 
            this.layoutPanelMenu.Controls.Add(this.pictureBox1);
            this.layoutPanelMenu.Controls.Add(this.label3);
            this.layoutPanelMenu.Controls.Add(this.panel1);
            this.layoutPanelMenu.Controls.Add(this.label1);
            this.layoutPanelMenu.Controls.Add(this.panel2);
            this.layoutPanelMenu.Controls.Add(this.buttonIndex);
            this.layoutPanelMenu.Controls.Add(this.buttonSeznam);
            this.layoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.layoutPanelMenu.Name = "layoutPanelMenu";
            this.layoutPanelMenu.Size = new System.Drawing.Size(244, 512);
            this.layoutPanelMenu.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.ImageIndex = 0;
            this.label3.Location = new System.Drawing.Point(108, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 40, 10, 40);
            this.label3.Size = new System.Drawing.Size(113, 101);
            this.label3.TabIndex = 2;
            this.label3.Text = "HobbyDesk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(90, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panely";
            // 
            // panelObsah
            // 
            this.panelObsah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelObsah.Location = new System.Drawing.Point(244, 0);
            this.panelObsah.Name = "panelObsah";
            this.panelObsah.Size = new System.Drawing.Size(1081, 769);
            this.panelObsah.TabIndex = 1;
            // 
            // panelTlacitka
            // 
            this.panelTlacitka.Controls.Add(this.layoutPanelMenu);
            this.panelTlacitka.Controls.Add(this.flowLayoutPanel1);
            this.panelTlacitka.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTlacitka.Location = new System.Drawing.Point(0, 0);
            this.panelTlacitka.Name = "panelTlacitka";
            this.panelTlacitka.Size = new System.Drawing.Size(244, 769);
            this.panelTlacitka.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.buttonUloz);
            this.flowLayoutPanel1.Controls.Add(this.buttonUlozitJako);
            this.flowLayoutPanel1.Controls.Add(this.buttonNacti);
            this.flowLayoutPanel1.Controls.Add(this.buttonUkonci);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 512);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 257);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(84, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Možnosti";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(6, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 10, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 2);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(154, 111);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 10, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 2);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(6, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 10, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 2);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(166, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 10, 3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(71, 2);
            this.panel4.TabIndex = 9;
            // 
            // imageListTlacitkaPanely
            // 
            this.imageListTlacitkaPanely.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTlacitkaPanely.ImageStream")));
            this.imageListTlacitkaPanely.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTlacitkaPanely.Images.SetKeyName(0, "ikona_home.png");
            this.imageListTlacitkaPanely.Images.SetKeyName(1, "ikona_list.png");
            // 
            // imageListTlacitkaMoznosti
            // 
            this.imageListTlacitkaMoznosti.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTlacitkaMoznosti.ImageStream")));
            this.imageListTlacitkaMoznosti.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTlacitkaMoznosti.Images.SetKeyName(0, "ikona_save.png");
            this.imageListTlacitkaMoznosti.Images.SetKeyName(1, "ikona_save_as.png");
            this.imageListTlacitkaMoznosti.Images.SetKeyName(2, "ikona_load.png");
            this.imageListTlacitkaMoznosti.Images.SetKeyName(3, "ikona_shutdown.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HobbyDesk.Properties.Resources.ikona_hobbydesk;
            this.pictureBox1.Location = new System.Drawing.Point(27, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(27, 14, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonIndex
            // 
            this.buttonIndex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIndex.ImageKey = "ikona_home.png";
            this.buttonIndex.ImageList = this.imageListTlacitkaPanely;
            this.buttonIndex.Location = new System.Drawing.Point(3, 124);
            this.buttonIndex.Name = "buttonIndex";
            this.buttonIndex.Padding = new System.Windows.Forms.Padding(15);
            this.buttonIndex.Size = new System.Drawing.Size(237, 110);
            this.buttonIndex.TabIndex = 2;
            this.buttonIndex.Text = "Domovská stránka";
            this.buttonIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonIndex.UseVisualStyleBackColor = true;
            this.buttonIndex.Click += new System.EventHandler(this.ButtonIndexClick);
            // 
            // buttonSeznam
            // 
            this.buttonSeznam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSeznam.ImageKey = "ikona_list.png";
            this.buttonSeznam.ImageList = this.imageListTlacitkaPanely;
            this.buttonSeznam.Location = new System.Drawing.Point(3, 240);
            this.buttonSeznam.Name = "buttonSeznam";
            this.buttonSeznam.Padding = new System.Windows.Forms.Padding(15, 15, 85, 15);
            this.buttonSeznam.Size = new System.Drawing.Size(237, 110);
            this.buttonSeznam.TabIndex = 0;
            this.buttonSeznam.Text = "Seznam";
            this.buttonSeznam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSeznam.UseVisualStyleBackColor = true;
            this.buttonSeznam.Click += new System.EventHandler(this.buttonSeznamClick);
            // 
            // buttonUloz
            // 
            this.buttonUloz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUloz.ImageIndex = 0;
            this.buttonUloz.ImageList = this.imageListTlacitkaMoznosti;
            this.buttonUloz.Location = new System.Drawing.Point(3, 23);
            this.buttonUloz.Name = "buttonUloz";
            this.buttonUloz.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.buttonUloz.Size = new System.Drawing.Size(237, 52);
            this.buttonUloz.TabIndex = 2;
            this.buttonUloz.Text = "Uložit";
            this.buttonUloz.UseVisualStyleBackColor = true;
            this.buttonUloz.Click += new System.EventHandler(this.buttonUlozClick);
            // 
            // buttonUlozitJako
            // 
            this.buttonUlozitJako.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUlozitJako.ImageIndex = 1;
            this.buttonUlozitJako.ImageList = this.imageListTlacitkaMoznosti;
            this.buttonUlozitJako.Location = new System.Drawing.Point(3, 81);
            this.buttonUlozitJako.Name = "buttonUlozitJako";
            this.buttonUlozitJako.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.buttonUlozitJako.Size = new System.Drawing.Size(237, 52);
            this.buttonUlozitJako.TabIndex = 6;
            this.buttonUlozitJako.Text = "Uložit jako..";
            this.buttonUlozitJako.UseVisualStyleBackColor = true;
            this.buttonUlozitJako.Click += new System.EventHandler(this.buttonUlozitJakoClick);
            // 
            // buttonNacti
            // 
            this.buttonNacti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNacti.ImageIndex = 2;
            this.buttonNacti.ImageList = this.imageListTlacitkaMoznosti;
            this.buttonNacti.Location = new System.Drawing.Point(3, 139);
            this.buttonNacti.Name = "buttonNacti";
            this.buttonNacti.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.buttonNacti.Size = new System.Drawing.Size(237, 52);
            this.buttonNacti.TabIndex = 4;
            this.buttonNacti.Text = "Načíst";
            this.buttonNacti.UseVisualStyleBackColor = true;
            this.buttonNacti.Click += new System.EventHandler(this.buttonNactiClick);
            // 
            // buttonUkonci
            // 
            this.buttonUkonci.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonUkonci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUkonci.ImageKey = "ikona_shutdown.png";
            this.buttonUkonci.ImageList = this.imageListTlacitkaMoznosti;
            this.buttonUkonci.Location = new System.Drawing.Point(3, 197);
            this.buttonUkonci.Name = "buttonUkonci";
            this.buttonUkonci.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.buttonUkonci.Size = new System.Drawing.Size(237, 52);
            this.buttonUkonci.TabIndex = 3;
            this.buttonUkonci.Text = "Ukončit";
            this.buttonUkonci.UseVisualStyleBackColor = false;
            this.buttonUkonci.Click += new System.EventHandler(this.buttonUkonciClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 769);
            this.Controls.Add(this.panelObsah);
            this.Controls.Add(this.panelTlacitka);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1050, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HobbyDesk v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1FormClosing);
            this.layoutPanelMenu.ResumeLayout(false);
            this.layoutPanelMenu.PerformLayout();
            this.panelTlacitka.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutPanelMenu;
        private System.Windows.Forms.Button buttonSeznam;
        private System.Windows.Forms.Button buttonUloz;
        private System.Windows.Forms.Button buttonUkonci;
        private System.Windows.Forms.Panel panelObsah;
        private System.Windows.Forms.Button buttonIndex;
        private System.Windows.Forms.Button buttonNacti;
        private System.Windows.Forms.Button buttonUlozitJako;
        private System.Windows.Forms.Panel panelTlacitka;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageListTlacitkaPanely;
        private System.Windows.Forms.ImageList imageListTlacitkaMoznosti;
    }
}


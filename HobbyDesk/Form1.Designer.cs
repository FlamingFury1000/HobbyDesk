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
            this.layoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonIndex = new System.Windows.Forms.Button();
            this.buttonSeznam = new System.Windows.Forms.Button();
            this.buttonUloz = new System.Windows.Forms.Button();
            this.buttonUlozitJako = new System.Windows.Forms.Button();
            this.buttonNacti = new System.Windows.Forms.Button();
            this.buttonUkonci = new System.Windows.Forms.Button();
            this.panelObsah = new System.Windows.Forms.Panel();
            this.panelTlacitka = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.layoutPanelMenu.SuspendLayout();
            this.panelTlacitka.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanelMenu
            // 
            this.layoutPanelMenu.Controls.Add(this.label3);
            this.layoutPanelMenu.Controls.Add(this.label1);
            this.layoutPanelMenu.Controls.Add(this.buttonIndex);
            this.layoutPanelMenu.Controls.Add(this.buttonSeznam);
            this.layoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.layoutPanelMenu.Name = "layoutPanelMenu";
            this.layoutPanelMenu.Size = new System.Drawing.Size(244, 512);
            this.layoutPanelMenu.TabIndex = 0;
            // 
            // buttonIndex
            // 
            this.buttonIndex.Location = new System.Drawing.Point(3, 123);
            this.buttonIndex.Name = "buttonIndex";
            this.buttonIndex.Size = new System.Drawing.Size(237, 110);
            this.buttonIndex.TabIndex = 2;
            this.buttonIndex.Text = "Domovská stránka";
            this.buttonIndex.UseVisualStyleBackColor = true;
            this.buttonIndex.Click += new System.EventHandler(this.ButtonIndexClick);
            // 
            // buttonSeznam
            // 
            this.buttonSeznam.Location = new System.Drawing.Point(3, 239);
            this.buttonSeznam.Name = "buttonSeznam";
            this.buttonSeznam.Size = new System.Drawing.Size(237, 110);
            this.buttonSeznam.TabIndex = 0;
            this.buttonSeznam.Text = "Seznam";
            this.buttonSeznam.UseVisualStyleBackColor = true;
            this.buttonSeznam.Click += new System.EventHandler(this.buttonSeznamClick);
            // 
            // buttonUloz
            // 
            this.buttonUloz.Location = new System.Drawing.Point(3, 23);
            this.buttonUloz.Name = "buttonUloz";
            this.buttonUloz.Size = new System.Drawing.Size(237, 52);
            this.buttonUloz.TabIndex = 2;
            this.buttonUloz.Text = "Uložit";
            this.buttonUloz.UseVisualStyleBackColor = true;
            this.buttonUloz.Click += new System.EventHandler(this.buttonUlozClick);
            // 
            // buttonUlozitJako
            // 
            this.buttonUlozitJako.Location = new System.Drawing.Point(3, 81);
            this.buttonUlozitJako.Name = "buttonUlozitJako";
            this.buttonUlozitJako.Size = new System.Drawing.Size(237, 52);
            this.buttonUlozitJako.TabIndex = 6;
            this.buttonUlozitJako.Text = "Uložit jako..";
            this.buttonUlozitJako.UseVisualStyleBackColor = true;
            this.buttonUlozitJako.Click += new System.EventHandler(this.buttonUlozitJakoClick);
            // 
            // buttonNacti
            // 
            this.buttonNacti.Location = new System.Drawing.Point(3, 139);
            this.buttonNacti.Name = "buttonNacti";
            this.buttonNacti.Size = new System.Drawing.Size(237, 52);
            this.buttonNacti.TabIndex = 4;
            this.buttonNacti.Text = "Načíst";
            this.buttonNacti.UseVisualStyleBackColor = true;
            this.buttonNacti.Click += new System.EventHandler(this.buttonNactiClick);
            // 
            // buttonUkonci
            // 
            this.buttonUkonci.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonUkonci.Location = new System.Drawing.Point(3, 197);
            this.buttonUkonci.Name = "buttonUkonci";
            this.buttonUkonci.Size = new System.Drawing.Size(237, 52);
            this.buttonUkonci.TabIndex = 3;
            this.buttonUkonci.Text = "Ukončit";
            this.buttonUkonci.UseVisualStyleBackColor = false;
            this.buttonUkonci.Click += new System.EventHandler(this.buttonUkonciClick);
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
            this.flowLayoutPanel1.Controls.Add(this.label2);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "---------- Panely ----------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "---------- Možnosti ----------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(40);
            this.label3.Size = new System.Drawing.Size(172, 100);
            this.label3.TabIndex = 2;
            this.label3.Text = "HobbyDesk";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 769);
            this.Controls.Add(this.panelObsah);
            this.Controls.Add(this.panelTlacitka);
            this.MinimumSize = new System.Drawing.Size(1050, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HobbyDesk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1FormClosing);
            this.layoutPanelMenu.ResumeLayout(false);
            this.layoutPanelMenu.PerformLayout();
            this.panelTlacitka.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
    }
}


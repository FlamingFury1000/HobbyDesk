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
            this.buttonVloz = new System.Windows.Forms.Button();
            this.buttonUloz = new System.Windows.Forms.Button();
            this.buttonUkonci = new System.Windows.Forms.Button();
            this.panelObsah = new System.Windows.Forms.Panel();
            this.layoutPanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanelMenu
            // 
            this.layoutPanelMenu.Controls.Add(this.buttonIndex);
            this.layoutPanelMenu.Controls.Add(this.buttonSeznam);
            this.layoutPanelMenu.Controls.Add(this.buttonVloz);
            this.layoutPanelMenu.Controls.Add(this.buttonUloz);
            this.layoutPanelMenu.Controls.Add(this.buttonUkonci);
            this.layoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.layoutPanelMenu.Name = "layoutPanelMenu";
            this.layoutPanelMenu.Size = new System.Drawing.Size(244, 769);
            this.layoutPanelMenu.TabIndex = 0;
            // 
            // buttonIndex
            // 
            this.buttonIndex.Location = new System.Drawing.Point(3, 3);
            this.buttonIndex.Name = "buttonIndex";
            this.buttonIndex.Size = new System.Drawing.Size(237, 52);
            this.buttonIndex.TabIndex = 2;
            this.buttonIndex.Text = "Domovská stránka";
            this.buttonIndex.UseVisualStyleBackColor = true;
            this.buttonIndex.Click += new System.EventHandler(this.ButtonIndex_Click);
            // 
            // buttonSeznam
            // 
            this.buttonSeznam.Location = new System.Drawing.Point(3, 61);
            this.buttonSeznam.Name = "buttonSeznam";
            this.buttonSeznam.Size = new System.Drawing.Size(237, 52);
            this.buttonSeznam.TabIndex = 0;
            this.buttonSeznam.Text = "Seznam";
            this.buttonSeznam.UseVisualStyleBackColor = true;
            this.buttonSeznam.Click += new System.EventHandler(this.buttonSeznam_Click);
            // 
            // buttonVloz
            // 
            this.buttonVloz.Location = new System.Drawing.Point(3, 119);
            this.buttonVloz.Name = "buttonVloz";
            this.buttonVloz.Size = new System.Drawing.Size(237, 52);
            this.buttonVloz.TabIndex = 1;
            this.buttonVloz.Text = "Vlož nový produkt";
            this.buttonVloz.UseVisualStyleBackColor = true;
            this.buttonVloz.Click += new System.EventHandler(this.buttonVloz_Click);
            // 
            // buttonUloz
            // 
            this.buttonUloz.Location = new System.Drawing.Point(3, 177);
            this.buttonUloz.Name = "buttonUloz";
            this.buttonUloz.Size = new System.Drawing.Size(237, 52);
            this.buttonUloz.TabIndex = 2;
            this.buttonUloz.Text = "Ulož";
            this.buttonUloz.UseVisualStyleBackColor = true;
            this.buttonUloz.Click += new System.EventHandler(this.buttonUloz_Click);
            // 
            // buttonUkonci
            // 
            this.buttonUkonci.Location = new System.Drawing.Point(3, 235);
            this.buttonUkonci.Name = "buttonUkonci";
            this.buttonUkonci.Size = new System.Drawing.Size(237, 52);
            this.buttonUkonci.TabIndex = 3;
            this.buttonUkonci.Text = "Ukončit";
            this.buttonUkonci.UseVisualStyleBackColor = true;
            this.buttonUkonci.Click += new System.EventHandler(this.buttonUkonci_Click);
            // 
            // panelObsah
            // 
            this.panelObsah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelObsah.Location = new System.Drawing.Point(244, 0);
            this.panelObsah.Name = "panelObsah";
            this.panelObsah.Size = new System.Drawing.Size(1081, 769);
            this.panelObsah.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 769);
            this.Controls.Add(this.panelObsah);
            this.Controls.Add(this.layoutPanelMenu);
            this.MinimumSize = new System.Drawing.Size(997, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.layoutPanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutPanelMenu;
        private System.Windows.Forms.Button buttonSeznam;
        private System.Windows.Forms.Button buttonVloz;
        private System.Windows.Forms.Button buttonUloz;
        private System.Windows.Forms.Button buttonUkonci;
        private System.Windows.Forms.Panel panelObsah;
        private System.Windows.Forms.Button buttonIndex;
    }
}


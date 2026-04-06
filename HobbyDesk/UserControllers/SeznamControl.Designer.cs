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
            this.listViewSeznam = new System.Windows.Forms.ListView();
            this.flowLayoutPreferenceListu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSeznam
            // 
            this.listViewSeznam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSeznam.FullRowSelect = true;
            this.listViewSeznam.GridLines = true;
            this.listViewSeznam.HideSelection = false;
            this.listViewSeznam.Location = new System.Drawing.Point(0, 126);
            this.listViewSeznam.Name = "listViewSeznam";
            this.listViewSeznam.Size = new System.Drawing.Size(1055, 643);
            this.listViewSeznam.TabIndex = 0;
            this.listViewSeznam.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPreferenceListu
            // 
            this.flowLayoutPreferenceListu.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPreferenceListu.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPreferenceListu.Name = "flowLayoutPreferenceListu";
            this.flowLayoutPreferenceListu.Size = new System.Drawing.Size(1055, 126);
            this.flowLayoutPreferenceListu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewSeznam);
            this.panel1.Controls.Add(this.flowLayoutPreferenceListu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 769);
            this.panel1.TabIndex = 2;
            // 
            // SeznamControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SeznamControl";
            this.Size = new System.Drawing.Size(1055, 769);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPreferenceListu;
        private System.Windows.Forms.ListView listViewSeznam;
        private System.Windows.Forms.Panel panel1;
    }
}

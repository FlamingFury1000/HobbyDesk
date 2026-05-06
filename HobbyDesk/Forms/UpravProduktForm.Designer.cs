namespace HobbyDesk.Forms
{
    partial class UpravProduktForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpravProduktForm));
            this.textBoxNazev = new System.Windows.Forms.TextBox();
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.comboBoxKategorie = new System.Windows.Forms.ComboBox();
            this.comboBoxVyrobce = new System.Windows.Forms.ComboBox();
            this.buttonUloz = new System.Windows.Forms.Button();
            this.buttonZrus = new System.Windows.Forms.Button();
            this.numericUpDownPocet = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxObrazek = new System.Windows.Forms.PictureBox();
            this.buttonVyberObrazek = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonZrusObrazek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPocet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNazev
            // 
            this.textBoxNazev.Location = new System.Drawing.Point(152, 212);
            this.textBoxNazev.Name = "textBoxNazev";
            this.textBoxNazev.Size = new System.Drawing.Size(224, 26);
            this.textBoxNazev.TabIndex = 0;
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Location = new System.Drawing.Point(152, 397);
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(224, 26);
            this.numericUpDownID.TabIndex = 1;
            // 
            // comboBoxKategorie
            // 
            this.comboBoxKategorie.FormattingEnabled = true;
            this.comboBoxKategorie.Location = new System.Drawing.Point(152, 302);
            this.comboBoxKategorie.Name = "comboBoxKategorie";
            this.comboBoxKategorie.Size = new System.Drawing.Size(224, 28);
            this.comboBoxKategorie.TabIndex = 2;
            // 
            // comboBoxVyrobce
            // 
            this.comboBoxVyrobce.FormattingEnabled = true;
            this.comboBoxVyrobce.Location = new System.Drawing.Point(152, 350);
            this.comboBoxVyrobce.Name = "comboBoxVyrobce";
            this.comboBoxVyrobce.Size = new System.Drawing.Size(224, 28);
            this.comboBoxVyrobce.TabIndex = 3;
            // 
            // buttonUloz
            // 
            this.buttonUloz.Location = new System.Drawing.Point(251, 491);
            this.buttonUloz.Name = "buttonUloz";
            this.buttonUloz.Size = new System.Drawing.Size(125, 40);
            this.buttonUloz.TabIndex = 4;
            this.buttonUloz.Text = "Uložit";
            this.buttonUloz.UseVisualStyleBackColor = true;
            this.buttonUloz.Click += new System.EventHandler(this.ButtonUloz_Click);
            // 
            // buttonZrus
            // 
            this.buttonZrus.Location = new System.Drawing.Point(29, 491);
            this.buttonZrus.Name = "buttonZrus";
            this.buttonZrus.Size = new System.Drawing.Size(125, 40);
            this.buttonZrus.TabIndex = 5;
            this.buttonZrus.Text = "Zrušit";
            this.buttonZrus.UseVisualStyleBackColor = true;
            this.buttonZrus.Click += new System.EventHandler(this.ButtonZrus_Click);
            // 
            // numericUpDownPocet
            // 
            this.numericUpDownPocet.Location = new System.Drawing.Point(152, 256);
            this.numericUpDownPocet.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPocet.Name = "numericUpDownPocet";
            this.numericUpDownPocet.Size = new System.Drawing.Size(224, 26);
            this.numericUpDownPocet.TabIndex = 6;
            // 
            // pictureBoxObrazek
            // 
            this.pictureBoxObrazek.Location = new System.Drawing.Point(29, 24);
            this.pictureBoxObrazek.Name = "pictureBoxObrazek";
            this.pictureBoxObrazek.Size = new System.Drawing.Size(163, 163);
            this.pictureBoxObrazek.TabIndex = 7;
            this.pictureBoxObrazek.TabStop = false;
            // 
            // buttonVyberObrazek
            // 
            this.buttonVyberObrazek.Location = new System.Drawing.Point(213, 24);
            this.buttonVyberObrazek.Name = "buttonVyberObrazek";
            this.buttonVyberObrazek.Size = new System.Drawing.Size(163, 40);
            this.buttonVyberObrazek.TabIndex = 8;
            this.buttonVyberObrazek.Text = "Vyber";
            this.buttonVyberObrazek.UseVisualStyleBackColor = true;
            this.buttonVyberObrazek.Click += new System.EventHandler(this.ButtonVyberObrazek_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonZrusObrazek
            // 
            this.buttonZrusObrazek.Location = new System.Drawing.Point(213, 147);
            this.buttonZrusObrazek.Name = "buttonZrusObrazek";
            this.buttonZrusObrazek.Size = new System.Drawing.Size(163, 40);
            this.buttonZrusObrazek.TabIndex = 9;
            this.buttonZrusObrazek.Text = "Smazat";
            this.buttonZrusObrazek.UseVisualStyleBackColor = true;
            this.buttonZrusObrazek.Click += new System.EventHandler(this.ButtonZrusObrazek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Počet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kategorie: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Výrobce:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID (Pokročilé):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Název:";
            // 
            // UpravProduktForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 547);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonZrusObrazek);
            this.Controls.Add(this.buttonVyberObrazek);
            this.Controls.Add(this.pictureBoxObrazek);
            this.Controls.Add(this.buttonZrus);
            this.Controls.Add(this.buttonUloz);
            this.Controls.Add(this.numericUpDownID);
            this.Controls.Add(this.comboBoxVyrobce);
            this.Controls.Add(this.comboBoxKategorie);
            this.Controls.Add(this.numericUpDownPocet);
            this.Controls.Add(this.textBoxNazev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpravProduktForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpravProduktForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPocet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObrazek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNazev;
        private System.Windows.Forms.NumericUpDown numericUpDownPocet;
        private System.Windows.Forms.ComboBox comboBoxKategorie;
        private System.Windows.Forms.ComboBox comboBoxVyrobce;
        private System.Windows.Forms.NumericUpDown numericUpDownID;
        private System.Windows.Forms.Button buttonUloz;
        private System.Windows.Forms.Button buttonZrus;
        private System.Windows.Forms.PictureBox pictureBoxObrazek;
        private System.Windows.Forms.Button buttonVyberObrazek;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonZrusObrazek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
namespace HobbyDesk
{
    partial class IndexControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea29 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend29 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea30 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend30 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelPocetProduktu = new System.Windows.Forms.Label();
            this.labelPocetKategorii = new System.Windows.Forms.Label();
            this.labelPocetVyrobcu = new System.Windows.Forms.Label();
            this.chartKategorie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVyrobci = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelKategorie = new System.Windows.Forms.Label();
            this.labelVyrobci = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartKategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVyrobci)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.labelPocetProduktu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelWelcome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(63, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 152);
            this.panel1.TabIndex = 1;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWelcome.Location = new System.Drawing.Point(258, -9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(427, 52);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Vítejte v HobbyDesk!";
            // 
            // labelPocetProduktu
            // 
            this.labelPocetProduktu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPocetProduktu.AutoSize = true;
            this.labelPocetProduktu.BackColor = System.Drawing.Color.Transparent;
            this.labelPocetProduktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPocetProduktu.Location = new System.Drawing.Point(330, 120);
            this.labelPocetProduktu.Name = "labelPocetProduktu";
            this.labelPocetProduktu.Size = new System.Drawing.Size(275, 29);
            this.labelPocetProduktu.TabIndex = 2;
            this.labelPocetProduktu.Text = "Aktuální počet produktů: ";
            this.labelPocetProduktu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPocetKategorii
            // 
            this.labelPocetKategorii.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPocetKategorii.BackColor = System.Drawing.Color.Transparent;
            this.labelPocetKategorii.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.labelPocetKategorii.Location = new System.Drawing.Point(245, 223);
            this.labelPocetKategorii.Margin = new System.Windows.Forms.Padding(0);
            this.labelPocetKategorii.Name = "labelPocetKategorii";
            this.labelPocetKategorii.Size = new System.Drawing.Size(32, 17);
            this.labelPocetKategorii.TabIndex = 3;
            this.labelPocetKategorii.Text = "999";
            this.labelPocetKategorii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPocetVyrobcu
            // 
            this.labelPocetVyrobcu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPocetVyrobcu.BackColor = System.Drawing.Color.Transparent;
            this.labelPocetVyrobcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.labelPocetVyrobcu.Location = new System.Drawing.Point(246, 223);
            this.labelPocetVyrobcu.Margin = new System.Windows.Forms.Padding(0);
            this.labelPocetVyrobcu.Name = "labelPocetVyrobcu";
            this.labelPocetVyrobcu.Size = new System.Drawing.Size(32, 17);
            this.labelPocetVyrobcu.TabIndex = 4;
            this.labelPocetVyrobcu.Text = "999";
            this.labelPocetVyrobcu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartKategorie
            // 
            this.chartKategorie.BackColor = System.Drawing.Color.Transparent;
            chartArea29.AxisX.LabelStyle.Enabled = false;
            chartArea29.AxisX.MajorGrid.Enabled = false;
            chartArea29.AxisY.LabelStyle.Enabled = false;
            chartArea29.AxisY.MajorGrid.Enabled = false;
            chartArea29.BackColor = System.Drawing.Color.Transparent;
            chartArea29.Name = "ChartArea1";
            this.chartKategorie.ChartAreas.Add(chartArea29);
            this.chartKategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            legend29.BackColor = System.Drawing.Color.Transparent;
            legend29.Enabled = false;
            legend29.Name = "Legend1";
            this.chartKategorie.Legends.Add(legend29);
            this.chartKategorie.Location = new System.Drawing.Point(0, 0);
            this.chartKategorie.Name = "chartKategorie";
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series29.CustomProperties = "PieLabelStyle=Outside, PieLineColor=Gray, PieDrawingStyle=Concave";
            series29.IsValueShownAsLabel = true;
            series29.Label = "#VALX\\n#VAL";
            series29.Legend = "Legend1";
            series29.Name = "Kategorie";
            this.chartKategorie.Series.Add(series29);
            this.chartKategorie.Size = new System.Drawing.Size(521, 470);
            this.chartKategorie.TabIndex = 5;
            this.chartKategorie.Text = "chart1";
            // 
            // chartVyrobci
            // 
            this.chartVyrobci.BackColor = System.Drawing.Color.Transparent;
            chartArea30.AxisX.LabelStyle.Enabled = false;
            chartArea30.AxisX.MajorGrid.Enabled = false;
            chartArea30.AxisY.LabelStyle.Enabled = false;
            chartArea30.AxisY.MajorGrid.Enabled = false;
            chartArea30.BackColor = System.Drawing.Color.Transparent;
            chartArea30.Name = "ChartArea1";
            this.chartVyrobci.ChartAreas.Add(chartArea30);
            this.chartVyrobci.Dock = System.Windows.Forms.DockStyle.Fill;
            legend30.BackColor = System.Drawing.Color.Transparent;
            legend30.Enabled = false;
            legend30.Name = "Legend1";
            this.chartVyrobci.Legends.Add(legend30);
            this.chartVyrobci.Location = new System.Drawing.Point(0, 0);
            this.chartVyrobci.Name = "chartVyrobci";
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series30.CustomProperties = "PieLabelStyle=Outside, PieLineColor=Gray, PieDrawingStyle=Concave";
            series30.IsValueShownAsLabel = true;
            series30.Label = "#VALX\\n#VAL";
            series30.Legend = "Legend1";
            series30.Name = "Výrobci";
            this.chartVyrobci.Series.Add(series30);
            this.chartVyrobci.Size = new System.Drawing.Size(522, 470);
            this.chartVyrobci.TabIndex = 6;
            this.chartVyrobci.Text = "chart2";
            // 
            // labelKategorie
            // 
            this.labelKategorie.AutoSize = true;
            this.labelKategorie.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKategorie.Location = new System.Drawing.Point(3, 0);
            this.labelKategorie.Name = "labelKategorie";
            this.labelKategorie.Size = new System.Drawing.Size(521, 29);
            this.labelKategorie.TabIndex = 7;
            this.labelKategorie.Text = "Produkty podle kategorie:";
            this.labelKategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVyrobci
            // 
            this.labelVyrobci.AutoSize = true;
            this.labelVyrobci.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelVyrobci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelVyrobci.Location = new System.Drawing.Point(530, 0);
            this.labelVyrobci.Name = "labelVyrobci";
            this.labelVyrobci.Size = new System.Drawing.Size(522, 29);
            this.labelVyrobci.TabIndex = 8;
            this.labelVyrobci.Text = "Produkty podle výrobce:";
            this.labelVyrobci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(188, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Zde můžete sledovat přehled svých produktů a jejich výrobců.";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(61, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 2);
            this.panel2.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelKategorie, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelVyrobci, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 253);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1055, 516);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1055, 253);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelPocetKategorii);
            this.panel3.Controls.Add(this.chartKategorie);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(521, 470);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelPocetVyrobcu);
            this.panel4.Controls.Add(this.chartVyrobci);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(530, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(522, 470);
            this.panel4.TabIndex = 12;
            // 
            // IndexControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "IndexControl";
            this.Size = new System.Drawing.Size(1055, 769);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartKategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVyrobci)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelPocetProduktu;
        private System.Windows.Forms.Label labelPocetVyrobcu;
        private System.Windows.Forms.Label labelPocetKategorii;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKategorie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVyrobci;
        private System.Windows.Forms.Label labelVyrobci;
        private System.Windows.Forms.Label labelKategorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

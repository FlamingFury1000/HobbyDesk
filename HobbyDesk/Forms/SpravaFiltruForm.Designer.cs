namespace HobbyDesk.Forms
{
    partial class SpravaFiltruForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpravaFiltruForm));
            this.listViewFiltry = new System.Windows.Forms.ListView();
            this.contextMenuProdukty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemUpravit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSmazat = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonZavri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOdeber = new System.Windows.Forms.Button();
            this.imageListTlacitka = new System.Windows.Forms.ImageList(this.components);
            this.buttonUprav = new System.Windows.Forms.Button();
            this.buttonPridej = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuProdukty.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewFiltry
            // 
            this.listViewFiltry.ContextMenuStrip = this.contextMenuProdukty;
            this.listViewFiltry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFiltry.FullRowSelect = true;
            this.listViewFiltry.GridLines = true;
            this.listViewFiltry.HideSelection = false;
            this.listViewFiltry.Location = new System.Drawing.Point(0, 118);
            this.listViewFiltry.Name = "listViewFiltry";
            this.listViewFiltry.Size = new System.Drawing.Size(444, 460);
            this.listViewFiltry.TabIndex = 0;
            this.listViewFiltry.UseCompatibleStateImageBehavior = false;
            this.listViewFiltry.View = System.Windows.Forms.View.Details;
            this.listViewFiltry.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewFiltryMouseDoubleClick);
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
            // buttonZavri
            // 
            this.buttonZavri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZavri.Location = new System.Drawing.Point(306, 10);
            this.buttonZavri.Name = "buttonZavri";
            this.buttonZavri.Size = new System.Drawing.Size(125, 40);
            this.buttonZavri.TabIndex = 2;
            this.buttonZavri.Text = "Zavřít";
            this.buttonZavri.UseVisualStyleBackColor = true;
            this.buttonZavri.Click += new System.EventHandler(this.ButtonZavriClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonZavri);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 578);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 62);
            this.panel1.TabIndex = 3;
            // 
            // buttonOdeber
            // 
            this.buttonOdeber.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOdeber.ImageIndex = 3;
            this.buttonOdeber.ImageList = this.imageListTlacitka;
            this.buttonOdeber.Location = new System.Drawing.Point(210, 12);
            this.buttonOdeber.Name = "buttonOdeber";
            this.buttonOdeber.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonOdeber.Size = new System.Drawing.Size(94, 94);
            this.buttonOdeber.TabIndex = 17;
            this.buttonOdeber.Text = "Odeber";
            this.buttonOdeber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOdeber.UseVisualStyleBackColor = true;
            this.buttonOdeber.Click += new System.EventHandler(this.ButtonOdeberClick);
            // 
            // imageListTlacitka
            // 
            this.imageListTlacitka.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTlacitka.ImageStream")));
            this.imageListTlacitka.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTlacitka.Images.SetKeyName(0, "ikona_plus.png");
            this.imageListTlacitka.Images.SetKeyName(1, "ikona_reset.png");
            this.imageListTlacitka.Images.SetKeyName(2, "ikona_edit.png");
            this.imageListTlacitka.Images.SetKeyName(3, "ikona_delete.png");
            // 
            // buttonUprav
            // 
            this.buttonUprav.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUprav.ImageIndex = 2;
            this.buttonUprav.ImageList = this.imageListTlacitka;
            this.buttonUprav.Location = new System.Drawing.Point(111, 12);
            this.buttonUprav.Name = "buttonUprav";
            this.buttonUprav.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonUprav.Size = new System.Drawing.Size(94, 94);
            this.buttonUprav.TabIndex = 16;
            this.buttonUprav.Text = "Uprav";
            this.buttonUprav.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUprav.UseVisualStyleBackColor = true;
            this.buttonUprav.Click += new System.EventHandler(this.ButtonUpravClick);
            // 
            // buttonPridej
            // 
            this.buttonPridej.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPridej.ImageIndex = 0;
            this.buttonPridej.ImageList = this.imageListTlacitka;
            this.buttonPridej.Location = new System.Drawing.Point(11, 12);
            this.buttonPridej.Name = "buttonPridej";
            this.buttonPridej.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonPridej.Size = new System.Drawing.Size(94, 94);
            this.buttonPridej.TabIndex = 15;
            this.buttonPridej.Text = "Přidej";
            this.buttonPridej.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPridej.UseVisualStyleBackColor = true;
            this.buttonPridej.Click += new System.EventHandler(this.ButtonPridejClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonUprav);
            this.panel2.Controls.Add(this.buttonOdeber);
            this.panel2.Controls.Add(this.buttonPridej);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 118);
            this.panel2.TabIndex = 18;
            // 
            // SpravaFiltruForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 640);
            this.Controls.Add(this.listViewFiltry);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpravaFiltruForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpravaFiltruForm";
            this.contextMenuProdukty.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewFiltry;
        private System.Windows.Forms.Button buttonZavri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOdeber;
        private System.Windows.Forms.Button buttonUprav;
        private System.Windows.Forms.Button buttonPridej;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuProdukty;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpravit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSmazat;
        private System.Windows.Forms.ImageList imageListTlacitka;
    }
}
namespace NotePad
{
    partial class NotepadFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadFrm));
            this.TxtArea = new System.Windows.Forms.TextBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.LnNo = new System.Windows.Forms.ToolStripStatusLabel();
            this.ClmNo = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaveStat = new System.Windows.Forms.ToolStripStatusLabel();
            this.FlnameSt = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuStrp = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteManu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fntDial1 = new System.Windows.Forms.FontDialog();
            this.prtDial1 = new System.Windows.Forms.PrintDialog();
            this.sFlDial1 = new System.Windows.Forms.SaveFileDialog();
            this.opnFlDial1 = new System.Windows.Forms.OpenFileDialog();
            this.ClrDial1 = new System.Windows.Forms.ColorDialog();
            this.statusBar.SuspendLayout();
            this.mnuStrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtArea
            // 
            this.TxtArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtArea.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArea.Location = new System.Drawing.Point(0, 27);
            this.TxtArea.Multiline = true;
            this.TxtArea.Name = "TxtArea";
            this.TxtArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtArea.Size = new System.Drawing.Size(917, 335);
            this.TxtArea.TabIndex = 0;
            this.TxtArea.WordWrap = false;
            this.TxtArea.TextChanged += new System.EventHandler(this.TxtArea_TextChanged);
            this.TxtArea.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtArea_KeyUp);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveStat,
            this.FlnameSt,
            this.LnNo,
            this.ClmNo});
            this.statusBar.Location = new System.Drawing.Point(0, 365);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(917, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "Status : ";
            // 
            // LnNo
            // 
            this.LnNo.Name = "LnNo";
            this.LnNo.Size = new System.Drawing.Size(0, 17);
            this.LnNo.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // ClmNo
            // 
            this.ClmNo.Name = "ClmNo";
            this.ClmNo.Size = new System.Drawing.Size(0, 17);
            // 
            // SaveStat
            // 
            this.SaveStat.Name = "SaveStat";
            this.SaveStat.Size = new System.Drawing.Size(52, 17);
            this.SaveStat.Text = "Unsaved";
            // 
            // FlnameSt
            // 
            this.FlnameSt.Name = "FlnameSt";
            this.FlnameSt.Size = new System.Drawing.Size(68, 17);
            this.FlnameSt.Text = "Unsaved.txt";
            // 
            // mnuStrp
            // 
            this.mnuStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.formatMenu});
            this.mnuStrp.Location = new System.Drawing.Point(0, 0);
            this.mnuStrp.Name = "mnuStrp";
            this.mnuStrp.Size = new System.Drawing.Size(917, 24);
            this.mnuStrp.TabIndex = 2;
            this.mnuStrp.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nFileMenu,
            this.openFileMenu,
            this.saveFileMenu,
            this.saveAsFileMenu,
            this.toolStripMenuItem1,
            this.exitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // nFileMenu
            // 
            this.nFileMenu.Name = "nFileMenu";
            this.nFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nFileMenu.Size = new System.Drawing.Size(155, 22);
            this.nFileMenu.Text = "New";
            this.nFileMenu.Click += new System.EventHandler(this.nFileMenu_Click);
            // 
            // openFileMenu
            // 
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileMenu.Size = new System.Drawing.Size(155, 22);
            this.openFileMenu.Text = "Open...";
            this.openFileMenu.Click += new System.EventHandler(this.openFileMenu_Click);
            // 
            // saveFileMenu
            // 
            this.saveFileMenu.Name = "saveFileMenu";
            this.saveFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileMenu.Size = new System.Drawing.Size(155, 22);
            this.saveFileMenu.Text = "Save";
            this.saveFileMenu.Click += new System.EventHandler(this.saveFileMenu_Click);
            // 
            // saveAsFileMenu
            // 
            this.saveAsFileMenu.Name = "saveAsFileMenu";
            this.saveAsFileMenu.Size = new System.Drawing.Size(155, 22);
            this.saveAsFileMenu.Text = "Save As...";
            this.saveAsFileMenu.Click += new System.EventHandler(this.saveAsFileMenu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(155, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutMenu,
            this.copyMenu,
            this.pasteManu,
            this.deleteMenu,
            this.selectAllMenu});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "&Edit";
            // 
            // cutMenu
            // 
            this.cutMenu.Name = "cutMenu";
            this.cutMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMenu.Size = new System.Drawing.Size(164, 22);
            this.cutMenu.Text = "Cut";
            this.cutMenu.Click += new System.EventHandler(this.cutMenu_Click);
            // 
            // copyMenu
            // 
            this.copyMenu.Name = "copyMenu";
            this.copyMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenu.Size = new System.Drawing.Size(164, 22);
            this.copyMenu.Text = "Copy";
            this.copyMenu.Click += new System.EventHandler(this.copyMenu_Click);
            // 
            // pasteManu
            // 
            this.pasteManu.Name = "pasteManu";
            this.pasteManu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteManu.Size = new System.Drawing.Size(164, 22);
            this.pasteManu.Text = "Paste";
            this.pasteManu.Click += new System.EventHandler(this.pasteManu_Click);
            // 
            // deleteMenu
            // 
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteMenu.Size = new System.Drawing.Size(164, 22);
            this.deleteMenu.Text = "Delete";
            this.deleteMenu.Click += new System.EventHandler(this.deleteMenu_Click);
            // 
            // selectAllMenu
            // 
            this.selectAllMenu.Name = "selectAllMenu";
            this.selectAllMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllMenu.Size = new System.Drawing.Size(164, 22);
            this.selectAllMenu.Text = "Select All";
            this.selectAllMenu.Click += new System.EventHandler(this.selectAllMenu_Click);
            // 
            // formatMenu
            // 
            this.formatMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontMenu,
            this.colorToolStripMenuItem});
            this.formatMenu.Name = "formatMenu";
            this.formatMenu.Size = new System.Drawing.Size(57, 20);
            this.formatMenu.Text = "F&ormat";
            // 
            // fontMenu
            // 
            this.fontMenu.Name = "fontMenu";
            this.fontMenu.Size = new System.Drawing.Size(103, 22);
            this.fontMenu.Text = "Font";
            this.fontMenu.Click += new System.EventHandler(this.fontMenu_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foreColorMenu,
            this.backColorMenu});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // foreColorMenu
            // 
            this.foreColorMenu.Name = "foreColorMenu";
            this.foreColorMenu.Size = new System.Drawing.Size(131, 22);
            this.foreColorMenu.Text = "Fore Color";
            this.foreColorMenu.Click += new System.EventHandler(this.foreColorMenu_Click);
            // 
            // backColorMenu
            // 
            this.backColorMenu.Name = "backColorMenu";
            this.backColorMenu.Size = new System.Drawing.Size(131, 22);
            this.backColorMenu.Text = "Back Color";
            this.backColorMenu.Click += new System.EventHandler(this.backColorMenu_Click);
            // 
            // prtDial1
            // 
            this.prtDial1.UseEXDialog = true;
            // 
            // opnFlDial1
            // 
            this.opnFlDial1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 387);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mnuStrp);
            this.Controls.Add(this.TxtArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuStrp;
            this.Name = "Form1";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.mnuStrp.ResumeLayout(false);
            this.mnuStrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtArea;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip mnuStrp;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem nFileMenu;
        private System.Windows.Forms.ToolStripMenuItem openFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsFileMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem cutMenu;
        private System.Windows.Forms.ToolStripMenuItem copyMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteManu;
        private System.Windows.Forms.ToolStripMenuItem deleteMenu;
        private System.Windows.Forms.ToolStripMenuItem formatMenu;
        private System.Windows.Forms.ToolStripMenuItem fontMenu;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreColorMenu;
        private System.Windows.Forms.ToolStripMenuItem backColorMenu;
        private System.Windows.Forms.ToolStripStatusLabel LnNo;
        private System.Windows.Forms.ToolStripStatusLabel ClmNo;
        private System.Windows.Forms.FontDialog fntDial1;
        private System.Windows.Forms.PrintDialog prtDial1;
        private System.Windows.Forms.SaveFileDialog sFlDial1;
        private System.Windows.Forms.OpenFileDialog opnFlDial1;
        private System.Windows.Forms.ColorDialog ClrDial1;
        private System.Windows.Forms.ToolStripStatusLabel SaveStat;
        private System.Windows.Forms.ToolStripStatusLabel FlnameSt;
        private System.Windows.Forms.ToolStripMenuItem selectAllMenu;
    }
}


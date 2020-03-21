namespace Lunch_Time
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fastObjectListView1 = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.labelWindowTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbWindowicon = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelControlBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWindowicon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnIn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOut, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(913, 49);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(616, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 49);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ADP";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnIn
            // 
            this.btnIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Location = new System.Drawing.Point(816, 3);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(94, 43);
            this.btnIn.TabIndex = 1;
            this.btnIn.TabStop = false;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOut
            // 
            this.btnOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Location = new System.Drawing.Point(716, 3);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(94, 43);
            this.btnOut.TabIndex = 0;
            this.btnOut.TabStop = false;
            this.btnOut.Text = "Out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fastObjectListView1
            // 
            this.fastObjectListView1.AllColumns.Add(this.olvColumn1);
            this.fastObjectListView1.AllColumns.Add(this.olvColumn2);
            this.fastObjectListView1.AllColumns.Add(this.olvColumn5);
            this.fastObjectListView1.AllColumns.Add(this.olvColumn3);
            this.fastObjectListView1.AllColumns.Add(this.olvColumn4);
            this.fastObjectListView1.AllColumns.Add(this.olvColumn6);
            this.fastObjectListView1.CellEditUseWholeCell = false;
            this.fastObjectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn5,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn6});
            this.fastObjectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.fastObjectListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastObjectListView1.FullRowSelect = true;
            this.fastObjectListView1.HideSelection = false;
            this.fastObjectListView1.Location = new System.Drawing.Point(0, 72);
            this.fastObjectListView1.Name = "fastObjectListView1";
            this.fastObjectListView1.ShowGroups = false;
            this.fastObjectListView1.Size = new System.Drawing.Size(913, 472);
            this.fastObjectListView1.TabIndex = 1;
            this.fastObjectListView1.UseAlternatingBackColors = true;
            this.fastObjectListView1.UseCellFormatEvents = true;
            this.fastObjectListView1.UseCompatibleStateImageBehavior = false;
            this.fastObjectListView1.View = System.Windows.Forms.View.Details;
            this.fastObjectListView1.VirtualMode = true;
            this.fastObjectListView1.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.fastObjectListView1_FormatCell);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "DisplayName";
            this.olvColumn1.FillsFreeSpace = true;
            this.olvColumn1.Text = "Name";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "NoteOut";
            this.olvColumn2.Text = "Note Out";
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "NoteIn";
            this.olvColumn5.Text = "Note In";
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Out";
            this.olvColumn3.Text = "Out";
            this.olvColumn3.Width = 120;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "In";
            this.olvColumn4.Text = "In";
            this.olvColumn4.Width = 120;
            // 
            // olvColumn6
            // 
            this.olvColumn6.Hideable = false;
            this.olvColumn6.IsEditable = false;
            this.olvColumn6.ShowTextInHeader = false;
            this.olvColumn6.Sortable = false;
            this.olvColumn6.Width = 3;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.fastObjectListView1);
            this.panelContent.Controls.Add(this.tableLayoutPanel1);
            this.panelContent.Controls.Add(this.panelControlBox);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(913, 544);
            this.panelContent.TabIndex = 2;
            // 
            // panelControlBox
            // 
            this.panelControlBox.Controls.Add(this.labelWindowTitle);
            this.panelControlBox.Controls.Add(this.menuStrip1);
            this.panelControlBox.Controls.Add(this.pbWindowicon);
            this.panelControlBox.Controls.Add(this.btnMin);
            this.panelControlBox.Controls.Add(this.btnMax);
            this.panelControlBox.Controls.Add(this.btnClose);
            this.panelControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlBox.Location = new System.Drawing.Point(0, 0);
            this.panelControlBox.Name = "panelControlBox";
            this.panelControlBox.Size = new System.Drawing.Size(913, 23);
            this.panelControlBox.TabIndex = 3;
            // 
            // labelWindowTitle
            // 
            this.labelWindowTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWindowTitle.Location = new System.Drawing.Point(110, 0);
            this.labelWindowTitle.Name = "labelWindowTitle";
            this.labelWindowTitle.Size = new System.Drawing.Size(653, 23);
            this.labelWindowTitle.TabIndex = 5;
            this.labelWindowTitle.Text = "label2";
            this.labelWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(23, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(87, 23);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pbWindowicon
            // 
            this.pbWindowicon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbWindowicon.Location = new System.Drawing.Point(0, 0);
            this.pbWindowicon.Name = "pbWindowicon";
            this.pbWindowicon.Size = new System.Drawing.Size(23, 23);
            this.pbWindowicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWindowicon.TabIndex = 3;
            this.pbWindowicon.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(763, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 23);
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Text = "button5";
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // btnMax
            // 
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(813, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(50, 23);
            this.btnMax.TabIndex = 1;
            this.btnMax.TabStop = false;
            this.btnMax.Text = "button4";
            this.btnMax.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(863, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "button3";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 544);
            this.Controls.Add(this.panelContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lunch Time!?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelControlBox.ResumeLayout(false);
            this.panelControlBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWindowicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnIn;
        private BrightIdeasSoftware.FastObjectListView fastObjectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelControlBox;
        private System.Windows.Forms.Label labelWindowTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbWindowicon;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}


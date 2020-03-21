namespace Lunch_Time
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.pbWindowicon = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelWindowTitle = new System.Windows.Forms.Label();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.cbDay = new Lunch_Time.CustomComboBox();
            this.cbMonth = new Lunch_Time.CustomComboBox();
            this.cbYear = new Lunch_Time.CustomComboBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.fastObjectListView1 = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.pbWindowicon)).BeginInit();
            this.panelControlBox.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).BeginInit();
            this.SuspendLayout();
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
            this.btnMin.Location = new System.Drawing.Point(650, 0);
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
            this.btnMax.Location = new System.Drawing.Point(700, 0);
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
            this.btnClose.Location = new System.Drawing.Point(750, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "button3";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // labelWindowTitle
            // 
            this.labelWindowTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWindowTitle.Location = new System.Drawing.Point(284, 0);
            this.labelWindowTitle.Name = "labelWindowTitle";
            this.labelWindowTitle.Size = new System.Drawing.Size(366, 23);
            this.labelWindowTitle.TabIndex = 5;
            this.labelWindowTitle.Text = "label2";
            this.labelWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControlBox
            // 
            this.panelControlBox.Controls.Add(this.labelWindowTitle);
            this.panelControlBox.Controls.Add(this.cbDay);
            this.panelControlBox.Controls.Add(this.cbMonth);
            this.panelControlBox.Controls.Add(this.cbYear);
            this.panelControlBox.Controls.Add(this.pbWindowicon);
            this.panelControlBox.Controls.Add(this.btnMin);
            this.panelControlBox.Controls.Add(this.btnMax);
            this.panelControlBox.Controls.Add(this.btnClose);
            this.panelControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlBox.Location = new System.Drawing.Point(0, 0);
            this.panelControlBox.Name = "panelControlBox";
            this.panelControlBox.Size = new System.Drawing.Size(800, 23);
            this.panelControlBox.TabIndex = 3;
            // 
            // cbDay
            // 
            this.cbDay.BorderColor2 = System.Drawing.Color.DimGray;
            this.cbDay.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(204, 0);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(80, 21);
            this.cbDay.TabIndex = 8;
            this.cbDay.SelectedIndexChanged += new System.EventHandler(this.cbDay_SelectedIndexChanged);
            // 
            // cbMonth
            // 
            this.cbMonth.BorderColor2 = System.Drawing.Color.DimGray;
            this.cbMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(114, 0);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(90, 21);
            this.cbMonth.TabIndex = 7;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // cbYear
            // 
            this.cbYear.BorderColor2 = System.Drawing.Color.DimGray;
            this.cbYear.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(23, 0);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(91, 21);
            this.cbYear.TabIndex = 6;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.fastObjectListView1);
            this.panelContent.Controls.Add(this.panelControlBox);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 450);
            this.panelContent.TabIndex = 3;
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
            this.fastObjectListView1.Location = new System.Drawing.Point(0, 23);
            this.fastObjectListView1.Name = "fastObjectListView1";
            this.fastObjectListView1.ShowGroups = false;
            this.fastObjectListView1.Size = new System.Drawing.Size(800, 427);
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
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryForm";
            this.Text = "History";
            this.Resize += new System.EventHandler(this.HistoryForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbWindowicon)).EndInit();
            this.panelControlBox.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbWindowicon;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelWindowTitle;
        private System.Windows.Forms.Panel panelControlBox;
        private System.Windows.Forms.Panel panelContent;
        private BrightIdeasSoftware.FastObjectListView fastObjectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private CustomComboBox cbYear;
        private CustomComboBox cbDay;
        private CustomComboBox cbMonth;
    }
}
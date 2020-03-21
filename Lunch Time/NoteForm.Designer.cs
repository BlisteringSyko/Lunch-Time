namespace Lunch_Time
{
    partial class NoteForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.labelWindowTitle = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            this.panelControlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(371, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 133);
            this.textBox1.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.textBox1);
            this.panelContent.Controls.Add(this.panelControlBox);
            this.panelContent.Controls.Add(this.button1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(3, 3);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(371, 187);
            this.panelContent.TabIndex = 2;
            // 
            // panelControlBox
            // 
            this.panelControlBox.Controls.Add(this.labelWindowTitle);
            this.panelControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlBox.Location = new System.Drawing.Point(0, 0);
            this.panelControlBox.Name = "panelControlBox";
            this.panelControlBox.Size = new System.Drawing.Size(371, 20);
            this.panelControlBox.TabIndex = 2;
            // 
            // labelWindowTitle
            // 
            this.labelWindowTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWindowTitle.Location = new System.Drawing.Point(0, 0);
            this.labelWindowTitle.Name = "labelWindowTitle";
            this.labelWindowTitle.Size = new System.Drawing.Size(371, 20);
            this.labelWindowTitle.TabIndex = 0;
            this.labelWindowTitle.Text = "label1";
            // 
            // NoteForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 193);
            this.Controls.Add(this.panelContent);
            this.MinimizeBox = false;
            this.Name = "NoteForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Note?";
            this.TopMost = true;
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelControlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelControlBox;
        private System.Windows.Forms.Label labelWindowTitle;
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;
using formCustomizer;

namespace Lunch_Time
{
    public partial class NoteForm : Form
    {
        FormCustomizer formCustomizer;
        public string Note { get; set; }
        public NoteForm()
        {
            InitializeComponent();
            Note = "";
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Sizable;

            if (formCustomizer is null) formCustomizer = new FormCustomizer(base.Handle, this);

            SetFormCustomizerInitialColors();
            UpdateFormCustomizer();
            formCustomizer.updateControlStyles(this);

            textBox1.DataBindings.Add(new Binding("Text", this, "Note"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        void SetFormCustomizerInitialColors()
        {
            formCustomizer.BackColor = ColorTranslator.FromHtml("#494949");
            formCustomizer.TextColor = ColorTranslator.FromHtml("#E9671B");
            formCustomizer.InputTextColor = ColorTranslator.FromHtml("#FFFFFF");
            formCustomizer.InputColor = ColorTranslator.FromHtml("#595959");
            formCustomizer.TitleTextColor = ColorTranslator.FromHtml("#DCDCDC");
            formCustomizer.MenuTextColor = ColorTranslator.FromHtml("#DCDCDC");
            formCustomizer.ControlButtonTextColor = ColorTranslator.FromHtml("#E9671B");
            formCustomizer.BorderColor = ColorTranslator.FromHtml("#CA5100");
            formCustomizer.ShadowColor = ColorTranslator.FromHtml("#292929");
            formCustomizer.TextStatusStripColor = Color.White;
            formCustomizer.TitleBarColor = ColorTranslator.FromHtml("#494949");
        }

        void UpdateFormCustomizer()
        {
            formCustomizer.setTitleBar(panelControlBox);
            formCustomizer.setTitleLabel(labelWindowTitle);


            panelContent.BackColor = formCustomizer.BackColor;

            button1.FlatAppearance.BorderColor = formCustomizer.BorderColor;
          
        }

        protected override void WndProc(ref Message m)
        {
            if (formCustomizer is null) formCustomizer = new FormCustomizer(base.Handle, this);
            if (formCustomizer.pWndProc(ref m)) base.WndProc(ref m);
        }
    }
}

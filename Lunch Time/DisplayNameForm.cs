using System;
using System.Windows.Forms;

namespace Lunch_Time
{
    public partial class DisplayNameForm : Form
    {
        public string DisplayName { get; set; }

        public DisplayNameForm()
        {
            InitializeComponent();
            DisplayName = Environment.UserName;
            textBox1.DataBindings.Add(new Binding("Text", this, "DisplayName", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(DisplayName is null) && !DisplayName.Trim().Equals(""))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

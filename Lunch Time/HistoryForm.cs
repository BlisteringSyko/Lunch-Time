using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using formCustomizer;
using System.IO;
using Newtonsoft.Json;

namespace Lunch_Time
{
    public partial class HistoryForm : Form
    {

        FormCustomizer formCustomizer;

        List<LogFile> LogFiles;

        private string _year;
        public string Year
        {
            get { return _year; }

            set
            {
                _year = value;
                Month = "";
                cbMonth.Items.Clear();
            }
        }

        private string _month;
        public string Month
        {
            get { return _month; }

            set
            {
                _month = value;
                Day = "";
                cbDay.Items.Clear();
            }
        }

        private string _day;
        public string Day
        {
            get { return _day; }
            set
            {
                _day = value;
            }
        }


        public HistoryForm(Settings settings)
        {
            InitializeComponent();

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


            LogFiles = new List<LogFile>();

            DirectoryInfo di = new DirectoryInfo(settings.LogFolder);
            FileInfo[] fi = di.GetFiles();
            foreach (FileInfo fii in fi)
            {
                if (fii.Extension == ".json")
                {
                    LogFile lf = JsonConvert.DeserializeObject<LogFile>(File.ReadAllText(fii.FullName));
                    LogFiles.Add(lf);

                    if (!cbYear.Items.Contains(lf.getYear()))
                    {
                        cbYear.Items.Add(lf.getYear());
                    }
                }

            }

        }

        void SetFormCustomizerInitialColors()
        {
            formCustomizer.BackColor = ColorTranslator.FromHtml("#494949");
            formCustomizer.TextColor = ColorTranslator.FromHtml("#E9671B");
            formCustomizer.InputTextColor = ColorTranslator.FromHtml("#FFFFFF");
            formCustomizer.InputColor = ColorTranslator.FromHtml("#696969");
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
            formCustomizer.isDialog = true;
            formCustomizer.setTitleBar(panelControlBox);
            formCustomizer.setTitleLabel(labelWindowTitle);
            formCustomizer.setIcon(pbWindowicon);
            formCustomizer.setCloseButton(btnClose);
            formCustomizer.setMaxiButton(btnMax);
            formCustomizer.setMiniButton(btnMin);

            panelContent.BackColor = formCustomizer.BackColor;

            cbYear.BorderColor = formCustomizer.ShadowColor;
            cbYear.BorderColor2 = formCustomizer.BorderColor;
            cbYear.BackColor = formCustomizer.BackColor;
            cbYear.ForeColor = formCustomizer.InputTextColor;

            cbMonth.BorderColor = formCustomizer.ShadowColor;
            cbMonth.BorderColor2 = formCustomizer.BorderColor;
            cbMonth.BackColor = formCustomizer.BackColor;
            cbMonth.ForeColor = formCustomizer.InputTextColor;

            cbDay.BorderColor = formCustomizer.ShadowColor;
            cbDay.BorderColor2 = formCustomizer.BorderColor;
            cbDay.BackColor = formCustomizer.BackColor;
            cbDay.ForeColor = formCustomizer.InputTextColor;


            fastObjectListView1.BackColor = formCustomizer.BackColor;
            fastObjectListView1.ForeColor = Color.WhiteSmoke;
            fastObjectListView1.AlternateRowBackColor = formCustomizer.ShadowColor;

            fastObjectListView1.SelectedBackColor = formCustomizer.BorderColor;
            fastObjectListView1.SelectedForeColor = Color.Black;

            foreach (OLVColumn item in fastObjectListView1.Columns)
            {
                var headerstyle = new HeaderFormatStyle();
                headerstyle.SetBackColor(formCustomizer.BackColor);
                headerstyle.SetForeColor(Color.WhiteSmoke);
                item.HeaderFormatStyle = headerstyle;
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (formCustomizer is null) formCustomizer = new FormCustomizer(base.Handle, this);
            if (formCustomizer.pWndProc(ref m)) base.WndProc(ref m);
        }

        private void HistoryForm_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        bool is_odd(int n)
        {
            return n % 2 != 0;
        }

        private void fastObjectListView1_FormatCell(object sender, FormatCellEventArgs e)
        {
            Log log = (Log)e.Model;
            Color bcolor = formCustomizer.BorderColor;

            if (((FastObjectListView)sender).SelectedIndex != -1 && ((Log)((FastObjectListView)sender).SelectedObjects[0]).Equals(log))
            {
                bcolor = Color.Black;
            }

            if (e.Column.IsVisible)
            {
                switch (is_odd(e.ColumnIndex))
                {
                    case true:
                        e.SubItem.Decoration = new CellBorderDecoration()
                        {
                            BoundsPadding = new Size(-2, 0),
                            BorderPen = new Pen(bcolor),
                            FillBrush = null,
                            CornerRounding = 0
                        };
                        break;
                    case false:
                        e.SubItem.Decoration = new CellBorderDecoration()
                        {
                            BoundsPadding = new Size(2, 0),
                            BorderPen = new Pen(bcolor),
                            FillBrush = null,
                            CornerRounding = 0
                        };
                        break;
                }

                switch (e.ColumnIndex)
                {
                    case 0:
                        // the first column is kind of weird, 
                        //the defualt bounds push the left side out of view, 
                        //and pulls the right over by a single pixel. 
                        //Everything above is to adjust the rest to make a uniform grid

                        e.SubItem.Decoration = new CellBorderDecoration()
                        {
                            BoundsPadding = new Size(1, 0),
                            BorderPen = new Pen(bcolor),
                            FillBrush = null,
                            CornerRounding = 0
                        };
                        break;
                    case 5:
                        // the last column fills the empty space to the right of the grid.
                        e.SubItem.Decoration = new CellBorderDecoration()
                        {
                            BoundsPadding = new Size(-5, 1),
                            BorderPen = null,
                            FillBrush = new SolidBrush(formCustomizer.BackColor),
                            CornerRounding = 0
                        };
                        break;
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Year = cbYear.SelectedItem.ToString();
            cbMonth.Items.Clear();
            foreach (LogFile lf in LogFiles)
            {
                if (lf.getYear() == Year && !cbMonth.Items.Contains(lf.getMonth()))
                {
                    cbMonth.Items.Add(lf.getMonth());
                }
            }

        }



        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            Month = cbMonth.SelectedItem.ToString();
            cbDay.Items.Clear();
            foreach (LogFile lf in LogFiles)
            {
                if (lf.getYear() == Year && lf.getMonth() == Month && !cbDay.Items.Contains(lf.getDay()))
                {
                    cbDay.Items.Add(lf.getDay());
                }
            }
        }

        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            Day = cbDay.SelectedItem.ToString();

            LogFile lf = LogFiles.FirstOrDefault(x => x.getYear() == Year && x.getMonth() == Month && x.getDay() == Day);

            if (!(lf is null))
            {
                fastObjectListView1.SetObjects(lf.Logs);
            }
        }
    }
}

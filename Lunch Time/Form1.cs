using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using formCustomizer;
using System.Drawing;
using BrightIdeasSoftware;

namespace Lunch_Time
{
    public partial class Form1 : Form
    {
        FormCustomizer formCustomizer;

        public Settings settings { get; set; }
        public LogFile logFile { get; set; }
        public Form1()
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

            LoadSettings();
            EnterDisplayName();

            label1.DataBindings.Add(new Binding("Text", settings, "DisplayName", false, DataSourceUpdateMode.OnPropertyChanged));

            fileSystemWatcher1.Path = settings.LogFolder;

            ReadLog();
        }

        void SetFormCustomizerInitialColors()
        {
            formCustomizer.BackColor = ColorTranslator.FromHtml("#494949");
            formCustomizer.TextColor = ColorTranslator.FromHtml("#E9671B");
            formCustomizer.InputTextColor = ColorTranslator.FromHtml("#000000");
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
            formCustomizer.setMenuStrip(menuStrip1);
            formCustomizer.setIcon(pbWindowicon);
            formCustomizer.setCloseButton(btnClose);
            formCustomizer.setMaxiButton(btnMax);
            formCustomizer.setMiniButton(btnMin);

            panelContent.BackColor = formCustomizer.BackColor;

            btnOut.FlatAppearance.BorderColor = formCustomizer.BorderColor;
            btnIn.FlatAppearance.BorderColor = formCustomizer.BorderColor;

            linkLabel1.ActiveLinkColor = formCustomizer.BorderColor;
            linkLabel1.LinkColor = formCustomizer.BorderColor;

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

        void LoadSettings()
        {
            if (File.Exists(Application.StartupPath + @"\settings.json"))
            {
                string raw = File.ReadAllText(Application.StartupPath + @"\settings.json");
                settings = JsonConvert.DeserializeObject<Settings>(raw);
                if (!(settings.olvState is null))
                {
                    fastObjectListView1.RestoreState(settings.olvState);
                }
            }
            else
            {
                settings = new Settings();
            }
        }

        void SaveSettings()
        {
            settings.olvState = fastObjectListView1.SaveState();
            string raw = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(Application.StartupPath + @"\settings.json", raw);
        }

        void EnterDisplayName()
        {
            if (settings.DisplayName is null)
            {
                DisplayNameForm dnf = new DisplayNameForm();
                DialogResult dr = dnf.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    settings.DisplayName = dnf.DisplayName;
                    label1.Text = settings.DisplayName;
                }
                else
                {
                    EnterDisplayName();
                }
                SaveSettings();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log log = logFile.Logs.FirstOrDefault(x => x.DisplayName == settings.DisplayName);
            if (!(log is null))
            {
                if (log.Out.Trim().Equals(""))
                {
                    log.Out = DateTime.Now.ToString("hh:mm:ss tt");
                    if (log.NoteOut.Trim().Equals(""))
                    {
                        NoteForm nf = new NoteForm();
                        DialogResult dr = nf.ShowDialog(this);
                        if (dr == DialogResult.OK)
                        {
                            log.NoteOut = nf.Note;
                        }
                    }
                    SaveLog();
                }
            }
            else
            {
                NoteForm nf = new NoteForm();
                nf.ShowDialog(this);
                logFile.Logs.Add(new Log(settings.DisplayName, nf.Note, "", DateTime.Now.ToString("hh:mm:ss tt"), ""));
                SaveLog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Log log = logFile.Logs.FirstOrDefault(x => x.DisplayName == settings.DisplayName);
            if (!(log is null))
            {
                if (log.In.Trim().Equals(""))
                {
                    log.In = DateTime.Now.ToString("hh:mm:ss tt");
                    if (log.NoteIn.Trim().Equals(""))
                    {
                        NoteForm nf = new NoteForm();
                        DialogResult dr = nf.ShowDialog(this);
                        if (dr == DialogResult.OK)
                        {
                            log.NoteIn = nf.Note;
                        }
                    }
                    SaveLog();
                }
            }
            else
            {
                NoteForm nf = new NoteForm();
                nf.ShowDialog(this);
                logFile.Logs.Add(new Log(settings.DisplayName, nf.Note, "", "", DateTime.Now.ToString("hh:mm:ss tt")));
                SaveLog();
            }
        }

        void SaveLog()
        {
            string file = DateTime.Now.ToString("MM-dd-yyyy") + ".json";
            string raw = JsonConvert.SerializeObject(logFile, Formatting.Indented);
            File.WriteAllText(settings.LogFolder + file, raw);
        }

        void ReadLog()
        {
            string file = DateTime.Now.ToString("MM-dd-yyyy") + ".json";
            if (File.Exists(settings.LogFolder + file))
            {
                File.Copy(settings.LogFolder + file, Application.StartupPath + @"\temp.json", true);

                string raw = File.ReadAllText(Application.StartupPath + @"\temp.json");
                logFile = JsonConvert.DeserializeObject<LogFile>(raw);
                fastObjectListView1.SetObjects(logFile.Logs);

                Log log = logFile.Logs.FirstOrDefault(x => x.DisplayName == settings.DisplayName);
                if (!(log is null))
                {
                    if (log.Out.Trim().Equals(""))
                    {
                        btnOut.Enabled = true;
                    }
                    else
                    {
                        btnOut.Enabled = false;
                    }

                    if (log.In.Trim().Equals(""))
                    {
                        btnIn.Enabled = true;
                    }
                    else
                    {
                        btnIn.Enabled = false;
                    }
                }
                else
                {
                    btnOut.Enabled = true;
                    btnIn.Enabled = true;
                }

                File.Delete(Application.StartupPath + @"\temp.json");
            }
            else
            {
                logFile = new LogFile();
                string raw = JsonConvert.SerializeObject(logFile, Formatting.Indented);
                File.WriteAllText(settings.LogFolder + file, raw);
            }
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            ReadLog();
        }

        private void fileSystemWatcher1_Changed(object sender, RenamedEventArgs e)
        {
            ReadLog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = Process.Start(settings.AdpUrl);
        }

        protected override void WndProc(ref Message m)
        {
            if (formCustomizer is null) formCustomizer = new FormCustomizer(base.Handle, this);
            if (formCustomizer.pWndProc(ref m)) base.WndProc(ref m);
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm hf = new HistoryForm(settings);
            hf.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab1 = new AboutBox1();
            ab1.ShowDialog();
        }
    }
}

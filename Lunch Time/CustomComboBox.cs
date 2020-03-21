using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lunch_Time
{
    public class CustomComboBox : ComboBox
    {
        private const int WM_PAINT = 0xF;
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                using (var g = Graphics.FromHwnd(Handle))
                {
                    // Uncomment this if you don't want the "highlight border".

                    using (var p = new Pen(this.BorderColor, 1))
                    {
                        g.DrawRectangle(p, 0, 0, Width - buttonWidth - 1, Height - 1);
                    }



                    using (var p = new Pen(this.BackColor, 2))
                    {
                        g.DrawRectangle(p, 2, 2, Width - buttonWidth - 4, Height - 4);
                    }
                    using (var p = new Pen(this.BorderColor2, 1))
                    {
                        g.DrawRectangle(p, 0, 0, Width - buttonWidth - 2, Height - 1);
                    }


                    using (var p = new Pen(this.BorderColor2, 1))
                    {
                        g.FillRectangle(new SolidBrush(this.BackColor), Width - buttonWidth, 0, buttonWidth, Height);

                        g.DrawRectangle(p, Width - buttonWidth, 0, buttonWidth - 1, Height - 1);

                        Font f = new Font(this.Font.FontFamily, 6, this.Font.Style);


                        StringFormat sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                        g.DrawString("▼", f, new SolidBrush(this.BorderColor2), new Rectangle(Width - buttonWidth, 0, buttonWidth, Height), sf);
                    }
                    
                }
            }
        }

        public CustomComboBox()
        {
            BorderColor = Color.DimGray;
            BorderColor2 = Color.DimGray;
        }

        [Browsable(true)]
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "DimGray")]
        public Color BorderColor { get; set; }

        public Color BorderColor2 { get; set; }
    }
}

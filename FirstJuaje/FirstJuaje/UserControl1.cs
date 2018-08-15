using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstJuaje
{
    public partial class UserControl1: Control
    {
        private Image backgroundImg;
        private Rectangle rectImg;
        private String DialText;

        public UserControl1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            rectImg = new Rectangle(0, 0, 30, 60);
            backgroundImg = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(backgroundImg);
            g.FillRectangle(new SolidBrush(Color.Aqua), new Rectangle(0, 0, 30, 60));
            SizeF textSize = g.MeasureString(this.DialText, this.Font);

            RectangleF digiFRectText = new RectangleF(this.Width / 2 - textSize.Width / 2, (int)(this.Height * .92), textSize.Width, textSize.Height);
            g.DrawString(DialText, this.Font, new SolidBrush(this.ForeColor), digiFRectText);

            e.Graphics.DrawImage(backgroundImg, rectImg);
        }
    }
}

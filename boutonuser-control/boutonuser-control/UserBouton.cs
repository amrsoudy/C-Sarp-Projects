using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace boutonuser_control
{
    public partial class UserBouton : UserControl
    {
     //   public Color background = Color.Gray;
        private string _labelBouton = "Click ";
        [Browsable(true), DefaultValue("click ")]
        private Image backgroungImg;
        private Rectangle rectImg;
        private bool requireReDraw = true;
                    



        public string dialText {

            get { return _labelBouton; }
            set { _labelBouton = value; Invalidate() ;this.Refresh();requireReDraw = true; }
           

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //Graphics graphics = e.Graphics;
            //int penWidth = 5;
            //Pen pen = new Pen(Color.Black, penWidth);

            //int fontHeight = 10;
            //Font font = new Font("Arial",fontHeight);

            //SolidBrush brush = new SolidBrush(background);

            //graphics.FillRectangle(brush, 0, 0, Width, Height);
            //SolidBrush textBrush = new SolidBrush(Color.Black);

            //graphics.DrawRectangle(pen,(int)penWidth,30,Width,Height/4);

            //Point point1 = new Point(10);
            //Point point2 = new Point(20);
            //Point point3 = new Point(30);
            //Point point4 = new Point(40);
            //Point point5 = new Point(50);

            //PointF[] points = new PointF[] {point1,point2,point3,point4,point5 };






            //graphics.DrawLines(pen, points);

            //graphics.DrawString(labelBouton, font, textBrush, Width / 2 - fontHeight,Height/2-fontHeight);

            rectImg = new Rectangle(131, 130,700,100);
            backgroungImg = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(backgroungImg);
            g.FillRectangle(new SolidBrush(Color.Aqua), new Rectangle(131, 130, Width, Height));
            SizeF textSize = g.MeasureString(this.dialText,this.Font);
            RectangleF digiFRectText = new RectangleF(this.Width / 2 - textSize.Width / 2, (int)(this.Height * .92), textSize.Width,textSize.Height);
            g.DrawString(dialText, this.Font, new SolidBrush(this.ForeColor), digiFRectText);

            e.Graphics.DrawImage(backgroungImg, rectImg);
            Pen thinkPen = new Pen(Color.Black, Width / 80);
            g.DrawLine(thinkPen, 20, 30, 10, 20);
            
            
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.FillRectangle(new SolidBrush(Color.Transparent), new Rectangle(0, 0, 300, 20));
            if (backgroungImg == null || requireReDraw)
            {


                backgroungImg = new Bitmap(this.Width, this.Height);
                Graphics g = Graphics.FromImage(backgroungImg);
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.FillRectangle(new SolidBrush(Color.Aqua), new Rectangle(10, 20, Width, Height));
                requireReDraw = false;
            }
        }

        public UserBouton()
        {
            InitializeComponent();
        }
    }
}

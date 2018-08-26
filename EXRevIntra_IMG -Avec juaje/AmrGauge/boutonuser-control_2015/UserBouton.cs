using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;

namespace boutonuser_control_2015
{
    public partial class UserBouton : UserControl
    {
        private int _mesure = 0;
        private int _valeur_Min = 0;
        private int _valeur_Max = 100;


        [Browsable(true), DefaultValue("0"), Description("represente la mesure ou la valeur à afficher"),
            DisplayName("Mesure"), Category("Propriétés")]
        public int Mesure
        {
            get { return _mesure; }
            set
            {
                _mesure = value;
                if (value < Valeur_Min) { _mesure = Valeur_Min; }
                else
                {
                    if (value > Valeur_Max) { _mesure = Valeur_Max; }
                    else
                    {
                        _mesure = value;

                    }
                }
                Invalidate();
            }
        }

        [Browsable(true), DefaultValue("0"), Description("represente la valeur min de la mesure"),
            DisplayName("Valeur Min"), Category("Propriétés")]
        public int Valeur_Min
        {
            get { return _valeur_Min; }
            set
            {
                _valeur_Min = value;

                Invalidate();
            }
        }

        [Browsable(true), DefaultValue("0"), Description("represente la valeur max de la mesure"),
            DisplayName("Valeur Max"), Category("Propriétés")]
        public int Valeur_Max
        {
            get { return _valeur_Max; }
            set
            {
                _valeur_Max = value;

                Invalidate();
            }
        }

        private Color _backgroundColor = Color.LightGray;

        public Color backgroundColor {

            get { return _backgroundColor; }
            set { _backgroundColor = value; Invalidate();}


        }
    //etape 2
    private string _labelBouton = "";
        [Browsable(true), DefaultValue("")]
        public string LabelBouton
        {
            get { return _labelBouton; }
            set { _labelBouton = value; Invalidate(); }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //ref: http://www.windowsdevcenter.com/pub/a/dotnet/2002/03/18/customcontrols.html?page=2
            Graphics graphics = e.Graphics;

            int penWidth = 4;
            Pen pen = new Pen(Color.Black, penWidth);
            Pen penOrange = new Pen(Color.Orange, 2);


            int fontHeight = 10;
            Font font = new Font("Arial", fontHeight);

            int fontHeight2 = 20;
            Font font2 = new Font("Arial", fontHeight2);


            SolidBrush brush = new SolidBrush(backgroundColor);
            graphics.FillRectangle(brush, 0, 0, Width, Height);
            SolidBrush textBrush = new SolidBrush(Color.Black);
            SolidBrush textBrush2 = new SolidBrush(Color.Red);


            //graphics.DrawEllipse(pen, (int)penWidth / 2,
            //(int)penWidth / 2, Width - penWidth, Height - penWidth);

            graphics.DrawRectangle(pen, 0, 0, Width, Height);
            Rectangle rect = new Rectangle(0, 0, Width, Height);

            Rectangle rect1 = new Rectangle(10,10, Width-20, Height-20);
          
            

            GraphicsPath RoundedRect(Rectangle bounds, int radius)
            {
                int diameter = radius * 2;
                Size size = new Size(diameter, diameter);
                Rectangle arc = new Rectangle(bounds.Location, size);
                GraphicsPath path = new GraphicsPath();

                if (radius == 0)
                {
                    path.AddRectangle(bounds);
                    return path;
                }

                // top left arc  
                path.AddArc(arc, 180, 90);

                // top right arc  
                arc.X = bounds.Right - diameter;
                path.AddArc(arc, 270, 90);

                // bottom right arc  
                arc.Y = bounds.Bottom - diameter;
                path.AddArc(arc, 0, 90);

                // bottom left arc 
                arc.X = bounds.Left;
                path.AddArc(arc, 90, 90);

                path.CloseFigure();
                return path;
            }

            graphics.DrawPath(pen, RoundedRect(rect1, 12));

            graphics.DrawString(LabelBouton, font, textBrush, Width / 2 - fontHeight, Height / 2 - fontHeight);
            Pen pen2 = new Pen(Color.Blue, 1);


            SolidBrush brushValeur = new SolidBrush(Color.Red);
            SolidBrush brushValeurWhite = new SolidBrush(Color.White);
            SolidBrush brushValeurBlack = new SolidBrush(Color.Black);
            SolidBrush brushValeurres = new SolidBrush(Color.Red);



            // MessageBox.Show(Width.ToString());

            double valeurWid = ((Width * 0.80));
            //
            double beginingPoint = (Width * 0.10);

            double fin = Width * 0.80;
            //MessageBox.Show(beginingPoint.ToString());


            graphics.FillRectangle(brushValeurWhite, (float)(beginingPoint), (float)(Height * 0.60), (float)fin, 12);

            double f = 0;
          
         
            // MessageBox.Show(Width.ToString()+"widith * 80"+ Width* 0.80+" begining "+beginingPoint +"  fin  : "+fin);

            double incremntationPar = Width / 5;

            for (double i = beginingPoint; i <= (float)(Width * 0.90); i += incremntationPar)
            {


                // create the  line sepratores 

                graphics.FillRectangle(brushValeurBlack, (float)i, (float)(Height * 0.60) - 23, 1, (float)(Height * 0.12));
               

                


                graphics.DrawString((f).ToString(), font, textBrush, (float)i - 10, (float)(Height * 0.60) - 50);
                if (f <= Valeur_Max)
                {
                    f += Valeur_Max / 4;


                }
            }




            for (int i = 0; i <= ((Mesure * fin)  / Valeur_Max); i++)
            {
                graphics.DrawEllipse(penOrange, (float)(beginingPoint + i) - 14, (float)(Height * 0.60) + 2 - 14, 14 + 14, 14 + 14);

              
                Thread.Sleep(50);

            }


        }
        public UserBouton()
        {
            InitializeComponent();
        }
    }
}

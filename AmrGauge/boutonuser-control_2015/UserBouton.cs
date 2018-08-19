using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace boutonuser_control_2015
{
    public partial class UserBouton : UserControl
    {
        private int _mesure = 0;
        private int _valeur_Min = 0;
        private int _valeur_Max = 200;


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

        public Color backgroundColor = Color.LightGray;
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
            Pen penOrange = new Pen(Color.Red, 2);


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

            graphics.DrawString(LabelBouton, font, textBrush, Width / 2 - fontHeight,
              Height / 2 - fontHeight);
            Pen pen2 = new Pen(Color.Blue, 1);


            SolidBrush brushValeur = new SolidBrush(Color.Red);
            SolidBrush brushValeurWhite = new SolidBrush(Color.White);
            SolidBrush brushValeurBlack = new SolidBrush(Color.Black);
            SolidBrush brushValeurRed = new SolidBrush(Color.Orange);



            // MessageBox.Show(Width.ToString());

            int valeurWid = (int)((Width * 0.80));
            //
            int beginingPoint = (int)(Width * 0.10);
           //MessageBox.Show(beginingPoint.ToString());


            graphics.FillRectangle(brushValeurWhite, (beginingPoint), (int)(Height * 0.60), valeurWid, 12);

            int f = 0;
            int fin = beginingPoint + valeurWid+35;
           // MessageBox.Show(Width.ToString()+"widith * 80"+ Width* 0.80+" begining "+beginingPoint +"  fin  : "+fin);

            int incremntationPar = fin / 5;


            for (int i = (beginingPoint ); i <= fin; i += incremntationPar)
            {
                // create the  line sepratores 
                
                    graphics.FillRectangle(brushValeurBlack, i, (int)(Height * 0.60)-23, 1, (int)(Height * 0.12));



                graphics.DrawString((f).ToString(), font, textBrush, i - 5, (int)(Height * 0.60) - 50);
                if (f <= Valeur_Max)
                {
                    f += Valeur_Max / 4;


                }
            }
            for (int i = 0; i <( Mesure*fin)/Valeur_Max+; i++)
            {

                // the bar red  
                graphics.FillRectangle(brushValeur, (beginingPoint ), (int)(Height * 0.60)+2, i , 7);
               // graphics.DrawEllipse(penOrange, (beginingPoint) - 14, (int)(Height * 0.60) + 2 - 14,14 + 14, 14 + 14);
               // graphics.FillEllipse(brushValeurRed, (beginingPoint) - 14, (int)(Height * 0.60) + 2 - 14, 14 + 14, 14 + 14);
                Thread.Sleep(50);

            }
        


        }
        public UserBouton()
        {
            InitializeComponent();
        }
    }
}

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

                        DateTime dt = new DateTime();
                        for (int i = 0; i < value; i++)
                        {
                            do
                            {
                                _mesure = i;


                            } while (dt.AddSeconds(0.1) > DateTime.Now);
                            //System.Threading.Thread.Sleep(20);



                        }

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

        public Color backgroundColor = Color.Beige;
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

            graphics.DrawRectangle(pen2, (int)(Width * 0.10), (int)(Height * 0.10), (int)(Width * 0.80), (int)(Height * 0.80));

            SolidBrush brushValeur = new SolidBrush(Color.Red);
            SolidBrush brushValeurWhite = new SolidBrush(Color.White);
            SolidBrush brushValeurBlack = new SolidBrush(Color.Black);



            int valeurWid = (int)((Width * 0.60));


            graphics.FillRectangle(brushValeurWhite, ((int)(Width * 0.40) / 2), (int)(Height * 0.45), valeurWid, 40);

            int f = 0;
            for (int i = ((int)(Width * 0.40) / 2); i <= ((int)(Width * 0.40) / 2) + ((int)((Width * 0.60))); i += (((int)(Width * 0.40) / 2) + ((int)((Width * 0.60)))+20)/7)
            {

                if ((f == 0) ||(f == Valeur_Max))
                {
                    graphics.FillRectangle(brushValeurBlack, i, (int)(Height * 0.40), 5, 80);

                }
               
                else {
                    graphics.FillRectangle(brushValeur, i, (int)(Height * 0.40), 1, 80);

                }

                graphics.DrawString((f).ToString(), font, textBrush, i, (Height / 2) - 45);
                f += Valeur_Max/5;
            }
            for (int i = 0; i <( Mesure*valeurWid)/Valeur_Max; i++)
            {
               

                graphics.FillRectangle(brushValeur, ((int)(Width * 0.42) / 2), (int)(Height *0.48), i , 22);
                Thread.Sleep(100);

            }

            graphics.DrawString("puissance", font2, textBrush2, ((Width/2) -60), Height -80);


        }
        public UserBouton()
        {
            InitializeComponent();
        }
    }
}

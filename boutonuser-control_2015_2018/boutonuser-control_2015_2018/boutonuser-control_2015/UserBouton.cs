using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
                    else { _mesure = value; }
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
        private string _labelBouton = "Click click";
        [Browsable(true), DefaultValue("Click click")]
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
            Pen pen = new Pen(Color.Black, 4);

            int fontHeight = 10;
            Font font = new Font("Arial", fontHeight);

            SolidBrush brush = new SolidBrush(backgroundColor);
            graphics.FillEllipse(brush, 0, 0, Width, Height);
            SolidBrush textBrush = new SolidBrush(Color.Black);

            graphics.DrawEllipse(pen, (int)penWidth / 2,
              (int)penWidth / 2, Width - penWidth, Height - penWidth);

            graphics.DrawString(LabelBouton, font, textBrush, Width / 2 - fontHeight,
              Height / 2 - fontHeight);

            SolidBrush brushValeur = new SolidBrush(Color.Red);

            graphics.FillRectangle(brushValeur, 0,
             ((int)Height - 10) / 2, Mesure, penWidth);//horiz


        }
        public UserBouton()
        {
            InitializeComponent();
        }
    }
}

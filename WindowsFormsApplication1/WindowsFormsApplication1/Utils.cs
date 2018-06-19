using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Utils
    {
        internal static void convertfrom1to2(TextBox textBox1, TextBox textBox2)
        {

            textBox2.Text = ((int.Parse(textBox1.Text)+32)/2).ToString();
        }

        internal static void convertfrom2to1(TextBox textBox1, TextBox textBox2)
        {
            textBox1.Text = ((int.Parse(textBox2.Text) * 2) -32 ).ToString();

        }
    }
}

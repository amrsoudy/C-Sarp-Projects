using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRevIntra_IMG
{
    class InfoEventArgs : EventArgs
    {
        public readonly double val;

        public InfoEventArgs(double n) {


            this.val = n;
           

        }
    }
}

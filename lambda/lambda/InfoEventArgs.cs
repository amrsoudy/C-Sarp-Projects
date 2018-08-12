
using System;

namespace Event
{
    public class InfoEventArgs : EventArgs
    {
        public readonly int valeur;
        public InfoEventArgs(int valeur) {

            this.valeur = valeur;
        }
    }
}
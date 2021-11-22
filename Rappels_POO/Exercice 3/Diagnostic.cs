using System;

namespace Rappels_POO.Exercice_3
{
    public class Diagnostic : Acte
    {
        private int fiabilite;

        public Maladie Maladie { get; set; }
        public int Fiabilite
        {
            get => fiabilite;
            set
            {
                fiabilite = value;
                if (fiabilite < 0)
                    fiabilite = 0;
                else if (fiabilite > 100)
                    fiabilite = 100;
            }
        }

        public Diagnostic(string soignant, DateTime date, 
                          Maladie maladie, int fiabilite)
            : base(soignant, date)
        {
            Maladie = maladie;
            Fiabilite = fiabilite;
        }
    }
}

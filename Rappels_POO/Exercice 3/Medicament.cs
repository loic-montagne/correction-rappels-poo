using System;

namespace Rappels_POO.Exercice_3
{
    public class Medicament : Soin
    {
        public int Posologie { get; set; }
        public int Frequence { get; set; }

        public Medicament(string soignant, DateTime date, int amelioration,
                          int posologie, int frequence)
            : base(soignant, date, amelioration)
        {
            Posologie = posologie;
            Frequence = frequence;
        }
    }
}

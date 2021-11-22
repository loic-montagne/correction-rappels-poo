using System;

namespace Rappels_POO.Exercice_3
{
    public abstract class Acte
    {
        public string Soignant { get; set; }
        public DateTime Date { get; set; }

        public Acte(string soignant, DateTime date)
        {
            Soignant = soignant;
            Date = date;
        }
    }
}

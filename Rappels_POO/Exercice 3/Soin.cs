using System;

namespace Rappels_POO.Exercice_3
{
    public class Soin : Acte
    {
        private int amelioration;
        public int Amelioration
        {
            get => amelioration;
            set
            {
                amelioration = value;
                if (amelioration < 0)
                    amelioration = 0;
                else if (amelioration > 100)
                    amelioration = 100;
            }
        }

        public Soin(string soignant, DateTime date, int amelioration)
            : base(soignant, date)
        {
            Amelioration = amelioration;
        }
    }
}

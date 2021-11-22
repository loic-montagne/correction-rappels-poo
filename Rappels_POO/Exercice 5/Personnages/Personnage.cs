using System;

namespace Rappels_POO.Exercice_5.Personnages
{
    public abstract class Personnage
    {
        private string nom;
        private int pointsVie;
        private int x;
        private int y;
        private int vitesse;
        private int sous;
        private bool visible;
        private int connaissances;

        public int PointsVie
        {
            get => pointsVie;
            set => pointsVie = (value < 0) ?   0 : value;
        }
        public int Sous
        {
            get => sous;
            set => sous = value;
        }

        public Personnage(string nom, int x, int y, int vitesse)
        {
            this.nom = nom;
            this.x = x;
            this.y = y;
            this.vitesse = vitesse;
        }

        public void SeDeplacer(int dx, int dy, int t)
        {
            x = (int)(x + dx * vitesse * t / Math.Sqrt(dx * dx + dy * dy));
            y = (int)(y + dy * vitesse * t / Math.Sqrt(dx * dx + dy * dy));
        }

        public abstract string Parler();

    }
}

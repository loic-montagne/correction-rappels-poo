using System;
using System.Collections.Generic;
using System.Linq;

namespace Rappels_POO.Exercice_5.Personnages
{
    public abstract class Personnage
    {
        #region Classes internes

        private abstract class Anneau
        {
            protected Personnage personnage;
            protected string nom;

            public Anneau(Personnage personnage)
            {
                this.personnage = personnage;
            }

            public abstract void MettreAuDoigt();
            public abstract void EnleverDuDoigt();
        }

        private class AnneauDeSauron : Anneau
        {
            public AnneauDeSauron(Personnage personnage) : base(personnage)
            {
            }

            public override void MettreAuDoigt()
            {
                personnage.visible = false;
            }

            public override void EnleverDuDoigt()
            {
                personnage.visible = true;
            }
        }

        #endregion

        private static int nbAnneauDeSauron = 0;

        private string nom;
        private int pointsVie;
        private int x;
        private int y;
        private int vitesse;
        private int sous;
        private bool visible;
        protected int connaissances;
        private List<Anneau> anneaux;

        public string Nom => nom;
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
        public bool Visible => visible;
        public int Connaissances => connaissances;

        public Personnage(string nom, int x, int y, int vitesse)
        {
            this.nom = nom;
            this.x = x;
            this.y = y;
            this.vitesse = vitesse;
            anneaux = new List<Anneau>();
        }

        public void SeDeplacer(int dx, int dy, int t)
        {
            x = (int)(x + dx * vitesse * t / Math.Sqrt(dx * dx + dy * dy));
            y = (int)(y + dy * vitesse * t / Math.Sqrt(dx * dx + dy * dy));
        }

        public abstract string Parler();

        public bool PorterAnneauDeSauron()
        {
            if (nbAnneauDeSauron == 0)
            {
                anneaux.Add(new AnneauDeSauron(this));
                nbAnneauDeSauron++;
                return true;
            }
            return false;
        }
        public void MettreAuDoigtAnneauDeSauron()
        {
            anneaux.FirstOrDefault(a => a is AnneauDeSauron)?.MettreAuDoigt();
        }
        public void EnleverDuDoigtAnneauDeSauron()
        {
            anneaux.FirstOrDefault(a => a is AnneauDeSauron)?.EnleverDuDoigt();
        }

    }
}


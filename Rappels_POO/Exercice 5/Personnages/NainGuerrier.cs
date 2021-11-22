using Rappels_POO.Exercice_5.Competences;

namespace Rappels_POO.Exercice_5.Personnages
{
    public class NainGuerrier : Nain, IGuerrier
    {
        public int Force { get; set; }

        public NainGuerrier(string nom, int x, int y, int force) : base(nom, x, y)
        {
            Force = force;
        }

        public void Attaquer(Personnage p)
        {
            p.PointsVie -= Force;
        }
    }
}


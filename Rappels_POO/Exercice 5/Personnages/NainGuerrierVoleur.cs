using Rappels_POO.Exercice_5.Classes;

namespace Rappels_POO.Exercice_5.Personnages
{
    public class NainGuerrierVoleur : NainGuerrier, IVoleur
    {
        public int Dexterite { get; set; }
        
        public NainGuerrierVoleur(string nom, int x, int y, int force, int dexterite)
            : base(nom, x, y, force)
        {
            Dexterite = dexterite;
        }

        public void Voler(Personnage p)
        {
            int sousVoles = p.Sous > Dexterite ? Dexterite : p.Sous;
            p.Sous -= sousVoles;
            Sous += sousVoles;
        }
    }
}

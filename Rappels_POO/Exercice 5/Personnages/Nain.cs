
namespace Rappels_POO.Exercice_5.Personnages
{
    public class Nain : Humanoide
    {
        public Nain(string nom, int x, int y) : base(nom, x, y, 2)
        {
        }

        public override string Parler()
        {
            return "Groumpf";
        }
    }
}


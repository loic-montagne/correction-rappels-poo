
namespace Rappels_POO.Exercice_5.Personnages
{
    public class Humain : Personnage
    {
        public Humain(string nom, int x, int y) : base(nom, x, y, 5)
        {
        }

        public override string Parler()
        {
            return "Bonjour";
        }
    }
}

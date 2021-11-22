
namespace Rappels_POO.Exercice_5.Personnages
{
    public class Elfe : Personnage
    {
        public Elfe(string nom, int x, int y) : base(nom, x, y, 7)
        {
        }

        public override string Parler()
        {
            return "Eldarie";
        }
    }
}


namespace Rappels_POO.Exercice_5.Personnages
{
    public class Hobbit : Humanoide
    {
        public Hobbit(string nom, int x, int y) : base(nom, x, y, 5)
        {
        }

        public override string Parler()
        {
            return "Belle journée ma foi";
        }
    }
}

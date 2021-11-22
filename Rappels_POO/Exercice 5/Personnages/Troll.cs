
namespace Rappels_POO.Exercice_5.Personnages
{
    public class Troll : Personnage, IMonstre
    {
        public int Force { get; }
        public int Puanteur => 200;

        public Troll(string nom, int x, int y, int vitesse, int force) : base(nom, x, y, vitesse)
        {
            Force = force;
        }

        public override string Parler()
        {
            return "Hiark";
        }

        public void Attaquer(Personnage p)
        {
            if (p is Troll)
                return;
            p.PointsVie -= Force - (int)(Puanteur * 0.1);
        }
    }
}


namespace Rappels_POO.Exercice_5.Objets
{
    public class Arme : Objet
    {
        public int Puissance { get; }

        public Arme(string nom, decimal prix, int puissance)
            : base(nom, prix)
        {
            Puissance = puissance;
        }
    }
}

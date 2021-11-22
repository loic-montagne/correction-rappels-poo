
namespace Rappels_POO.Exercice_5.Objets
{
    public abstract class Objet
    {
        public string Nom { get; }
        public decimal Prix { get; }

        public Objet(string nom, decimal prix)
        {
            Nom = nom;
            Prix = prix;
        }
    }
}

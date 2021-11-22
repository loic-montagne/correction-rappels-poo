
namespace Rappels_POO.Exercice_5.Objets
{
    public class Document : Objet
    {
        public int Connaissance { get; }

        public Document(string nom, decimal prix, int connaissance)
            : base(nom, prix)
        {
            Connaissance = connaissance;
        }
    }
}

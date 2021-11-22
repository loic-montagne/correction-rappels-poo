
namespace Rappels_POO.Exercice_2
{
    public abstract class Personne
    {
        private decimal montantCompteBancaire;

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public decimal MontantCompteBancaire
        {
            get => montantCompteBancaire;
            protected set => montantCompteBancaire = value;
        }

        // Equivalent à la notation
        // public decimal MontantCompteBancaire
        // {
        //     get
        //     {
        //         return montantCompteBancaire;
        //     }
        //     protected set
        //     {
        //         montantCompteBancaire = value;
        //     }
        // }

        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
            montantCompteBancaire = 0;
        }

        public void AjouterSous(decimal montant)
        {
            montantCompteBancaire += montant;
        }
    }
}

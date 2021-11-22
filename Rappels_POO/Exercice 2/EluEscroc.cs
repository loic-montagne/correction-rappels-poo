
namespace Rappels_POO.Exercice_2
{
    public class EluEscroc : EluEconome
    {
        private decimal montantCompteBancaireSuisse;

        public decimal MontantCompteBancaireSuisse => montantCompteBancaireSuisse;
        // Equivalent aux notations
        //
        // public decimal MontantCompteBancaireSuisse
        // {
        //     get => montantCompteBancaireSuisse;
        // }
        //
        // ou
        //
        // public decimal MontantCompteBancaireSuisse
        // {
        //     get
        //     {
        //         return montantCompteBancaireSuisse;
        //     }
        // }

        public EluEscroc(string nom, string prenom) : base(nom, prenom)
        {
        }

        public override void VerserDotationBudgetaire()
        {
            base.VerserDotationBudgetaire();
            montantCompteBancaireSuisse = MontantCompteBancaire;
            MontantCompteBancaire = 0;
        }
    }
}

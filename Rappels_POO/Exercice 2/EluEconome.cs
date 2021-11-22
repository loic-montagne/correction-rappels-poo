
namespace Rappels_POO.Exercice_2
{
    public class EluEconome : Elu
    {
        public EluEconome(string nom, string prenom) : base(nom, prenom)
        {
        }

        public override void VerserDotationBudgetaire()
        {
            decimal montantEquitableSmic = MontantCompteBancaire / Assistants.Count;
            if (montantEquitableSmic > 1480)
                montantEquitableSmic = 1480;
            foreach (Personne a in Assistants)
            {
                a.AjouterSous(montantEquitableSmic);
                MontantCompteBancaire -= montantEquitableSmic;
            }
        }
    }
}

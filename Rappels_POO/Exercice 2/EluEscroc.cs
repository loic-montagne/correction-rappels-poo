using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rappels_POO.Exercice_2
{
    public class EluEscroc : Elu
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
            decimal montantEquitableSmic = MontantCompteBancaire / Assistants.Count;
            if (montantEquitableSmic > 1480)
                montantEquitableSmic = 1480;
            foreach (Personne a in Assistants)
            {
                a.AjouterSous(montantEquitableSmic);
                MontantCompteBancaire -= montantEquitableSmic;
            }

            montantCompteBancaireSuisse = MontantCompteBancaire;
            MontantCompteBancaire = 0;
        }
    }
}

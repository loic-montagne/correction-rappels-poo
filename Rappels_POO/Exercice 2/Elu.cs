using System.Collections.Generic;

namespace Rappels_POO.Exercice_2
{
    public class Elu : Personne
    {
        public List<Personne> Assistants { get; }

        public Elu(string nom, string prenom) : base (nom, prenom)
        {
            Assistants = new List<Personne>();
        }

        public virtual void EmbaucherAssistant(Personne assistant)
        {
            Assistants.Add(assistant);
        }

        public void LicencierAssistant(Personne assistant)
        {
            Assistants.Remove(assistant);
        }

        public virtual void VerserDotationBudgetaire()
        {
            decimal montantEquitable = MontantCompteBancaire / Assistants.Count;
            foreach (Personne a in Assistants)
            {
                a.AjouterSous(montantEquitable);
                MontantCompteBancaire -= montantEquitable;
            }
        }
    }
}

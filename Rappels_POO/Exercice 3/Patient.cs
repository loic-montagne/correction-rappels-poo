using System;
using System.Collections.Generic;

namespace Rappels_POO.Exercice_3
{
    public class Patient
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Sexe Sexe { get; set; }
        public DateTime DateNaissance { get; set; }
        public int Age => (int)(DateTime.Now.Subtract(DateNaissance).TotalDays / 365.242199);
        public List<Acte> ActesMedicaux { get; }

        public Patient(string nom, string prenom, Sexe sexe, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            Sexe = sexe;
            DateNaissance = dateNaissance;
            ActesMedicaux = new List<Acte>();
        }

        public void AjouterActeMedical(Acte acte)
        {
            ActesMedicaux.Add(acte);
        }

        public int CalculerNombreMedicamentsParJour()
        {
            int nb = 0;
            foreach (Acte a in ActesMedicaux)
            {
                if (a is Medicament)
                {
                    nb += (a as Medicament).Frequence;
                }
            }
            return nb;
        }
    }
}

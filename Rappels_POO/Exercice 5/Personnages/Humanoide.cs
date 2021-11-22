using Rappels_POO.Exercice_5.Objets;
using System.Collections.Generic;

namespace Rappels_POO.Exercice_5.Personnages
{
    public abstract class Humanoide : Personnage
    {

        public List<Objet> Objets { get; }
        public List<Document> DocumentsLus { get; }

        public Humanoide(string nom, int x, int y, int vitesse) : base(nom, x, y, vitesse)
        {
            Objets = new List<Objet>();
            DocumentsLus = new List<Document>();
        }

        public void AcquerirObjet(Objet objet)
        {
            Objets.Add(objet);
        }
        public void PerdreObjet(Objet objet)
        {
            Objets.Remove(objet);
        }
        public void DonnerObjet(Objet objet, Humanoide personnage)
        {
            if (Objets.Contains(objet))
            {
                PerdreObjet(objet);
                personnage.AcquerirObjet(objet);
            }
        }

        public void Attaquer(Personnage personnage, Arme arme)
        {
            if (Objets.Contains(arme))
                personnage.PointsVie -= arme.Puissance;
        }

        public void Lire(Document document)
        {
            if (Objets.Contains(document) && !DocumentsLus.Contains(document))
            {
                connaissances += document.Connaissance;
                DocumentsLus.Add(document);
            }
        }

    }
}

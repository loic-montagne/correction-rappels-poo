
using System.Collections.Generic;

namespace Rappels_POO.Exercice_1
{
    public class QuestionChoixMultiples : Question
    {
        private string enonce;
        private int difficulte;
        private List<Reponse> reponses;

        public override string Enonce 
        { 
            get
            {
                return enonce;
            }
            set
            {
                enonce = value;
            }
        }

        public override int Difficulte
        {
            get
            {
                return difficulte;
            }
            set
            {
                difficulte = value;
                if (difficulte < 0)
                    difficulte = 0;
                else if (difficulte > 100)
                    difficulte = 100;
            }
        }
        public List<Reponse> Reponses
        {
            get
            {
                return reponses;
            }
        }

        public QuestionChoixMultiples(string enonce, int difficulte)
        {
            Enonce = enonce;
            Difficulte = difficulte;
            reponses = new List<Reponse>();
        }

        public void AjouterReponse(string enonce, bool estVrai)
        {
            Reponses.Add(new Reponse(enonce, estVrai));
        }

    }
}

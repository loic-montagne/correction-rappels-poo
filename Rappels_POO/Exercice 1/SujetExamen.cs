using System.Collections.Generic;

namespace Rappels_POO.Exercice_1
{
    public class SujetExamen
    {
        public List<QuestionNotee> Questions { get; }
        public int DifficulteMoyenne
        {
            get
            {
                int d = 0;
                foreach (QuestionNotee q in Questions)
                    d += q.Difficulte;
                return d / Questions.Count;
            }
        }

        public SujetExamen()
        {
            Questions = new List<QuestionNotee>();
        }

        public void AjouterQuestion(Question q, float nbPoints)
        {
            Questions.Add(new QuestionNotee(q, nbPoints));
        }

    }
}

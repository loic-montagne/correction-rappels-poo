
namespace Rappels_POO.Exercice_1
{
    public class QuestionNotee
    {
        public float NombrePoints { get; }
        public Question Question { get; }
        public string Enonce
        {
            get
            {
                if (Question != null)
                    return Question.Enonce;
                return null;
            }
            set
            {
                if (Question != null)
                    Question.Enonce = value;
            }
        }
        public int Difficulte
        {
            get => Question?.Difficulte ?? 0;
            set
            {
                if (Question != null) 
                    Question.Difficulte = value;
            }
        }


        public QuestionNotee(Question question, float nombrePoints)
        {
            Question = question;
            NombrePoints = nombrePoints;
        }

    }
}


namespace Rappels_POO.Exercice_1
{
    public class Reponse
    {
        public string Enonce { get; set; }
        public bool EstVrai { get; set; }

        public Reponse(string enonce, bool estVrai)
        {
            Enonce = enonce;
            EstVrai = estVrai;
        }
    }
}

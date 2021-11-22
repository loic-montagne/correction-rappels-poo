
namespace Rappels_POO.Exercice_4
{
    public abstract class Enseignant
    {
        public static int TauxCharges => 100;

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public float NombreHeuresEnseignement { get; set; }
        public abstract float NombreHeuresService { get; }
        public float NombreHeuresSupplementaires => (NombreHeuresEnseignement>NombreHeuresService) ? NombreHeuresEnseignement - NombreHeuresService : 0;
        public abstract float SalaireAnnuel { get; }
        public float CoutAnnuel => SalaireAnnuel * (1 + TauxCharges / 100);

        public Enseignant(string nom, string prenom, float nbHeuresEnseignement)
        {
            Nom = nom;
            Prenom = prenom;
            NombreHeuresEnseignement = nbHeuresEnseignement;
        }
    }
}

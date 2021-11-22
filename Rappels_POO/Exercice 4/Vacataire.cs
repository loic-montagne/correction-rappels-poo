
namespace Rappels_POO.Exercice_4
{
    public class Vacataire : Enseignant
    {

        public string Organisme { get; set; }
        public override float NombreHeuresService => 0;
        public override float SalaireAnnuel => NombreHeuresEnseignement * 40;

        public Vacataire(string nom, string prenom, string organisme, float nbHeuresEnseignement)
            : base(nom, prenom, nbHeuresEnseignement)
        {
            Organisme = organisme;
        }
    }
}

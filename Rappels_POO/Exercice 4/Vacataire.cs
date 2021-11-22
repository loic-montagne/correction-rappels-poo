
namespace Rappels_POO.Exercice_4
{
    public class Vacataire : Enseignant
    {

        public override float NombreHeuresService => 0;
        public override float SalaireAnnuel => NombreHeuresEnseignement * 40;

        public Vacataire(string nom, string prenom, float nbHeuresEnseignement)
            : base(nom, prenom, nbHeuresEnseignement)
        {
        }
    }
}

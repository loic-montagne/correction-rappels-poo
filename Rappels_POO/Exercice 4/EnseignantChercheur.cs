
namespace Rappels_POO.Exercice_4
{
    public class EnseignantChercheur : Enseignant
    {

        public override float NombreHeuresService => 192;
        public override float SalaireAnnuel => 2000 * 12 + NombreHeuresSupplementaires * 40;

        public EnseignantChercheur(string nom, string prenom, float nbHeuresEnseignement)
            : base(nom, prenom, nbHeuresEnseignement)
        {
        }
    }
}

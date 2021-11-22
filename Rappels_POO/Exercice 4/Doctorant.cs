
namespace Rappels_POO.Exercice_4
{
    public class Doctorant : Enseignant
    {

        public override float NombreHeuresService => 96;
        public override float SalaireAnnuel => (NombreHeuresEnseignement - NombreHeuresSupplementaires) * 30;

        public Doctorant(string nom, string prenom, float nbHeuresEnseignement)
            : base(nom, prenom, nbHeuresEnseignement)
        {
        }
    }
}

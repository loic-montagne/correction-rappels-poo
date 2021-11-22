using Rappels_POO.Exercice_5.Personnages;

namespace Rappels_POO.Exercice_5.Competences
{
    public interface IVoleur
    {
        int Dexterite { get; set; }
        void Voler(Personnage p);
    }
}


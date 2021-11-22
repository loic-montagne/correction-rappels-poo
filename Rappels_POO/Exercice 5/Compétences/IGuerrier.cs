using Rappels_POO.Exercice_5.Personnages;

namespace Rappels_POO.Exercice_5.Competences
{
    public interface IGuerrier
    {
        int Force { get; set; }
        void Attaquer(Personnage p);
    }
}


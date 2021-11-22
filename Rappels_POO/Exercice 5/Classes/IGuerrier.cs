using Rappels_POO.Exercice_5.Personnages;

namespace Rappels_POO.Exercice_5.Classes
{
    public interface IGuerrier
    {
        int Force { get; set; }
        void Attaquer(Personnage p);
    }
}


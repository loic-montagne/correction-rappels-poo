using Rappels_POO.Exercice_5.Personnages;

namespace Rappels_POO.Exercice_5.Classes
{
    public interface IMagicien
    {
        int NiveauMagie { get; set; }
        void LancerSort(Personnage p);
    }
}

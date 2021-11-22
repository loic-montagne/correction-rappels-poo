
namespace Rappels_POO.Exercice_5.Personnages
{
    public interface IMonstre
    {
        int Puanteur { get; }
        void Attaquer(Personnage p);
    }
}

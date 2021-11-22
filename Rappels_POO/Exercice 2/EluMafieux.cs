
namespace Rappels_POO.Exercice_2
{
    public class EluMafieux : Elu
    {
        public EluMafieux(string nom, string prenom) : base(nom, prenom)
        {
        }

        public override void EmbaucherAssistant(Personne assistant)
        {
            if (assistant.Nom == Nom)
                base.EmbaucherAssistant(assistant);
        }
    }
}

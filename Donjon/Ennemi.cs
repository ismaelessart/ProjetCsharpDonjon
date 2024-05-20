using System;

namespace D_DProjetC_
{
    public class Ennemi : Entite
    {
        public Ennemi(string nom) : base(nom)
        {

        }
        public override void Attaquer(Entite cible)
        {
            int degats = this.force; // Vous pouvez ajouter de la logique pour calculer les dégâts
            cible.RecevoirDegats(degats);
            Console.WriteLine($"{this.Nom} attaque {cible.Nom} et inflige {degats} dégâts.");
        }

    }
}

using System;

namespace D_DProjetC_
{
    // Sous-classe représentant la Dague de l'Assassin
    public class DaguesAssassin : Dagues
    {
        // Constructeur pour la Dague de l'Assassin
        public DaguesAssassin(string rarete)
            : base("Dagues de l'Assassin", "Dagues aiguisées pour les assassins agiles.", rarete, 20, 0, 0, 4, 0, 0, 0, 5, 15)
        {
            // Vous pouvez ajouter d'autres propriétés spécifiques à la Dague de l'Assassin si nécessaire
        }
    }
}
using System;
using System.Collections.Generic;

public class Sorts
{
    public string Nom { get; set; }
    public string Description { get; set; }
    public int CoûtMana { get; set; }
    public bool CoupCritique { get; set; }
    public bool AoE { get; set; }
    public int Dégâts { get; set; }

    public Sort(string nom, string description, int coûtMana, bool coupCritique, bool aoE, int dégâts)
    {
        Nom = nom;
        Description = description;
        CoûtMana = coûtMana;
        CoupCritique = coupCritique;
        AoE = aoE;
        Dégâts = dégâts;
    }
    public static List<Sort> EpéeSorts()
    {
        return new List<Sort>
        {
            new Sort("Coup Rapide", "Augmente la vitesse d'attaque pendant un court laps de temps.", 20, false, false, 0),
            new Sort("Tourbillon Tranchant", "Effectue une attaque en rotation, infligeant des dégâts à tous les ennemis autour.", 40, false, true, 50),
            new Sort("Frénésie Guerrière", "Augmente temporairement les dégâts infligés.", 30, false, false, 0),
            new Sort("Frappe Défensive", "Augmente la défense de l'utilisateur pendant un court laps de temps.", 30, false, false, 0),
            new Sort("Coup Éclair", "Effectue une attaque rapide avec une chance accrue de coup critique.", 25, true, false, 0),
            new Sort("Lame de Feu", "Enveloppe la lame d'une énergie ardente, infligeant des dégâts de feu supplémentaires.", 50, false, false, 40),
            new Sort("Parade Parfaite", "Bloque et contre-attaque automatiquement la prochaine attaque ennemie.", 40, false, false, 0),
            new Sort("Épée de Lumière", "Invoque une lame de lumière divine, infligeant des dégâts sacrés et guérissant légèrement l'utilisateur.", 60, false, false, 30)
        };
    }
    public static List<Sort> MarteauSorts()
    {
        return new List<Sort>
        {
            new Sort("Frappe Écrasante", "Inflige des dégâts supplémentaires et étourdit l'ennemi.", 20, false, false, 0),
            new Sort("Tonnerre Divin", "Fait tomber un éclair sur l'ennemi, infligeant des dégâts de foudre.", 40, false, false, 50),
            new Sort("Tempête de Fer", "Lance plusieurs attaques rapides sur tous les ennemis.", 30, false, false, 0),
            new Sort("Furie Martiale", "Augmente temporairement la force de l'utilisateur.", 30, false, false, 0),
            new Sort("Souffle de Vent", "Crée une bourrasque qui repousse les ennemis et les étourdit.", 25, false, true, 0),
            new Sort("Ruée Brutale", "Charge l'ennemi, lui infligeant des dégâts et le projetant en arrière.", 40, false, false, 30),
            new Sort("Bouclier de Gaïa", "Crée un bouclier protecteur qui absorbe les dégâts pendant un court laps de temps.", 50, false, false, 0),
            new Sort("Martellement Continu", "Effectue une série de frappes puissantes qui affaiblissent la défense de l'ennemi.", 60, false, false, 40)
        };
    }
    public static List<Sort> DaguesSorts()
    {
        return new List<Sort>
        {
            new Sort("Assaut Furtif", "Effectue une attaque rapide et furtive, infligeant des dégâts supplémentaires.", 20, false, false, 0),
            new Sort("Ombres Traîtresses", "Disparaît dans les ombres, rendant l'utilisateur invisible pendant un court laps de temps.", 40, false, false, 0),
            new Sort("Danse Mortelle", "Danse agilement autour de l'ennemi, infligeant des coups critiques avec une grande précision.", 30, true, false, 0),
            new Sort("Évasion Éclair", "Esquive automatiquement la prochaine attaque ennemie.", 30, false, false, 0),
            new Sort("Poison Perçant", "Envenime la lame, infligeant des dégâts supplémentaires au fil du temps.", 25, false, false, 0),
            new Sort("Coup Critique", "Augmente considérablement les chances de coup critique pour la prochaine attaque.", 40, true, false, 0),
            new Sort("Frénésie Sanguinaire", "Augmente temporairement la vitesse d'attaque et les dégâts infligés.", 50, false, false, 0),
            new Sort("Voile de l'Invisible", "Devient complètement invisible pour les ennemis pendant un court laps de temps.", 60, false, false, 0)
        };
    
    }
    public static List<Sort> BâtonSorts()
    {
        return new List<Sort>
        {
            new Sort("Boule de Feu", "Lance une boule de feu sur l'ennemi, infligeant des dégâts de feu.", 20, false, false, 50),
            new Sort("Rayon de Guérison", "Guérit les alliés blessés dans un rayon autour de l'utilisateur.", 40, false, false, 0),
            new Sort("Gel Glacial", "Gèle les ennemis sur place, les empêchant de se déplacer ou d'attaquer.", 30, false, true, 0),
            new Sort("Bénédiction de Sagesse", "Augmente temporairement la sagesse de l'utilisateur, améliorant ses capacités magiques.", 30, false, false, 0),
            new Sort("Protection Élémentaire", "Crée un bouclier magique qui absorbe les dégâts d'un type d'élément spécifique.", 25, false, false, 0),
            new Sort("Invocation de Vent", "Appelle une rafale de vent qui repousse les ennemis et les étourdit.", 40, false, true, 0),
            new Sort("Renforcement d'Armure", "Renforce l'armure de l'utilisateur, réduisant les dégâts subis.", 50, false, false, 0),
            new Sort("Éclat Divin", "Libère une explosion de lumière divine, infligeant des dégâts sacrés à tous les ennemis autour de l'utilisateur.", 60, false, true, 60)
        };
    }
}

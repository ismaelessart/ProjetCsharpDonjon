using System;
using System.Xml.Linq;


namespace D_DProjetC_
{
    public abstract class Ennemi : Entite
    {
        public Ennemi(string nom) : base(nom)
        {

        }
        /*public void Attaquer(Entite cible)
        {
            int degats = this.force;
            cible.RecevoirDegats(degats);
            Console.WriteLine($"{this.Nom} attaque {cible.Nom} et inflige {degats} dégâts.");
        }*/
        public int Attaquer()
        {
            int degats = force;
            return degats;
        }

        public void RecevoirDegats(int degats)
        {
            PointsDeVie -= degats;
            if (PointsDeVie <= 0)
            {
                EstMort = true;
            }
        }

        public bool IsAlive{ get { return !EstMort; } }

        public void Attaquer(Personnage personnage)
        {
            int degats = Attaquer(); // Utilisez votre méthode existante pour calculer les dégâts de l'ennemi
            personnage.RecevoirDegats(degats); // Appliquez les dégâts au personnage
            Console.WriteLine($"{this.Nom} vous attaque, il vous reste {personnage.PointsDeVie} points de vie.");
        }

        public static Ennemi ChargerEnnemi(XElement ennemiElement)
        {
            string type = ennemiElement.Attribute("type").Value;
            switch (type)
            {
                case "Orc":
                    return new Orc();
                case "Gobelin":
                    return new Gobelin();
                case "Squelette":
                    return new Squelette();
                default:
                    throw new ArgumentException($"Type d'ennemi inconnu : {type}");
            }
        }
    }
}
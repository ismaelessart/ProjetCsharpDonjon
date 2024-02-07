using System;

namespace D_DProjetC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le jeu Donjons et Dragons !");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Dans un monde où la magie et les créatures fantastiques abondent, une \r\nancienne légende raconte l'existence d'un donjon oublié depuis des \r\nsiècles. On dit que ce donjon renferme d'innombrables trésors, des \r\nartefacts puissants et des secrets ancestraux. Cependant, personne n'a \r\njamais réussi à percer ses mystères, et ceux qui ont osé s'y aventurer \r\nn'en sont jamais revenus.");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Vous devez maîtriser le pouvoir du cristal pour vaincre les ténèbres qui menacent votre royaume. En explorant les recoins les plus sombres de la forêt ancienne et en affrontant les gardiens maléfiques, vous devrez déverrouiller les secrets de l'artefact et devenir le héros légendaire qui sauvera son monde de l'obscurité.\r\n\r\n");

            Console.Write("Entrez le nom de votre personnage : ");
            string nomPersonnage = Console.ReadLine();

            Console.WriteLine("Choisissez la classe de votre personnage :");
            Console.WriteLine("1. Mage");
            Console.WriteLine("2. Guerrier");
            Console.WriteLine("3. Voleur");

            int choixClasse = int.Parse(Console.ReadLine());

            Personnage personnage;

            switch (choixClasse)
            {
                case 1:
                    personnage = new Mage(nomPersonnage);
                    break;
                case 2:
                    personnage = new Guerrier(nomPersonnage);
                    break;
                case 3:
                    personnage = new Voleur(nomPersonnage);
                    break;
                default:
                    Console.WriteLine("Classe invalide.");
                    return;
            }

            Console.WriteLine($"Bienvenue, {personnage.Nom} !");
            Console.WriteLine("-----------------------------------------------------------------------");

            while (true)
            {
                Console.WriteLine("Que voulez-vous faire ?");
                Console.WriteLine("1. Explorer le donjon");
                Console.WriteLine("2. Voir les informations du personnage");
                Console.WriteLine("3. Quitter le jeu");

                int choixAction = int.Parse(Console.ReadLine());

                switch (choixAction)
                {
                    case 1:
                        Console.WriteLine("Vous explorez le donjon...");
                        // Ajoutez ici le code pour gérer l'exploration du donjon
                        break;
                    case 2:
                        Console.WriteLine(personnage.GetInfo());
                        break;
                    case 3:
                        Console.WriteLine("Merci d'avoir joué !");
                        return;
                    default:
                        Console.WriteLine("Action invalide.");
                        break;
                }

                Console.WriteLine("-----------------------------------------------------------------------");
            }
        }
    }

    class Personnage
    {
        public string Nom { get; set; }
        public int PDV { get; set; }
        public int PDM { get; set; }
        public int Intelligence { get; set; }
        public int Dexterite { get; set; }
        public int Constitution { get; set; }
        public int Sagesse { get; set; }
        public int Force { get; set; }

        public Personnage(string nom, int PDV, int PDM, int intelligence, int dexterite, int constitution, int sagesse, int force)
        {
            Nom = nom;
            this.PDV = PDV;
            this.PDM = PDM;
            Intelligence = intelligence;
            Dexterite = dexterite;
            Constitution = constitution;
            Sagesse = sagesse;
            Force = force;
        }

        public virtual string GetInfo()
        {
            return $"Nom: {Nom}\nPoints de vie: {PDV}\nPoints de magie: {PDM}\nIntelligence: {Intelligence}\nDextérité: {Dexterite}\nConstitution: {Constitution}\nSagesse: {Sagesse}\nForce: {Force}";
        }
    }

    class Mage : Personnage
    {
        public Mage(string nom) : base(nom, 40, 80, 16, 12, 10, 14, 8)
        {
            // Ajoutez ici des actions spécifiques à la classe Mage
        }

        public override string GetInfo()
        {
            return base.GetInfo() + "\nClasse: Mage";
        }
    }

    class Guerrier : Personnage
    {
        public Guerrier(string nom) : base(nom, 60, 60, 10, 14, 16, 12, 14)
        {
            // Ajoutez ici des actions spécifiques à la classe Guerrier
        }

        public override string GetInfo()
        {
            return base.GetInfo() + "\nClasse: Guerrier";
        }
    }

    class Voleur : Personnage
    {
        public Voleur(string nom) : base(nom, 50, 50, 12, 16, 12, 10, 12)
        {
            // Ajoutez ici des actions spécifiques à la classe Voleur
        }

        public override string GetInfo()
        {
            return base.GetInfo() + "\nClasse: Voleur";
        }
    }
}

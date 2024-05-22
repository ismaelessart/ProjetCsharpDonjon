using System;

namespace D_DProjetC_
{
    public static class ArmeFactory
    {
        /*private static readonly Random rand = new Random();
        
        public static Arme CreerArmeAleatoire(string typeArme)
        {
            Type typeArmeSpecifique = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(type => type.Name == typeArme && type.IsSubclassOf(typeof(Arme)));
            
            if (typeArmeSpecifique != null)
            {
                return (Arme)Activator.CreateInstance(typeArmeSpecifique, "Commun");
            }
            else
            {
                throw new ArgumentException("Type d'arme invalide.");
            }
        }
    }*/
    /*{
        private static Random rand = new Random();

        public static Arme CreerArmeAleatoire(string typeArme)
        {
            string rarete = GenererRaretéAleatoire();
            switch (typeArme.ToLower())
            {
                case "epee":
                    return CreerEpeeAleatoire(rarete);
                case "marteau":
                    return CreerMarteauAleatoire(rarete);
                case "baton":
                    return CreerBatonAleatoire(rarete);
                case "dague":
                    return CreerDagueAleatoire(rarete);
                default:
                    throw new ArgumentException("Type d'arme invalide.");
            }
        }

        private static string GenererRaretéAleatoire()
        {
            string[] raretes = { "Commun", "Rare", "Épique", "Légendaire" };
            return raretes[rand.Next(raretes.Length)];
        }

        private static Arme CreerEpeeAleatoire(string rarete)
        {
            string[] nomsEpees = { "EpeeDeFlamme", "EpeeDeLaJustice", "EpeeDeLaube", "EpeeDuTraqueur" };
            string nomEpee = nomsEpees[rand.Next(nomsEpees.Length)];
            Type epeeType = Type.GetType("D_DProjetC_." + nomEpee);
            return (Arme)Activator.CreateInstance(epeeType, rarete);
        }

        private static Arme CreerMarteauAleatoire(string rarete)
        {
            string[] nomsMarteaux = { "MarteauDeGuerre", "MarteauEclairant", "MarteauLourd", "MarteauTonnerre" };
            string nomMarteau = nomsMarteaux[rand.Next(nomsMarteaux.Length)];
            Type marteauType = Type.GetType("D_DProjetC_." + nomMarteau);
            return (Arme)Activator.CreateInstance(marteauType, rarete);
        }

        private static Arme CreerBatonAleatoire(string rarete)
        {
            string[] nomsBatons = { "Bâton de Feu", "Bâton de Givre", "Bâton de Guérison", "Bâton Enchanté" };
            string nomBaton = nomsBatons[rand.Next(nomsBatons.Length)];
            Type batonType = Type.GetType("D_DProjetC_." + nomBaton);
            return (Arme)Activator.CreateInstance(batonType, rarete);
        }

        private static Arme CreerDagueAleatoire(string rarete)
        {
            string[] nomsDagues = { "DaguesAssassin", "DaguesFolles", "DaguesObert", "DaguesOmbre" };
            string nomDague = nomsDagues[rand.Next(nomsDagues.Length)];
            Type dagueType = Type.GetType("D_DProjetC_." + nomDague);
            return (Arme)Activator.CreateInstance(dagueType, rarete);
        }*/
    }
}
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace D_DProjetC_
{
    [Serializable]
    public class Salle
    {
        public string Nom { get; set; }
        
        [XmlArray("portes")]
        [XmlArrayItem("porte")]
        public List<int> Portes { get; set; }
        public int Id { get; internal set; }
        public List<Ennemi> Ennemis { get; set; }
        public Salle(string nom, List<int> portes)
        {
            Nom = nom;
            Portes = portes;
            Ennemis = new List<Ennemi>();
        }

        public Salle()
        {
            Portes = new List<int>();
            Ennemis = new List<Ennemi>();
        }

        public string Description()
        {
            string description = $"Vous êtes dans la salle : {Nom}\n";
            description += "         [ 4 ] --[ 5 ]--[ 6 ]\n";
            description += "          |         |        |\n";
            description += "         [ 1 ] --[ 2 ]--[ 3 ]\n";
            description += "          |         |        |\n";
            description += "         [ 7 ] --[ 8 ]--[ 9 ]\n";

            return description;
        }
        public void GenererEnnemis(List<Ennemi> ennemisDisponibles)
        {
            Ennemis.Clear();
            foreach (var ennemi in ennemisDisponibles)
            {
                Ennemis.Add(ennemi);
            }
        }
    }
}
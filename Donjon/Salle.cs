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

        public Salle(string nom, List<int> portes)
        {
            Nom = nom;
            Portes = portes;
        }

        public Salle()
        {
            Portes = new List<int>();
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

    }
}

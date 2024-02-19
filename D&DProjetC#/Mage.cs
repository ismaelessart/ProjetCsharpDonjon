using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DProjetC_
{
    internal class Mage : Personnage
    {   
        public Mage(string nom) : base(nom)
        {
            pointsDeVie = 85;
            degatsMin = 25;
            degatsMax = 35;
        }
    }
}

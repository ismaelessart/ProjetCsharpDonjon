using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DProjetC_
{
    internal class Voleur : Personnage
    {
        public Voleur(string nom) : base(nom) 
        {
            pointsDeVie = 100;
            degatsMin = 20;
            degatsMax = 30;
        }
    }
}

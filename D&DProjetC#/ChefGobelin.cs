using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DProjetC_
{
    internal class ChefGobelin : Entite
    {
        public ChefGobelin(string nom) : base(nom)
        {
            pointsDeVie = 120;
            degatsMin = 15;
            degatsMax = 30;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DProjetC_
{
    internal class GobelinMage : Entite
    {
        public GobelinMage(string nom) : base(nom)
        {
            pointsDeVie = 60;
            degatsMin = 8;
            degatsMax = 15;
        }
    }
}

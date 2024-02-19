using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DProjetC_
{
    internal class GobelinArcher : Entite
    {
        public GobelinArcher(string nom) : base(nom)
        {
            pointsDeVie = 50;
            degatsMin = 10;
            degatsMax = 20;
        }
    }
}

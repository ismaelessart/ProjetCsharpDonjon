using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DProjetC_
{
    internal class GobelinGuerrier : Entite
    {
        public GobelinGuerrier(string nom) : base(nom)
        {
            pointsDeVie = 70;
            degatsMin = 10;
            degatsMax = 25;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Entidades
{
    public class FrutosSecos
    {
        public int FrutosSecosID { get; set; }
        public string NombreFrutoS { get; set; } = null!;
        public override string ToString()
        {
            return $"{NombreFrutoS}";
        }
    }
}

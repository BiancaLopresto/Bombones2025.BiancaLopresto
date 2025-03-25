using Bombones2025.Datos.Repositorios;
using Bombones2025.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Servicios
{
   public class FrutosSecosServicio
    {
        private readonly FrutosSecosRepositorio RepositorioFrutos_ = null!;
        public FrutosSecosServicio(string FSruta)
        {
            RepositorioFrutos_ = new FrutosSecosRepositorio(FSruta);
        }


        public List<FrutosSecos> GetFrutoSeco()
        {
            return RepositorioFrutos_.GetFrutosSecos();
        }
    }
}

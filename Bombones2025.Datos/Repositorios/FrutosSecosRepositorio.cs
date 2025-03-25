using Bombones2025.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Datos.Repositorios
{
    public class FrutosSecosRepositorio
    {
        private List<FrutosSecos> FrutoSeco= new();
        private readonly string FSruta;
        public FrutosSecosRepositorio(string rutaArchivo)
        {
            FSruta = rutaArchivo;
            LeerDatos();
        }
        public List<FrutosSecos> GetFrutosSecos()
        {
            return FrutoSeco;
        }
        private void LeerDatos()
        {
            if (!File.Exists(FSruta))
            {
                return;
            }
            var registros = File.ReadAllLines(FSruta);
            foreach (var registro in registros)
            {
                FrutosSecos frutos = ConstruirFrutoSeco(registro);
                FrutoSeco.Add(frutos);
            }

        }
        private FrutosSecos ConstruirFrutoSeco(string registro)
        {
            var campos = registro.Split('|');
            var IDfruto = int.Parse(campos[0]);
            var nombreFruto = campos[1];
            return new FrutosSecos()
            {
                NombreFrutoS = nombreFruto,
                FrutosSecosID = IDfruto,
            };
        }
    }
}

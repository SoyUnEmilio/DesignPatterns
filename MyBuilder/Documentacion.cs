using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuilder
{
    public abstract class Documentacion
    {
        protected IList<string> Documentos = new List<string>();

        public abstract void Agregar(string documento);

        public abstract IList<string> ObtenerDocumentos();
    }
}

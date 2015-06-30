using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuilder
{
    public class DocumentacionHtml : Documentacion
    {
        public override void Agregar(string documento)
        {
            if (documento.StartsWith("<HTML>"))
            {
                Documentos.Add(documento);
            }
        }

        public override IList<string> ObtenerDocumentos()
        {
            return Documentos;
        }
    }
}

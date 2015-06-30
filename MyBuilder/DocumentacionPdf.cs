using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuilder
{
    public class DocumentacionPdf : Documentacion
    {
        public override void Agregar(string documento)
        {
            if (documento.StartsWith("<PDF>"))
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

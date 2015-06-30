using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuilder
{
    public class GeneracionDocumentacionVehiculoPdf : GeneracionDocumentacionVehiculo
    {
        public GeneracionDocumentacionVehiculoPdf(Documentacion documentacion) : base(documentacion)
        {
        }

        public GeneracionDocumentacionVehiculoPdf() : base(new DocumentacionPdf())
        {
        }

        public override void DocumentoVenta(string nombreCliente)
        {
            string result = string.Format("<PDF>Documentación de venta para {0}</PDF>", nombreCliente);
            Documentacion.Agregar(result);
        }

        public override void DocumentoMatriculacion(string nombreCliente)
        {
            string result = string.Format("<PDF>Documentación de matriculación para {0}</PDF>", nombreCliente);
            Documentacion.Agregar(result);
        }

        public override Documentacion ObtenerTodaLaDocumentacion()
        {
            return Documentacion;
        }
    }
}

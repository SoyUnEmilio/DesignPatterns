using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuilder
{
    public class GeneracionDocumentacionVehiculoHtml : GeneracionDocumentacionVehiculo
    {
        public GeneracionDocumentacionVehiculoHtml(Documentacion documentacion) : base(documentacion)
        {
        }

        public GeneracionDocumentacionVehiculoHtml(): base(new DocumentacionHtml())
        {
        }

        public override void DocumentoVenta(string nombreCliente)
        {
            string result = string.Format("<HTML>Documentación de venta para {0}</HTML>", nombreCliente);
            Documentacion.Agregar(result);
        }

        public override void DocumentoMatriculacion(string nombreCliente)
        {
            string result = string.Format("<HTML>Documentación de matriculación para {0}</HTML>", nombreCliente);
            Documentacion.Agregar(result);
        }

        public override Documentacion ObtenerTodaLaDocumentacion()
        {
            return Documentacion;
        }
    }
}

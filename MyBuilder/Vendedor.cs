using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuilder
{
    public class Vendedor
    {
        private readonly GeneracionDocumentacionVehiculo _generacionDocumentacionVehiculo;

        public Vendedor(GeneracionDocumentacionVehiculo generacionDocumentacionVehiculo)
        {
            _generacionDocumentacionVehiculo = generacionDocumentacionVehiculo;
        }

        public void GenerarDocumentoVenta(string nombreCliente)
        {
            _generacionDocumentacionVehiculo.DocumentoVenta(nombreCliente);
        }

        public Documentacion ObtenerDocumentosGenerados()
        {
            return _generacionDocumentacionVehiculo.ObtenerTodaLaDocumentacion();
        }

        public void GenerarDocumentoMatriculacion(string nombreCliente)
        {
            _generacionDocumentacionVehiculo.DocumentoMatriculacion(nombreCliente);
        }
    }
}

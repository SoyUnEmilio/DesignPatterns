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

        public Documentacion GenerarYObtenerDocumentacion(string nombreCliente)
        {
            _generacionDocumentacionVehiculo.DocumentoVenta(nombreCliente);
            _generacionDocumentacionVehiculo.DocumentoMatriculacion(nombreCliente);

            return _generacionDocumentacionVehiculo.ObtenerTodaLaDocumentacion();
        }
    }
}

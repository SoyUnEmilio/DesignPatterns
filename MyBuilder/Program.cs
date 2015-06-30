using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneracionDocumentacionVehiculo generacionDocumentacionVehiculoPDF = new GeneracionDocumentacionVehiculoPdf();
            Vendedor vendedorPDF = new Vendedor(generacionDocumentacionVehiculoPDF);
            vendedorPDF.GenerarDocumentoVenta("Luís");
            vendedorPDF.GenerarDocumentoMatriculacion("Luís");

            ImprimirDocumentacionPDF(vendedorPDF);
        }

        private static void ImprimirDocumentacionPDF(Vendedor vendedor)
        {
            var documentosGenerados = vendedor.ObtenerDocumentosGenerados();
            foreach (var documento in documentosGenerados.ObtenerDocumentos())
            {
                Console.WriteLine(documento);
            }
        }
    }
}

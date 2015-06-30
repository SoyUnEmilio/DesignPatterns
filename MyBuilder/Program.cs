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
            var generacionDocumentacionVehiculoPdf = new GeneracionDocumentacionVehiculoPdf();
            var vendedorPdf = new Vendedor(generacionDocumentacionVehiculoPdf);
            var documentacionPdf = vendedorPdf.GenerarYObtenerDocumentacion("Luís");
            ImprimirDocumentacion(documentacionPdf);

            var generacionDocumentacionVehiculoHtml = new GeneracionDocumentacionVehiculoHtml();
            var vendedorHtml = new Vendedor(generacionDocumentacionVehiculoHtml);
            var documentacionHtml = vendedorHtml.GenerarYObtenerDocumentacion("Luís");
            ImprimirDocumentacion(documentacionHtml);
        }

        private static void ImprimirDocumentacion(Documentacion documentacion)
        {
            foreach (var documento in documentacion.ObtenerDocumentos())
            {
                Console.WriteLine(documento);
            }
        }
    }
}

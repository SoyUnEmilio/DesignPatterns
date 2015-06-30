using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyBuilder.Tests
{
    [TestFixture]
    public class GeneracionDocumentacionVehiculoPdfTest
    {
        [Test]
        public void PuedoGenerarDocumentoVentaPdfYObtenerUnDocumento()
        {
            var generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoPdf();

            generacionDocumentacionVehiculo.DocumentoVenta("Luís");
            var documentacion = generacionDocumentacionVehiculo.ObtenerTodaLaDocumentacion();
            var numeroDocumentos = documentacion.ObtenerDocumentos().Count;

            Assert.AreEqual(1, numeroDocumentos);
        }

        [Test]
        public void PuedoGenerarDocumentoMatriculacionPdfYObtenerUnDocumento()
        {
            var generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoPdf();

            generacionDocumentacionVehiculo.DocumentoMatriculacion("Luís");
            var documentacion = generacionDocumentacionVehiculo.ObtenerTodaLaDocumentacion();
            var numeroDocumentos = documentacion.ObtenerDocumentos().Count;

            Assert.AreEqual(1, numeroDocumentos);
        }

        [Test]
        public void PuedoGenerarDocumentoVentaYMatriculacionPdfYObtenerDosDocumentos()
        {
            var generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoPdf();

            generacionDocumentacionVehiculo.DocumentoVenta("Luís");
            generacionDocumentacionVehiculo.DocumentoMatriculacion("Luís");
            var documentacion = generacionDocumentacionVehiculo.ObtenerTodaLaDocumentacion();
            var numeroDocumentos = documentacion.ObtenerDocumentos().Count;

            Assert.AreEqual(2, numeroDocumentos);
        }
    }

}

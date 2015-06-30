using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyBuilder.Tests
{
    [TestFixture]
    public class GeneracionDocumentacionVehiculoHtmlTest
    {
        [Test]
        public void PuedoGenerarDocumentoVentaHtmlYObtenerUnDocumento()
        {
            var generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoHtml();

            generacionDocumentacionVehiculo.DocumentoVenta("Luís");
            var documentacion = generacionDocumentacionVehiculo.ObtenerTodaLaDocumentacion();
            var numeroDocumentos = documentacion.ObtenerDocumentos().Count;

            Assert.AreEqual(1, numeroDocumentos);
        }

        [Test]
        public void PuedoGenerarDocumentoMatriculacionHtmlYObtenerUnDocumento()
        {
            var generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoHtml();

            generacionDocumentacionVehiculo.DocumentoMatriculacion("Luís");
            var documentacion = generacionDocumentacionVehiculo.ObtenerTodaLaDocumentacion();
            var numeroDocumentos = documentacion.ObtenerDocumentos().Count;

            Assert.AreEqual(1, numeroDocumentos);
        }

        [Test]
        public void PuedoGenerarDocumentoVentaYMatriculacionHtmlYObtenerDosDocumentos()
        {
            var generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoHtml();

            generacionDocumentacionVehiculo.DocumentoVenta("Luís");
            generacionDocumentacionVehiculo.DocumentoMatriculacion("Luís");
            var documentacion = generacionDocumentacionVehiculo.ObtenerTodaLaDocumentacion();
            var numeroDocumentos = documentacion.ObtenerDocumentos().Count;

            Assert.AreEqual(2, numeroDocumentos);
        }
    }
}

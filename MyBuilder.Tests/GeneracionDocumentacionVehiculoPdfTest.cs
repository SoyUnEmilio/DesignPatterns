using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace MyBuilder.Tests
{
    [TestFixture]
    public class GeneracionDocumentacionVehiculoPdfTest
    {
        [Test]
        public void PuedoGenerarDocumentoVentaPdf()
        {
            var documentacion = new Mock<DocumentacionPdf>();
            documentacion.Setup(s => s.Agregar(It.IsAny<string>()));
            var generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoPdf(documentacion.Object);

            generacionDocumentacionVehiculo.DocumentoVenta("Luís");

            documentacion.Verify(v => v.Agregar(It.IsAny<string>()));
        }

        [Test]
        public void PuedoGenerarDocumentoMatriculacionPdf()
        {
            var documentacion = new Mock<DocumentacionPdf>();
            documentacion.Setup(s => s.Agregar(It.IsAny<string>()));
            var generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoPdf(documentacion.Object);

            generacionDocumentacionVehiculo.DocumentoMatriculacion("Luís");

            documentacion.Verify(v => v.Agregar(It.IsAny<string>()));
        }

        [Test]
        public void PuedoGenerarDocumentoVentaYMatriculacionPdf()
        {
            var documentacion = new Mock<DocumentacionPdf>();
            documentacion.Setup(s => s.Agregar(It.IsAny<string>()));
            var generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoPdf(documentacion.Object);

            generacionDocumentacionVehiculo.DocumentoVenta("Luís");
            generacionDocumentacionVehiculo.DocumentoMatriculacion("Luís");

            documentacion.Verify(v => v.Agregar(It.IsAny<string>()), Times.Exactly(2));
        }

        [Test]
        public void PuedoObtenerDocumentacionGeneradaPdf()
        {
            var generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoPdf();

            generacionDocumentacionVehiculo.DocumentoVenta("Luís");
            generacionDocumentacionVehiculo.DocumentoMatriculacion("Luís");
            var documentacion = generacionDocumentacionVehiculo.ObtenerTodaLaDocumentacion().ObtenerDocumentos();

            Assert.AreEqual(2, documentacion.Count);
        }
    }
}
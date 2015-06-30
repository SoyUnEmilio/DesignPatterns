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
    public class GeneracionDocumentacionVehiculoHtmlTest
    {
        [Test]
        public void PuedoGenerarDocumentoVentaHtml()
        {
            var documentacion = new Mock<DocumentacionHtml>();
            documentacion.Setup(s => s.Agregar(It.IsAny<string>()));
            var generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoHtml(documentacion.Object);

            generacionDocumentacionVehiculo.DocumentoVenta("Luís");

            documentacion.Verify(v => v.Agregar(It.IsAny<string>()));
        }

        [Test]
        public void PuedoGenerarDocumentoMatriculacionHtml()
        {
            var documentacion = new Mock<DocumentacionHtml>();
            documentacion.Setup(s => s.Agregar(It.IsAny<string>()));
            var generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoHtml(documentacion.Object);

            generacionDocumentacionVehiculo.DocumentoMatriculacion("Luís");

            documentacion.Verify(v => v.Agregar(It.IsAny<string>()));
        }

        [Test]
        public void PuedoGenerarDocumentoVentaYMatriculacionHtml()
        {
            var documentacion = new Mock<DocumentacionHtml>();
            documentacion.Setup(s => s.Agregar(It.IsAny<string>()));
            var generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoHtml(documentacion.Object);

            generacionDocumentacionVehiculo.DocumentoVenta("Luís");
            generacionDocumentacionVehiculo.DocumentoMatriculacion("Luís");

            documentacion.Verify(v => v.Agregar(It.IsAny<string>()), Times.Exactly(2));
        }

        [Test]
        public void PuedoObtenerDocumentacionGeneradaHtml()
        {
            var generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoHtml();

            generacionDocumentacionVehiculo.DocumentoVenta("Luís");
            generacionDocumentacionVehiculo.DocumentoMatriculacion("Luís");
            var documentacion = generacionDocumentacionVehiculo.ObtenerTodaLaDocumentacion().ObtenerDocumentos();

            Assert.AreEqual(2, documentacion.Count);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyBuilder.Tests
{
    [TestFixture]
    public class VendedorTest
    {
        [Test]
        public void UnVendedorPuedeGenerarDocumentacionPdfParaCliente()
        {
            GeneracionDocumentacionVehiculo generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoPdf();
            Vendedor vendedor = new Vendedor(generacionDocumentacionVehiculo);

            Documentacion documentacion = vendedor.GenerarYObtenerDocumentacion("Luís");

            Assert.AreEqual(2, documentacion.ObtenerDocumentos().Count);
        }

        [Test]
        public void UnVendedorPuedeGenerarDocumentacionHtmlParaCliente()
        {
            GeneracionDocumentacionVehiculo generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoHtml();
            Vendedor vendedor = new Vendedor(generacionDocumentacionVehiculo);

            Documentacion documentacion = vendedor.GenerarYObtenerDocumentacion("Luís");

            Assert.AreEqual(2, documentacion.ObtenerDocumentos().Count);
        }
    }
}

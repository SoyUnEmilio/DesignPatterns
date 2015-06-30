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
        public void UnVendedorPuedeGenerarDocumentoDeVentaPDFParaCliente()
        {
            GeneracionDocumentacionVehiculo generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoPdf();
            Vendedor vendedor = new Vendedor(generacionDocumentacionVehiculo);
            
            vendedor.GenerarDocumentoVenta("Luís");
            
            Assert.AreEqual(1, vendedor.ObtenerDocumentosGenerados().ObtenerDocumentos().Count);
        }

        [Test]
        public void UnVendedorPuedeGenerarDocumentoDeVentaHTMLParaCliente()
        {
            GeneracionDocumentacionVehiculo generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoHtml();
            Vendedor vendedor = new Vendedor(generacionDocumentacionVehiculo);

            vendedor.GenerarDocumentoVenta("Luís");

            Assert.AreEqual(1, vendedor.ObtenerDocumentosGenerados().ObtenerDocumentos().Count);
        }

        [Test]
        public void UnVendedorPuedeGenerarDocumentoDeMatricualcionPDFParaCliente()
        {
            GeneracionDocumentacionVehiculo generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoPdf();
            Vendedor vendedor = new Vendedor(generacionDocumentacionVehiculo);

            vendedor.GenerarDocumentoMatriculacion("Luís");

            Assert.AreEqual(1, vendedor.ObtenerDocumentosGenerados().ObtenerDocumentos().Count);
        }

        [Test]
        public void UnVendedorPuedeGenerarDocumentoDeMatricualcionHTMLParaCliente()
        {
            GeneracionDocumentacionVehiculo generacionDocumentacionVehiculo = new GeneracionDocumentacionVehiculoHtml();
            Vendedor vendedor = new Vendedor(generacionDocumentacionVehiculo);

            vendedor.GenerarDocumentoMatriculacion("Luís");

            Assert.AreEqual(1, vendedor.ObtenerDocumentosGenerados().ObtenerDocumentos().Count);
        }

    }
}

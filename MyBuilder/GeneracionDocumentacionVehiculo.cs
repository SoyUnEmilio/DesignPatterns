namespace MyBuilder
{
    public abstract class GeneracionDocumentacionVehiculo
    {
        protected Documentacion Documentacion;

        public GeneracionDocumentacionVehiculo(Documentacion documentacion)
        {
            Documentacion = documentacion;
        }

        public abstract void DocumentoVenta(string nombreCliente);

        public abstract Documentacion ObtenerTodaLaDocumentacion();
        public abstract void DocumentoMatriculacion(string nombreCliente);
    }
}
namespace Builder
{
    public abstract class ConstructorDocumentacionVehiculo
    {
        protected Documentacion documentacion;

        public abstract void construyeSolicitudPedido(string
            nombreCliente);

        public abstract void construyeSolicitudMatriculacion
            (string nombreSolicitante);

        public Documentacion resultado()
        {
            return documentacion;
        }
    }
}

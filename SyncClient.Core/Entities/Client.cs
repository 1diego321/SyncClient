using System;

namespace SyncClient.Core.Entities
{
    public class Client
    {
        public Guid Id_cliente_proveedor { get; set; }
        public string Cod_cliente_proveedor { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}

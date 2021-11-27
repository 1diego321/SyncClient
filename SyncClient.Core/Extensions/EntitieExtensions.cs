using SyncClient.Core.Entities;
using SyncClient.Core.Models.DTO;

namespace SyncClient.Core.Extensions
{
    public static class EntitieExtensions
    {
        public static ArticuloSyncDTO MapDTO(this Article article)
        {
            return new ArticuloSyncDTO
            {
                Id = article.id_articulo,
                Description = article.descripcion,
                Price = article.precio,
                BarCode = article.cod_barras
            };
        }

        public static ClienteSyncDTO MapDTO(this Client client)
        {
            return new ClienteSyncDTO
            {
                Id = client.Id_cliente_proveedor,
                ClientCode = client.Cod_cliente_proveedor,
                Email = client.Email,
                Identification = client.Cedula,
                Name = client.Nombre,
                PhoneNumber = client.Telefono
            };
        }
    }
}

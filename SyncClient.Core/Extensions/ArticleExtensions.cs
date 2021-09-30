using SyncClient.Core.Entities;
using SyncClient.Core.Models.DTO;

namespace SyncClient.Core.Extensions
{
    public static class ArticleExtensions
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
    }
}

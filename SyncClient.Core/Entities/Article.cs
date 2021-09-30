using System;

namespace SyncClient.Core.Entities
{
    public class Article
    {
        public Guid id_articulo { get; set; }
        public string descripcion { get; set; }
        public string cod_barras { get; set; }
        public decimal precio { get; set; }
    }
}

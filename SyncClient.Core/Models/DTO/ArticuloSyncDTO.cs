using System;

namespace SyncClient.Core.Models.DTO
{
    public class ArticuloSyncDTO
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string BarCode { get; set; }
        public decimal Price { get; set; }
    }
}

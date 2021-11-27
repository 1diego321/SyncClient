using System;

namespace SyncClient.Core.Models.DTO
{
    public class ClienteSyncDTO
    {
        public Guid Id { get; set; }
        public string ClientCode { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}

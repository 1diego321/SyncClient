﻿using System;

namespace SyncClient.Core.Models.DTO
{
    public class ClienteSyncDTO
    {
        public Guid Id { get; set; }
        public string CodCliente { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}

using Dapper;
using SyncClient.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncClient.Core.SQL.DAO
{
    public class ClienteDAO : ConnectionSql
    {
        string query = @"select c.id_cliente_proveedor,
	                            c.cod_cliente_proveedor,
	                            c.nombre,
	                            c.cedula,
	                            c.email,
	                            c.telefono
                         from netbus_cliente_proveedor c";
        public List<Client> GetAll()
        {
            using (var connection = GetConnection())
            {
                var result = connection.Query<Client>(query);

                return result.ToList();
            }
        }
    }
}

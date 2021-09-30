using Dapper;
using SyncClient.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SyncClient.Core.SQL.DAO
{
    public class ArticleDAO : ConnectionSql
    {
        string query = @"SELECT ia.id_articulo,
                                ia.descripcion,
	                            ia.cod_barras,
	                            COALESCE((SELECT TOP 1 precio
                                FROM inventario_historico_precios
                        WHERE id_articulo = ia.id_articulo
                        ORDER BY fecha DESC), 0) AS precio
                        FROM inventario_articulo ia";
        public List<Article> GetAll()
        {
            using(var connection = GetConnection())
            {
                var result = connection.Query<Article>(query);

                return result.ToList();
            }
        }
    }
}

using SyncClient.Core.Models.Reponse;
using SyncClient.Core.SQL.DAO;
using SyncClient.Core.Extensions;
using System.Collections.Generic;
using SyncClient.Core.Models.DTO;
using System.Linq;

namespace SyncClient.Core.Service
{
    public class SyncService
    {
        public SyncResponse SyncArticles()
        {
            var articleDAO = new ArticleDAO();
            var httpRepo = new HTTP.HttpRepository();
            var dtos = new List<ArticuloSyncDTO>();
            string url = "https://localhost:44394/api/System/SyncArticles";
            //string url = "https://market-express.azurewebsites.net/api/System/SyncArticles";
            SyncResponse res = new();

            try
            {
                var articles = articleDAO.GetAll();

                articles.ForEach(x =>
                {
                    dtos.Add(x.MapDTO());
                });

                res = httpRepo.Send(dtos, url);

                res.SentCount = articles.Count;

                return res;
            }
            catch (System.Exception ex)
            {
                return new SyncResponse(false);
            }
        }

        public SyncResponse SyncClients()
        {
            var clientDAO = new ClienteDAO();
            var httpRepo = new HTTP.HttpRepository();
            var dtos = new List<ClienteSyncDTO>();
            string url = "https://localhost:44394/api/System/SyncClients";
            //string url = "https://market-express.azurewebsites.net/api/System/SyncClients";
            SyncResponse res = new();

            try
            {
                var clients = clientDAO.GetAll();

                clients.RemoveAt(clients.FindIndex(x => x.Nombre == "CLIENTE CONTADO"));

                clients.ForEach(x =>
                {
                    dtos.Add(x.MapDTO());
                });

                res = httpRepo.Send(dtos, url);

                res.SentCount = clients.Count;

                return res;
            }
            catch (System.Exception ex)
            {
                return new SyncResponse(false);
            }
        }
    }
}

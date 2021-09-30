using SyncClient.Core.Models.Reponse;
using SyncClient.Core.SQL.DAO;
using SyncClient.Core.Extensions;
using System.Collections.Generic;
using SyncClient.Core.Models.DTO;

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
            SyncResponse res = new();
            int count = 0;

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
    }
}

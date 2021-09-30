namespace SyncClient.Core.Models.Reponse
{
    public class SyncResponse
    {
        public SyncResponse()
        {

        }

        public SyncResponse(bool success)
        {
            Success = success;
        }

        public int AddedCount { get; set; }
        public int UpdatedCount { get; set; }
        public bool Success { get; set; }
        public int SentCount { get; set; }
        public System.Net.HttpStatusCode StatusCode { get; set; }
    }
}

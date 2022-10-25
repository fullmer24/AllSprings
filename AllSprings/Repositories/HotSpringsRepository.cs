using System.Data;

namespace AllSprings.Repositories
{
    public class HotSpringsRepository
    {
        private readonly IDbConnection _db;
        public HotSpringsRepository(IDbConnection db)
        {
            _db = db;
        }
    }
}
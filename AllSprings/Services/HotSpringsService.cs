using AllSprings.Repositories;

namespace AllSprings.Services
{
    public class HotSpringsService
    {
        private readonly HotSpringsRepository _hsRepo;
        public HotSpringsService(HotSpringsRepository hsRepo)
        {
            _hsRepo = hsRepo;
        }
    }
}
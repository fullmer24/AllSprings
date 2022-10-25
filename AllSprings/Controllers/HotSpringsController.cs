using AllSprings.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllSprings.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotSpringsController : ControllerBase
    {
        private readonly HotSpringsService _hsService;

        public HotSpringsController(HotSpringsService hsService)
        {
            _hsService = hsService;
        }
    }
}
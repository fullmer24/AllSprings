using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AllSprings.Models;
using AllSprings.Services;
using Microsoft.AspNetCore.Authorization;
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
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<HotSprings>> Create([FromBody] HotSprings newHotSprings)
        {
            try
            {
                Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
                newHotSprings.creatorId = userInfo?.Id;
                HotSprings hotSprings = _hsService.Create(newHotSprings);
                hotSprings.Creator = userInfo;
                return Ok(hotSprings);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        public async Task<ActionResult<List<HotSprings>>> GetAll()
        {
            try
            {
                Account user = await HttpContext.GetUserInfoAsync<Account>();
                List<HotSprings> hotSprings = _hsService.GetAll(user?.Id);
                return Ok(hotSprings);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwoToFour___Endpoints.Services;

namespace MiniChallengeTwoToFour___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LessThenGreaterThen : ControllerBase
    {
        private readonly LessThenGreaterThenServices _lessThenGreaterThenService;
        public LessThenGreaterThen(LessThenGreaterThenServices lessThenGreaterThenService)
        {
            _lessThenGreaterThenService = lessThenGreaterThenService;
        }

        [HttpPost]
        [Route("lessThenGreaterThen/{num3}/{num4}")]
        public string LessThenGreaterThenMethod(string num3, string num4)
        {
            _lessThenGreaterThenService.LessThenGreaterThen(num3, num4);
            return _lessThenGreaterThenService.reply1;
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwoToFour___Endpoints.Services;

namespace MiniChallengeTwoToFour___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TwoInputsSentence : ControllerBase
    {
        private readonly TwoInputsSentenceServices _twoInputsSentenceServices;
        public TwoInputsSentence(TwoInputsSentenceServices twoInputsSentenceServices)
        {
            _twoInputsSentenceServices = twoInputsSentenceServices;
        }

        [HttpPost]
        [Route("twoInputsSentence/{yourName}/{whatTimeDidyouWakeUp}")]
        public string TwoInputsSentenceMethod(string yourName, string whatTimeDidyouWakeUp)
        {
            _twoInputsSentenceServices.TwoInputsSentence(yourName, whatTimeDidyouWakeUp);
            return _twoInputsSentenceServices.reply;
        }
    }
}
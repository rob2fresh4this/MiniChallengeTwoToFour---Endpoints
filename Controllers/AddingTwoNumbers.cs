
using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwoToFour___Endpoints.Services;

namespace MiniChallengeTwoToFour___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddingTwoNumbers : ControllerBase
    {
        private readonly AddingTwoNumbersService _addingTwoNumbersService;

        public AddingTwoNumbers(AddingTwoNumbersService addingTwoNumbersService)
        {
            _addingTwoNumbersService = addingTwoNumbersService;
        }

        [HttpPost]
        [Route("addNumbers/{num1}/{num2}")]
        public string AddNumbers(string num1, string num2)
        {
            _addingTwoNumbersService.AddingTwoNumbers(num1, num2);
            return _addingTwoNumbersService.anwser;
        }
    }
}
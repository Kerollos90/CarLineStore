using Microsoft.AspNetCore.Http;
using OpenAI.Chat;
using OpenAI;

using Microsoft.AspNetCore.Mvc;
using Carline.Web.Extensions;
using Microsoft.Graph;

namespace Carline.Web.Controllers
{
    [Route("api/chat")]
    [ApiController]
    public class ChatBotController : ControllerBase
    {
        private readonly OpenAIService _openAIService;

        public ChatBotController()
        {
            _openAIService = new OpenAIService();
        }

        [HttpPost("ask")]
        public async Task<IActionResult> AskChatGPT([FromBody] ChatRequest request)
        {
            var response = await _openAIService.GetChatGPTResponse(request.Message);
            return Ok(response);
        }


    }
    public class ChatRequest
    {
        public string Message { get; set; }
    }
}

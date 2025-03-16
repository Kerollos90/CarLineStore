using System.Text.Json;
using System.Text;

namespace Carline.Web.Extensions
{
    public class OpenAIService
    {
        private readonly string _apiKey = "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";
        private readonly HttpClient _httpClient;

        public OpenAIService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetChatGPTResponse(string prompt)
        {
            var requestBody = new
            {
                model = "gpt-3.5-turbo",
                messages = new[]
                {
                new { role = "system", content = "You are a helpful assistant." },
                new { role = "user", content = prompt }
            },
                max_tokens = 100
            };

            var requestContent = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");

            var response = await _httpClient.PostAsync("https://api.openai.com/v1/chat/completions", requestContent);
            var responseContent = await response.Content.ReadAsStringAsync();

            return responseContent;
        }
    }
}

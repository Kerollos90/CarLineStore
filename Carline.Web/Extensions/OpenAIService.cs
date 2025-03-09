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

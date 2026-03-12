using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Authentication_Winform.Models;
using System.Net.Http;

namespace Authentication_Winform.Service
{
    public class AuthApi
    {
        private readonly HttpClient _httpClient;

        public AuthApi()
        {
            _httpClient = new HttpClient();
        }

        public async Task<LoginResponse?> LoginAsync(string username, string password)
        {
            try
            {
                var body = new
                {
                    username,
                    password
                };

                var json = JsonSerializer.Serialize(body);

                var content = new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json"
                );

                using var response = await _httpClient.PostAsync(
                    "https://dummyjson.com/auth/login",
                    content
                );

                if (!response.IsSuccessStatusCode)
                    return null;

                var stream = await response.Content.ReadAsStreamAsync();

                var result = await JsonSerializer.DeserializeAsync<LoginResponse>(
                    stream,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                return result;
            }
            catch
            {
                return null;
            }
        }

    }
}

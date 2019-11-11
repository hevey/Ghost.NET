using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HLStudios.GhostAPI.Models;

namespace HLStudios.GhostAPI.APIs
{
    public class ContentApi
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        
        public ContentApi(string url, string apiKey)
        {
            _httpClient = new HttpClient();
            _apiKey = apiKey;

            _httpClient.BaseAddress = new Uri(url);
        }

        public async Task<PostList> BrowsePostsAsync(bool tags = false, bool authors = false)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/posts/?key={_apiKey}");
            
            // Adds optional request information to the call.
            requestUri.Append(tags && authors ? "&include=tags,authors" : "");
            requestUri.Append(tags ? "&include=tags" : "");
            requestUri.Append(authors ? "&include=authors" : "");

            try
            {
                using var response =
                    await _httpClient.GetAsync(requestUri.ToString());
                
                //TODO: send back error information from the API when response.EnsureStatusCode() fails. 
                response.EnsureSuccessStatusCode();
                
                return JsonSerializer.Deserialize<PostList>(await response.Content.ReadAsStringAsync());
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
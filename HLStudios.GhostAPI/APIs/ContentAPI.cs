using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HLStudios.GhostAPI.Enums;
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

        public async Task<PostList> BrowsePostsAsync(PostOptions options = null)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/posts/?key={_apiKey}");

            if (options != null)
            {
                // Adds optional request information to the call.
                requestUri.Append(options.Include == IncludeEnum.AuthorsAndTags ? "&include=tags,authors" : "");
                requestUri.Append(options.Include == IncludeEnum.Tags ? "&include=tags" : "");
                requestUri.Append(options.Include == IncludeEnum.Authors ? "&include=authors" : "");

                requestUri.Append(options.Format == FormatEnum.PlainText ? "&formats=plaintext" : "");
                requestUri.Append(options.Format == FormatEnum.Html ? "&formats=html" : "");
                requestUri.Append(options.Format == FormatEnum.HtmlAndPlainText ? "&formats=html,plaintext" : "");

                requestUri.Append(options.Page != string.Empty ? $"&page={options.Page}" : "");
                requestUri.Append(options.Limit != string.Empty ? $"&limit={options.Limit}" : "");
            }

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

        public async Task<Post> ReadPostByIdAsync(string id, PostOptions options = null)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/posts/{id}/?key={_apiKey}");
            
            if (options != null)
            {
                // Adds optional request information to the call.
                requestUri.Append(options.Include == IncludeEnum.AuthorsAndTags ? "&include=tags,authors" : "");
                requestUri.Append(options.Include == IncludeEnum.Tags ? "&include=tags" : "");
                requestUri.Append(options.Include == IncludeEnum.Authors ? "&include=authors" : "");

                requestUri.Append(options.Format == FormatEnum.PlainText ? "&formats=plaintext" : "");
                requestUri.Append(options.Format == FormatEnum.Html ? "&formats=html" : "");
                requestUri.Append(options.Format == FormatEnum.HtmlAndPlainText ? "&formats=html,plaintext" : "");
            }
            
            try
            {
                using var response =
                    await _httpClient.GetAsync(requestUri.ToString());
                
                //TODO: send back error information from the API when response.EnsureStatusCode() fails. 
                response.EnsureSuccessStatusCode();
                
                var postList = JsonSerializer.Deserialize<PostList>(await response.Content.ReadAsStringAsync());

                return postList.Posts[0];
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        
        public async Task<Post> ReadPostBySlugAsync(string slug, PostOptions options = null)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/posts/slug/{slug}/?key={_apiKey}");
            
            if (options != null)
            {
                // Adds optional request information to the call.
                requestUri.Append(options.Include == IncludeEnum.AuthorsAndTags ? "&include=tags,authors" : "");
                requestUri.Append(options.Include == IncludeEnum.Tags ? "&include=tags" : "");
                requestUri.Append(options.Include == IncludeEnum.Authors ? "&include=authors" : "");

                requestUri.Append(options.Format == FormatEnum.PlainText ? "&formats=plaintext" : "");
                requestUri.Append(options.Format == FormatEnum.Html ? "&formats=html" : "");
                requestUri.Append(options.Format == FormatEnum.HtmlAndPlainText ? "&formats=html,plaintext" : "");
            }
            
            try
            {
                using var response =
                    await _httpClient.GetAsync(requestUri.ToString());
                
                //TODO: send back error information from the API when response.EnsureStatusCode() fails. 
                response.EnsureSuccessStatusCode();

                var postList = JsonSerializer.Deserialize<PostList>(await response.Content.ReadAsStringAsync());

                return postList.Posts[0];
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
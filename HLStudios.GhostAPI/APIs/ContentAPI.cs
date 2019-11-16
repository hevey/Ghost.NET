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

            return await GetRequestAsync<PostList>(requestUri);
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

            var postList = await GetRequestAsync<PostList>(requestUri);
            return postList.Posts[0];
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

            var postList = await GetRequestAsync<PostList>(requestUri);
            return postList.Posts[0];
        }
        
        public async Task<PageList> BrowsePageAsync(PageOptions options = null)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/pages/?key={_apiKey}");

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

            return await GetRequestAsync<PageList>(requestUri);
        }
        
        public async Task<Page> ReadPageByIdAsync(string id, PageOptions options = null)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/pages/{id}/?key={_apiKey}");
            
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

            var pageList = await GetRequestAsync<PageList>(requestUri);
            return pageList.Pages[0];
        }
        
        public async Task<Page> ReadPageBySlugAsync(string slug, PageOptions options = null)
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
            
            var pageList = await GetRequestAsync<PageList>(requestUri);
            return pageList.Pages[0];
        }
        
        public async Task<TagList> BrowseTagsAsync()
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/tags/?key={_apiKey}");

            return await GetRequestAsync<TagList>(requestUri);
        }
        
        public async Task<Tag> ReadTagByIdAsync(string id)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/tags/{id}/?key={_apiKey}");

            var tagList = await GetRequestAsync<TagList>(requestUri);
            return tagList.Tags[0];
        }
        
        public async Task<Tag> ReadTagBySlugAsync(string slug)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/tags/slug/{slug}/?key={_apiKey}");

            var tagList = await GetRequestAsync<TagList>(requestUri);
            return tagList.Tags[0];
        }
        
        public async Task<AuthorList> BrowseAuthorsAsync()
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/authors/?key={_apiKey}");

            return await GetRequestAsync<AuthorList>(requestUri);
        }
        
        public async Task<Author> ReadAuthorByIdAsync(string id)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/authors/{id}/?key={_apiKey}");

            var authorList = await GetRequestAsync<AuthorList>(requestUri);
            return authorList.Authors[0];
        }
        
        public async Task<Author> ReadAuthorBySlugAsync(string slug)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/authors/slug/{slug}/?key={_apiKey}");

            var authorList = await GetRequestAsync<AuthorList>(requestUri);
            return authorList.Authors[0];
        }

        public async Task<Settings> ReadSettingsAsync()
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/settings/?key={_apiKey}");

            var settingsRoot = await GetRequestAsync<SettingsRoot>(requestUri);
            return settingsRoot.Settings;
        }

        private async Task<T> GetRequestAsync<T>(StringBuilder requestUri)
        {
            try
            {
                using var response =
                    await _httpClient.GetAsync(requestUri.ToString());

                //TODO: send back error information from the API when response.EnsureStatusCode() fails. 
                response.EnsureSuccessStatusCode();

                var ghostResponse = JsonSerializer.Deserialize<T>(await response.Content.ReadAsStringAsync());
                
                return ghostResponse;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HLStudios.GhostAPI.Enums;
using HLStudios.GhostAPI.Models;
using HLStudios.GhostAPI.Utilities;

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
                requestUri.Append(options.Include != Include.None 
                    ? $"&include={options.Include.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Format != Format.None 
                    ? $"&formats={options.Format.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Fields != PostFields.None
                    ? $"&fields={options.Fields.GetDescriptions()}"
                    : string.Empty);
                
                requestUri.Append(options.Page != string.Empty ? $"&page={options.Page}" : string.Empty);
                requestUri.Append(options.Limit != string.Empty ? $"&limit={options.Limit}" : string.Empty);
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
                requestUri.Append(options.Include != Include.None 
                    ? $"&include={options.Include.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Format != Format.None 
                    ? $"&formats={options.Format.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Fields != PostFields.None
                    ? $"&fields={options.Fields.GetDescriptions()}"
                    : string.Empty);
            }

            var postList = await GetRequestAsync<PostList>(requestUri);
            return postList.Posts.SingleOrDefault();
        }
        
        public async Task<Post> ReadPostBySlugAsync(string slug, PostOptions options = null)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/posts/slug/{slug}/?key={_apiKey}");
            
            if (options != null)
            {
                // Adds optional request information to the call.
                requestUri.Append(options.Include != Include.None 
                    ? $"&include={options.Include.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Format != Format.None 
                    ? $"&formats={options.Format.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Fields != PostFields.None
                    ? $"&fields={options.Fields.GetDescriptions()}"
                    : string.Empty);
            }

            var postList = await GetRequestAsync<PostList>(requestUri);
            return postList.Posts.SingleOrDefault();
        }
        
        public async Task<PageList> BrowsePageAsync(PageOptions options = null)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/pages/?key={_apiKey}");

            if (options != null)
            {
                // Adds optional request information to the call.
                requestUri.Append(options.Include != Include.None 
                    ? $"&include={options.Include.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Format != Format.None 
                    ? $"&formats={options.Format.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Fields != PageFields.None
                    ? $"&fields={options.Fields.GetDescriptions()}"
                    : string.Empty);

                requestUri.Append(options.Page != string.Empty ? $"&page={options.Page}" : string.Empty);
                requestUri.Append(options.Limit != string.Empty ? $"&limit={options.Limit}" : string.Empty);
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
                requestUri.Append(options.Include != Include.None 
                    ? $"&include={options.Include.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Format != Format.None 
                    ? $"&formats={options.Format.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Fields != PageFields.None
                    ? $"&fields={options.Fields.GetDescriptions()}"
                    : string.Empty);
            }

            var pageList = await GetRequestAsync<PageList>(requestUri);
            return pageList.Pages.SingleOrDefault();
        }
        
        public async Task<Page> ReadPageBySlugAsync(string slug, PageOptions options = null)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/posts/slug/{slug}/?key={_apiKey}");
            
            if (options != null)
            {
                // Adds optional request information to the call.
                requestUri.Append(options.Include != Include.None 
                    ? $"&include={options.Include.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Format != Format.None 
                    ? $"&formats={options.Format.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Fields != PageFields.None
                    ? $"&fields={options.Fields.GetDescriptions()}"
                    : string.Empty);
            }
            
            var pageList = await GetRequestAsync<PageList>(requestUri);
            return pageList.Pages.SingleOrDefault();
        }
        
        public async Task<TagList> BrowseTagsAsync(TagOptions options = null)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/tags/?key={_apiKey}");
            
            if (options != null)
            {
                requestUri.Append(options.Include != Include.None 
                    ? $"&include={options.Include.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Fields != TagFields.None
                    ? $"&fields={options.Fields.GetDescriptions()}"
                    : string.Empty);
                
                requestUri.Append(options.Page != string.Empty ? $"&page={options.Page}" : string.Empty);
                requestUri.Append(options.Limit != string.Empty ? $"&limit={options.Limit}" : string.Empty);
            }

            return await GetRequestAsync<TagList>(requestUri);
        }
        
        public async Task<Tag> ReadTagByIdAsync(string id, TagOptions options = null)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/tags/{id}/?key={_apiKey}");
            
            if (options != null)
            {
                requestUri.Append(options.Include != Include.None 
                    ? $"&include={options.Include.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Fields != TagFields.None
                    ? $"&fields={options.Fields.GetDescriptions()}"
                    : string.Empty);
            }

            var tagList = await GetRequestAsync<TagList>(requestUri);
            return tagList.Tags.SingleOrDefault();
        }
        
        public async Task<Tag> ReadTagBySlugAsync(string slug, TagOptions options = null)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/tags/slug/{slug}/?key={_apiKey}");
            
            if (options != null)
            {
                requestUri.Append(options.Include != Include.None 
                    ? $"&include={options.Include.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Fields != TagFields.None
                    ? $"&fields={options.Fields.GetDescriptions()}"
                    : string.Empty);
            }

            var tagList = await GetRequestAsync<TagList>(requestUri);
            return tagList.Tags.SingleOrDefault();
        }
        
        public async Task<AuthorList> BrowseAuthorsAsync(AuthorOptions options = null)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/authors/?key={_apiKey}");
            
            if (options != null)
            {
                requestUri.Append(options.Include != Include.None 
                    ? $"&include={options.Include.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Fields != AuthorFields.None
                    ? $"&fields={options.Fields.GetDescriptions()}"
                    : string.Empty);
                
                requestUri.Append(options.Page != string.Empty ? $"&page={options.Page}" : string.Empty);
                requestUri.Append(options.Limit != string.Empty ? $"&limit={options.Limit}" : string.Empty);
            }

            return await GetRequestAsync<AuthorList>(requestUri);
        }
        
        public async Task<Author> ReadAuthorByIdAsync(string id, AuthorOptions options = null)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/authors/{id}/?key={_apiKey}");
            
            if (options != null)
            {
                requestUri.Append(options.Include != Include.None 
                    ? $"&include={options.Include.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Fields != AuthorFields.None
                    ? $"&fields={options.Fields.GetDescriptions()}"
                    : string.Empty);
            }

            var authorList = await GetRequestAsync<AuthorList>(requestUri);
            return authorList.Authors.SingleOrDefault();
        }
        
        public async Task<Author> ReadAuthorBySlugAsync(string slug, AuthorOptions options = null)
        {
            var requestUri = new StringBuilder();
            
            requestUri.Append($"/ghost/api/v3/content/authors/slug/{slug}/?key={_apiKey}");
            
            if (options != null)
            {
                requestUri.Append(options.Include != Include.None 
                    ? $"&include={options.Include.GetDescriptions()}" 
                    : string.Empty);
                requestUri.Append(options.Fields != AuthorFields.None
                    ? $"&fields={options.Fields.GetDescriptions()}"
                    : string.Empty);
            }

            var authorList = await GetRequestAsync<AuthorList>(requestUri);
            return authorList.Authors.SingleOrDefault();
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
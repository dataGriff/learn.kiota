using System.Security.Cryptography;
using System.Text;
using Marvel.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;


// API requires no authentication, so use the anonymous
// authentication provider
// var authProvider = new AnonymousAuthenticationProvider();
// // Create request adapter using the HttpClient-based implementation
// var adapter = new HttpClientRequestAdapter(authProvider);
// // Create the API client
// var client = new MarvelClient(adapter);

        string _publicApiKey = "";
        string _privateApiKey = "";
        using var md5 = MD5.Create();
        string timestamp = DateTime.Now.Ticks.ToString();
        var data = Encoding.UTF8.GetBytes(timestamp + _privateApiKey + _publicApiKey);
        var hashedKey = md5.ComputeHash(data);
        var hashedKeyString = BitConverter.ToString(hashedKey).Replace("-", "").ToLower();

        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://gateway.marvel.com:443/v1/public/characters?apikey={_publicApiKey}&hash={hashedKeyString}&ts={timestamp}&nameStartsWith=spider&limit=10");
        

try
{
    // GET /posts
    // var allCharacters = await client.Characters.GetAsync();
    // Console.WriteLine($"{allCharacters}");

    Console.WriteLine(request);


    var content = new StringContent("", null, "text/plain");
    request.Content = content;
    var response = await client.SendAsync(request);
    response.EnsureSuccessStatusCode();
    Console.WriteLine(await response.Content.ReadAsStringAsync());


    // // GET /posts/{id}
    // var specificPostId = 5;
    // var specificPost = await client.Posts[specificPostId].GetAsync();
    // Console.WriteLine($"Retrieved post - ID: {specificPost?.Id}, Title: {specificPost?.Title}, Body: {specificPost?.Body}");

}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
    Console.WriteLine(ex.StackTrace);
}

// public class CustomAuthProvider : IAuthenticationProvider
// {
//     private readonly string _apiKey;

//     public CustomAuthProvider(string apiKey)
//     {
//         _apiKey = apiKey;
//     }

//     public async Task AuthenticateRequestAsync(HttpRequestMessage request)
//     {
//         using var sha256 = SHA256.Create();
//         var hashedKey = sha256.ComputeHash(Encoding.UTF8.GetBytes(_apiKey));
//         var hashedKeyString = BitConverter.ToString(hashedKey).Replace("-", "").ToLower();

//         request.Headers.Add("Authorization", $"Bearer {hashedKeyString}");
//     }
// }

// public class CustomAuthProvider : IAuthenticationProvider
// {
//     private readonly string _publicApiKey;
//     private readonly string _privateApiKey;

//     public CustomAuthProvider(string publicApiKey, string privateApiKey)
//     {
//         _publicApiKey = publicApiKey;
//         _privateApiKey = privateApiKey;
//     }

//     public async Task AuthenticateRequestAsync(HttpRequestMessage request)
//     {
//         using var md5 = MD5.Create();
//         string timestamp = DateTime.Now.Ticks.ToString();
//         var data = Encoding.UTF8.GetBytes(_publicApiKey + _privateApiKey + timestamp);
//         var hashedKey = md5.ComputeHash(data);
//         var hashedKeyString = BitConverter.ToString(hashedKey).Replace("-", "").ToLower();

//         var uriBuilder = new UriBuilder(request.Uri);
//         var query = HttpUtility.ParseQueryString(uriBuilder.Query);
//         query["apikey"] = _publicApiKey;
//         query["hash"] = hashedKeyString;
//         query["timestamp"] = timestamp;
//         uriBuilder.Query = query.ToString();
//         request.Uri = uriBuilder.Uri;
//     }
// }
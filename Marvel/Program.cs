using System.Security.Cryptography;
using System.Text;
// using System.Net.Http;
using Marvel.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

string publicApiKey = "";
string privateApiKey = "";


// API requires no authentication, so use the anonymous
// authentication provider
//var authProvider = new CustomAuthProvider(publicApiKey, privateApiKey);
var authProvider = new AnonymousAuthenticationProvider();
// Create request adapter using the HttpClient-based implementation
var adapter = new HttpClientRequestAdapter(authProvider);
// Create the API client
var client = new MarvelClient(adapter);


using var md5 = MD5.Create();
string timestamp = DateTime.Now.Ticks.ToString();
var data = Encoding.UTF8.GetBytes(timestamp + privateApiKey + publicApiKey);
var hashedKey = md5.ComputeHash(data);
var hashedKeyString = BitConverter.ToString(hashedKey).Replace("-", "").ToLower();

var notclient = new HttpClient();
var request = new HttpRequestMessage(HttpMethod.Get, $"https://gateway.marvel.com:443/v1/public/characters?apikey={publicApiKey}&hash={hashedKeyString}&ts={timestamp}&nameStartsWith=spider&limit=10");
//client.Characters.RequestAdapter.BaseUrl = $"https://gateway.marvel.com:443/v1/public/characters?apikey={publicApiKey}&hash={hashedKeyString}&ts={timestamp}&nameStartsWith=spider&limit=10";

try
{
    Console.WriteLine(request);


    var content = new StringContent("", null, "text/plain");
    request.Content = content;
    var response = await notclient.SendAsync(request);
    response.EnsureSuccessStatusCode();
    Console.WriteLine(await response.Content.ReadAsStringAsync());

    Console.WriteLine("Finished not using client.");

   

    // GET /posts
    var allCharacters = await client.Characters.GetAsync();
    Console.WriteLine($"{allCharacters}");


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
//     private readonly string _publicApiKey;
//     private readonly string _privateApiKey;

//     public CustomAuthProvider(string publicApiKey, string privateApiKey)
//     {
//         _publicApiKey = publicApiKey;
//         _privateApiKey = privateApiKey;
//     }

//     public async Task AuthenticateRequestAsync(HttpRequestMessage request)
//     {
//         // Implement your authentication logic here
//         // Example for a hypothetical API that uses MD5 hash of keys and timestamp

//         // Create a timestamp for this request
//         var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();

//         // Concatenate the timestamp, private key, and public key
//         var toBeHashed = timestamp + _privateApiKey + _publicApiKey;

//         // Create the MD5 hash
//         string hash;
//         using (var md5 = MD5.Create())
//         {
//             var hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(toBeHashed));
//             hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
//         }

//         // Append the authentication query parameters
//         var query = HttpUtility.ParseQueryString(request.RequestUri.Query);
//         query["apikey"] = _publicApiKey;
//         query["hash"] = hash;
//         query["ts"] = timestamp;

//         var uriBuilder = new UriBuilder(request.RequestUri)
//         {
//             Query = query.ToString()
//         };

//         request.RequestUri = uriBuilder.Uri;

//         // If there are additional headers or bearer tokens required, set them here
//         // request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "your_access_token");

//         // Note: No need to return anything as you're directly modifying the HttpRequestMessage
//     }
// }
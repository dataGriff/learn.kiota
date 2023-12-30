# learn.kiota

dotnet add package Microsoft.Kiota.Abstractions
dotnet add package Microsoft.Kiota.Http.HttpClientLibrary
dotnet add package Microsoft.Kiota.Serialization.Form
dotnet add package Microsoft.Kiota.Serialization.Json
dotnet add package Microsoft.Kiota.Serialization.Text
dotnet add package Microsoft.Kiota.Serialization.Multipart

kiota generate -l CSharp -c PostsClient -n KiotaPosts.Client -d ./posts-api.yml -o ./Client


kiota generate -l CSharp -c PostsClient -n KiotaPosts.Client -d ./Marvel.json -o ./Client
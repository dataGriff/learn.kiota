# learn.kiota

## Standard

dotnet add package Microsoft.Kiota.Abstractions
dotnet add package Microsoft.Kiota.Http.HttpClientLibrary
dotnet add package Microsoft.Kiota.Serialization.Form
dotnet add package Microsoft.Kiota.Serialization.Json
dotnet add package Microsoft.Kiota.Serialization.Text
dotnet add package Microsoft.Kiota.Serialization.Multipart

kiota generate -l CSharp -c PostsClient -n KiotaPosts.Client -d ./posts-api.yml -o ./Client

## Marvel

```bash
dotnet new console -o Marvel
dotnet new gitignore
```

```bash
cd Marvel
dotnet add package Microsoft.Kiota.Abstractions
dotnet add package Microsoft.Kiota.Http.HttpClientLibrary
dotnet add package Microsoft.Kiota.Serialization.Form
dotnet add package Microsoft.Kiota.Serialization.Json
dotnet add package Microsoft.Kiota.Serialization.Text
dotnet add package Microsoft.Kiota.Serialization.Multipart
```

```bash
kiota generate -l CSharp -c MarvelClient -n Marvel.Client -d ./Marvel.json -o ./Client
```

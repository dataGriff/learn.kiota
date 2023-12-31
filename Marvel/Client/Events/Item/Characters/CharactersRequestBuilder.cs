// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marvel.Client.Events.Item.Characters {
    /// <summary>
    /// Builds and executes requests for operations under \events\{eventId}\characters
    /// </summary>
    public class CharactersRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new CharactersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CharactersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/events/{eventId}/characters{?name*,nameStartsWith*,modifiedSince*,comics*,series*,stories*,orderBy*,limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CharactersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CharactersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/events/{eventId}/characters{?name*,nameStartsWith*,modifiedSince*,comics*,series*,stories*,orderBy*,limit*,offset*}", rawUrl) {
        }
        /// <summary>
        /// Fetches lists of characters filtered by an event id.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<CharactersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<CharactersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Fetches lists of characters filtered by an event id.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CharactersRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CharactersRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/octet-stream");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public CharactersRequestBuilder WithUrl(string rawUrl) {
            return new CharactersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Fetches lists of characters filtered by an event id.
        /// </summary>
        public class CharactersRequestBuilderGetQueryParameters {
            /// <summary>Return only characters which appear in the specified comics (accepts a comma-separated list of ids).</summary>
            [QueryParameter("comics")]
            public double? Comics { get; set; }
            /// <summary>Limit the result set to the specified number of resources.</summary>
            [QueryParameter("limit")]
            public double? Limit { get; set; }
            /// <summary>Return only characters which have been modified since the specified date.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("modifiedSince")]
            public string? ModifiedSince { get; set; }
#nullable restore
#else
            [QueryParameter("modifiedSince")]
            public string ModifiedSince { get; set; }
#endif
            /// <summary>Return only characters matching the specified full character name (e.g. Spider-Man).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("name")]
            public string? Name { get; set; }
#nullable restore
#else
            [QueryParameter("name")]
            public string Name { get; set; }
#endif
            /// <summary>Return characters with names that begin with the specified string (e.g. Sp).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("nameStartsWith")]
            public string? NameStartsWith { get; set; }
#nullable restore
#else
            [QueryParameter("nameStartsWith")]
            public string NameStartsWith { get; set; }
#endif
            /// <summary>Skip the specified number of resources in the result set.</summary>
            [QueryParameter("offset")]
            public double? Offset { get; set; }
            /// <summary>Order the result set by a field or fields. Add a &quot;-&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("orderBy")]
            public string? OrderBy { get; set; }
#nullable restore
#else
            [QueryParameter("orderBy")]
            public string OrderBy { get; set; }
#endif
            /// <summary>Return only characters which appear the specified series (accepts a comma-separated list of ids).</summary>
            [QueryParameter("series")]
            public double? Series { get; set; }
            /// <summary>Return only characters which appear the specified stories (accepts a comma-separated list of ids).</summary>
            [QueryParameter("stories")]
            public double? Stories { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class CharactersRequestBuilderGetRequestConfiguration : RequestConfiguration<CharactersRequestBuilderGetQueryParameters> {
        }
    }
}
// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marvel.Client.Comics.Item.Stories {
    /// <summary>
    /// Builds and executes requests for operations under \comics\{comicId}\stories
    /// </summary>
    public class StoriesRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new StoriesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StoriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/comics/{comicId}/stories{?modifiedSince*,series*,events*,creators*,characters*,orderBy*,limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new StoriesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StoriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/comics/{comicId}/stories{?modifiedSince*,series*,events*,creators*,characters*,orderBy*,limit*,offset*}", rawUrl) {
        }
        /// <summary>
        /// Fetches lists of stories filtered by a comic id.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<StoriesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<StoriesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Fetches lists of stories filtered by a comic id.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<StoriesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<StoriesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public StoriesRequestBuilder WithUrl(string rawUrl) {
            return new StoriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Fetches lists of stories filtered by a comic id.
        /// </summary>
        public class StoriesRequestBuilderGetQueryParameters {
            /// <summary>Return only stories which feature the specified characters (accepts a comma-separated list of ids).</summary>
            [QueryParameter("characters")]
            public double? Characters { get; set; }
            /// <summary>Return only stories which feature work by the specified creators (accepts a comma-separated list of ids).</summary>
            [QueryParameter("creators")]
            public double? Creators { get; set; }
            /// <summary>Return only stories which take place during the specified events (accepts a comma-separated list of ids).</summary>
            [QueryParameter("events")]
            public double? Events { get; set; }
            /// <summary>Limit the result set to the specified number of resources.</summary>
            [QueryParameter("limit")]
            public double? Limit { get; set; }
            /// <summary>Return only stories which have been modified since the specified date.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("modifiedSince")]
            public string? ModifiedSince { get; set; }
#nullable restore
#else
            [QueryParameter("modifiedSince")]
            public string ModifiedSince { get; set; }
#endif
            /// <summary>Skip the specified number of resources.</summary>
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
            /// <summary>Return only stories contained the specified series (accepts a comma-separated list of ids).</summary>
            [QueryParameter("series")]
            public double? Series { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class StoriesRequestBuilderGetRequestConfiguration : RequestConfiguration<StoriesRequestBuilderGetQueryParameters> {
        }
    }
}

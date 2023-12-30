// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaPosts.Client.V1.Public.Series.Item.Events {
    /// <summary>
    /// Builds and executes requests for operations under \v1\public\series\{seriesId}\events
    /// </summary>
    public class EventsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new EventsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/public/series/{seriesId}/events{?name*,nameStartsWith*,modifiedSince*,creators*,characters*,comics*,stories*,orderBy*,limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new EventsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/public/series/{seriesId}/events{?name*,nameStartsWith*,modifiedSince*,creators*,characters*,comics*,stories*,orderBy*,limit*,offset*}", rawUrl) {
        }
        /// <summary>
        /// Fetches lists of events which occur in a specific series, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<EventsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<EventsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Fetches lists of events which occur in a specific series, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EventsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EventsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public EventsRequestBuilder WithUrl(string rawUrl) {
            return new EventsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Fetches lists of events which occur in a specific series, with optional filters. See notes on individual parameters below.
        /// </summary>
        public class EventsRequestBuilderGetQueryParameters {
            /// <summary>Return only events which feature the specified characters (accepts a comma-separated list of ids).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("characters")]
            public int?[]? Characters { get; set; }
#nullable restore
#else
            [QueryParameter("characters")]
            public int?[] Characters { get; set; }
#endif
            /// <summary>Return only events which take place in the specified comics (accepts a comma-separated list of ids).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("comics")]
            public int?[]? Comics { get; set; }
#nullable restore
#else
            [QueryParameter("comics")]
            public int?[] Comics { get; set; }
#endif
            /// <summary>Return only events which feature work by the specified creators (accepts a comma-separated list of ids).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("creators")]
            public int?[]? Creators { get; set; }
#nullable restore
#else
            [QueryParameter("creators")]
            public int?[] Creators { get; set; }
#endif
            /// <summary>Limit the result set to the specified number of resources.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Return only events which have been modified since the specified date.</summary>
            [QueryParameter("modifiedSince")]
            public Date? ModifiedSince { get; set; }
            /// <summary>Filter the event list by name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("name")]
            public string? Name { get; set; }
#nullable restore
#else
            [QueryParameter("name")]
            public string Name { get; set; }
#endif
            /// <summary>Return events with names that begin with the specified string (e.g. Sp).</summary>
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
            public int? Offset { get; set; }
            /// <summary>Order the result set by a field or fields. Add a &quot;-&quot; to the value sort in descending order. Multiple values are given priority in the order in which they are passed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("orderBy")]
            public string[]? OrderBy { get; set; }
#nullable restore
#else
            [QueryParameter("orderBy")]
            public string[] OrderBy { get; set; }
#endif
            /// <summary>Return only events which contain the specified stories (accepts a comma-separated list of ids).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("stories")]
            public int?[]? Stories { get; set; }
#nullable restore
#else
            [QueryParameter("stories")]
            public int?[] Stories { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class EventsRequestBuilderGetRequestConfiguration : RequestConfiguration<EventsRequestBuilderGetQueryParameters> {
        }
    }
}

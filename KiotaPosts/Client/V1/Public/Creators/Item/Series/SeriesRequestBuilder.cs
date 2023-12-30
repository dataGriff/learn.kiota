// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaPosts.Client.V1.Public.Creators.Item.Series {
    /// <summary>
    /// Builds and executes requests for operations under \v1\public\creators\{creatorId}\series
    /// </summary>
    public class SeriesRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new SeriesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SeriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/public/creators/{creatorId}/series{?title*,titleStartsWith*,startYear*,modifiedSince*,comics*,stories*,events*,characters*,seriesType*,contains*,orderBy*,limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SeriesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SeriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/public/creators/{creatorId}/series{?title*,titleStartsWith*,startYear*,modifiedSince*,comics*,stories*,events*,characters*,seriesType*,contains*,orderBy*,limit*,offset*}", rawUrl) {
        }
        /// <summary>
        /// Fetches lists of comic series in which a specific creator&apos;s work appears, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<SeriesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<SeriesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Fetches lists of comic series in which a specific creator&apos;s work appears, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SeriesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SeriesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public SeriesRequestBuilder WithUrl(string rawUrl) {
            return new SeriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Fetches lists of comic series in which a specific creator&apos;s work appears, with optional filters. See notes on individual parameters below.
        /// </summary>
        public class SeriesRequestBuilderGetQueryParameters {
            /// <summary>Return only series which feature the specified characters (accepts a comma-separated list of ids).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("characters")]
            public int?[]? Characters { get; set; }
#nullable restore
#else
            [QueryParameter("characters")]
            public int?[] Characters { get; set; }
#endif
            /// <summary>Return only series which contain the specified comics (accepts a comma-separated list of ids).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("comics")]
            public int?[]? Comics { get; set; }
#nullable restore
#else
            [QueryParameter("comics")]
            public int?[] Comics { get; set; }
#endif
            /// <summary>Return only series containing one or more comics with the specified format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("contains")]
            public string[]? Contains { get; set; }
#nullable restore
#else
            [QueryParameter("contains")]
            public string[] Contains { get; set; }
#endif
            /// <summary>Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("events")]
            public int?[]? Events { get; set; }
#nullable restore
#else
            [QueryParameter("events")]
            public int?[] Events { get; set; }
#endif
            /// <summary>Limit the result set to the specified number of resources.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Return only series which have been modified since the specified date.</summary>
            [QueryParameter("modifiedSince")]
            public Date? ModifiedSince { get; set; }
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
            /// <summary>Filter the series by publication frequency type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("seriesType")]
            public string? SeriesType { get; set; }
#nullable restore
#else
            [QueryParameter("seriesType")]
            public string SeriesType { get; set; }
#endif
            /// <summary>Return only series matching the specified start year.</summary>
            [QueryParameter("startYear")]
            public int? StartYear { get; set; }
            /// <summary>Return only series which contain the specified stories (accepts a comma-separated list of ids).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("stories")]
            public int?[]? Stories { get; set; }
#nullable restore
#else
            [QueryParameter("stories")]
            public int?[] Stories { get; set; }
#endif
            /// <summary>Filter by series title.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("title")]
            public string? Title { get; set; }
#nullable restore
#else
            [QueryParameter("title")]
            public string Title { get; set; }
#endif
            /// <summary>Return series with titles that begin with the specified string (e.g. Sp).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("titleStartsWith")]
            public string? TitleStartsWith { get; set; }
#nullable restore
#else
            [QueryParameter("titleStartsWith")]
            public string TitleStartsWith { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class SeriesRequestBuilderGetRequestConfiguration : RequestConfiguration<SeriesRequestBuilderGetQueryParameters> {
        }
    }
}
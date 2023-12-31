// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marvel.Client.Events.Item.Comics {
    /// <summary>
    /// Builds and executes requests for operations under \events\{eventId}\comics
    /// </summary>
    public class ComicsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new ComicsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ComicsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/events/{eventId}/comics{?format*,formatType*,noVariants*,dateDescriptor*,dateRange*,diamondCode*,digitalId*,upc*,isbn*,ean*,issn*,hasDigitalIssue*,modifiedSince*,creators*,characters*,series*,events*,stories*,sharedAppearances*,collaborators*,orderBy*,limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ComicsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ComicsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/events/{eventId}/comics{?format*,formatType*,noVariants*,dateDescriptor*,dateRange*,diamondCode*,digitalId*,upc*,isbn*,ean*,issn*,hasDigitalIssue*,modifiedSince*,creators*,characters*,series*,events*,stories*,sharedAppearances*,collaborators*,orderBy*,limit*,offset*}", rawUrl) {
        }
        /// <summary>
        /// Fetches lists of comics filtered by an event id.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<ComicsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<ComicsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Fetches lists of comics filtered by an event id.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ComicsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ComicsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public ComicsRequestBuilder WithUrl(string rawUrl) {
            return new ComicsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Fetches lists of comics filtered by an event id.
        /// </summary>
        public class ComicsRequestBuilderGetQueryParameters {
            /// <summary>Return only comics which feature the specified characters (accepts a comma-separated list of ids).</summary>
            [QueryParameter("characters")]
            public double? Characters { get; set; }
            /// <summary>Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work).</summary>
            [QueryParameter("collaborators")]
            public double? Collaborators { get; set; }
            /// <summary>Return only comics which feature work by the specified creators (accepts a comma-separated list of ids).</summary>
            [QueryParameter("creators")]
            public double? Creators { get; set; }
            /// <summary>Return comics within a predefined date range.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("dateDescriptor")]
            public string? DateDescriptor { get; set; }
#nullable restore
#else
            [QueryParameter("dateDescriptor")]
            public string DateDescriptor { get; set; }
#endif
            /// <summary>Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format.</summary>
            [QueryParameter("dateRange")]
            public double? DateRange { get; set; }
            /// <summary>Filter by diamond code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("diamondCode")]
            public string? DiamondCode { get; set; }
#nullable restore
#else
            [QueryParameter("diamondCode")]
            public string DiamondCode { get; set; }
#endif
            /// <summary>Filter by digital comic id.</summary>
            [QueryParameter("digitalId")]
            public double? DigitalId { get; set; }
            /// <summary>Filter by EAN.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ean")]
            public string? Ean { get; set; }
#nullable restore
#else
            [QueryParameter("ean")]
            public string Ean { get; set; }
#endif
            /// <summary>Return only comics which take place in the specified events (accepts a comma-separated list of ids).</summary>
            [QueryParameter("events")]
            public double? Events { get; set; }
            /// <summary>Filter by the issue format (e.g. comic, digital comic, hardcover).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("format")]
            public string? Format { get; set; }
#nullable restore
#else
            [QueryParameter("format")]
            public string Format { get; set; }
#endif
            /// <summary>Filter by the issue format type (comic or collection).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("formatType")]
            public string? FormatType { get; set; }
#nullable restore
#else
            [QueryParameter("formatType")]
            public string FormatType { get; set; }
#endif
            /// <summary>Include only results which are available digitally.</summary>
            [QueryParameter("hasDigitalIssue")]
            public bool? HasDigitalIssue { get; set; }
            /// <summary>Filter by ISBN.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("isbn")]
            public string? Isbn { get; set; }
#nullable restore
#else
            [QueryParameter("isbn")]
            public string Isbn { get; set; }
#endif
            /// <summary>Filter by ISSN.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("issn")]
            public string? Issn { get; set; }
#nullable restore
#else
            [QueryParameter("issn")]
            public string Issn { get; set; }
#endif
            /// <summary>Limit the result set to the specified number of resources.</summary>
            [QueryParameter("limit")]
            public double? Limit { get; set; }
            /// <summary>Return only comics which have been modified since the specified date.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("modifiedSince")]
            public string? ModifiedSince { get; set; }
#nullable restore
#else
            [QueryParameter("modifiedSince")]
            public string ModifiedSince { get; set; }
#endif
            /// <summary>Exclude variant comics from the result set.</summary>
            [QueryParameter("noVariants")]
            public bool? NoVariants { get; set; }
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
            /// <summary>Return only comics which are part of the specified series (accepts a comma-separated list of ids).</summary>
            [QueryParameter("series")]
            public double? Series { get; set; }
            /// <summary>Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear).</summary>
            [QueryParameter("sharedAppearances")]
            public double? SharedAppearances { get; set; }
            /// <summary>Return only comics which contain the specified stories (accepts a comma-separated list of ids).</summary>
            [QueryParameter("stories")]
            public double? Stories { get; set; }
            /// <summary>Filter by UPC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("upc")]
            public string? Upc { get; set; }
#nullable restore
#else
            [QueryParameter("upc")]
            public string Upc { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ComicsRequestBuilderGetRequestConfiguration : RequestConfiguration<ComicsRequestBuilderGetQueryParameters> {
        }
    }
}

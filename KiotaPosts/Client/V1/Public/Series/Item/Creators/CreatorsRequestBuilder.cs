// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaPosts.Client.V1.Public.Series.Item.Creators {
    /// <summary>
    /// Builds and executes requests for operations under \v1\public\series\{seriesId}\creators
    /// </summary>
    public class CreatorsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new CreatorsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CreatorsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/public/series/{seriesId}/creators{?firstName*,middleName*,lastName*,suffix*,nameStartsWith*,firstNameStartsWith*,middleNameStartsWith*,lastNameStartsWith*,modifiedSince*,comics*,events*,stories*,orderBy*,limit*,offset*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CreatorsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CreatorsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/public/series/{seriesId}/creators{?firstName*,middleName*,lastName*,suffix*,nameStartsWith*,firstNameStartsWith*,middleNameStartsWith*,lastNameStartsWith*,modifiedSince*,comics*,events*,stories*,orderBy*,limit*,offset*}", rawUrl) {
        }
        /// <summary>
        /// Fetches lists of comic creators whose work appears in a specific series, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<CreatorsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<CreatorsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Fetches lists of comic creators whose work appears in a specific series, with optional filters. See notes on individual parameters below.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CreatorsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<CreatorsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public CreatorsRequestBuilder WithUrl(string rawUrl) {
            return new CreatorsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Fetches lists of comic creators whose work appears in a specific series, with optional filters. See notes on individual parameters below.
        /// </summary>
        public class CreatorsRequestBuilderGetQueryParameters {
            /// <summary>Return only creators who worked on in the specified comics (accepts a comma-separated list of ids).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("comics")]
            public int?[]? Comics { get; set; }
#nullable restore
#else
            [QueryParameter("comics")]
            public int?[] Comics { get; set; }
#endif
            /// <summary>Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("events")]
            public int?[]? Events { get; set; }
#nullable restore
#else
            [QueryParameter("events")]
            public int?[] Events { get; set; }
#endif
            /// <summary>Filter by creator first name (e.g. brian).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("firstName")]
            public string? FirstName { get; set; }
#nullable restore
#else
            [QueryParameter("firstName")]
            public string FirstName { get; set; }
#endif
            /// <summary>Filter by creator first names that match critera (e.g. B, St L).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("firstNameStartsWith")]
            public string? FirstNameStartsWith { get; set; }
#nullable restore
#else
            [QueryParameter("firstNameStartsWith")]
            public string FirstNameStartsWith { get; set; }
#endif
            /// <summary>Filter by creator last name (e.g. Bendis).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("lastName")]
            public string? LastName { get; set; }
#nullable restore
#else
            [QueryParameter("lastName")]
            public string LastName { get; set; }
#endif
            /// <summary>Filter by creator last names that match critera (e.g. Ben).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("lastNameStartsWith")]
            public string? LastNameStartsWith { get; set; }
#nullable restore
#else
            [QueryParameter("lastNameStartsWith")]
            public string LastNameStartsWith { get; set; }
#endif
            /// <summary>Limit the result set to the specified number of resources.</summary>
            [QueryParameter("limit")]
            public int? Limit { get; set; }
            /// <summary>Filter by creator middle name (e.g. Michael).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("middleName")]
            public string? MiddleName { get; set; }
#nullable restore
#else
            [QueryParameter("middleName")]
            public string MiddleName { get; set; }
#endif
            /// <summary>Filter by creator middle names that match critera (e.g. Mi).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("middleNameStartsWith")]
            public string? MiddleNameStartsWith { get; set; }
#nullable restore
#else
            [QueryParameter("middleNameStartsWith")]
            public string MiddleNameStartsWith { get; set; }
#endif
            /// <summary>Return only creators which have been modified since the specified date.</summary>
            [QueryParameter("modifiedSince")]
            public Date? ModifiedSince { get; set; }
            /// <summary>Filter by creator names that match critera (e.g. B, St L).</summary>
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
            /// <summary>Return only creators who worked on the specified stories (accepts a comma-separated list of ids).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("stories")]
            public int?[]? Stories { get; set; }
#nullable restore
#else
            [QueryParameter("stories")]
            public int?[] Stories { get; set; }
#endif
            /// <summary>Filter by suffix or honorific (e.g. Jr., Sr.).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("suffix")]
            public string? Suffix { get; set; }
#nullable restore
#else
            [QueryParameter("suffix")]
            public string Suffix { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class CreatorsRequestBuilderGetRequestConfiguration : RequestConfiguration<CreatorsRequestBuilderGetQueryParameters> {
        }
    }
}

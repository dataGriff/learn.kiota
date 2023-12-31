// <auto-generated/>
using KiotaPosts.Client.V1.Public.Events.Item.Characters;
using KiotaPosts.Client.V1.Public.Events.Item.Comics;
using KiotaPosts.Client.V1.Public.Events.Item.Creators;
using KiotaPosts.Client.V1.Public.Events.Item.Series;
using KiotaPosts.Client.V1.Public.Events.Item.Stories;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaPosts.Client.V1.Public.Events.Item {
    /// <summary>
    /// Builds and executes requests for operations under \v1\public\events\{eventId}
    /// </summary>
    public class WithEventItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The characters property</summary>
        public CharactersRequestBuilder Characters { get =>
            new CharactersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The comics property</summary>
        public ComicsRequestBuilder Comics { get =>
            new ComicsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The creators property</summary>
        public CreatorsRequestBuilder Creators { get =>
            new CreatorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The series property</summary>
        public SeriesRequestBuilder Series { get =>
            new SeriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The stories property</summary>
        public StoriesRequestBuilder Stories { get =>
            new StoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithEventItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEventItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/public/events/{eventId}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithEventItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEventItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/public/events/{eventId}", rawUrl) {
        }
        /// <summary>
        /// This method fetches a single event resource.  It is the canonical URI for any event resource provided by the API.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This method fetches a single event resource.  It is the canonical URI for any event resource provided by the API.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        public WithEventItemRequestBuilder WithUrl(string rawUrl) {
            return new WithEventItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithEventItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}

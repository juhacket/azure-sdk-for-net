// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// RecommendationsOperations operations.
    /// </summary>
    public partial interface IRecommendationsOperations
    {
        /// <summary>
        /// Gets a list of recommendations associated with the specified
        /// subscription.
        /// </summary>
        /// Gets a list of recommendations associated with the specified
        /// subscription.
        /// <param name='featured'>
        /// If set, this API returns only the most critical recommendation
        /// among the others. Otherwise this API returns all recommendations
        /// available
        /// </param>
        /// <param name='filter'>
        /// Return only channels specified in the filter. Filter is specified
        /// by using OData syntax. Example: $filter=channels eq 'Api' or
        /// channel eq 'Notification'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IList<Recommendation>>> GetWithHttpMessagesAsync(bool? featured = default(bool?), string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of past recommendations optionally specified by the
        /// time range.
        /// </summary>
        /// Gets the list of past recommendations optionally specified by the
        /// time range.
        /// <param name='resourceGroupName'>
        /// Resource group name
        /// </param>
        /// <param name='siteName'>
        /// Site name
        /// </param>
        /// <param name='startTime'>
        /// The start time of a time range to query, e.g. $filter=startTime eq
        /// '2015-01-01T00:00:00Z' and endTime eq '2015-01-02T00:00:00Z'
        /// </param>
        /// <param name='endTime'>
        /// The end time of a time range to query, e.g. $filter=startTime eq
        /// '2015-01-01T00:00:00Z' and endTime eq '2015-01-02T00:00:00Z'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IList<Recommendation>>> ListHistoryForWebAppWithHttpMessagesAsync(string resourceGroupName, string siteName, string startTime = default(string), string endTime = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of recommendations associated with the specified web
        /// site.
        /// </summary>
        /// Gets a list of recommendations associated with the specified web
        /// site.
        /// <param name='resourceGroupName'>
        /// Resource group name
        /// </param>
        /// <param name='siteName'>
        /// Site name
        /// </param>
        /// <param name='featured'>
        /// If set, this API returns only the most critical recommendation
        /// among the others. Otherwise this API returns all recommendations
        /// available
        /// </param>
        /// <param name='webAppSku'>
        /// The name of web app SKU.
        /// </param>
        /// <param name='numSlots'>
        /// The number of site slots associated to the site
        /// </param>
        /// <param name='liveHours'>
        /// If greater than zero, this API scans the last active live site
        /// symptoms, dynamically generate on-the-fly recommendations
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IList<Recommendation>>> ListRecommendedRulesForWebAppWithHttpMessagesAsync(string resourceGroupName, string siteName, bool? featured = default(bool?), string webAppSku = default(string), int? numSlots = default(int?), int? liveHours = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the detailed properties of the recommendation object for the
        /// specified web site.
        /// </summary>
        /// Gets the detailed properties of the recommendation object for the
        /// specified web site.
        /// <param name='resourceGroupName'>
        /// Resource group name
        /// </param>
        /// <param name='siteName'>
        /// Name of web app
        /// </param>
        /// <param name='name'>
        /// Recommendation rule name
        /// </param>
        /// <param name='updateSeen'>
        /// If true, the backend updates the last seen timestamp of the
        /// recommendation object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<RecommendationRule>> GetRuleDetailsByWebAppWithHttpMessagesAsync(string resourceGroupName, string siteName, string name, bool? updateSeen = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
// <copyright>
// Copyright 2019 by Luther Pierce Hendon, III
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System.Collections.Generic;
using ClearstreamDotNetFramework.v1.Model.Object;
using ClearstreamDotNetFramework.v1.Model.Response;
using RestSharp;
using static ClearstreamDotNetFramework.Enum;

namespace ClearstreamDotNetFramework.v1
{
    public partial class Client
    {
        /// <summary>
        /// Gets the keywords. https://api-docs.clearstream.io/#view-all-keywords
        /// </summary>
        /// <param name="limit">The limit.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public KeywordsResponse GetKeywords( int? limit = null, int? page = null )
        {
            var request = new RestRequest( "keywords" );
            request.Method = Method.GET;

            if ( limit.HasValue )
            {
                request.AddParameter( "limit", limit, ParameterType.GetOrPost );
            }

            if ( page.HasValue )
            {
                request.AddParameter( "page", page, ParameterType.GetOrPost );
            }

            return Execute<KeywordsResponse>( request );
        }

        /// <summary>
        /// Gets all keywords.
        /// </summary>
        /// <returns></returns>
        public List<Keyword> GetAllKeywords()
        {
            var keywords = new List<Keyword>();
            var response = GetKeywords();

            if ( response != null && response.Count > 0 )
            {
                keywords.AddRange( response.Data );

                if ( response.Pages > 1 )
                {
                    var limit = response.Limit;
                    var page = response.CurrentPage;
                    var totalPages = response.Total;

                    while ( page <= totalPages )
                    {
                        page++;
                        response = GetKeywords( limit, page );
                        keywords.AddRange( response.Data );
                    }
                }
            }

            return keywords;
        }

        /// <summary>
        /// Gets the keyword. https://api-docs.clearstream.io/#view-a-keyword
        /// </summary>
        /// <param name="keywordName">Name of the keyword.</param>
        /// <returns></returns>
        public KeywordResponse GetKeyword( string keywordName )
        {
            var request = new RestRequest( $"keywords/{keywordName}" );
            request.Method = Method.GET;

            return Execute<KeywordResponse>( request );
        }

        /// <summary>
        /// Creates the keyword. https://api-docs.clearstream.io/#create-a-keyword
        /// </summary>
        /// <param name="keywordName">Name of the keyword.</param>
        /// <param name="enableOptIn">The enable opt in.</param>
        /// <param name="optInLists">The opt in lists.</param>
        /// <param name="enableAutoResponse">The enable automatic response.</param>
        /// <param name="autoresponseHeader">The autoresponse header.</param>
        /// <param name="autoresponseBody">The autoresponse body.</param>
        /// <param name="autoresponseSetting">The autoresponse setting.</param>
        /// <returns></returns>
        public KeywordResponse CreateKeyword( string keywordName, bool? enableOptIn = null, List<int> optInLists = null, bool? enableAutoResponse = null, string autoresponseHeader = null, string autoresponseBody = null, AutoresponseSetting autoresponseSetting = AutoresponseSetting.ALWAYS )
        {
            var request = new RestRequest( "keywords" );
            request.Method = Method.POST;

            request.AddParameter( "name", keywordName, ParameterType.GetOrPost );

            if ( enableOptIn.HasValue && optInLists != null && optInLists.Count > 0 )
            {
                int enableOptInInt = enableOptIn.Value ? 1 : 0;
                request.AddParameter( "enable_opt_in", enableOptInInt );
                request.AddParameter( "opt_in_lists", string.Join( ",", optInLists.ToArray() ), ParameterType.GetOrPost );
            }

            if ( enableAutoResponse.HasValue && enableAutoResponse.Value && ( !string.IsNullOrWhiteSpace( autoresponseHeader ) || !string.IsNullOrWhiteSpace( autoresponseBody ) ) )
            {
                int enableAutoResponseInt = enableAutoResponse.Value ? 1 : 0;
                request.AddParameter( "enable_autoresponse", enableAutoResponseInt );
                request.AddParameter( "autoresponse_header", autoresponseHeader ?? string.Empty, ParameterType.GetOrPost );
                request.AddParameter( "autoresponse_body", autoresponseBody ?? string.Empty, ParameterType.GetOrPost );
                request.AddParameter( "autoresponse_setting", autoresponseSetting.ToString() );
            }

            return Execute<KeywordResponse>( request );
        }

        /// <summary>
        /// Updates the keyword. https://api-docs.clearstream.io/#update-a-keyword
        /// </summary>
        /// <param name="keywordName">Name of the keyword.</param>
        /// <param name="enableOptIn">The enable opt in.</param>
        /// <param name="optInLists">The opt in lists.</param>
        /// <param name="enableAutoResponse">The enable automatic response.</param>
        /// <param name="autoresponseHeader">The autoresponse header.</param>
        /// <param name="autoresponseBody">The autoresponse body.</param>
        /// <param name="autoresponseSetting">The autoresponse setting.</param>
        /// <returns></returns>
        public KeywordResponse UpdateKeyword( string keywordName, bool? enableOptIn = null, List<int> optInLists = null, bool? enableAutoResponse = null, string autoresponseHeader = null, string autoresponseBody = null, AutoresponseSetting autoresponseSetting = AutoresponseSetting.ALWAYS )
        {
            var request = new RestRequest( $"keywords/{keywordName}" );
            request.Method = Method.PATCH;

            if ( enableOptIn.HasValue && optInLists != null && optInLists.Count > 0 )
            {
                int enableOptInInt = enableOptIn.Value ? 1 : 0;
                request.AddParameter( "enable_opt_in", enableOptInInt, ParameterType.GetOrPost );
                request.AddParameter( "opt_in_lists", string.Join( ",", optInLists.ToArray() ), ParameterType.GetOrPost );
            }

            if ( enableAutoResponse.HasValue && enableAutoResponse.Value && ( !string.IsNullOrWhiteSpace( autoresponseHeader ) || !string.IsNullOrWhiteSpace( autoresponseBody ) ) )
            {
                int enableAutoResponseInt = enableAutoResponse.Value ? 1 : 0;
                request.AddParameter( "enable_autoresponse", enableAutoResponseInt, ParameterType.GetOrPost );
                request.AddParameter( "autoresponse_header", autoresponseHeader ?? string.Empty, ParameterType.GetOrPost );
                request.AddParameter( "autoresponse_body", autoresponseBody ?? string.Empty, ParameterType.GetOrPost );
                request.AddParameter( "autoresponse_setting", autoresponseSetting.ToString(), ParameterType.GetOrPost );
            }

            return Execute<KeywordResponse>( request );
        }

        /// <summary>
        /// Deletes the keyword. https://api-docs.clearstream.io/#delete-a-keyword
        /// </summary>
        /// <param name="keywordName">Name of the keyword.</param>
        /// <returns></returns>
        public KeywordResponse DeleteKeyword( string keywordName )
        {
            var request = new RestRequest( $"keywords/{keywordName}" );
            request.Method = Method.DELETE;

            return Execute<KeywordResponse>( request );
        }
    }
}

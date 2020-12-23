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
        /// Gets the subscribers. https://api-docs.clearstream.io/#view-all-subscribers
        /// </summary>
        /// <param name="limit">The limit.</param>
        /// <param name="page">The page.</param>
        /// <param name="firstName">The first name to search for.</param>
        /// <param name="lastName">The last name to search for.</param>
        /// <param name="mobileNumber">The mobile number to search for.</param>
        /// <param name="searchOperator">The search operator to use if multiple search params are provided.</param>
        /// <returns></returns>
        public SubscribersResponse GetSubscribers( int? limit = null, int? page = null, string firstName = null, string lastName = null, string mobileNumber = null, SearchOperator searchOperator = SearchOperator.AND, SubscriberStatus status = SubscriberStatus.ACTIVE )
        {
            var request = new RestRequest( "subscribers" );
            request.Method = Method.GET;

            if ( limit.HasValue )
            {
                request.AddParameter( "limit", limit, ParameterType.GetOrPost );
            }

            if ( page.HasValue )
            {
                request.AddParameter( "page", page, ParameterType.GetOrPost );
            }

            var searchParams = 0;

            if ( !string.IsNullOrWhiteSpace( firstName ) )
            {
                request.AddParameter( "first", firstName, ParameterType.GetOrPost );
                searchParams = searchParams + 1;
            }

            if ( !string.IsNullOrWhiteSpace( lastName ) )
            {
                request.AddParameter( "last", lastName, ParameterType.GetOrPost );
                searchParams = searchParams + 1;
            }

            if ( !string.IsNullOrWhiteSpace( mobileNumber ) )
            {
                request.AddParameter( "mobile_number", mobileNumber, ParameterType.GetOrPost );
                searchParams = searchParams + 1;
            }

            request.AddParameter( "status", status.ToString(), ParameterType.GetOrPost );
            searchParams = searchParams + 1;

            if ( searchParams > 1 )
            {
                request.AddParameter( "operator", searchOperator.ToString(), ParameterType.GetOrPost );
            }

            return Execute<SubscribersResponse>( request );
        }

        /// <summary>
        /// Gets all subscribers.
        /// </summary>
        /// <param name="firstName">The first name to search for.</param>
        /// <param name="lastName">The last name to search for.</param>
        /// <param name="mobileNumber">The mobile number to search for.</param>
        /// <param name="searchOperator">The search operator to use if multiple search params are provided.</param>
        /// <returns></returns>
        public List<Subscriber> GetAllSubscribers( string firstName = null, string lastName = null, string mobileNumber = null, SearchOperator searchOperator = SearchOperator.AND )
        {
            var subscribers = new List<Subscriber>();
            var response = GetSubscribers( firstName: firstName, lastName: lastName, mobileNumber: mobileNumber, searchOperator: searchOperator );

            if ( response != null && response.Count > 0 )
            {
                subscribers.AddRange( response.Data );

                if ( response.Pages > 1 )
                {
                    var limit = response.Limit;
                    var page = response.CurrentPage;
                    var totalPages = response.Total;

                    while ( page <= totalPages )
                    {
                        page++;
                        response = GetSubscribers( limit, page, firstName, lastName, mobileNumber, searchOperator );
                        subscribers.AddRange( response.Data );
                    }
                }
            }

            return subscribers;
        }

        /// <summary>
        /// Gets the subscriber. https://api-docs.clearstream.io/#view-a-subscriber
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public SubscriberResponse GetSubscriber( int id )
        {
            var request = new RestRequest( $"subscribers/{id}" );
            request.Method = Method.GET;

            return Execute<SubscriberResponse>( request );
        }

        /// <summary>
        /// Creates the subscriber. https://api-docs.clearstream.io/#create-a-subscriber
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <param name="lists">The lists.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="email">The email address.</param>
        /// <param name="autoresponseHeader">The autoresponse header.</param>
        /// <param name="autoresponseBody">The autoresponse body.</param>
        /// <returns></returns>
        public SubscriberResponse CreateSubscriber( string mobileNumber, List<int> lists, string firstName = null, string lastName = null, string email = null, string autoresponseHeader = null, string autoresponseBody = null )
        {
            var request = new RestRequest( "subscribers" );
            request.Method = Method.POST;

            request.AddParameter( "mobile_number", mobileNumber, ParameterType.GetOrPost );
            request.AddParameter( "lists", string.Join( ",", lists.ToArray() ), ParameterType.GetOrPost );

            if ( !string.IsNullOrWhiteSpace( firstName ) )
            {
                request.AddParameter( "first", firstName, ParameterType.GetOrPost );
            }

            if ( !string.IsNullOrWhiteSpace( lastName ) )
            {
                request.AddParameter( "last", lastName, ParameterType.GetOrPost );
            }

            if ( !string.IsNullOrWhiteSpace( email ) )
            {
                request.AddParameter( "email", email, ParameterType.GetOrPost );
            }

            if ( !string.IsNullOrWhiteSpace( autoresponseHeader ) || !string.IsNullOrWhiteSpace( autoresponseBody ) )
            {
                request.AddParameter( "autoresponse_header", autoresponseHeader ?? string.Empty, ParameterType.GetOrPost );
                request.AddParameter( "autoresponse_body", autoresponseBody ?? string.Empty, ParameterType.GetOrPost );
            }

            return Execute<SubscriberResponse>( request );
        }

        /// <summary>
        /// Updates the subscriber. https://api-docs.clearstream.io/#update-a-subscriber
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public SubscriberResponse UpdateSubscriber( string mobileNumber, string firstName = null, string lastName = null, string email = null )
        {
            var request = new RestRequest( $"subscribers/{mobileNumber}" );
            request.Method = Method.PATCH;

            if ( !string.IsNullOrWhiteSpace( firstName ) )
            {
                request.AddParameter( "first", firstName, ParameterType.GetOrPost );
            }

            if ( !string.IsNullOrWhiteSpace( lastName ) )
            {
                request.AddParameter( "last", lastName, ParameterType.GetOrPost );
            }

            if ( !string.IsNullOrWhiteSpace( email ) )
            {
                request.AddParameter( "email", email, ParameterType.GetOrPost );
            }

            return Execute<SubscriberResponse>( request );
        }

        /// <summary>
        /// Deletes the subscriber. https://api-docs.clearstream.io/#delete-a-subscriber
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <returns></returns>
        public SubscriberResponse DeleteSubscriber( string mobileNumber )
        {
            var request = new RestRequest( $"subscribers/{mobileNumber}" );
            request.Method = Method.DELETE;

            return Execute<SubscriberResponse>( request );
        }
    }
}

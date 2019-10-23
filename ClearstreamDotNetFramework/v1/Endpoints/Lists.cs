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

using ClearstreamDotNetFramework.v1.Model.Response;
using RestSharp;
using static ClearstreamDotNetFramework.Enum;

namespace ClearstreamDotNetFramework.v1
{
    public partial class Client
    {
        /// <summary>
        /// Gets the lists. https://api-docs.clearstream.io/#view-all-lists
        /// </summary>
        /// <param name="limit">The limit.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public ListsResponse GetLists( int? limit = null, int? page = null )
        {
            var request = new RestRequest( "lists" );
            request.Method = Method.GET;

            if ( limit.HasValue )
            {
                request.AddParameter( "limit", limit, ParameterType.GetOrPost );
            }

            if ( page.HasValue )
            {
                request.AddParameter( "page", page, ParameterType.GetOrPost );
            }

            return Execute<ListsResponse>( request );
        }

        /// <summary>
        /// Gets the list. https://api-docs.clearstream.io/#view-a-list
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public ListResponse GetList( int id )
        {
            var request = new RestRequest( $"lists/{id}" );
            request.Method = Method.GET;

            return Execute<ListResponse>( request );
        }

        /// <summary>
        /// Creates the list. https://api-docs.clearstream.io/#create-a-list
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public ListResponse CreateList( string name )
        {
            var request = new RestRequest( "lists" );
            request.Method = Method.POST;

            request.AddParameter( "name", name, ParameterType.GetOrPost );

            return Execute<ListResponse>( request );
        }

        /// <summary>
        /// Updates the list. https://api-docs.clearstream.io/#update-a-list
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public ListResponse UpdateList( int id, string name )
        {
            var request = new RestRequest( $"lists/{id}" );
            request.Method = Method.PATCH;

            request.AddParameter( "name", name, ParameterType.GetOrPost );

            return Execute<ListResponse>( request );
        }

        /// <summary>
        /// Deletes the list. https://api-docs.clearstream.io/#delete-a-list
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="forceDelete">if set to <c>true</c> [force delete].</param>
        /// <returns></returns>
        public ListResponse DeleteList( int id, bool forceDelete = false )
        {
            var request = new RestRequest( $"lists/{id}" );
            request.Method = Method.DELETE;

            int forceDeleteInt = forceDelete ? 1 : 0;
            request.AddParameter( "force_delete", forceDeleteInt );

            return Execute<ListResponse>( request );
        }

        /// <summary>
        /// Gets the list subscribers.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="limit">The limit.</param>
        /// <param name="page">The page.</param>
        /// <param name="firstName">The first name to search for in the list.</param>
        /// <param name="lastName">The last name to search for in the list.</param>
        /// <param name="mobileNumber">The mobile number to search for in the list.</param>
        /// <param name="searchOperator">The search operator to use if multiple search params are provided.</param>
        /// <returns></returns>
        public ListResponse GetListSubscribers( int id, int? limit = null, int? page = null, string firstName = null, string lastName = null, string mobileNumber = null, SearchOperator searchOperator = SearchOperator.AND )
        {
            var request = new RestRequest( $"lists/{id}/subscribers" );
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

            if ( !string.IsNullOrWhiteSpace( firstName) )
            {
                request.AddParameter( "first", firstName, ParameterType.GetOrPost );
                searchParams = searchParams + 1;
            }

            if ( !string.IsNullOrWhiteSpace( lastName) )
            {
                request.AddParameter( "last", lastName, ParameterType.GetOrPost );
                searchParams = searchParams + 1;
            }

            if ( !string.IsNullOrWhiteSpace( mobileNumber) )
            {
                request.AddParameter( "mobile_number", mobileNumber, ParameterType.GetOrPost );
                searchParams = searchParams + 1;
            }

            if ( searchParams > 1)
            {
                request.AddParameter( "operator", searchOperator.ToString(), ParameterType.GetOrPost );
            }

            return Execute<ListResponse>( request );
        }
    }
}

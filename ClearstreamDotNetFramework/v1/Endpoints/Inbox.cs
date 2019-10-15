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

namespace ClearstreamDotNetFramework.v1
{
    public partial class Client
    {
        /// <summary>
        /// Gets all threads. https://api-docs.clearstream.io/#view-all-threads
        /// </summary>
        /// <param name="limit">The limit.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public ThreadsResponse GetAllThreads( int? limit = null, int? page = null )
        {
            var request = new RestRequest( "threads" );
            request.Method = Method.GET;

            if ( limit.HasValue )
            {
                request.AddParameter( "limit", limit, ParameterType.GetOrPost );
            }

            if ( page.HasValue )
            {
                request.AddParameter( "page", page, ParameterType.GetOrPost );
            }

            return Execute<ThreadsResponse>( request );
        }

        /// <summary>
        /// Gets the thread. https://api-docs.clearstream.io/#view-a-thread
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public ThreadResponse GetThread( int id )
        {
            var request = new RestRequest( $"threads/{id}" );
            request.Method = Method.GET;

            return Execute<ThreadResponse>( request );
        }

        /// <summary>
        /// Gets the thread replies. https://api-docs.clearstream.io/#view-a-thread-39-s-replies
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public RepliesResponse GetThreadReplies( int id )
        {
            var request = new RestRequest( $"threads/{id}/replies" );
            request.Method = Method.GET;

            return Execute<RepliesResponse>( request );
        }

        /// <summary>
        /// Sends the reply. https://api-docs.clearstream.io/#send-a-reply
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="replyText">The reply text.</param>
        /// <returns></returns>
        public ReplyResponse SendReply( int id, string replyText )
        {
            var request = new RestRequest( $"threads/{id}/replies" );
            request.Method = Method.GET;

            request.AddParameter( "text", replyText, ParameterType.GetOrPost );

            return Execute<ReplyResponse>( request );
        }

        /// <summary>
        /// Deletes the thread.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public ThreadResponse DeleteThread( int id )
        {
            var request = new RestRequest( $"threads/{id}" );
            request.Method = Method.DELETE;

            return Execute<ThreadResponse>( request );
        }
    }
}

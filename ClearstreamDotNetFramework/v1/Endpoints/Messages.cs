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

using System;
using System.Collections.Generic;
using ClearstreamDotNetFramework.v1.Model.Response;
using RestSharp;

namespace ClearstreamDotNetFramework.v1
{
    public partial class Client
    {
        /// <summary>
        /// Gets all messages. https://api-docs.clearstream.io/#view-all-messages
        /// </summary>
        /// <param name="limit">The limit.</param>
        /// <param name="page">The page.</param>
        /// <returns></returns>
        public MessagesResponse GetAllMessages( int? limit = null, int? page = null )
        {
            var request = new RestRequest( "messages" );
            request.Method = Method.GET;

            if ( limit.HasValue )
            {
                request.AddParameter( "limit", limit, ParameterType.GetOrPost );
            }

            if ( page.HasValue )
            {
                request.AddParameter( "page", page, ParameterType.GetOrPost );
            }

            return Execute<MessagesResponse>( request );
        }

        /// <summary>
        /// Gets the message. https://api-docs.clearstream.io/#view-a-message
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public MessageResponse GetMessage( int id )
        {
            var request = new RestRequest( $"messages/{id}" );
            request.Method = Method.GET;

            return Execute<MessageResponse>( request );
        }

        /// <summary>
        /// Sends the message. https://api-docs.clearstream.io/#send-schedule-a-message
        /// </summary>
        /// <param name="messageHeader">The message header.</param>
        /// <param name="messageBody">The message body.</param>
        /// <param name="lists">The lists.</param>
        /// <param name="subscribers">The subscribers.</param>
        /// <param name="isScheduled">The is scheduled.</param>
        /// <param name="sendDateTime">The send date time.</param>
        /// <param name="timezone">The timezone.</param>
        /// <param name="sendToFacebook">The send to facebook.</param>
        /// <param name="sendToTwitter">The send to twitter.</param>
        /// <returns></returns>
        public MessageResponse SendMessage( string messageHeader, string messageBody, List<int> lists = null, List<string> subscribers = null, bool? isScheduled = null, DateTime? sendDateTime = null, string timezone = null, bool? sendToFacebook = null, bool? sendToTwitter = null )
        {
            var request = new RestRequest( "messages" );
            request.Method = Method.POST;

            request.AddParameter( "message_header", messageHeader, ParameterType.GetOrPost );
            request.AddParameter( "message_body", messageBody, ParameterType.GetOrPost );

            if ( lists != null && lists.Count > 0 )
            {
                request.AddParameter( "lists", string.Join( ",", lists.ToArray() ), ParameterType.GetOrPost );
            }
            else if ( subscribers != null && subscribers.Count > 0 )
            {
                request.AddParameter( "subscribers", string.Join( ",", subscribers.ToArray() ), ParameterType.GetOrPost );
            }

            if ( isScheduled.HasValue && sendDateTime.HasValue && !string.IsNullOrWhiteSpace(timezone) )
            {
                int isScheduledInt = isScheduled.Value ? 1 : 0;
                request.AddParameter( "schedule", isScheduledInt, ParameterType.GetOrPost );
                request.AddParameter( "datetime", sendDateTime.Value.ToString( "yyyy-MM-dd HH:mm:ss" ), ParameterType.GetOrPost );
                request.AddParameter( "timezone", timezone, ParameterType.GetOrPost );
            }

            if (sendToFacebook.HasValue)
            {
                int sendToFacebookInt = sendToFacebook.Value ? 1 : 0;
                request.AddParameter( "send_to_fb", sendToFacebookInt, ParameterType.GetOrPost );
            }

            if ( sendToTwitter.HasValue )
            {
                int sendToTwitterInt = sendToTwitter.Value ? 1 : 0;
                request.AddParameter( "send_to_tw", sendToTwitterInt, ParameterType.GetOrPost );
            }

            return Execute<MessageResponse>( request );
        }

        /// <summary>
        /// Deletes the message. https://api-docs.clearstream.io/#delete-a-scheduled-message
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public MessageResponse DeleteMessage( int id )
        {
            var request = new RestRequest( $"messages/{id}" );
            request.Method = Method.DELETE;

            return Execute<MessageResponse>( request );
        }
    }
}

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
        /// Gets all users. https://api-docs.clearstream.io/#view-all-users
        /// </summary>
        /// <returns></returns>
        public UsersResponse GetAllUsers()
        {
            var request = new RestRequest( "users" );
            request.Method = Method.GET;

            return Execute<UsersResponse>( request );
        }

        /// <summary>
        /// Gets the user. https://api-docs.clearstream.io/#view-a-user
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// <returns></returns>
        public UserResponse GetUser( string emailAddress )
        {
            var request = new RestRequest( $"users/{emailAddress}" );
            request.Method = Method.GET;

            return Execute<UserResponse>( request );
        }
    }
}

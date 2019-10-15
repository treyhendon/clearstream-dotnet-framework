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
        /// Gets the account. https://api-docs.clearstream.io/#view-account
        /// </summary>
        /// <param name="timezone">The timezone.</param>
        /// <returns></returns>
        public AccountResponse GetAccount( string timezone = null )
        {
            var request = new RestRequest( "account" );
            request.Method = Method.GET;

            if ( !string.IsNullOrWhiteSpace( timezone ) )
            {
                request.AddParameter( "timezone", timezone, ParameterType.GetOrPost );
            }

            return Execute<AccountResponse>( request );
        }

        /// <summary>
        /// Updates the account. https://api-docs.clearstream.io/#update-account
        /// </summary>
        /// <param name="newBusinessName">New name of the business.</param>
        /// <param name="newPhoneNumber">The new phone number.</param>
        /// <param name="collectEmailsFlag">The collect emails flag.</param>
        /// <returns></returns>
        public AccountResponse UpdateAccount( string newBusinessName = null, string newPhoneNumber = null, bool? collectEmailsFlag = null )
        {
            var request = new RestRequest( "account" );
            request.Method = Method.PATCH;

            if ( !string.IsNullOrWhiteSpace( newBusinessName ) )
            {
                request.AddParameter( "business", newBusinessName, ParameterType.GetOrPost );
            }

            if ( !string.IsNullOrWhiteSpace( newPhoneNumber ) )
            {
                request.AddParameter( "phone", newPhoneNumber, ParameterType.GetOrPost );
            }

            if ( collectEmailsFlag.HasValue )
            {
                int collectEmailsInt = collectEmailsFlag.Value ? 1 : 0;
                request.AddParameter( "collect_emails", collectEmailsInt );
            }

            return Execute<AccountResponse>( request );
        }
    }
}

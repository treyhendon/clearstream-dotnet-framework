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
using RestSharp;

namespace ClearstreamDotNetFramework.v1
{
    public partial class Client
    {
        #region Properties

        /// <summary>
        /// The base URL
        /// </summary>
        private const string _baseUrl = "https://api.getclearstream.com/v1/";

        /// <summary>
        /// The client
        /// </summary>
        private readonly IRestClient _client;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public Client( string apiKey )
        {
            _client = new RestClient( _baseUrl );
            _client.AddDefaultHeader( "X-Api-Key", apiKey );
        }

        #endregion

        #region Method

        /// <summary>
        /// Executes the specified request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public T Execute<T>( RestRequest request ) where T : new()
        {
            var response = _client.Execute<T>( request );

            if ( response.ErrorException != null )
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var exception = new ApplicationException( message, response.ErrorException );
                throw exception;
            }
            return response.Data;
        }

        #endregion
    }
}

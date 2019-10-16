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

namespace ClearstreamDotNetFramework.v1.Model.Response
{
    /// <summary>
    /// The api response for multiple messages.
    /// </summary>
    /// <seealso cref="ClearstreamDotNetFramework.v1.Model.Response.PaginatedResponse" />
    public class MessagesResponse : PaginatedResponse
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public List<Message> Data { get; set; }
    }
}

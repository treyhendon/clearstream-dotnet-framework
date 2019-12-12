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

namespace ClearstreamDotNetFramework.v1.Model.Object
{
    /// <summary>
    /// The subscriber details.
    /// </summary>
    public class Subscriber
    {
        /// <summary>
        /// Gets or sets the mobile number.
        /// </summary>
        /// <value>
        /// The mobile number.
        /// </value>
        public string MobileNumber { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the first.
        /// </summary>
        /// <value>
        /// The first.
        /// </value>
        public string First { get; set; }

        /// <summary>
        /// Gets or sets the last.
        /// </summary>
        /// <value>
        /// The last.
        /// </value>
        public string Last { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the lists.
        /// </summary>
        /// <value>
        /// The lists.
        /// </value>
        public List<List> Lists { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Subscriber"/> is deleted.
        /// </summary>
        /// <value>
        ///   <c>true</c> if deleted; otherwise, <c>false</c>.
        /// </value>
        public bool? Deleted { get; set; }
        
        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        /// <value>
        /// The created_at.
        /// </value>
        public DateTime CreatedAt { get; set; }
        
        /// <summary>
        /// Gets or sets the updated_at.
        /// </summary>
        /// <value>
        /// The updated_at.
        /// </value>
        public DateTime UpdatedAt { get; set; }
        
        /// <summary>
        /// Gets or sets the joined_at.
        /// </summary>
        /// <value>
        /// The joined_at.
        /// </value>
        public DateTime JoinedAt { get; set; }
    }
}

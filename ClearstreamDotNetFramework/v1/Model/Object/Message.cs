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

namespace ClearstreamDotNetFramework.v1.Model.Object
{
    /// <summary>
    ///
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the sent at.
        /// </summary>
        /// <value>
        /// The sent at.
        /// </value>
        public DateTime? SentAt { get; set; }

        /// <summary>
        /// Gets or sets the completed at.
        /// </summary>
        /// <value>
        /// The completed at.
        /// </value>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public Text Text { get; set; }

        /// <summary>
        /// Gets or sets the lists.
        /// </summary>
        /// <value>
        /// The lists.
        /// </value>
        public List<List> Lists { get; set; }

        /// <summary>
        /// Gets or sets the stats.
        /// </summary>
        /// <value>
        /// The stats.
        /// </value>
        public Stats Stats { get; set; }

        /// <summary>
        /// Gets or sets the social.
        /// </summary>
        /// <value>
        /// The social.
        /// </value>
        public Social Social { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Keyword"/> is deleted.
        /// </summary>
        /// <value>
        ///   <c>true</c> if deleted; otherwise, <c>false</c>.
        /// </value>
        public bool? Deleted { get; set; }

        /// <summary>
        /// Gets or sets the subscribers.
        /// </summary>
        /// <value>
        /// The subscribers.
        /// </value>
        public List<Subscriber> Subscribers { get; set; }
    }
}

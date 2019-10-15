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
    public class Thread
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Thread"/> is unread.
        /// </summary>
        /// <value>
        ///   <c>true</c> if unread; otherwise, <c>false</c>.
        /// </value>
        public bool? Unread { get; set; }

        /// <summary>
        /// Gets or sets the reply count.
        /// </summary>
        /// <value>
        /// The reply count.
        /// </value>
        public int? ReplyCount { get; set; }

        /// <summary>
        /// Gets or sets the replied at.
        /// </summary>
        /// <value>
        /// The replied at.
        /// </value>
        public DateTime? RepliedAt { get; set; }

        /// <summary>
        /// Gets or sets the subscriber.
        /// </summary>
        /// <value>
        /// The subscriber.
        /// </value>
        public Subscriber Subscriber { get; set; }

        /// <summary>
        /// Gets or sets the recent replies.
        /// </summary>
        /// <value>
        /// The recent replies.
        /// </value>
        public List<Reply> RecentReplies { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Keyword"/> is deleted.
        /// </summary>
        /// <value>
        ///   <c>true</c> if deleted; otherwise, <c>false</c>.
        /// </value>
        public bool? Deleted { get; set; }
    }
}

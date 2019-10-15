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

namespace ClearstreamDotNetFramework.v1.Model.Object
{
    /// <summary>
    ///
    /// </summary>
    public class KeywordUsed
    {
        /// <summary>
        /// Gets or sets the keyword.
        /// </summary>
        /// <value>
        /// The keyword.
        /// </value>
        public Keyword Keyword { get; set; }

        /// <summary>
        /// Gets or sets the thread.
        /// </summary>
        /// <value>
        /// The thread.
        /// </value>
        public Thread Thread { get; set; }

        /// <summary>
        /// Gets or sets the reply.
        /// </summary>
        /// <value>
        /// The reply.
        /// </value>
        public Reply Reply { get; set; }

        /// <summary>
        /// Gets or sets the subscriber.
        /// </summary>
        /// <value>
        /// The subscriber.
        /// </value>
        public Subscriber Subscriber { get; set; }
    }
}

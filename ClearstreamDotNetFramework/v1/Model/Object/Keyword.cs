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
    /// The keyword details.
    /// </summary>
    public class Keyword
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the shortcode.
        /// </summary>
        /// <value>
        /// The shortcode.
        /// </value>
        public string Shortcode { get; set; }

        /// <summary>
        /// Gets or sets the autoresponse.
        /// </summary>
        /// <value>
        /// The autoresponse.
        /// </value>
        public Autoresponse Autoresponse { get; set; }

        /// <summary>
        /// Gets or sets the opt in.
        /// </summary>
        /// <value>
        /// The opt in.
        /// </value>
        public OptIn OptIn { get; set; }

        /// <summary>
        /// Gets or sets the stats.
        /// </summary>
        /// <value>
        /// The stats.
        /// </value>
        public Stats Stats { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Keyword"/> is deleted.
        /// </summary>
        /// <value>
        ///   <c>true</c> if deleted; otherwise, <c>false</c>.
        /// </value>
        public bool? Deleted { get; set; }
    }
}

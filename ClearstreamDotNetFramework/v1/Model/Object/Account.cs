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
    public class Account
    {
        /// <summary>
        /// Gets or sets the business.
        /// </summary>
        /// <value>
        /// The business.
        /// </value>
        public string Business { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the credits.
        /// </summary>
        /// <value>
        /// The credits.
        /// </value>
        public int? Credits { get; set; }

        /// <summary>
        /// Gets or sets the total subscribers.
        /// </summary>
        /// <value>
        /// The total subscribers.
        /// </value>
        public int? TotalSubscribers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [collect emails].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [collect emails]; otherwise, <c>false</c>.
        /// </value>
        public bool? CollectEmails { get; set; }

        /// <summary>
        /// Gets or sets the next billing date.
        /// </summary>
        /// <value>
        /// The next billing date.
        /// </value>
        public string NextBillingDate { get; set; }

        /// <summary>
        /// Gets or sets the plan.
        /// </summary>
        /// <value>
        /// The plan.
        /// </value>
        public Plan Plan { get; set; }

        /// <summary>
        /// Gets or sets the stats.
        /// </summary>
        /// <value>
        /// The stats.
        /// </value>
        public Stats Stats { get; set; }
    }
}

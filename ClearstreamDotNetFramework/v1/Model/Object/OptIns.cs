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
    public class OptIns
    {
        /// <summary>
        /// Gets or sets the past7 days.
        /// </summary>
        /// <value>
        /// The past7 days.
        /// </value>
        public StatTotal Past7Days { get; set; }

        /// <summary>
        /// Gets or sets the past month.
        /// </summary>
        /// <value>
        /// The past month.
        /// </value>
        public StatTotal PastMonth { get; set; }

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>
        /// The total.
        /// </value>
        public int? Total { get; set; }
    }
}

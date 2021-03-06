﻿// <copyright>
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
    /// The business email notification settings for the <see cref="User"/>.
    /// </summary>
    public class EmailNotifications
    {
        /// <summary>
        /// Gets or sets a value indicating whether [incoming reply].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [incoming reply]; otherwise, <c>false</c>.
        /// </value>
        public bool? IncomingReply { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [opt in].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [opt in]; otherwise, <c>false</c>.
        /// </value>
        public bool? OptIn { get; set; }
    }
}

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
    public class User
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email notifications.
        /// </summary>
        /// <value>
        /// The email notifications.
        /// </value>
        public EmailNotifications EmailNotifications { get; set; }

        /// <summary>
        /// Gets or sets the timezone.
        /// </summary>
        /// <value>
        /// The timezone.
        /// </value>
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="User"/> is owner.
        /// </summary>
        /// <value>
        ///   <c>true</c> if owner; otherwise, <c>false</c>.
        /// </value>
        public bool? Owner { get; set; }
    }
}

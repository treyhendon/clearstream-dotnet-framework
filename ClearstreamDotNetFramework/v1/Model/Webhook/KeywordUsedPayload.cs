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

using ClearstreamDotNetFramework.v1.Model.Object;

namespace ClearstreamDotNetFramework.v1.Model.Webhook
{
    /// <summary>
    /// The keyword used webhook payload.
    /// </summary>
    /// <seealso cref="ClearstreamDotNetFramework.v1.Model.Webhook.WebhookPayload" />
    public class KeywordUsedPayload : WebhookPayload
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public KeywordUsed Data { get; set; }
    }
}
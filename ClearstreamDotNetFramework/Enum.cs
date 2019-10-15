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

namespace ClearstreamDotNetFramework
{
    public class Enum
    {
        /// <summary>
        /// If passing multiple search parameters, the operator to use.
        /// </summary>
        public enum SearchOperator
        {
            OR,
            AND
        }

        /// <summary>
        /// When to send the auto-response text.
        /// </summary>
        public enum AutoresponseSetting
        {
            ALWAYS,
            FIRST,
            NEW
        }
    }
}

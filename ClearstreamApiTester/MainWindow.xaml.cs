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

using System.Text;
using System.Windows;
using ClearstreamDotNetFramework.v1;
using ClearstreamDotNetFramework.v1.Model.Response;

namespace ClearstreamApiTester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the GetAccountInfo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void GetAccountInfo_Click( object sender, RoutedEventArgs e )
        {
            string timezone = null;
            if ( !string.IsNullOrWhiteSpace( txtTimeZones.Text ) )
            {
                timezone = txtTimeZones.Text;
            }

            var ApiKey = txtApiKey.Text.Trim();
            var response = new Client( ApiKey );
            var account = response.GetAccount( timezone );
            DisplayAccountInfo( account );
        }

        /// <summary>
        /// Handles the Click event of the UpdateAccountInfo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void UpdateAccountInfo_Click( object sender, RoutedEventArgs e )
        {
            var ApiKey = txtApiKey.Text.Trim();
            var response = new Client( ApiKey );
            var account = UpdateAccountInfo( response );
            DisplayAccountInfo( account );
        }

        /// <summary>
        /// Gets the account information.
        /// </summary>
        private void DisplayAccountInfo( AccountResponse account )
        {
            if ( account.Data == null )
            {
                txtResponse.Text = "Please check your API Key";
                return;
            }

            var sb = new StringBuilder();
            sb.Append( $"Status: {account.Data.Status}" );
            sb.Append( "\n" );
            sb.Append( $"Time Zone: {account.Data.Stats.Timezone}" );
            sb.Append( "\n" );
            sb.Append( $"Name: {account.Data.Business}" );
            sb.Append( "\n" );
            sb.Append( $"Phone: {account.Data.Phone}" );
            sb.Append( "\n" );
            sb.Append( $"Collect Emails: {account.Data.CollectEmails}" );

            txtResponse.Text = sb.ToString();
        }

        /// <summary>
        /// Updates the account information.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns></returns>
        private AccountResponse UpdateAccountInfo( Client response )
        {
            string newName = null;
            string newPhone = null;
            bool? allowEmail = null;

            if ( !string.IsNullOrWhiteSpace( txtNewName.Text ) )
            {
                newName = txtNewName.Text;
            }

            if ( !string.IsNullOrWhiteSpace( txtNewPhone.Text ) )
            {
                newPhone = txtNewPhone.Text;
            }

            if ( rbAllowEmailFalse.IsChecked == true )
            {
                allowEmail = false;
            }

            if ( rbAllowEmailTrue.IsChecked == true )
            {
                allowEmail = true;
            }

            return response.UpdateAccount( newName, newPhone, allowEmail );
        }
    }
}

/*
 * SecuritytextOrgAPI.Standard
 *
 * This file was automatically generated for SecurityTextOrg by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using SecuritytextOrgAPI.Standard.Controllers;
using APIMATIC.SDK.Http.Client;
using APIMATIC.SDK.Common;

namespace SecuritytextOrgAPI.Standard
{
    public partial class SecuritytextOrgAPIClient: ISecuritytextOrgAPIClient
    {

        /// <summary>
        /// Singleton access to Whois controller
        /// </summary>
        public IWhoisController Whois
        {
            get
            {
                return WhoisController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public SecuritytextOrgAPIClient() { }
        #endregion
    }
}
﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------


using System.Management.Automation;
using Microsoft.Azure.Commands.WebApp.Utilities;
using Microsoft.Azure.Management.WebSites.Models;


namespace Microsoft.Azure.Commands.WebApp.Cmdlets
{
    /// <summary>
    /// this commandlet will let you create a new Azure Web app using ARM APIs
    /// </summary>
    [Cmdlet(VerbsCommon.New, "AzureRMWebApp")]
    public class NewAzureWebAppCmdlet : WebAppBaseCmdlet
    {

        [Parameter(Position = 3, Mandatory = true, HelpMessage = "The Location of the web app eg: West US.")]
        public string Location { get; set; }

        [Parameter(Position = 4, Mandatory = true, HelpMessage = "The name of the app service plan eg: Default1.")]
        public string AppServicePlan { get; set; }

        [Parameter(Position = 5, Mandatory = false, HelpMessage = "The information needed to clone web app")]
        [ValidateNotNullOrEmpty]
        public Site SourceWebApp { get; set; }

        [Parameter(Position = 6, Mandatory = false, HelpMessage = "The information needed to clone web app")]
        [ValidateNotNullOrEmpty]
        public CloningInfo CloningInfo { get; set; }
       
        protected override void ProcessRecord()
        {
            if (SourceWebApp != null && CloningInfo == null)
            {
                CloningInfo = new CloningInfo()
                {
                    SourceWebAppId = SourceWebApp.Id
                };
            }

            WriteObject(WebsitesClient.CreateWebsite(ResourceGroup, Name, SlotName, Location, AppServicePlan, CloningInfo));
            
        }
        
    }
}




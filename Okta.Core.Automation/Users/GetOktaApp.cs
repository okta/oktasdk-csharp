﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management.Automation;
using Okta.Core;

namespace Okta.Core.Automation
{
    [Cmdlet(VerbsCommon.Get, "OktaApp")]
    public class GetOktaApp : OktaCmdlet
    {
        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            Position = 0,
            HelpMessage = "App id to retrieve"
        )]
        public string Id { get; set; }

        protected override void ProcessRecord()
        {
            var appsClient = Client.GetAppsClient();
            if (!string.IsNullOrEmpty(Id))
            {
                var app = appsClient.Get(Id);
                WriteObject(app);
            }
            else
            {
                var apps = appsClient.GetFilteredEnumerator();
                WriteObject(apps);
            }
        }
    }
}

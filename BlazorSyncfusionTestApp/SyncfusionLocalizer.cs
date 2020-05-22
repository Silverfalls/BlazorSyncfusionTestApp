using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Blazor;

namespace BlazorSyncfusionTestApp
{
    public class SyncfusionLocalizer : ISyncfusionStringLocalizer
    {
        public string Get(string key)
        {
            return this.Manager.GetString(key);
        }

        public System.Resources.ResourceManager Manager
        {
            get
            {
                return BlazorSyncfusionTestApp.Resources.SfResources.ResourceManager;
            }
        }
    }
}

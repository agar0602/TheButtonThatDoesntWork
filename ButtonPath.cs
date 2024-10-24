using ArcGIS.Core.CIM;
using ArcGIS.Core.Data;
using ArcGIS.Core.Geometry;
using ArcGIS.Desktop.Catalog;
using ArcGIS.Desktop.Core;
using ArcGIS.Desktop.Core.Geoprocessing;
using ArcGIS.Desktop.Editing;
using ArcGIS.Desktop.Extensions;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Framework.Dialogs;
using ArcGIS.Desktop.Framework.Threading.Tasks;
using ArcGIS.Desktop.Layouts;
using ArcGIS.Desktop.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLM_Tab
{
    internal class Button1 : Button
    {
        private IEnumerable<string> args;

        protected override async void OnClick()
        {
            var arguments = Geoprocessing.MakeValueArray();

            ///Insert file path here. Python script should be saved inside a toolbox.
            string toolpath = @"\\Conveyance_Basemap_Update.atbx\Script";

            Geoprocessing.OpenToolDialog(toolpath, args);
        }
    }
}

using ArcGIS.Core.CIM;
using ArcGIS.Core.Data;
using ArcGIS.Core.Geometry;
using ArcGIS.Desktop.Catalog;
using ArcGIS.Desktop.Core;
using ArcGIS.Desktop.Editing;
using ArcGIS.Desktop.Extensions;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Mapping.Events;
using ArcGIS.Desktop.Framework.Dialogs;
using ArcGIS.Desktop.Framework.Threading.Tasks;
using ArcGIS.Desktop.Layouts;
using ArcGIS.Desktop.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WLM_Tab
{
    internal class Module1 : Module
    {
        private static Module1 _this = null;
        protected override bool Initialize()
        {
            ArcGIS.Desktop.Mapping.Events.MapSelectionChangedEvent.Subscribe(MapSelectionChanged);

            return true;
        }
        /// <summary>
        /// Retrieve the singleton instance to this module here
        /// </summary>
        /// 
        public void MapSelectionChanged(MapSelectionChangedEventArgs obj)
        {
			///Add name of condition here. I named mine "button_on".
            FrameworkApplication.State.Deactivate("button_on");
            var sel = obj.Selection.ToDictionary();
            foreach (var item in sel)
            {
                ///Add name of layer below. If adding multiple layers, use || as OR operation.
                if (item.Key.ToString().Equals("Survey Record (Local)"))
                {
                    FrameworkApplication.State.Activate("button_on");
                    break;
                }
            }
        }
	}
}
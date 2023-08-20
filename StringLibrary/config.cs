using MapGeneration;
using PlayerRoles;
using PluginAPI.Core.Zones.Heavy.Rooms;
using System.Collections.Generic;
using System.ComponentModel;

namespace lastalive
{
    public class Config
    {
        [Description("Will the plugin be enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug?")]
        public bool Debug { get; set; } = false;

        [Description("Text to send the last player")]
        public string Text { get; set; } = "You are the last one alive";

        [Description("How long should we display the text for?")]
        public int Time { get; set; } = 10;
        }
}

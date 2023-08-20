using PluginAPI.Events;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
namespace lastalive
{
    public class plugin
    {
        public static Plugin Singleton;
        [PluginConfig]
        public Config Config;
        
        [PluginEntryPoint("LastAlive, "1.0.0", "", "zInitial")]
        void OnEnabled()
        {

            if (!Config.IsEnabled)
                return;

              Singleton = this;
            PluginAPI.Events.EventManager.RegisterEvents(this);
        }

        [PluginEvent(ServerEventType.PlayerDeath)]
        void OnPlayerDeath(PlayerDeathEvent e)
        {
            Config config = Plugin.Singleton.Config;
            
            int alive_count = 0;
            Player target = null;
            foreach (var p in Player.GetPlayers())
            {
                if (p.IsHuman)
                {
                    alive_count++;
                    target = p;
                }
            }
            if (alive_count == 1)
                target.ReceiveHint(config.Text, config.Duration);
        }
    }
}

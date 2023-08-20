using PluginAPI.Events;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
namespace lastalive
{
    public class plugin
    {

        [PluginEntryPoint("LastAlive, "1.0.0", "", "zInitial")]
        void OnEnabled()
        {
            PluginAPI.Events.EventManager.RegisterEvents(this);
        }

        [PluginEvent(ServerEventType.PlayerDeath)]
        void OnPlayerDeath(PlayerDeathEvent e)
        {
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
                target.ReceiveHint("You are the last one alive", 10);
        }
    }
}

using System;

using Exiled.API.Features;
using Exiled.API.Enums;

using PPlayer = Exiled.Events.Handlers.Player;

namespace No_MTF_Tesla
{
    public class NMT : Plugin<Config>
    {
        private Handlers.Player player;
		
        public override string Name { get; } = "NMT";
        public override string Author { get; } = "TypicalIllusion";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 1, 19);
        public override string Prefix { get; } = "NMT";
        public override PluginPriority Priority { get; } = PluginPriority.Low;

        public void RegisterEvents()
        {
            player = new Handlers.Player();

            PPlayer.TriggeringTesla += player.TriggeringTeslaGate;
        }
        public void UnregisterEvents()
        {
            PPlayer.TriggeringTesla -= player.TriggeringTeslaGate;

            player = null;
        }

        public override void OnEnabled()
        {
            RegisterEvents();
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            UnregisterEvents();
            base.OnDisabled();
        }
    }
}

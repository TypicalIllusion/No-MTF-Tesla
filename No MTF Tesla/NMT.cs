using System;

using Exiled.API.Features;
using Exiled.API.Enums;

using PPlayer = Exiled.Events.Handlers.Player;

namespace No_MTF_Tesla
{
    public class NMT : Plugin<Config>
    {
        private Handlers.Player player = new Handlers.Player();
        public override string Name { get; } = "NMT";
        public override string Author { get; } = "TypicalIllusion";
        public override Version Version { get; } = new Version(2, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 1, 19);
        public override string Prefix { get; } = "NMT";

        public static NMT Instance;

        public override PluginPriority Priority { get; } = PluginPriority.Low;

        public static NMT Singleton;


        public static bool enabledInGame = true;

        public void RegisterEvents()
        {
            PPlayer.TriggeringTesla += player.TriggeringTeslaGate;
            Singleton = this;
        }
        public void UnregisterEvents()
        {
            PPlayer.TriggeringTesla -= player.TriggeringTeslaGate;
            player = null;
            Singleton = null;
        }

        public override void OnEnabled()
        {
            base.OnEnabled();
            RegisterEvents();
        }
        public override void OnDisabled()
        {
            base.OnDisabled();
            UnregisterEvents();
        }
        public override void OnReloaded()
        {
            base.OnReloaded();
        }
    }
}

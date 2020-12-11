using System;

using Exiled.API.Features;
using Exiled.API.Enums;

using Player = Exiled.Events.Handlers.Player;

namespace No_MTF_Tesla
{
    public class NMT : Plugin<Config>
    {
        private readonly Handlers.Player player = new Handlers.Player();

        public static NMT Singleton { get; private set; }
        public override string Name { get; } = "NMT";
        public override string Author { get; } = "TypicalIllusion";
        public override Version Version { get; } = new Version(2, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 1, 19);
        public override string Prefix { get; } = "NMT";
        public override PluginPriority Priority { get; } = PluginPriority.Low;

        public NMT()
        {
            Singleton = this;
        }
        public void RegisterEvents()
        {
            Player.TriggeringTesla += player.TriggeringTeslaGate;
        }
        public void UnregisterEvents()
        {
            Player.TriggeringTesla -= player.TriggeringTeslaGate;
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

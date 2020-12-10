using Exiled.Events.EventArgs;
using static No_MTF_Tesla.NMT;

namespace No_MTF_Tesla.Handlers
{
    class Player
    {
        public void TriggeringTeslaGate(TriggeringTeslaEventArgs ev)
        {
            ev.IsTriggerable = !((Singleton.Config.MTFTesla && ev.Player.Team == Team.MTF) || (Singleton.Config.ScientistTesla && ev.Player.Team == Team.RSC));
        }
    }
}

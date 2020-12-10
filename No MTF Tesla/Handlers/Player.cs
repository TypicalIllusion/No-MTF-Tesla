using Exiled.Events.EventArgs;
using static No_MTF_Tesla.NMT;

namespace No_MTF_Tesla.Handlers
{
    class Player
    {
        public void TriggeringTeslaGate(TriggeringTeslaEventArgs ev)
        {
            if (Singleton.Config.MTFTesla) return;
            else
            {
                if (ev.Player.Team == Team.MTF)
                {
                    ev.IsTriggerable = false;
                }
            }
            if (Singleton.Config.ScientistTesla) return;
            else
            {
                if (ev.Player.Team == Team.RSC)
                {
                    ev.IsTriggerable = false;
                }
            }
        }
    }
}

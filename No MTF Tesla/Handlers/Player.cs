using Exiled.Events.EventArgs;

namespace No_MTF_Tesla.Handlers
{
    class Player
    {
        public void TriggeringTeslaGate(TriggeringTeslaEventArgs ev)
        {
            if(ev.Player.Team == Team.MTF || ev.Player.Team == Team.RSC)
            {
                ev.IsTriggerable = false;
            }
        }
    }
}

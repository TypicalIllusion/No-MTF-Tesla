using Exiled.Events.EventArgs;

namespace No_MTF_Tesla.Handlers
{
    class Player
    {
        public void TriggeringTeslaGate(TriggeringTeslaEventArgs ev)
        {
            ev.IsTriggerable = !(ev.Player.Team == Team.MTF || ev.Player.Team == Team.RSC);
        }
    }
}

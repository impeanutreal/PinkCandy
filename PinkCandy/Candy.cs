using System;
using Exiled.API.Features;
using Exiled.Events;
using Exiled.Events.EventArgs;

namespace PinkCandy
{
    internal class Candy
    {

        public void PickingUp(PickingUpScp330EventArgs ev)
        {
            Random rnd = new Random();
            int canche = rnd.Next(1, 100);

           Log.Info(canche);
            if (canche >= 1 && canche <= 2)
            {
                ev.Player.TryAddCandy(InventorySystem.Items.Usables.Scp330.CandyKindID.Pink);
            }
        }

    }
}

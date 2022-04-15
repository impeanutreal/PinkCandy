using Exiled.API.Features;
using Exiled.API.Enums;
using System;

using Player = Exiled.Events.Handlers.Player;

namespace PinkCandy
{
    public class Main : Plugin<Config>
    {
        private static readonly Lazy<Main> LazyInstance = new Lazy<Main>(() => new Main());
        public static Main Instance => LazyInstance.Value;


        public override PluginPriority Priority { get; } = PluginPriority.Low;

        private Candy candy;

        public override void OnEnabled()
        {
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
        }

        public void RegisterEvents()
        {
            candy = new Candy();

            Player.PickingUpScp330 += candy.PickingUp;
        }

        public void UnregisterEvents()
        {
            Player.PickingUpScp330 -= candy.PickingUp;
        }
    }
}
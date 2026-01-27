using MEC;
using System;
using System.Collections.Generic;
using CommandSystem;
using Exiled.API.Features;
using Exiled.API.Interfaces;

namespace MyFirstPlugin
{
    public class MyPlugin : Plugin<PluginConfig>
    {
        public override string Name => "AlpacasFPlugin";
        public override string Author => "Alpaca";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 0, 0);

        public override void OnEnabled()
        {
            Log.Info("AlpacasFP injected!");
            Exiled.Events.Handlers.Server.WaitingForPlayers += OnWaitingForPlayers;
            // Additional initialization code can go here
            // unsub from events
        }
        public override void OnDisabled()
        {
            Log.Info("AlpacasFP ejected!");
            Exiled.Events.Handlers.Server.WaitingForPlayers -= OnWaitingForPlayers;
            // Additional cleanup code can go here
            // unsub from events
        }


    // Simple configuration class so Plugin<PluginConfig> has a defined type.
    public class PluginConfig : IConfig
    {
        // Add configuration properties here as needed, e.g.:
        // public bool SomeSetting { get; set; } = true;
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
    }
}
﻿using Dalamud.Plugin;

namespace Ice_Box
{
    internal class Service
    {
        internal static Plugin Plugin { get; set; } = null!;
        internal static Config Configuration { get; set; } = null!;
        public static IDalamudPluginInterface PluginInterface { get; set; } = null!;
    }
}
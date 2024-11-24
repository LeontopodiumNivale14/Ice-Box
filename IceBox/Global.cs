/*
 * This file is used to import all the necessary namespaces and classes that are used in the plugin.
 * This file is then imported in ALL the files in the plugin.
 *
 * you never have to worry about importing the same namespaces in every file. Especially usefull für utility classes.
 */

global using static ECommons.GenericHelpers;
global using static IceBox.Util.Utils;
global using static IceBox.Util.Data;
global using IceBox.Scheduler;
global using Dalamud.Interface;
global using Dalamud.Interface.Colors;
global using Dalamud.Interface.Utility;
global using Dalamud.Interface.Windowing;
global using Dalamud.Plugin;
global using ECommons;
global using ECommons.DalamudServices;
global using ECommons.DalamudServices.Legacy;
global using ECommons.ImGuiMethods;
global using ECommons.Logging;
global using ECommons.Schedulers;
global using ImGuiNET;
global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Numerics;
global using System.Runtime.InteropServices;
global using System.Text;
global using System.Threading.Tasks;
global using static ECommons.GenericHelpers;
global using Callback = ECommons.Automation.Callback;
global using CSFramework = FFXIVClientStructs.FFXIV.Client.System.Framework.Framework;

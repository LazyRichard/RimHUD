﻿using Harmony;
using RimHUD.Data;
using RimHUD.Interface;
using RimWorld;
using Verse;

namespace RimHUD.Patch
{
    [HarmonyPatch(typeof(ITab), "PaneTopY", MethodType.Getter)]
    internal static class RimWorld_ITab_PaneTopY
    {
        public static bool Prefix(ref float __result)
        {
            if (!State.AltInspectPane || !State.PawnSelected) { return true; }

            __result = (float) UI.screenHeight - Theme.InspectPaneHeight.Value;

            return false;
        }
    }
}

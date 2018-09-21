﻿using Harmony;
using RimHUD.Data;
using RimHUD.Interface;
using Verse;

namespace RimHUD.Patch
{
    [HarmonyPatch(typeof(LetterStack), "LettersOnGUI")]
    internal static class Verse_LetterStack_LettersOnGUI
    {
        private static bool Prefix(float baseY) => !State.AltLetters || LetterStackPlus.DrawLetters(baseY);
    }
}

using HarmonyLib;
using iiMenu.Mods;
using System;
using UnityEngine;
using static iiMenu.Menu.Main;

namespace iiMenu.Patches
{
    [HarmonyPatch(typeof(LegalAgreements), "Update")]
    public class TOSPatch1
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(LegalAgreements), "Start")]
    public class TOSPatch2
    {
        private static bool Prefix()
        {
            return false;
        }
    }
}

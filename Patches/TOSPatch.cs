using HarmonyLib;
using iiMenu.Mods;
using System;
using UnityEngine;
using static iiMenu.Menu.Main;

namespace iiMenu.Patches
{
    [HarmonyPatch(typeof(LegalAgreements), "Update")]
    public class TOSPatch
    {
        public static bool enabled = false;
        private static void Postfix(LegalAgreements __instance)
        {
            if (enabled)
            {
                GameObject.Find("Miscellaneous Scripts/PrivateUIRoom/LegalAgreementCheck").SetActive(false);
                GameObject.Find("Miscellaneous Scripts/PrivateUIRoom/LegalAgreementCheck").SetActive(false);
            }
        }
    }
}

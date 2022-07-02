using System;
using System.IO;
using System.Reflection;
using Harmony;
using UnityEngine;

namespace FreezeWhiteNight_MOD
{
    public class Harmony_Patch
    {
        public Harmony_Patch()
        {
            try
            {
                var harmony = HarmonyInstance.Create("Nonnonstop.FreezeWhiteNight");
                var assembly = Assembly.GetExecutingAssembly();
                harmony.PatchAll(assembly);
            }
            catch (Exception ex)
            {
                File.WriteAllText(Application.dataPath + "/BaseMods/error_FreezeWhiteNight.txt", ex.Message);
            }
        }

        [HarmonyPatch(typeof(WhiteNightSpace.PlagueDoctor), "ChangeIsolateRoom")]
        private class PlagueDoctor_ChangeIsolateRoom_Patch
        {
            public static bool Prefix()
            {
                return false;
            }
        }

        [HarmonyPatch(typeof(WhiteNightSpace.DeathAngel), "ChangeIsolateRoom")]
        private class DeathAngel_ChangeIsolateRoom_Patch
        {
            public static bool Prefix()
            {
                return false;
            }
        }
    }
}

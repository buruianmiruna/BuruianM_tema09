using System;
using System.IO;

namespace SlotMachine_App.Logic
{
    /// <summary>
    /// Enum care definește cele 4 simboluri posibile pentru sloturi
    /// </summary>
    public enum SlotItem
    {
        Simbol_A = 0,  // img_a.png
        Simbol_B = 1,  // img_b.png
        Simbol_C = 2,  // img_c.png
        Simbol_D = 3   // img_d.png
    }

    /// <summary>
    /// Clasă helper pentru gestionarea simbolurilor
    /// </summary>
    public static class SlotItemHelper
    {
        /// <summary>
        /// Returnează numele fișierului de imagine pentru un simbol dat
        /// </summary>
        public static string GetImageFileName(SlotItem item)
        {
            return item switch
            {
                SlotItem.Simbol_A => "img_a.png",
                SlotItem.Simbol_B => "img_b.png",
                SlotItem.Simbol_C => "img_c.png",
                SlotItem.Simbol_D => "img_d.png"
            };
        }

        /// <summary>
        /// Returnează path-ul complet către fișierul de imagine
        /// </summary>
        public static string GetImagePath(SlotItem item)
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            string imageName = GetImageFileName(item);
            return Path.Combine(appPath, "Assets", "Texturi", imageName);
        }

        /// <summary>
        /// Returnează un simbol aleatoriu
        /// </summary>
        public static SlotItem GetRandom(Random random)
        {
            return (SlotItem)random.Next(0, 4);
        }
    }
}

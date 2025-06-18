using Shef_Kuhar_2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Shef_Kuhar_2.Services
{
    public static class DailyMenuService
    {
        private static string folder = "menus";

        public static void SaveMenu(DailyMenuModel menu)
        {
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            string path = Path.Combine(folder, $"menu_{menu.Date:yyyyMMdd}.json");
            string json = JsonConvert.SerializeObject(menu, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static DailyMenuModel LoadMenu(DateTime date)
        {
            string path = Path.Combine(folder, $"menu_{date:yyyyMMdd}.json");
            if (!File.Exists(path))
                return null;

            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<DailyMenuModel>(json);
        }
    }
}

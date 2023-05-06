using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleManager
{
    internal class Utility
    {
        static readonly string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static readonly string bm = $"{documents}/BattleManager";
        static readonly string stats = $"{bm}/statblocks";
        static readonly string parties = $"{bm}/party";

        public static int keyToNum(KeyEventArgs e)
        {
            return e.KeyData switch
            {
                Keys.D1 or Keys.NumPad1 => 1,
                Keys.D2 or Keys.NumPad2 => 2,
                Keys.D3 or Keys.NumPad3 => 3,
                Keys.D4 or Keys.NumPad4 => 4,
                Keys.D5 or Keys.NumPad5 => 5,
                Keys.D6 or Keys.NumPad6 => 6,
                Keys.D7 or Keys.NumPad7 => 7,
                Keys.D8 or Keys.NumPad8 => 8,
                Keys.D9 or Keys.NumPad9 => 9,
                Keys.D0 or Keys.NumPad0 => 0,
                _ => -1,
            };
        }

        public static void writePartyFile(string name, Dictionary<string, Character> obj)
        {
            string path = $"{parties}/{name}.json";
            string content = JsonSerializer.Serialize(obj, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(path, content);
        }

        public static void deletePartyFile(string name)
        {
            string path = $"{parties}/{name}.json";
            if (File.Exists(path)) File.Delete(path);
        }

        public static Dictionary<string, Character> getParty(string name)
        {
            string path = $"{parties}/{name}.json";
            if (File.Exists(path)) return JsonSerializer.Deserialize<Dictionary<string, Character>>(File.ReadAllText(path));
            else return null;
        }

        public static IEnumerable getPartyFiles()
        {
            return Directory.EnumerateFiles(parties);

        }

        public static IEnumerable getStatFiles()
        {
            return Directory.EnumerateFiles(stats);
        }

        public static void makeFolder(string name)
        {
            string path = $"{bm}/{name}";
            Directory.CreateDirectory(path);
        }

        public static void initializeFolders()
        {
            makeFolder("party");
            makeFolder("statblocks");
        }
    }
}

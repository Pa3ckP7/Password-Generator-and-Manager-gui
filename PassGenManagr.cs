using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwords_gui
{
    class PassGenManagr
    {
        static string Filters_directory = @"Saved_data\Filters";
        static string Passwords_directory = @"Saved_data\Passwords";
        public static void Generate(string passwordName, int passwordLength, string filter, string key)
        {

            Random rng = new Random();
            string genPassword = "";
            for (int i = 0; i < passwordLength; i++)
            {
                string[] chars = File.ReadAllLines($@"{Filters_directory}\{filter}.txt");
                genPassword += chars[rng.Next(0, chars.Length)];
            }
            string password = Encrypt.EncryptString(genPassword, key);
            File.WriteAllText($@"{Passwords_directory}\{passwordName}", password);
        }
    }
}

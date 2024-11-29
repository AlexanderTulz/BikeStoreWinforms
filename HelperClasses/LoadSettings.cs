using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStore.HelperClasses
{
    internal class LoadSettings
    {
        static string BasePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory()));
        static string SettingsDirectory = BasePath + @"\temp\";
        static string SettingsFileName = "settings.txt";
        public string fullPath = SettingsDirectory + SettingsFileName;

        const string SettingsParameters =
            "login = \n" +
            "user = \n" +
            "password = \n" +
            "role = \n";

        public LoadSettings()
        {
            CreateSettingsFile();
        }

        private void CreateSettingsFile()
        {
            // TODO: fill for an empty file also
            try
            {
                if (!Directory.Exists(SettingsDirectory))
                {
                    Directory.CreateDirectory(SettingsDirectory);
                }
                if (!File.Exists(fullPath))
                {
                    using (FileStream fs = File.OpenWrite(fullPath))
                    {
                        byte[] title = new UTF8Encoding(true).GetBytes(SettingsParameters);
                        fs.Write(title, 0, title.Length);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        public string ReadSettingsFile()
        {
            if (!File.Exists(fullPath))
            {
                CreateSettingsFile();
            }

            string settingsStr = "";

            try
            {
                using (StreamReader sr = File.OpenText(fullPath))
                {
                    string buffer = "";

                    while ((buffer = sr.ReadLine()) != null)
                    {
                        settingsStr += buffer + "\n";
                    }

                    sr.Close();
                }
            }
            catch (Exception Ex)
            {

            }

            return settingsStr;
        }

        private string GetFieldValue(string fieldName)
        {
            fieldName += " = ";

            string settings = ReadSettingsFile();
            string value = "";


            if (settings == null || settings.Length <= 1)
            {
                return null;
            }

            for (int i = 0, j = 0; i < settings.Length; ++i)
            {
                if (settings[i] == fieldName[j] && j < fieldName.Length)
                {
                    if (j == fieldName.Length - 1)
                    {
                        while (settings[++i] != '\n' && i < settings.Length)
                        {
                            char c = settings[i];
                            value += c;
                        }
                        break;
                    }

                    ++j;
                }
                else if (settings[i] != fieldName[j])
                {
                    j = 0;
                    while (settings[i] != '\n')
                    {
                        ++i;
                    }
                }

            }

            return value;
        }

        public string GetLogin()
        {
            string login = GetFieldValue("login");
            return login;
        }

        public string GetWhichUserIsLogged()
        {

            string username = GetFieldValue("user");
            return username;
        }

        public string GetUserPassword()
        {
            string password = GetFieldValue("password");
            return password;
        }

        public string GetRole()
        {
            string role = GetFieldValue("role");
            return role;
        }


    }
}

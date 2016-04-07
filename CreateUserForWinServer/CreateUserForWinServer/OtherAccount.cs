using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreateUserForWinServer
{
    class OtherAccount
    {
        public static string AccountType { get; set; }
        public static string[] Directory { get; set; }
        public static string Prefix { get; set; } = "";
        public static Random Key { private get; set; } = new Random();
        public string AccountName { get; private set; }
        public int Password { private get; set; }
        public string[] FullName { get; private set; }
        public string Login { get; private set; }
        public string[] OU { private get; set; }

        string Patronymic = "";



        public OtherAccount(string OAName)
        {
            AccountName = OAName;
            FullName = AccountName.Split(' ');
            Login = CreateLogin();
            Password = Key.Next(1000, 9999);
            OU = new string[Directory.Length - 1];
            for (int i = 0; i < Directory.Length; i++)
                if (Directory[i] != "")
                    OU[i] = "OU=" + Directory[i];

        }

        public int GetPassword()
        {
            return Password;
        }

        public void SetLogin(string login)
        {
            Login = login;
        }

        public string GetLogin()
        {
            return Login;
        }

        public string CreateLogin()
        {
            string Surname = FullName[0].ToLower();
            string Name = FullName[1].ToLower();
            string RusLogin = "";
            
            if (FullName.Length > 2)
            {
                Patronymic = FullName[2].ToLower();
                RusLogin = Surname + '_' + Name[0] + Patronymic[0];
            }
            else
            {
                RusLogin = Surname + '_' + Name[0];
                Patronymic = "";
            }
            string LatLogin = Transliteration.Transliteration.Front(RusLogin);
            if (Prefix != "")
                LatLogin = Prefix + "_" + LatLogin;
            return LatLogin;
        }

        /*
        Directory[0] == accounts
        Directory[1] == olympiads
        Directory[2] == 2015 - 10 - sep
        Directory[3] == login
        */
        public string GetCreateCMD()
        {
            string domain = "DC=amm,DC=vsu,DC=ru";
            string fs_Server = "fs";
            string result = "";
            result += "@echo " + " " + AccountName + " \n";
            result += "dsadd ou \"OU=" + Directory[2] + ",OU=" + Directory[1] + ",OU=" + Directory[0] + "," + domain + "\" \n";
            result += "dsadd ou \"OU=" + Directory[2] + ",OU=" + Directory[1] + ",OU=" + Directory[0] + "," + domain + "\" \n";
            if (Directory[1] == "olympiads" || Directory[1] == "geks")
                result += "dsadd user \"CN=" + Login + ",OU=" + Directory[2] + ",OU=" + Directory[1] + ",OU=" + Directory[0] + "," + domain + "\" -samid " + Login + " -memberof \"CN=Students,CN=Users," + domain + "\" -display \"" + AccountName + "\" -fn \"" + FullName[1] + " " + Patronymic + "\" -ln \"" + FullName[0] + "\" -desc \"" + Directory[1] + "," + Directory[2] + "-" + Directory[3] + "\"" + " -hmdir \"\\\\" + fs_Server + "\\home\" -hmdrv x: -mustchpwd no -pwd " + Password + " -disabled no \n";
            else
                result += "dsadd user \"CN=" + Login + ",OU=" + Directory[2] + ",OU=" + Directory[1] + ",OU=" + Directory[0] + "," + domain + "\" -samid " + Login + " -memberof \"CN=Students,CN=Users," + domain + "\" -display \"" + AccountName + "\" -fn \"" + FullName[1] + " " + Patronymic + "\" -ln \"" + FullName[0] + "\" -desc \"" + Directory[1] + "," + Directory[2] + "-" + Directory[3] + "\"" + " -hmdir \"\\\\" + fs_Server + "\\home\" -hmdrv x: -mustchpwd yes -pwd " + Password + " -disabled no \n";
            return result;
        }
    }
}

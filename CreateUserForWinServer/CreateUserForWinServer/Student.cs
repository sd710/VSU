using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transliteration;

namespace CreateUserForWinServer
{
    class Student
    {
        public string StudentName { get; private set; }
        public static Random Key { private get; set; } = new Random();
        public int GroupNumber { get; private set; }
        public decimal Year { get; private set; }
        public string StudentId { get; private set; }
        public int Password { private get; set; }
        public string[] FullName { get; private set; }
        public string Login { get; private set; }
        public string TimeEducation { get; private set; } = "";
        public static string Directory { get; set; }

        public Student(string SName, string GrNum, decimal Y, string StId, bool timeEducation, string direct)
        {
            StudentName = SName;
            GroupNumber = Convert.ToInt16(GrNum);
            Year = Y;
            StudentId = StId;
            Password = Key.Next(1000, 9999);
            FullName = StudentName.Split(' ');
            Login = CreateLogin();
            if (!timeEducation) TimeEducation = "v";
  
            Directory = direct;
        }

        public int GetPassword()
        {
            return Password;
        }

        public string CreateLogin()
        {
            string Surname = FullName[0].ToLower();
            string Name = FullName[1].ToLower();
            string RusLogin = "";
            string Patronymic = "";
            if (FullName.Length > 2)
            {
                Patronymic = FullName[2].ToLower();
                RusLogin = Surname + '_' + Name[0] + Patronymic[0];
            }
            else
                RusLogin = Surname + '_' + Name[0];
            
            string LatLogin = Transliteration.Transliteration.Front(RusLogin);
            return LatLogin;
        }

        public void SetLogin(string login)
        {
            Login = login;
        }

        public string GetLogin()
        {
            return Login;
        }

        public string GetCreateCMD()
        {
            string domain = "DC=amm,DC=vsu,DC=ru";
            string fs_Server = "fs";
            string result = @"";
            result += @"@echo " + StudentId + " " + StudentName + " \n";
            result += "dsadd ou \"OU=" + Year + ",OU=" + Directory + ",OU=accounts," + domain + "\" \n";
            result += "dsadd ou \"OU=" + GroupNumber + TimeEducation + "gr,OU=" + Year + ",OU=" + Directory + ",OU=accounts," + domain + "\" \n";
            result += "dsadd user \"CN=" + Login + ",OU=" + GroupNumber + TimeEducation + "gr,OU=" + Year + ",OU=" + Directory + ",OU=accounts," + domain + "\" -samid " + Login + " -memberof \"CN=Students,CN=Users," + domain + "\" -display \"" + StudentName + "\" -fn \"" + FullName[1] + "\" -ln \"" + FullName[0] + "\" -desc \"Student, " + Year + " - GR" + GroupNumber + TimeEducation + "\" -pager " + StudentId + " -hmdir \"\\\\" + fs_Server + "\\home\" -hmdrv x: -mustchpwd yes -pwd " + Password + " -disabled no \n";

            return result;
        }
    }
}

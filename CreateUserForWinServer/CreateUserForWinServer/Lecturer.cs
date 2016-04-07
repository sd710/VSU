using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateUserForWinServer
{
    class Lecturer
    {
        public static Random Key { private get; set; } = new Random();
        public string LecturerName { get; private set; }
        public string RusChairLecturer { get; private set; }
        public string LatChairLecturer { get; private set; }
        public string Login { get; private set; }
        public string[] FullName { get; private set; }
        public int Password { private get; set; }

        public Lecturer(string LName, string ChLecturer)
        {
            LecturerName = LName;
            RusChairLecturer = ChLecturer;
            CreateLatChairLecturer();
            FullName = LecturerName.Split(' ');
            Password = Key.Next(1000, 9999);
            Login = CreateLogin();
        }

        private void CreateLatChairLecturer()
        {
            switch(RusChairLecturer)
            {
                case "МО ЭВМ":
                    LatChairLecturer = "MO";
                    break;
                case "ММИО":
                    LatChairLecturer = "MMIO";
                    break;
                case "МиПА":
                    LatChairLecturer = "MIPA";
                    break;
                case "ТПМ":
                    LatChairLecturer = "TPM";
                    break;
                case "ТКиАР":
                    LatChairLecturer = "TKIAR";
                    break;
                case "НК":
                    LatChairLecturer = "NK";
                    break;
                case "ВМиПИТ":
                    LatChairLecturer = "VMPIT";
                    break;
                case "ПОиАИС":
                    LatChairLecturer = "POIAIS";
                    break;
                case "T-Systems":
                    LatChairLecturer = "tsystems";
                    break;     
            }
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
            string Patronymic = "";
            string RusLogin = "";

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

        public string GetCreateCMD()
        {
            string domain = "DC=amm,DC=vsu,DC=ru";
            string fs_Server = "fs";
            string result = "";

            result += "@echo " + LecturerName + " \n";
            result += "dsadd user \"CN=" + Login + ",OU=" + LatChairLecturer + ",OU=members,OU=accounts," + domain + "\" -samid " + Login + " -memberof \"CN=Members,CN=Users," + domain + "\" -display \"" + LecturerName + "\" -fn \"" + FullName[1] + " " + FullName[2] + "\" -ln \"" + FullName[0] + "\" -desc \"member, " + RusChairLecturer + "\"" + " -hmdir \"\\\\" + fs_Server + "\\home\" -hmdrv x: -mustchpwd yes -pwd " + Password + " -disabled no \n";
            return result;
        }
    }
}

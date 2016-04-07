using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace CreateUserForWinServer
{
    public partial class MainFormCreateUser : Form
    {
        public MainFormCreateUser()
        {
            InitializeComponent();
            numUpDownYearStudent.Value = DateTime.Today.Year;
        }

        bool timeEducation = true;
        string AccountType = "";
        string Directory = @"accounts";
        string Date = "";
        string Login = "Surname_NP";
        string defaultTextPrefix = @"<Введите, если нужно>";
        string defaultTextFileDirectory = "Укажите файл со списком пользователей";
        string defaultTextListName = @"<список студентов для создания пользователей>";
        string defaultTextListNameStudent = "<Фамилия Имя Отчество>" + Environment.NewLine + "<Номер студенческого билета>";
        string OATimeEducation = "gr";

        //проверка строки - имени (только русские буквы)
        private bool CheckName(string name)
        {
            string tmpName = name;
            //int a = tmpName[0];
            foreach (char c in tmpName)
                if ((c < 'А' || c > 'я') && (c != 'ё' && c != 'Ё'))
                    if (c != ' ')
                        return false;
            return true;
        }

        //вся информация о студенте, проверка введенных данных, исключение ошибок
        private bool CheckStudentInfo()
        {
            if (tBStudentName.Text == "")
            {
                labelErrorStudent.Text = "Заполните поле " + "\"" + labelStudentName.Text + "\"";
                labelErrorStudent.Visible = true;
                return false;
            }

            string[] tmpName = tBStudentName.Text.Split(' ');
            if (tmpName[0].Length > 17)
            {
                labelErrorStudent.Text = "Фаимилия слишком длинная";
                labelErrorStudent.Visible = true;
                return false;
            }

            if (!CheckName(tBStudentName.Text))
            {
                labelErrorStudent.Text = "Введено неккоректное имя";
                labelErrorStudent.Visible = true;
                return false;
            }

            if (tBGroupNumber.Text == "")
            {
                labelErrorStudent.Text = "Заполните поле " + "\"" + labelGroupNumber.Text + "\"";
                labelErrorStudent.Visible = true;
                return false;
            }
            try
            {
                Int32 temp = Convert.ToInt32(tBGroupNumber.Text);
            }
            catch
            {
                tBGroupNumber.Select();
                tBGroupNumber.SelectionStart = 0;
                tBGroupNumber.SelectionLength = tBGroupNumber.Text.Length;
                labelErrorStudent.Text += "\"" + labelGroupNumber.Text + "\"";
                labelErrorStudent.Visible = true;
                return false;
            }

            if (tBStudentId.Text == "")
            {
                labelErrorStudent.Text = "Заполните поле " + "\"" + labelStudentId.Text + "\"";
                labelErrorStudent.Visible = true;
                return false;
            }
            try
            {
                Int32 tempStId = Convert.ToInt32(tBStudentId.Text);
            }
            catch
            {
                tBStudentId.Select();
                tBStudentId.SelectionStart = 0;
                tBStudentId.SelectionLength = tBStudentId.Text.Length;
                labelErrorStudent.Text += "\"" + labelStudentId.Text + "\"";
                labelErrorStudent.Visible = true;
                return false;
            }
            return true;
        }

        //вся информация о преподе, проверка введенных данных, исключение ошибок
        private bool CheckLecturerInfo()
        {
            try
            {
                if (tBLecturerName.Text == "")
                {
                    labelErrorStudent.Text = "Заполните поле " + "\"" + labelLecturerName.Text + "\""; ;
                    labelErrorLecturer.Visible = true;
                    return false;
                }

                string[] tmpName = tBLecturerName.Text.Split(' ');
                if (tmpName[0].Length > 17)
                {
                    labelErrorStudent.Text = "Фаимилия слишком длинная";
                    labelErrorLecturer.Visible = true;
                    return false;
                }

                if (!CheckName(tBLecturerName.Text))
                {
                    labelErrorStudent.Text = "Введено неккоректное имя";
                    labelErrorStudent.Visible = true;
                    return false;
                }

                if (comBChairs.Text == "")
                {
                    labelErrorLecturer.Text = "Заполните поле " + "\"" + labelChair.Text + "\"";
                    labelErrorLecturer.Visible = true;
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //вся информация об аккаунте, проверка введенных данных, исключение ошибок
        private bool CheckOtherAccountInfo()
        {
            try
            {
                if (comBTypeAccount.SelectedItem == null)
                {
                    labelErrorOtherAccount.Text = "Тип учетной записи не выбран";
                    labelErrorOtherAccount.Visible = true;
                    return false;
                }
                if (tBListName.Text == defaultTextListName || tBListName.Text == defaultTextListNameStudent)
                {
                    labelErrorOtherAccount.Text = "Введите список студентов или укажите файл со списком";
                    labelErrorOtherAccount.Visible = true;
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //создание массива строк - фамилий пользователей
        private bool CreateListAccount(List<OtherAccount> LAccount)
        {
            string[] UsersName;
            char[] splitSym = { '\n', '\r', '\t' };
            try
            {
                UsersName = tBListName.Text.Split(splitSym, StringSplitOptions.RemoveEmptyEntries);

                OtherAccount.AccountType = AccountType;
                OtherAccount.Directory = tBOtherAccountDirectory.Text.Split('\\');
                if (tBPrefixOtherAccount.Text != defaultTextPrefix)
                    OtherAccount.Prefix = tBPrefixOtherAccount.Text;

                foreach (string UName in UsersName)
                    if (!CheckName(UName))
                    {
                        labelErrorOtherAccount.Text = "Введено неккоректное имя " + UName;
                        labelErrorOtherAccount.Visible = true;
                        return false;
                    }
                    else
                    {
                        string[] tmpName = UName.Split(' ');
                        if (tmpName[0].Length > 17)
                        {
                            labelErrorOtherAccount.Text = "Введена слишком длинная фамилия ";
                            labelErrorOtherAccount.Visible = true;
                            return false;
                        }
                        else
                            LAccount.Add(new OtherAccount(UName));
                    }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //создание массива строк - фамилий студентов и их студенческие
        private bool CreateListAccount(List<Student> LAccount)
        {
            string[] StudNameAndStudId;
            char[] splitSym = { '\n', '\r', '\t' };

            StudNameAndStudId = tBListName.Text.Split(splitSym, StringSplitOptions.RemoveEmptyEntries);

            bool even = true;
            if (rBtnEveningTime.Checked) timeEducation = false;
            string tmpStudName = "";
            string tmpGroupNumber = tBGroupOtherAccount.Text;
            decimal tmpYearStudent = dateTimeOtherAccount.Value.Year;
            string tmpStudentId = "";

            foreach (string StudInfo in StudNameAndStudId)
            {
                
                if (even)
                {
                    if (!CheckName(StudInfo))
                    {
                        labelErrorOtherAccount.Text = "Введено неккоректное имя " + StudInfo;
                        labelErrorOtherAccount.Visible = true;
                        return false;
                    }
                    else
                    {
                        string[] tmpName = StudInfo.Split(' ');
                        if (tmpName[0].Length > 17)
                        {
                            labelErrorOtherAccount.Text = "Введена слишком длинная фамилия ";
                            labelErrorOtherAccount.Visible = true;
                            return false;
                        }
                        else
                            tmpStudName = StudInfo;
                        even = false;
                    }
                }
                else
                {
                    try
                    {
                        Int32 tempStId = Convert.ToInt32(StudInfo);
                    }
                    catch
                    {
                        labelErrorOtherAccount.Text = "Введён неккоректный номер студенческого билета " + StudInfo;
                        labelErrorOtherAccount.Visible = true;
                        return false;
                    }
                    tmpStudentId = StudInfo;
                    LAccount.Add(new Student(tmpStudName, tmpGroupNumber, tmpYearStudent, tmpStudentId, timeEducation, OtherAccount.Directory[1]));
                    even = true;
                }

            }
            return true;
        }

        // получение месяца в текстовом представлении
        private string GetMonth(int Month)
        {
            string tmpMonth = "";
            switch (Month)
            {
                case 1:
                    tmpMonth = "jan";
                    break;
                case 2:
                    tmpMonth = "feb";
                    break;
                case 3:
                    tmpMonth = "mar";
                    break;
                case 4:
                    tmpMonth = "apr";
                    break;
                case 5:
                    tmpMonth = "may";
                    break;
                case 6:
                    tmpMonth = "jun";
                    break;
                case 7:
                    tmpMonth = "jul";
                    break;
                case 8:
                    tmpMonth = "aug";
                    break;
                case 9:
                    tmpMonth = "sep";
                    break;
                case 10:
                    tmpMonth = "oct";
                    break;
                case 11:
                    tmpMonth = "nov";
                    break;
                case 12:
                    tmpMonth = "dec";
                    break;
            }
            return tmpMonth;
        }

        // получение даты в текстовом представлении
        private string GetDate()
        {
            Date = dateTimeOtherAccount.Value.Year.ToString();
            Date += "-" + GetMonth(dateTimeOtherAccount.Value.Month) + "-" + dateTimeOtherAccount.Value.Day.ToString();
            return Date;
        }

        // проверка, создался ли пользователь
        private bool CheckCreateLoginInAD(string login)
        {
            ProcessStartInfo psiOpt = new ProcessStartInfo(@"cmd.exe", @"/C dsquery user -samid " + login)
            {
                StandardOutputEncoding = Encoding.GetEncoding(866)
            };
            // настройки окна запущенного процесса
            psiOpt.WindowStyle = ProcessWindowStyle.Hidden;
            psiOpt.RedirectStandardOutput = true;
            psiOpt.UseShellExecute = false;
            psiOpt.CreateNoWindow = true;
            // запускаем процесс
            Process procCommand = Process.Start(psiOpt);
            // получаем ответ запущенного процесса
            StreamReader srIncoming = procCommand.StandardOutput;
            // закрываем процесс
            procCommand.WaitForExit();
            // проверяем результат
            if (srIncoming.Peek() == -1)
                return false;
            else
                return true;            
        }

        // проверка на существование создаваемого логина в active directory, если существуем, генерируем логин_i
        private string CheckLoginInAD(string login)
        {
            bool done = false;
            int i = 0;
            string tmpLogin;

            while (!done)
            {
                ProcessStartInfo psiOpt = new ProcessStartInfo(@"cmd.exe", @"/C dsquery user -samid " + login)
                {
                    StandardOutputEncoding = Encoding.GetEncoding(866)
                };
                // настройки окна запущенного процесса
                psiOpt.WindowStyle = ProcessWindowStyle.Hidden;
                psiOpt.RedirectStandardOutput = true;
                psiOpt.UseShellExecute = false;
                psiOpt.CreateNoWindow = true;
                // запускаем процесс
                Process procCommand = Process.Start(psiOpt);
                // получаем ответ запущенного процесса
                StreamReader srIncoming = procCommand.StandardOutput;
                
                // проверяем результат
                if (srIncoming.Peek() == -1)
                    done = true;
                else
                {
                    //как заменить в строке последние два символа
                    tmpLogin = login;
                    if (i == 0)
                       login += "_" + ++i;
                    else
                    {
                        tmpLogin = login.Remove(login.Length - 1);
                        login = tmpLogin += ++i;
                    }
                    srIncoming.Dispose();
                }

                // закрываем процесс
                procCommand.WaitForExit();
            }
            return login;
        }

        // создание пользователя студента
        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            labelErrorStudent.Visible = false;
            labelErrorStudent.Text = "Неккоректные данные, в поле ";
            if (CheckStudentInfo())
            {
                

                Student student = new Student(tBStudentName.Text, tBGroupNumber.Text, numUpDownYearStudent.Value, tBStudentId.Text, timeEducation, "students");

                student.SetLogin(CheckLoginInAD(student.Login));

                var resultMesBox = MessageBox.Show("Создать пользователя с логином " + student.GetLogin() + "?", "Внимание", MessageBoxButtons.YesNo);
                if (resultMesBox == DialogResult.Yes)
                {
                    File.WriteAllText("CreateUser.cmd", student.GetCreateCMD(), Encoding.GetEncoding(866));
                    Process.Start("CreateUser.cmd");
                    if (!CheckCreateLoginInAD(student.Login))
                        MessageBox.Show("Создан пользователь: " + student.Login + ", пароль: " + student.GetPassword().ToString(), "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("Пользователь не создан: " + student.Login, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            tBStudentName.Text = "";
            tBGroupNumber.Text = "";
            tBStudentId.Text = "";
        }

        // создание пользователя преподавателя
        private void btnCreateLecturer_Click(object sender, EventArgs e)
        {
            labelErrorLecturer.Visible = false;
            labelErrorLecturer.Text = "Неккоректные данные, в поле ";
            if (CheckLecturerInfo())
            {
                Lecturer lecturer = new Lecturer(tBLecturerName.Text, comBChairs.Text);

                lecturer.SetLogin(CheckLoginInAD(lecturer.Login));
                var resultMesBox = MessageBox.Show("Создать пользователя с логином " + lecturer.GetLogin() + "?", "Внимание", MessageBoxButtons.YesNo);
                if (resultMesBox == DialogResult.Yes)
                {
                    File.WriteAllText("CreateUser.cmd", lecturer.GetCreateCMD(), Encoding.GetEncoding(866));
                    Process.Start("CreateUser.cmd");
                    if (!CheckCreateLoginInAD(lecturer.Login))
                        MessageBox.Show("Создан пользователь: " + lecturer.Login + ", пароль: " + lecturer.GetPassword().ToString(), "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("Пользователь не создан: " + lecturer.Login, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            tBLecturerName.Text = "";
            comBChairs.Text = "";
        }

        // создание других аккаунтов
        private void btnCreateOtherAccount_Click(object sender, EventArgs e)
        {
            labelErrorOtherAccount.Visible = false;
            labelErrorOtherAccount.Text = "Неккоректные данные, в поле ";
            OtherAccount.Directory = tBOtherAccountDirectory.Text.Split('\\');
            string FileName = "";
            string AllLoginPass = "";
            string path = "";
            if (CheckOtherAccountInfo())
            {

                if (comBTypeAccount.SelectedIndex != 4 && comBTypeAccount.SelectedIndex != 0)
                {
                    FileName = "AllLoginPass_" + OtherAccount.Directory[2] + ".txt";
                    List<OtherAccount> LAccount = new List<OtherAccount>();

                    if (CreateListAccount(LAccount))
                    {
                        
                        foreach (OtherAccount OA in LAccount)
                        {
                            OA.SetLogin(CheckLoginInAD(OA.Login));

                            File.WriteAllText("CreateUser.cmd", OA.GetCreateCMD(), Encoding.GetEncoding(866));
                            Process crUser = new Process();
                            crUser.StartInfo.FileName = "CreateUser.cmd";
                            crUser.StartInfo.CreateNoWindow = false;
                            crUser.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                            crUser.Start();
                            crUser.WaitForExit();

                            AllLoginPass += OA.Login + " " + OA.GetPassword() + "\n\n";
                        }
                        MessageBox.Show("Пользователи созданы", "Внимание");
                        path = @"C:\Documents and Settings\Administrator\Desktop\" + OtherAccount.Directory[2];
                    }
                 }
                else
                {
                    FileName = "AllLoginPass_" + OtherAccount.Directory[1] + "_" + OtherAccount.Directory[2] + "_" + OtherAccount.Directory[3] + ".txt";
                    List<Student> LStudent = new List<Student>();
                    if (CreateListAccount(LStudent))
                    {
                        foreach (Student St in LStudent)
                        {
                            St.SetLogin(CheckLoginInAD(St.Login));

                            File.WriteAllText("CreateUser.cmd", St.GetCreateCMD(), Encoding.GetEncoding(866));
                            Process crUser = new Process();
                            crUser.StartInfo.FileName = "CreateUser.cmd";
                            crUser.StartInfo.CreateNoWindow = false;
                            crUser.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                            crUser.Start();
                            crUser.WaitForExit();

                            AllLoginPass += St.StudentName + " " + St.Login + " " + St.GetPassword() + "\n\n";
                        }
                        MessageBox.Show("Пользователи созданы", "Внимание");
                        path = @"C:\Documents and Settings\Administrator\Desktop\" + OtherAccount.Directory[1] + "_" + OtherAccount.Directory[2] + "_" + OtherAccount.Directory[3];
                    }
                }
                if (path != "")
                {
                    System.IO.Directory.CreateDirectory(path);
                    //добавление файла в папку
                    path += @"\" + FileName;
                    //File.Create(path);
                    File.WriteAllText(path, AllLoginPass);
                    //открытие папки и выбор созданного файла
                    Process PrFolder = new Process();
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.CreateNoWindow = true;
                    psi.WindowStyle = ProcessWindowStyle.Normal;
                    psi.FileName = "explorer";
                    psi.Arguments = @"/n, /select, " + path;
                    PrFolder.StartInfo = psi;
                    PrFolder.Start();
                }
            }
            tBListName.ForeColor = Color.Gray;
            if (comBTypeAccount.SelectedIndex == 3)
                tBListName.Text = defaultTextListNameStudent;
            else
                tBListName.Text = defaultTextListName;
        }


        private void btnBrowseOtherAccount_Click(object sender, EventArgs e)
        {
            //flagBtnBrowse = true;
            openFileDialogOther.InitialDirectory = "c:\\";
            openFileDialogOther.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialogOther.FilterIndex = 1;
            openFileDialogOther.RestoreDirectory = true;
            openFileDialogOther.Title = "Выберите файл со списком пользователей";

            if (openFileDialogOther.ShowDialog() == DialogResult.OK)
            {
                tBFileDirectory.Text = openFileDialogOther.FileName;

                if (".txt" != System.IO.Path.GetExtension(openFileDialogOther.FileName))
                    MessageBox.Show("Неверно указан файл");
                else
                {
                    tBListName.ForeColor = Color.Black;
                    tBListName.Text = "";
                    tBListName.Text = System.IO.File.ReadAllText(openFileDialogOther.FileName, Encoding.GetEncoding(1251));
                }  
            }
        }


        private void dateTimeOtherAccount_ValueChanged(object sender, EventArgs e)
        {
            if (comBTypeAccount.SelectedIndex != 3)
                tBOtherAccountDirectory.Text = Directory + @"\" + AccountType + @"\" + AccountType.Remove(AccountType.Length - 1) + "-" + GetDate() + @"\";
            else
                if (tBGroupOtherAccount.Text == "")
                    tBOtherAccountDirectory.Text = Directory + @"\" + AccountType + @"\" + dateTimeOtherAccount.Value.Year + @"\" + tBGroupOtherAccount.Text;
                else
                    tBOtherAccountDirectory.Text = Directory + @"\" + AccountType + @"\" + dateTimeOtherAccount.Value.Year + @"\" + tBGroupOtherAccount.Text + OATimeEducation;
        }


        private void tBPrefixOtherAccount_Enter(object sender, EventArgs e)
        {
            if (tBPrefixOtherAccount.ForeColor == Color.Gray)
            {
                tBPrefixOtherAccount.Text = "";
                tBPrefixOtherAccount.ForeColor = Color.Black;
            }
            
        }

        private void tBPrefixOtherAccount_TextChanged(object sender, EventArgs e)
        {
            if (tBPrefixOtherAccount.Text != defaultTextPrefix)
                tBLoginOtherAccount.Text = tBPrefixOtherAccount.Text + "_" + Login;
            else
                tBLoginOtherAccount.Text = Login;

        }


        private void tPStudent_Enter(object sender, EventArgs e)
        {
            Size = new Size(441, 273);
            tBStudentName.Select();
        }

        private void tPLecturer_Enter(object sender, EventArgs e)
        {
            Size = new Size(441, 273);
            tBLecturerName.Select();  
        }

        private void tPAbout_Enter(object sender, EventArgs e)
        {
            Size = new Size(441, 273);
        }

        private void tPOther_Enter(object sender, EventArgs e)
        {
            Size = new Size(441, 472);
            tBFileDirectory.ReadOnly = false;
            btnBrowseOtherAccount.Enabled = true;

            labelOtherAccountGroup.Visible = false;
            tBGroupOtherAccount.Visible = false;
            rBOtherAccountDayTime.Visible = false;
            rBOtherAccountEveningTime.Visible = false;

            Date = dateTimeOtherAccount.Value.Year.ToString();
            Date += "-" + GetMonth(dateTimeOtherAccount.Value.Month) + "-" + dateTimeOtherAccount.Value.Day.ToString();

            tBOtherAccountDirectory.Text = Directory + @"\" + AccountType + @"\" + Date + @"\";
        }

        private void tBListName_Enter(object sender, EventArgs e)
        {
            if (tBListName.Text == defaultTextListName || tBListName.Text == defaultTextListNameStudent)
            {
                tBListName.ForeColor = Color.Black;
                tBListName.Text = "";
            }
        }

        private void tBListName_Leave(object sender, EventArgs e)
        {
            if (tBListName.Text == "")
            {
                tBListName.ForeColor = Color.Gray;
                if (comBTypeAccount.SelectedIndex == 3)
                    tBListName.Text = defaultTextListNameStudent;
                else
                    tBListName.Text = defaultTextListName;
            }
        }

        private void tBFileDirectory_Enter(object sender, EventArgs e)
        {
            if (!tBFileDirectory.ReadOnly && tBFileDirectory.ForeColor == Color.Gray && tBFileDirectory.Text == defaultTextFileDirectory)
            {
                tBFileDirectory.Text = "";
                tBFileDirectory.ForeColor = Color.Black;
            }
            else
                if (!tBFileDirectory.ReadOnly && tBFileDirectory.Text != defaultTextFileDirectory)
                tBFileDirectory.ForeColor = Color.Black;
        }

        private void tBFileDirectory_Leave(object sender, EventArgs e)
        {
            if (tBFileDirectory.Text == "")
            {
                tBFileDirectory.ForeColor = Color.Gray;
                tBFileDirectory.Text = defaultTextFileDirectory;
            }
        }

        private void tBPrefixOtherAccount_Leave(object sender, EventArgs e)
        {
            if (tBPrefixOtherAccount.Text == "")
            {
                tBPrefixOtherAccount.ForeColor = Color.Gray;
                tBPrefixOtherAccount.Text = defaultTextPrefix;
            }

        }

        private void comBTypeAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comBTypeAccount.SelectedIndex)
            {
                case 0:
                        AccountType = "second";
                    break;
                case 1 : AccountType = "geks";
                    break;
                case 2 : AccountType = "olympiads";
                    break;
                case 3 : AccountType = "external";
                    break;
                case 4 : AccountType = "students";
                    break;
            }
            tBOtherAccountDirectory.Text = "";
            if (comBTypeAccount.SelectedIndex == 4 || comBTypeAccount.SelectedIndex == 0)
            {
                if (tBGroupOtherAccount.Text == "")
                    tBOtherAccountDirectory.Text = Directory + @"\" + AccountType + @"\" + dateTimeOtherAccount.Value.Year +  @"\" + tBGroupOtherAccount.Text;
                else
                    tBOtherAccountDirectory.Text = Directory + @"\" + AccountType + @"\" + dateTimeOtherAccount.Value.Year + @"\" + tBGroupOtherAccount.Text + OATimeEducation;
                labelOtherAccountGroup.Visible = true;
                tBGroupOtherAccount.Visible = true;
                rBOtherAccountDayTime.Visible = true;
                rBOtherAccountEveningTime.Visible = true;
                labelOtherAccountLogin.Visible = false;
                labelOtherAccountPrefix.Visible = false;
                tBPrefixOtherAccount.Visible = false;
                tBLoginOtherAccount.Visible = false;
                tBListName.Text = defaultTextListNameStudent;
                tBListName.ForeColor = Color.Gray;
            }
            else
            {
                tBOtherAccountDirectory.Text = Directory + @"\" + AccountType + @"\" + AccountType.Remove(3) + "-" + GetDate() + @"\";

                labelOtherAccountGroup.Visible = false;
                tBGroupOtherAccount.Visible = false;
                rBOtherAccountDayTime.Visible = false;
                rBOtherAccountEveningTime.Visible = false;
                labelOtherAccountLogin.Visible = true;
                labelOtherAccountPrefix.Visible = true;
                tBPrefixOtherAccount.Visible = true;
                tBLoginOtherAccount.Visible = true;
                tBListName.Text = defaultTextListName;
                tBListName.ForeColor = Color.Gray;
            }
                
        }

        private void tBGroupOtherAccount_TextChanged(object sender, EventArgs e)
        {
            if (tBGroupOtherAccount.Text != "")
                tBOtherAccountDirectory.Text = Directory + @"\" + AccountType + @"\" + dateTimeOtherAccount.Value.Year + @"\" + tBGroupOtherAccount.Text + OATimeEducation;
            else
                tBOtherAccountDirectory.Text = Directory + @"\" + AccountType + @"\" + dateTimeOtherAccount.Value.Year + @"\" + tBGroupOtherAccount.Text;
        }

        private void rBOtherAccountDayTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rBOtherAccountEveningTime.Checked)
                OATimeEducation = "vgr";
            else
                OATimeEducation = "gr";
            if (tBGroupOtherAccount.Text != "")
                tBOtherAccountDirectory.Text = Directory + @"\" + AccountType + @"\" + dateTimeOtherAccount.Value.Year + @"\" + tBGroupOtherAccount.Text + OATimeEducation;
        }

    }
}
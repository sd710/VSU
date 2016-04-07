namespace CreateUserForWinServer
{
    partial class MainFormCreateUser
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormCreateUser));
            this.tCCreateUser = new System.Windows.Forms.TabControl();
            this.tPStudent = new System.Windows.Forms.TabPage();
            this.rBtnEveningTime = new System.Windows.Forms.RadioButton();
            this.rBtnDayTime = new System.Windows.Forms.RadioButton();
            this.numUpDownYearStudent = new System.Windows.Forms.NumericUpDown();
            this.labelErrorStudent = new System.Windows.Forms.Label();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.tBStudentId = new System.Windows.Forms.TextBox();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.tBGroupNumber = new System.Windows.Forms.TextBox();
            this.labelGroupNumber = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.tBStudentName = new System.Windows.Forms.TextBox();
            this.tPLecturer = new System.Windows.Forms.TabPage();
            this.labelErrorLecturer = new System.Windows.Forms.Label();
            this.btnCreateLecturer = new System.Windows.Forms.Button();
            this.comBChairs = new System.Windows.Forms.ComboBox();
            this.labelChair = new System.Windows.Forms.Label();
            this.tBLecturerName = new System.Windows.Forms.TextBox();
            this.labelLecturerName = new System.Windows.Forms.Label();
            this.tPOther = new System.Windows.Forms.TabPage();
            this.rBOtherAccountEveningTime = new System.Windows.Forms.RadioButton();
            this.rBOtherAccountDayTime = new System.Windows.Forms.RadioButton();
            this.tBGroupOtherAccount = new System.Windows.Forms.TextBox();
            this.labelOtherAccountGroup = new System.Windows.Forms.Label();
            this.tBListName = new System.Windows.Forms.TextBox();
            this.labelErrorOtherAccount = new System.Windows.Forms.Label();
            this.tBLoginOtherAccount = new System.Windows.Forms.TextBox();
            this.labelOtherAccountLogin = new System.Windows.Forms.Label();
            this.tBPrefixOtherAccount = new System.Windows.Forms.TextBox();
            this.labelOtherAccountPrefix = new System.Windows.Forms.Label();
            this.tBOtherAccountDirectory = new System.Windows.Forms.TextBox();
            this.labelDirectoryOtherAccount = new System.Windows.Forms.Label();
            this.btnCreateOtherAccount = new System.Windows.Forms.Button();
            this.dateTimeOtherAccount = new System.Windows.Forms.DateTimePicker();
            this.labelDateOtherAccount = new System.Windows.Forms.Label();
            this.labelTypeAccount = new System.Windows.Forms.Label();
            this.comBTypeAccount = new System.Windows.Forms.ComboBox();
            this.btnBrowseOtherAccount = new System.Windows.Forms.Button();
            this.tBFileDirectory = new System.Windows.Forms.TextBox();
            this.tPAbout = new System.Windows.Forms.TabPage();
            this.rTBAbout = new System.Windows.Forms.RichTextBox();
            this.openFileDialogOther = new System.Windows.Forms.OpenFileDialog();
            this.tCCreateUser.SuspendLayout();
            this.tPStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownYearStudent)).BeginInit();
            this.tPLecturer.SuspendLayout();
            this.tPOther.SuspendLayout();
            this.tPAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCCreateUser
            // 
            this.tCCreateUser.Controls.Add(this.tPStudent);
            this.tCCreateUser.Controls.Add(this.tPLecturer);
            this.tCCreateUser.Controls.Add(this.tPOther);
            this.tCCreateUser.Controls.Add(this.tPAbout);
            this.tCCreateUser.Location = new System.Drawing.Point(0, 0);
            this.tCCreateUser.Name = "tCCreateUser";
            this.tCCreateUser.SelectedIndex = 0;
            this.tCCreateUser.Size = new System.Drawing.Size(429, 436);
            this.tCCreateUser.TabIndex = 0;
            this.tCCreateUser.TabStop = false;
            // 
            // tPStudent
            // 
            this.tPStudent.Controls.Add(this.rBtnEveningTime);
            this.tPStudent.Controls.Add(this.rBtnDayTime);
            this.tPStudent.Controls.Add(this.numUpDownYearStudent);
            this.tPStudent.Controls.Add(this.labelErrorStudent);
            this.tPStudent.Controls.Add(this.btnCreateStudent);
            this.tPStudent.Controls.Add(this.tBStudentId);
            this.tPStudent.Controls.Add(this.labelStudentId);
            this.tPStudent.Controls.Add(this.labelYear);
            this.tPStudent.Controls.Add(this.tBGroupNumber);
            this.tPStudent.Controls.Add(this.labelGroupNumber);
            this.tPStudent.Controls.Add(this.labelStudentName);
            this.tPStudent.Controls.Add(this.tBStudentName);
            this.tPStudent.Location = new System.Drawing.Point(4, 22);
            this.tPStudent.Name = "tPStudent";
            this.tPStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tPStudent.Size = new System.Drawing.Size(421, 410);
            this.tPStudent.TabIndex = 0;
            this.tPStudent.Text = "Студент";
            this.tPStudent.UseVisualStyleBackColor = true;
            this.tPStudent.Enter += new System.EventHandler(this.tPStudent_Enter);
            // 
            // rBtnEveningTime
            // 
            this.rBtnEveningTime.AutoSize = true;
            this.rBtnEveningTime.Location = new System.Drawing.Point(280, 57);
            this.rBtnEveningTime.Name = "rBtnEveningTime";
            this.rBtnEveningTime.Size = new System.Drawing.Size(129, 17);
            this.rBtnEveningTime.TabIndex = 3;
            this.rBtnEveningTime.TabStop = true;
            this.rBtnEveningTime.Text = "Вечернее отделение";
            this.rBtnEveningTime.UseVisualStyleBackColor = true;
            // 
            // rBtnDayTime
            // 
            this.rBtnDayTime.AutoSize = true;
            this.rBtnDayTime.Checked = true;
            this.rBtnDayTime.Location = new System.Drawing.Point(143, 57);
            this.rBtnDayTime.Name = "rBtnDayTime";
            this.rBtnDayTime.Size = new System.Drawing.Size(126, 17);
            this.rBtnDayTime.TabIndex = 2;
            this.rBtnDayTime.TabStop = true;
            this.rBtnDayTime.Text = "Дневное отделение";
            this.rBtnDayTime.UseVisualStyleBackColor = true;
            // 
            // numUpDownYearStudent
            // 
            this.numUpDownYearStudent.Location = new System.Drawing.Point(106, 96);
            this.numUpDownYearStudent.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numUpDownYearStudent.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numUpDownYearStudent.Name = "numUpDownYearStudent";
            this.numUpDownYearStudent.ReadOnly = true;
            this.numUpDownYearStudent.Size = new System.Drawing.Size(68, 20);
            this.numUpDownYearStudent.TabIndex = 4;
            this.numUpDownYearStudent.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // labelErrorStudent
            // 
            this.labelErrorStudent.AutoSize = true;
            this.labelErrorStudent.ForeColor = System.Drawing.Color.Red;
            this.labelErrorStudent.Location = new System.Drawing.Point(9, 182);
            this.labelErrorStudent.Name = "labelErrorStudent";
            this.labelErrorStudent.Size = new System.Drawing.Size(165, 13);
            this.labelErrorStudent.TabIndex = 9;
            this.labelErrorStudent.Text = "Неккоректные данные, в поле ";
            this.labelErrorStudent.Visible = false;
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Location = new System.Drawing.Point(334, 177);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(75, 23);
            this.btnCreateStudent.TabIndex = 6;
            this.btnCreateStudent.Text = "Создать";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // tBStudentId
            // 
            this.tBStudentId.Location = new System.Drawing.Point(147, 132);
            this.tBStudentId.Name = "tBStudentId";
            this.tBStudentId.Size = new System.Drawing.Size(100, 20);
            this.tBStudentId.TabIndex = 5;
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Location = new System.Drawing.Point(8, 135);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(133, 13);
            this.labelStudentId.TabIndex = 6;
            this.labelStudentId.Text = "№ студенческого билета";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(8, 98);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(92, 13);
            this.labelYear.TabIndex = 4;
            this.labelYear.Text = "Год поступления";
            // 
            // tBGroupNumber
            // 
            this.tBGroupNumber.Location = new System.Drawing.Point(56, 57);
            this.tBGroupNumber.Name = "tBGroupNumber";
            this.tBGroupNumber.Size = new System.Drawing.Size(49, 20);
            this.tBGroupNumber.TabIndex = 1;
            // 
            // labelGroupNumber
            // 
            this.labelGroupNumber.AutoSize = true;
            this.labelGroupNumber.Location = new System.Drawing.Point(8, 57);
            this.labelGroupNumber.Name = "labelGroupNumber";
            this.labelGroupNumber.Size = new System.Drawing.Size(42, 13);
            this.labelGroupNumber.TabIndex = 2;
            this.labelGroupNumber.Text = "Группа";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(3, 23);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(125, 13);
            this.labelStudentName.TabIndex = 0;
            this.labelStudentName.Text = "Фамлия Имя Отчество";
            // 
            // tBStudentName
            // 
            this.tBStudentName.Location = new System.Drawing.Point(134, 20);
            this.tBStudentName.Name = "tBStudentName";
            this.tBStudentName.Size = new System.Drawing.Size(275, 20);
            this.tBStudentName.TabIndex = 0;
            // 
            // tPLecturer
            // 
            this.tPLecturer.Controls.Add(this.labelErrorLecturer);
            this.tPLecturer.Controls.Add(this.btnCreateLecturer);
            this.tPLecturer.Controls.Add(this.comBChairs);
            this.tPLecturer.Controls.Add(this.labelChair);
            this.tPLecturer.Controls.Add(this.tBLecturerName);
            this.tPLecturer.Controls.Add(this.labelLecturerName);
            this.tPLecturer.Location = new System.Drawing.Point(4, 22);
            this.tPLecturer.Name = "tPLecturer";
            this.tPLecturer.Padding = new System.Windows.Forms.Padding(3);
            this.tPLecturer.Size = new System.Drawing.Size(421, 410);
            this.tPLecturer.TabIndex = 1;
            this.tPLecturer.Text = "Преподаватель";
            this.tPLecturer.UseVisualStyleBackColor = true;
            this.tPLecturer.Enter += new System.EventHandler(this.tPLecturer_Enter);
            // 
            // labelErrorLecturer
            // 
            this.labelErrorLecturer.AutoSize = true;
            this.labelErrorLecturer.ForeColor = System.Drawing.Color.Red;
            this.labelErrorLecturer.Location = new System.Drawing.Point(8, 177);
            this.labelErrorLecturer.Name = "labelErrorLecturer";
            this.labelErrorLecturer.Size = new System.Drawing.Size(165, 13);
            this.labelErrorLecturer.TabIndex = 7;
            this.labelErrorLecturer.Text = "Неккоректные данные, в поле ";
            this.labelErrorLecturer.Visible = false;
            // 
            // btnCreateLecturer
            // 
            this.btnCreateLecturer.Location = new System.Drawing.Point(334, 177);
            this.btnCreateLecturer.Name = "btnCreateLecturer";
            this.btnCreateLecturer.Size = new System.Drawing.Size(75, 23);
            this.btnCreateLecturer.TabIndex = 2;
            this.btnCreateLecturer.Text = "Создать";
            this.btnCreateLecturer.UseVisualStyleBackColor = true;
            this.btnCreateLecturer.Click += new System.EventHandler(this.btnCreateLecturer_Click);
            // 
            // comBChairs
            // 
            this.comBChairs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBChairs.FormattingEnabled = true;
            this.comBChairs.Items.AddRange(new object[] {
            "ВМиПИТ",
            "МиПа",
            "ММИО",
            "МО ЭВМ",
            "НК",
            "ПОиАИС",
            "ТКиАР",
            "ТПМ",
            "T-Systems"});
            this.comBChairs.Location = new System.Drawing.Point(66, 54);
            this.comBChairs.MaxDropDownItems = 9;
            this.comBChairs.Name = "comBChairs";
            this.comBChairs.Size = new System.Drawing.Size(121, 21);
            this.comBChairs.TabIndex = 1;
            // 
            // labelChair
            // 
            this.labelChair.AutoSize = true;
            this.labelChair.Location = new System.Drawing.Point(8, 57);
            this.labelChair.Name = "labelChair";
            this.labelChair.Size = new System.Drawing.Size(52, 13);
            this.labelChair.TabIndex = 4;
            this.labelChair.Text = "Кафедра";
            // 
            // tBLecturerName
            // 
            this.tBLecturerName.Location = new System.Drawing.Point(134, 20);
            this.tBLecturerName.Name = "tBLecturerName";
            this.tBLecturerName.Size = new System.Drawing.Size(275, 20);
            this.tBLecturerName.TabIndex = 0;
            // 
            // labelLecturerName
            // 
            this.labelLecturerName.AutoSize = true;
            this.labelLecturerName.Location = new System.Drawing.Point(3, 23);
            this.labelLecturerName.Name = "labelLecturerName";
            this.labelLecturerName.Size = new System.Drawing.Size(131, 13);
            this.labelLecturerName.TabIndex = 2;
            this.labelLecturerName.Text = "Фамилия Имя Отчество";
            // 
            // tPOther
            // 
            this.tPOther.Controls.Add(this.rBOtherAccountEveningTime);
            this.tPOther.Controls.Add(this.rBOtherAccountDayTime);
            this.tPOther.Controls.Add(this.tBGroupOtherAccount);
            this.tPOther.Controls.Add(this.labelOtherAccountGroup);
            this.tPOther.Controls.Add(this.tBListName);
            this.tPOther.Controls.Add(this.labelErrorOtherAccount);
            this.tPOther.Controls.Add(this.tBLoginOtherAccount);
            this.tPOther.Controls.Add(this.labelOtherAccountLogin);
            this.tPOther.Controls.Add(this.tBPrefixOtherAccount);
            this.tPOther.Controls.Add(this.labelOtherAccountPrefix);
            this.tPOther.Controls.Add(this.tBOtherAccountDirectory);
            this.tPOther.Controls.Add(this.labelDirectoryOtherAccount);
            this.tPOther.Controls.Add(this.btnCreateOtherAccount);
            this.tPOther.Controls.Add(this.dateTimeOtherAccount);
            this.tPOther.Controls.Add(this.labelDateOtherAccount);
            this.tPOther.Controls.Add(this.labelTypeAccount);
            this.tPOther.Controls.Add(this.comBTypeAccount);
            this.tPOther.Controls.Add(this.btnBrowseOtherAccount);
            this.tPOther.Controls.Add(this.tBFileDirectory);
            this.tPOther.Location = new System.Drawing.Point(4, 22);
            this.tPOther.Name = "tPOther";
            this.tPOther.Size = new System.Drawing.Size(421, 410);
            this.tPOther.TabIndex = 2;
            this.tPOther.Text = "Разное";
            this.tPOther.UseVisualStyleBackColor = true;
            this.tPOther.Enter += new System.EventHandler(this.tPOther_Enter);
            // 
            // rBOtherAccountEveningTime
            // 
            this.rBOtherAccountEveningTime.AutoSize = true;
            this.rBOtherAccountEveningTime.Checked = true;
            this.rBOtherAccountEveningTime.Location = new System.Drawing.Point(270, 72);
            this.rBOtherAccountEveningTime.Name = "rBOtherAccountEveningTime";
            this.rBOtherAccountEveningTime.Size = new System.Drawing.Size(129, 17);
            this.rBOtherAccountEveningTime.TabIndex = 8;
            this.rBOtherAccountEveningTime.TabStop = true;
            this.rBOtherAccountEveningTime.Text = "Вечернее отделение";
            this.rBOtherAccountEveningTime.UseVisualStyleBackColor = true;
            // 
            // rBOtherAccountDayTime
            // 
            this.rBOtherAccountDayTime.AutoSize = true;
            this.rBOtherAccountDayTime.Checked = true;
            this.rBOtherAccountDayTime.Location = new System.Drawing.Point(138, 72);
            this.rBOtherAccountDayTime.Name = "rBOtherAccountDayTime";
            this.rBOtherAccountDayTime.Size = new System.Drawing.Size(126, 17);
            this.rBOtherAccountDayTime.TabIndex = 7;
            this.rBOtherAccountDayTime.TabStop = true;
            this.rBOtherAccountDayTime.Text = "Дневное отделение";
            this.rBOtherAccountDayTime.UseVisualStyleBackColor = true;
            this.rBOtherAccountDayTime.CheckedChanged += new System.EventHandler(this.rBOtherAccountDayTime_CheckedChanged);
            // 
            // tBGroupOtherAccount
            // 
            this.tBGroupOtherAccount.Location = new System.Drawing.Point(56, 71);
            this.tBGroupOtherAccount.Name = "tBGroupOtherAccount";
            this.tBGroupOtherAccount.Size = new System.Drawing.Size(60, 20);
            this.tBGroupOtherAccount.TabIndex = 4;
            this.tBGroupOtherAccount.TextChanged += new System.EventHandler(this.tBGroupOtherAccount_TextChanged);
            // 
            // labelOtherAccountGroup
            // 
            this.labelOtherAccountGroup.AutoSize = true;
            this.labelOtherAccountGroup.Location = new System.Drawing.Point(8, 74);
            this.labelOtherAccountGroup.Name = "labelOtherAccountGroup";
            this.labelOtherAccountGroup.Size = new System.Drawing.Size(42, 13);
            this.labelOtherAccountGroup.TabIndex = 16;
            this.labelOtherAccountGroup.Text = "Группа";
            // 
            // tBListName
            // 
            this.tBListName.ForeColor = System.Drawing.Color.Gray;
            this.tBListName.Location = new System.Drawing.Point(11, 107);
            this.tBListName.Multiline = true;
            this.tBListName.Name = "tBListName";
            this.tBListName.Size = new System.Drawing.Size(398, 226);
            this.tBListName.TabIndex = 9;
            this.tBListName.Text = "<список студентов для создания пользователей>";
            this.tBListName.Enter += new System.EventHandler(this.tBListName_Enter);
            this.tBListName.Leave += new System.EventHandler(this.tBListName_Leave);
            // 
            // labelErrorOtherAccount
            // 
            this.labelErrorOtherAccount.AutoSize = true;
            this.labelErrorOtherAccount.ForeColor = System.Drawing.Color.Red;
            this.labelErrorOtherAccount.Location = new System.Drawing.Point(8, 376);
            this.labelErrorOtherAccount.Name = "labelErrorOtherAccount";
            this.labelErrorOtherAccount.Size = new System.Drawing.Size(165, 13);
            this.labelErrorOtherAccount.TabIndex = 15;
            this.labelErrorOtherAccount.Text = "Неккоректные данные, в поле ";
            this.labelErrorOtherAccount.Visible = false;
            // 
            // tBLoginOtherAccount
            // 
            this.tBLoginOtherAccount.Location = new System.Drawing.Point(234, 71);
            this.tBLoginOtherAccount.Name = "tBLoginOtherAccount";
            this.tBLoginOtherAccount.Size = new System.Drawing.Size(175, 20);
            this.tBLoginOtherAccount.TabIndex = 5;
            // 
            // labelOtherAccountLogin
            // 
            this.labelOtherAccountLogin.AutoSize = true;
            this.labelOtherAccountLogin.Location = new System.Drawing.Point(190, 74);
            this.labelOtherAccountLogin.Name = "labelOtherAccountLogin";
            this.labelOtherAccountLogin.Size = new System.Drawing.Size(38, 13);
            this.labelOtherAccountLogin.TabIndex = 13;
            this.labelOtherAccountLogin.Text = "Логин";
            // 
            // tBPrefixOtherAccount
            // 
            this.tBPrefixOtherAccount.ForeColor = System.Drawing.Color.Gray;
            this.tBPrefixOtherAccount.Location = new System.Drawing.Point(59, 71);
            this.tBPrefixOtherAccount.Name = "tBPrefixOtherAccount";
            this.tBPrefixOtherAccount.Size = new System.Drawing.Size(125, 20);
            this.tBPrefixOtherAccount.TabIndex = 3;
            this.tBPrefixOtherAccount.Text = "<Введите, если нужно>";
            this.tBPrefixOtherAccount.TextChanged += new System.EventHandler(this.tBPrefixOtherAccount_TextChanged);
            this.tBPrefixOtherAccount.Enter += new System.EventHandler(this.tBPrefixOtherAccount_Enter);
            this.tBPrefixOtherAccount.Leave += new System.EventHandler(this.tBPrefixOtherAccount_Leave);
            // 
            // labelOtherAccountPrefix
            // 
            this.labelOtherAccountPrefix.AutoSize = true;
            this.labelOtherAccountPrefix.Location = new System.Drawing.Point(8, 74);
            this.labelOtherAccountPrefix.Name = "labelOtherAccountPrefix";
            this.labelOtherAccountPrefix.Size = new System.Drawing.Size(53, 13);
            this.labelOtherAccountPrefix.TabIndex = 11;
            this.labelOtherAccountPrefix.Text = "Префикс";
            // 
            // tBOtherAccountDirectory
            // 
            this.tBOtherAccountDirectory.Location = new System.Drawing.Point(138, 40);
            this.tBOtherAccountDirectory.Name = "tBOtherAccountDirectory";
            this.tBOtherAccountDirectory.Size = new System.Drawing.Size(271, 20);
            this.tBOtherAccountDirectory.TabIndex = 2;
            // 
            // labelDirectoryOtherAccount
            // 
            this.labelDirectoryOtherAccount.AutoSize = true;
            this.labelDirectoryOtherAccount.Location = new System.Drawing.Point(8, 45);
            this.labelDirectoryOtherAccount.Name = "labelDirectoryOtherAccount";
            this.labelDirectoryOtherAccount.Size = new System.Drawing.Size(124, 13);
            this.labelDirectoryOtherAccount.TabIndex = 9;
            this.labelDirectoryOtherAccount.Text = "Директория аккаунтов";
            // 
            // btnCreateOtherAccount
            // 
            this.btnCreateOtherAccount.Location = new System.Drawing.Point(334, 371);
            this.btnCreateOtherAccount.Name = "btnCreateOtherAccount";
            this.btnCreateOtherAccount.Size = new System.Drawing.Size(75, 23);
            this.btnCreateOtherAccount.TabIndex = 12;
            this.btnCreateOtherAccount.Text = "Создать";
            this.btnCreateOtherAccount.UseVisualStyleBackColor = true;
            this.btnCreateOtherAccount.Click += new System.EventHandler(this.btnCreateOtherAccount_Click);
            // 
            // dateTimeOtherAccount
            // 
            this.dateTimeOtherAccount.Location = new System.Drawing.Point(258, 14);
            this.dateTimeOtherAccount.Name = "dateTimeOtherAccount";
            this.dateTimeOtherAccount.Size = new System.Drawing.Size(151, 20);
            this.dateTimeOtherAccount.TabIndex = 1;
            this.dateTimeOtherAccount.ValueChanged += new System.EventHandler(this.dateTimeOtherAccount_ValueChanged);
            // 
            // labelDateOtherAccount
            // 
            this.labelDateOtherAccount.AutoSize = true;
            this.labelDateOtherAccount.Location = new System.Drawing.Point(219, 17);
            this.labelDateOtherAccount.Name = "labelDateOtherAccount";
            this.labelDateOtherAccount.Size = new System.Drawing.Size(33, 13);
            this.labelDateOtherAccount.TabIndex = 5;
            this.labelDateOtherAccount.Text = "Дата";
            // 
            // labelTypeAccount
            // 
            this.labelTypeAccount.AutoSize = true;
            this.labelTypeAccount.Location = new System.Drawing.Point(8, 17);
            this.labelTypeAccount.Name = "labelTypeAccount";
            this.labelTypeAccount.Size = new System.Drawing.Size(26, 13);
            this.labelTypeAccount.TabIndex = 4;
            this.labelTypeAccount.Text = "Тип";
            // 
            // comBTypeAccount
            // 
            this.comBTypeAccount.BackColor = System.Drawing.SystemColors.Window;
            this.comBTypeAccount.DisplayMember = "Государственный экзамен";
            this.comBTypeAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBTypeAccount.ForeColor = System.Drawing.Color.Black;
            this.comBTypeAccount.FormattingEnabled = true;
            this.comBTypeAccount.Items.AddRange(new object[] {
            "Второе Высшее",
            "Государственный экзамен",
            "Олимпиада",
            "Разное",
            "Студенты"});
            this.comBTypeAccount.Location = new System.Drawing.Point(41, 14);
            this.comBTypeAccount.Name = "comBTypeAccount";
            this.comBTypeAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comBTypeAccount.Size = new System.Drawing.Size(173, 21);
            this.comBTypeAccount.Sorted = true;
            this.comBTypeAccount.TabIndex = 0;
            this.comBTypeAccount.ValueMember = "Items";
            this.comBTypeAccount.SelectedIndexChanged += new System.EventHandler(this.comBTypeAccount_SelectedIndexChanged);
            // 
            // btnBrowseOtherAccount
            // 
            this.btnBrowseOtherAccount.Location = new System.Drawing.Point(334, 339);
            this.btnBrowseOtherAccount.Name = "btnBrowseOtherAccount";
            this.btnBrowseOtherAccount.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOtherAccount.TabIndex = 11;
            this.btnBrowseOtherAccount.Text = "Обзор";
            this.btnBrowseOtherAccount.UseVisualStyleBackColor = true;
            this.btnBrowseOtherAccount.Click += new System.EventHandler(this.btnBrowseOtherAccount_Click);
            // 
            // tBFileDirectory
            // 
            this.tBFileDirectory.BackColor = System.Drawing.Color.White;
            this.tBFileDirectory.ForeColor = System.Drawing.Color.Gray;
            this.tBFileDirectory.Location = new System.Drawing.Point(11, 339);
            this.tBFileDirectory.Name = "tBFileDirectory";
            this.tBFileDirectory.ReadOnly = true;
            this.tBFileDirectory.Size = new System.Drawing.Size(307, 20);
            this.tBFileDirectory.TabIndex = 10;
            this.tBFileDirectory.Text = "Укажите файл со списком пользователей";
            this.tBFileDirectory.Enter += new System.EventHandler(this.tBFileDirectory_Enter);
            this.tBFileDirectory.Leave += new System.EventHandler(this.tBFileDirectory_Leave);
            // 
            // tPAbout
            // 
            this.tPAbout.Controls.Add(this.rTBAbout);
            this.tPAbout.Location = new System.Drawing.Point(4, 22);
            this.tPAbout.Name = "tPAbout";
            this.tPAbout.Size = new System.Drawing.Size(421, 410);
            this.tPAbout.TabIndex = 3;
            this.tPAbout.Text = "About";
            this.tPAbout.UseVisualStyleBackColor = true;
            this.tPAbout.Enter += new System.EventHandler(this.tPAbout_Enter);
            // 
            // rTBAbout
            // 
            this.rTBAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTBAbout.BulletIndent = 2;
            this.rTBAbout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rTBAbout.Location = new System.Drawing.Point(0, 3);
            this.rTBAbout.Name = "rTBAbout";
            this.rTBAbout.ReadOnly = true;
            this.rTBAbout.Size = new System.Drawing.Size(421, 212);
            this.rTBAbout.TabIndex = 0;
            this.rTBAbout.Text = resources.GetString("rTBAbout.Text");
            // 
            // openFileDialogOther
            // 
            this.openFileDialogOther.FileName = "txt file";
            // 
            // MainFormCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 433);
            this.Controls.Add(this.tCCreateUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(441, 472);
            this.MinimumSize = new System.Drawing.Size(441, 273);
            this.Name = "MainFormCreateUser";
            this.Text = "Create User";
            this.tCCreateUser.ResumeLayout(false);
            this.tPStudent.ResumeLayout(false);
            this.tPStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownYearStudent)).EndInit();
            this.tPLecturer.ResumeLayout(false);
            this.tPLecturer.PerformLayout();
            this.tPOther.ResumeLayout(false);
            this.tPOther.PerformLayout();
            this.tPAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tCCreateUser;
        private System.Windows.Forms.TabPage tPStudent;
        private System.Windows.Forms.TextBox tBStudentId;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox tBGroupNumber;
        private System.Windows.Forms.Label labelGroupNumber;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.TextBox tBStudentName;
        private System.Windows.Forms.TabPage tPLecturer;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.TabPage tPOther;
        private System.Windows.Forms.Label labelErrorStudent;
        private System.Windows.Forms.NumericUpDown numUpDownYearStudent;
        private System.Windows.Forms.ComboBox comBChairs;
        private System.Windows.Forms.Label labelChair;
        private System.Windows.Forms.TextBox tBLecturerName;
        private System.Windows.Forms.Label labelLecturerName;
        private System.Windows.Forms.Button btnCreateLecturer;
        private System.Windows.Forms.Label labelErrorLecturer;
        private System.Windows.Forms.RadioButton rBtnEveningTime;
        private System.Windows.Forms.RadioButton rBtnDayTime;
        private System.Windows.Forms.OpenFileDialog openFileDialogOther;
        private System.Windows.Forms.Button btnBrowseOtherAccount;
        private System.Windows.Forms.TextBox tBFileDirectory;
        private System.Windows.Forms.ComboBox comBTypeAccount;
        private System.Windows.Forms.Label labelTypeAccount;
        private System.Windows.Forms.Label labelDateOtherAccount;
        private System.Windows.Forms.DateTimePicker dateTimeOtherAccount;
        private System.Windows.Forms.Button btnCreateOtherAccount;
        private System.Windows.Forms.Label labelDirectoryOtherAccount;
        private System.Windows.Forms.TextBox tBOtherAccountDirectory;
        private System.Windows.Forms.Label labelOtherAccountPrefix;
        private System.Windows.Forms.Label labelOtherAccountLogin;
        private System.Windows.Forms.TextBox tBPrefixOtherAccount;
        private System.Windows.Forms.TextBox tBLoginOtherAccount;
        private System.Windows.Forms.Label labelErrorOtherAccount;
        private System.Windows.Forms.TextBox tBListName;
        private System.Windows.Forms.TabPage tPAbout;
        private System.Windows.Forms.RichTextBox rTBAbout;
        private System.Windows.Forms.Label labelOtherAccountGroup;
        private System.Windows.Forms.TextBox tBGroupOtherAccount;
        private System.Windows.Forms.RadioButton rBOtherAccountEveningTime;
        private System.Windows.Forms.RadioButton rBOtherAccountDayTime;
    }
}


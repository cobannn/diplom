namespace diplom
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            файToolStripMenuItem = new ToolStripMenuItem();
            сменитьПарольToolStripMenuItem = new ToolStripMenuItem();
            задачиToolStripMenuItem = new ToolStripMenuItem();
            выполненныеЗадачиToolStripMenuItem = new ToolStripMenuItem();
            задачиВРаботеToolStripMenuItem = new ToolStripMenuItem();
            еЗадачиToolStripMenuItem = new ToolStripMenuItem();
            сотрудникиToolStripMenuItem = new ToolStripMenuItem();
            списокСотрудниковToolStripMenuItem = new ToolStripMenuItem();
            списокОтпусковToolStripMenuItem = new ToolStripMenuItem();
            админToolStripMenuItem = new ToolStripMenuItem();
            сменитьПарольToolStripMenuItem1 = new ToolStripMenuItem();
            сменитьИмяПользователяToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(12, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 472);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файToolStripMenuItem, задачиToolStripMenuItem, сотрудникиToolStripMenuItem, админToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(870, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файToolStripMenuItem
            // 
            файToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сменитьПарольToolStripMenuItem });
            файToolStripMenuItem.Name = "файToolStripMenuItem";
            файToolStripMenuItem.Size = new Size(57, 20);
            файToolStripMenuItem.Text = "Файлы";
            // 
            // сменитьПарольToolStripMenuItem
            // 
            сменитьПарольToolStripMenuItem.Name = "сменитьПарольToolStripMenuItem";
            сменитьПарольToolStripMenuItem.Size = new Size(164, 22);
            сменитьПарольToolStripMenuItem.Text = "Выгрузка отчета";
            сменитьПарольToolStripMenuItem.Click += сменитьПарольToolStripMenuItem_Click;
            // 
            // задачиToolStripMenuItem
            // 
            задачиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выполненныеЗадачиToolStripMenuItem, задачиВРаботеToolStripMenuItem, еЗадачиToolStripMenuItem });
            задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            задачиToolStripMenuItem.Size = new Size(58, 20);
            задачиToolStripMenuItem.Text = "Задачи";
            // 
            // выполненныеЗадачиToolStripMenuItem
            // 
            выполненныеЗадачиToolStripMenuItem.Name = "выполненныеЗадачиToolStripMenuItem";
            выполненныеЗадачиToolStripMenuItem.Size = new Size(193, 22);
            выполненныеЗадачиToolStripMenuItem.Text = "Выполненные задачи";
            выполненныеЗадачиToolStripMenuItem.Click += выполненныеЗадачиToolStripMenuItem_Click;
            // 
            // задачиВРаботеToolStripMenuItem
            // 
            задачиВРаботеToolStripMenuItem.Name = "задачиВРаботеToolStripMenuItem";
            задачиВРаботеToolStripMenuItem.Size = new Size(193, 22);
            задачиВРаботеToolStripMenuItem.Text = "Задачи в работе";
            // 
            // еЗадачиToolStripMenuItem
            // 
            еЗадачиToolStripMenuItem.Name = "еЗадачиToolStripMenuItem";
            еЗадачиToolStripMenuItem.Size = new Size(193, 22);
            еЗадачиToolStripMenuItem.Text = "Все задачи";
            еЗадачиToolStripMenuItem.Click += еЗадачиToolStripMenuItem_Click;
            // 
            // сотрудникиToolStripMenuItem
            // 
            сотрудникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { списокСотрудниковToolStripMenuItem, списокОтпусковToolStripMenuItem });
            сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            сотрудникиToolStripMenuItem.Size = new Size(85, 20);
            сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // списокСотрудниковToolStripMenuItem
            // 
            списокСотрудниковToolStripMenuItem.Name = "списокСотрудниковToolStripMenuItem";
            списокСотрудниковToolStripMenuItem.Size = new Size(188, 22);
            списокСотрудниковToolStripMenuItem.Text = "Список сотрудников";
            списокСотрудниковToolStripMenuItem.Click += списокСотрудниковToolStripMenuItem_Click;
            // 
            // списокОтпусковToolStripMenuItem
            // 
            списокОтпусковToolStripMenuItem.Name = "списокОтпусковToolStripMenuItem";
            списокОтпусковToolStripMenuItem.Size = new Size(188, 22);
            списокОтпусковToolStripMenuItem.Text = "Список отпусков";
            списокОтпусковToolStripMenuItem.Click += списокОтпусковToolStripMenuItem_Click;
            // 
            // админToolStripMenuItem
            // 
            админToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сменитьПарольToolStripMenuItem1, сменитьИмяПользователяToolStripMenuItem });
            админToolStripMenuItem.Name = "админToolStripMenuItem";
            админToolStripMenuItem.Size = new Size(56, 20);
            админToolStripMenuItem.Text = "Админ";
            // 
            // сменитьПарольToolStripMenuItem1
            // 
            сменитьПарольToolStripMenuItem1.Name = "сменитьПарольToolStripMenuItem1";
            сменитьПарольToolStripMenuItem1.Size = new Size(200, 22);
            сменитьПарольToolStripMenuItem1.Text = "Сменить пароль";
            сменитьПарольToolStripMenuItem1.Click += сменитьПарольToolStripMenuItem1_Click;
            // 
            // сменитьИмяПользователяToolStripMenuItem
            // 
            сменитьИмяПользователяToolStripMenuItem.Name = "сменитьИмяПользователяToolStripMenuItem";
            сменитьИмяПользователяToolStripMenuItem.Size = new Size(200, 22);
            сменитьИмяПользователяToolStripMenuItem.Text = "Сменить пользователя";
            сменитьИмяПользователяToolStripMenuItem.Click += сменитьИмяПользователяToolStripMenuItem_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(870, 519);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "MainWindow";
            Load += MainWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файToolStripMenuItem;
        private ToolStripMenuItem сменитьПарольToolStripMenuItem;
        private ToolStripMenuItem задачиToolStripMenuItem;
        private ToolStripMenuItem сотрудникиToolStripMenuItem;
        private ToolStripMenuItem админToolStripMenuItem;
        private ToolStripMenuItem выполненныеЗадачиToolStripMenuItem;
        private ToolStripMenuItem задачиВРаботеToolStripMenuItem;
        private ToolStripMenuItem списокСотрудниковToolStripMenuItem;
        private ToolStripMenuItem списокОтпусковToolStripMenuItem;
        private ToolStripMenuItem сменитьПарольToolStripMenuItem1;
        private ToolStripMenuItem сменитьИмяПользователяToolStripMenuItem;
        private ToolStripMenuItem еЗадачиToolStripMenuItem;
    }
}
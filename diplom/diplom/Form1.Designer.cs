namespace diplom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserNameBox = new TextBox();
            PasswordBox = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // UserNameBox
            // 
            UserNameBox.BackColor = SystemColors.Window;
            UserNameBox.Cursor = Cursors.IBeam;
            UserNameBox.Location = new Point(80, 22);
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(312, 23);
            UserNameBox.TabIndex = 2;
            UserNameBox.TextChanged += UserName_TextChanged;
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = SystemColors.Window;
            PasswordBox.Cursor = Cursors.IBeam;
            PasswordBox.Location = new Point(80, 71);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(312, 23);
            PasswordBox.TabIndex = 3;
            PasswordBox.TextChanged += Password_TextChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(UserNameBox);
            panel1.Controls.Add(PasswordBox);
            panel1.Location = new Point(7, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 151);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(16, 74);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 7;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(34, 17);
            label1.TabIndex = 6;
            label1.Text = "Имя";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(317, 110);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Отмена";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(226, 110);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Ок";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(426, 176);
            Controls.Add(panel1);
            MaximumSize = new Size(442, 215);
            MinimumSize = new Size(442, 215);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox UserNameBox;
        private TextBox PasswordBox;
        private Panel panel1;
        private Button button1;
        private Label label2;
        private Label label1;
        private Button button3;
    }
}

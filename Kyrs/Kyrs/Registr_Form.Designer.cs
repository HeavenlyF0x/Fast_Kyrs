namespace Kyrs
{
    partial class Registr_Form
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
            this.B_Create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.E_NewLogin = new System.Windows.Forms.TextBox();
            this.E_NewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.E_NewPassRe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.E_Lastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.E_Firstname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.E_Patronymic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.E_Number = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.B_Empty = new System.Windows.Forms.Button();
            this.B_LoginForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Create
            // 
            this.B_Create.Location = new System.Drawing.Point(292, 55);
            this.B_Create.Name = "B_Create";
            this.B_Create.Size = new System.Drawing.Size(115, 23);
            this.B_Create.TabIndex = 0;
            this.B_Create.Text = "Создать";
            this.B_Create.UseVisualStyleBackColor = true;
            this.B_Create.Click += new System.EventHandler(this.B_Create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // E_NewLogin
            // 
            this.E_NewLogin.Location = new System.Drawing.Point(157, 54);
            this.E_NewLogin.Name = "E_NewLogin";
            this.E_NewLogin.Size = new System.Drawing.Size(100, 20);
            this.E_NewLogin.TabIndex = 2;
            // 
            // E_NewPass
            // 
            this.E_NewPass.Location = new System.Drawing.Point(157, 95);
            this.E_NewPass.Name = "E_NewPass";
            this.E_NewPass.Size = new System.Drawing.Size(100, 20);
            this.E_NewPass.TabIndex = 4;
            this.E_NewPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // E_NewPassRe
            // 
            this.E_NewPassRe.Location = new System.Drawing.Point(157, 121);
            this.E_NewPassRe.Name = "E_NewPassRe";
            this.E_NewPassRe.Size = new System.Drawing.Size(100, 20);
            this.E_NewPassRe.TabIndex = 6;
            this.E_NewPassRe.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Повторить пароль";
            // 
            // E_Lastname
            // 
            this.E_Lastname.Location = new System.Drawing.Point(157, 164);
            this.E_Lastname.Name = "E_Lastname";
            this.E_Lastname.Size = new System.Drawing.Size(100, 20);
            this.E_Lastname.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Фамилия";
            // 
            // E_Firstname
            // 
            this.E_Firstname.Location = new System.Drawing.Point(157, 190);
            this.E_Firstname.Name = "E_Firstname";
            this.E_Firstname.Size = new System.Drawing.Size(100, 20);
            this.E_Firstname.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Имя";
            // 
            // E_Patronymic
            // 
            this.E_Patronymic.Location = new System.Drawing.Point(157, 216);
            this.E_Patronymic.Name = "E_Patronymic";
            this.E_Patronymic.Size = new System.Drawing.Size(100, 20);
            this.E_Patronymic.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Отчество";
            // 
            // E_Number
            // 
            this.E_Number.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.E_Number.Location = new System.Drawing.Point(157, 259);
            this.E_Number.Name = "E_Number";
            this.E_Number.Size = new System.Drawing.Size(100, 20);
            this.E_Number.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Номер телефона";
            // 
            // B_Empty
            // 
            this.B_Empty.Location = new System.Drawing.Point(292, 155);
            this.B_Empty.Name = "B_Empty";
            this.B_Empty.Size = new System.Drawing.Size(115, 27);
            this.B_Empty.TabIndex = 15;
            this.B_Empty.Text = "Очистить поля";
            this.B_Empty.UseVisualStyleBackColor = true;
            this.B_Empty.Click += new System.EventHandler(this.B_Empty_Click);
            // 
            // B_LoginForm
            // 
            this.B_LoginForm.Location = new System.Drawing.Point(292, 257);
            this.B_LoginForm.Name = "B_LoginForm";
            this.B_LoginForm.Size = new System.Drawing.Size(115, 23);
            this.B_LoginForm.TabIndex = 16;
            this.B_LoginForm.Text = "Вернуться назад";
            this.B_LoginForm.UseVisualStyleBackColor = true;
            this.B_LoginForm.Click += new System.EventHandler(this.B_LoginForm_Click);
            // 
            // Registr_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 325);
            this.ControlBox = false;
            this.Controls.Add(this.B_LoginForm);
            this.Controls.Add(this.B_Empty);
            this.Controls.Add(this.E_Number);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.E_Patronymic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.E_Firstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.E_Lastname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.E_NewPassRe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.E_NewPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.E_NewLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Create);
            this.Name = "Registr_Form";
            this.Text = "Registr_Form";
            this.Load += new System.EventHandler(this.Registr_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox E_NewLogin;
        private System.Windows.Forms.TextBox E_NewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox E_NewPassRe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox E_Lastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox E_Firstname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox E_Patronymic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox E_Number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button B_Empty;
        private System.Windows.Forms.Button B_LoginForm;
    }
}
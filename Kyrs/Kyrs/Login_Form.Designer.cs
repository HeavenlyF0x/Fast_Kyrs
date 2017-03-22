namespace Kyrs
{
    partial class Login_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.B_Registr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.E_Login = new System.Windows.Forms.TextBox();
            this.E_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Enter = new System.Windows.Forms.Button();
            this.B_CloseProgramm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Registr
            // 
            this.B_Registr.Location = new System.Drawing.Point(112, 99);
            this.B_Registr.Name = "B_Registr";
            this.B_Registr.Size = new System.Drawing.Size(75, 23);
            this.B_Registr.TabIndex = 0;
            this.B_Registr.Text = "Регистрация";
            this.B_Registr.UseVisualStyleBackColor = true;
            this.B_Registr.Click += new System.EventHandler(this.B_Registr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // E_Login
            // 
            this.E_Login.Location = new System.Drawing.Point(148, 23);
            this.E_Login.Name = "E_Login";
            this.E_Login.Size = new System.Drawing.Size(133, 20);
            this.E_Login.TabIndex = 2;
            // 
            // E_Password
            // 
            this.E_Password.Location = new System.Drawing.Point(148, 58);
            this.E_Password.Name = "E_Password";
            this.E_Password.Size = new System.Drawing.Size(133, 20);
            this.E_Password.TabIndex = 3;
            this.E_Password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // B_Enter
            // 
            this.B_Enter.Location = new System.Drawing.Point(206, 99);
            this.B_Enter.Name = "B_Enter";
            this.B_Enter.Size = new System.Drawing.Size(75, 23);
            this.B_Enter.TabIndex = 5;
            this.B_Enter.Text = "Вход";
            this.B_Enter.UseVisualStyleBackColor = true;
            this.B_Enter.Click += new System.EventHandler(this.B_Enter_Click);
            // 
            // B_CloseProgramm
            // 
            this.B_CloseProgramm.Location = new System.Drawing.Point(164, 135);
            this.B_CloseProgramm.Name = "B_CloseProgramm";
            this.B_CloseProgramm.Size = new System.Drawing.Size(75, 23);
            this.B_CloseProgramm.TabIndex = 6;
            this.B_CloseProgramm.Text = "Закрыть ";
            this.B_CloseProgramm.UseVisualStyleBackColor = true;
            this.B_CloseProgramm.Click += new System.EventHandler(this.B_CloseProgramm_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 170);
            this.ControlBox = false;
            this.Controls.Add(this.B_CloseProgramm);
            this.Controls.Add(this.B_Enter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.E_Password);
            this.Controls.Add(this.E_Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Registr);
            this.Name = "Login_Form";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Registr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox E_Login;
        private System.Windows.Forms.TextBox E_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Enter;
        private System.Windows.Forms.Button B_CloseProgramm;
    }
}


namespace Kyrs
{
    partial class New_Hotel_Form
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
            this.B_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.E_IdHotel = new System.Windows.Forms.TextBox();
            this.E_Title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.E_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.N_StarCount = new System.Windows.Forms.NumericUpDown();
            this.B_Clear = new System.Windows.Forms.Button();
            this.B_Cancle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.N_StarCount)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Add
            // 
            this.B_Add.Location = new System.Drawing.Point(84, 159);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(75, 23);
            this.B_Add.TabIndex = 0;
            this.B_Add.Text = "Добавить";
            this.B_Add.UseVisualStyleBackColor = true;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Идентификатор";
            // 
            // E_IdHotel
            // 
            this.E_IdHotel.Location = new System.Drawing.Point(144, 25);
            this.E_IdHotel.Name = "E_IdHotel";
            this.E_IdHotel.Size = new System.Drawing.Size(128, 20);
            this.E_IdHotel.TabIndex = 2;
            // 
            // E_Title
            // 
            this.E_Title.Location = new System.Drawing.Point(144, 60);
            this.E_Title.Name = "E_Title";
            this.E_Title.Size = new System.Drawing.Size(128, 20);
            this.E_Title.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название";
            // 
            // E_Address
            // 
            this.E_Address.Location = new System.Drawing.Point(144, 118);
            this.E_Address.Name = "E_Address";
            this.E_Address.Size = new System.Drawing.Size(242, 20);
            this.E_Address.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Адресс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Колличество звёзд";
            // 
            // N_StarCount
            // 
            this.N_StarCount.Location = new System.Drawing.Point(218, 92);
            this.N_StarCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.N_StarCount.Name = "N_StarCount";
            this.N_StarCount.Size = new System.Drawing.Size(54, 20);
            this.N_StarCount.TabIndex = 8;
            // 
            // B_Clear
            // 
            this.B_Clear.Location = new System.Drawing.Point(182, 159);
            this.B_Clear.Name = "B_Clear";
            this.B_Clear.Size = new System.Drawing.Size(75, 23);
            this.B_Clear.TabIndex = 9;
            this.B_Clear.Text = "Сброс";
            this.B_Clear.UseVisualStyleBackColor = true;
            // 
            // B_Cancle
            // 
            this.B_Cancle.Location = new System.Drawing.Point(280, 159);
            this.B_Cancle.Name = "B_Cancle";
            this.B_Cancle.Size = new System.Drawing.Size(75, 23);
            this.B_Cancle.TabIndex = 10;
            this.B_Cancle.Text = "Отмена";
            this.B_Cancle.UseVisualStyleBackColor = true;
            this.B_Cancle.Click += new System.EventHandler(this.B_Cancle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // New_Hotel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 203);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.B_Cancle);
            this.Controls.Add(this.B_Clear);
            this.Controls.Add(this.N_StarCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.E_Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.E_Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.E_IdHotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Add);
            this.Name = "New_Hotel_Form";
            this.Text = "New_Hotel_Form";
            this.Load += new System.EventHandler(this.New_Hotel_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.N_StarCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox E_IdHotel;
        private System.Windows.Forms.TextBox E_Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox E_Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown N_StarCount;
        private System.Windows.Forms.Button B_Clear;
        private System.Windows.Forms.Button B_Cancle;
        private System.Windows.Forms.TextBox textBox1;
    }
}
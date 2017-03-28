namespace Kyrs
{
    partial class New_Room_Form
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
            this.E_IdRoom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_IdHotel = new System.Windows.Forms.ComboBox();
            this.CB_Class = new System.Windows.Forms.ComboBox();
            this.B_Clear = new System.Windows.Forms.Button();
            this.B_Cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Add
            // 
            this.B_Add.Location = new System.Drawing.Point(39, 126);
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
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер комнаты";
            // 
            // E_IdRoom
            // 
            this.E_IdRoom.Location = new System.Drawing.Point(142, 54);
            this.E_IdRoom.Name = "E_IdRoom";
            this.E_IdRoom.Size = new System.Drawing.Size(121, 20);
            this.E_IdRoom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер отеля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Класс комнаты";
            // 
            // CB_IdHotel
            // 
            this.CB_IdHotel.FormattingEnabled = true;
            this.CB_IdHotel.Location = new System.Drawing.Point(142, 27);
            this.CB_IdHotel.Name = "CB_IdHotel";
            this.CB_IdHotel.Size = new System.Drawing.Size(121, 21);
            this.CB_IdHotel.TabIndex = 5;
            // 
            // CB_Class
            // 
            this.CB_Class.FormattingEnabled = true;
            this.CB_Class.Location = new System.Drawing.Point(142, 81);
            this.CB_Class.Name = "CB_Class";
            this.CB_Class.Size = new System.Drawing.Size(121, 21);
            this.CB_Class.TabIndex = 6;
            // 
            // B_Clear
            // 
            this.B_Clear.Location = new System.Drawing.Point(131, 126);
            this.B_Clear.Name = "B_Clear";
            this.B_Clear.Size = new System.Drawing.Size(75, 23);
            this.B_Clear.TabIndex = 7;
            this.B_Clear.Text = "Сброс";
            this.B_Clear.UseVisualStyleBackColor = true;
            this.B_Clear.Click += new System.EventHandler(this.B_Clear_Click);
            // 
            // B_Cancle
            // 
            this.B_Cancle.Location = new System.Drawing.Point(221, 126);
            this.B_Cancle.Name = "B_Cancle";
            this.B_Cancle.Size = new System.Drawing.Size(75, 23);
            this.B_Cancle.TabIndex = 8;
            this.B_Cancle.Text = "Отмена";
            this.B_Cancle.UseVisualStyleBackColor = true;
            this.B_Cancle.Click += new System.EventHandler(this.B_Cancle_Click);
            // 
            // New_Room_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 172);
            this.ControlBox = false;
            this.Controls.Add(this.B_Cancle);
            this.Controls.Add(this.B_Clear);
            this.Controls.Add(this.CB_Class);
            this.Controls.Add(this.CB_IdHotel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.E_IdRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Add);
            this.Name = "New_Room_Form";
            this.Text = "New_Room_Form";
            this.Load += new System.EventHandler(this.New_Room_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox E_IdRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_IdHotel;
        private System.Windows.Forms.ComboBox CB_Class;
        private System.Windows.Forms.Button B_Clear;
        private System.Windows.Forms.Button B_Cancle;
    }
}
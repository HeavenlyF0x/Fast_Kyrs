namespace Kyrs
{
    partial class New_Classes
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
            this.label1 = new System.Windows.Forms.Label();
            this.B_Add = new System.Windows.Forms.Button();
            this.E_Class = new System.Windows.Forms.TextBox();
            this.CB_IdHotel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.E_Cost = new System.Windows.Forms.TextBox();
            this.B_Clear = new System.Windows.Forms.Button();
            this.B_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Идентификатор отеля";
            // 
            // B_Add
            // 
            this.B_Add.Location = new System.Drawing.Point(89, 151);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(75, 23);
            this.B_Add.TabIndex = 1;
            this.B_Add.Text = "Добавить";
            this.B_Add.UseVisualStyleBackColor = true;
            this.B_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // E_Class
            // 
            this.E_Class.Location = new System.Drawing.Point(169, 67);
            this.E_Class.Name = "E_Class";
            this.E_Class.Size = new System.Drawing.Size(121, 20);
            this.E_Class.TabIndex = 2;
            // 
            // CB_IdHotel
            // 
            this.CB_IdHotel.FormattingEnabled = true;
            this.CB_IdHotel.Location = new System.Drawing.Point(169, 30);
            this.CB_IdHotel.Name = "CB_IdHotel";
            this.CB_IdHotel.Size = new System.Drawing.Size(121, 21);
            this.CB_IdHotel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Характеристика класса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Стоимость";
            // 
            // E_Cost
            // 
            this.E_Cost.Location = new System.Drawing.Point(169, 106);
            this.E_Cost.Name = "E_Cost";
            this.E_Cost.Size = new System.Drawing.Size(121, 20);
            this.E_Cost.TabIndex = 6;
            // 
            // B_Clear
            // 
            this.B_Clear.Location = new System.Drawing.Point(181, 151);
            this.B_Clear.Name = "B_Clear";
            this.B_Clear.Size = new System.Drawing.Size(75, 23);
            this.B_Clear.TabIndex = 7;
            this.B_Clear.Text = "Сброс";
            this.B_Clear.UseVisualStyleBackColor = true;
            this.B_Clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // B_Close
            // 
            this.B_Close.Location = new System.Drawing.Point(274, 151);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(75, 23);
            this.B_Close.TabIndex = 8;
            this.B_Close.Text = "Отмена";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.button3_Click);
            // 
            // New_Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 202);
            this.ControlBox = false;
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_Clear);
            this.Controls.Add(this.E_Cost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_IdHotel);
            this.Controls.Add(this.E_Class);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.label1);
            this.Name = "New_Classes";
            this.Text = "New_Classes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.TextBox E_Class;
        private System.Windows.Forms.ComboBox CB_IdHotel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox E_Cost;
        private System.Windows.Forms.Button B_Clear;
        private System.Windows.Forms.Button B_Close;
    }
}
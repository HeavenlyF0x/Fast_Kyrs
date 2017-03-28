namespace Kyrs
{
    partial class Admin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BC_Hotel = new System.Windows.Forms.ToolStripButton();
            this.BC_Room = new System.Windows.Forms.ToolStripButton();
            this.BC_Class = new System.Windows.Forms.ToolStripButton();
            this.BC_User = new System.Windows.Forms.ToolStripButton();
            this.BC_Reservation = new System.Windows.Forms.ToolStripButton();
            this.BC_Log = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.B_AddInfo = new System.Windows.Forms.Button();
            this.CB_SelectUser = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.B_UnLogin = new System.Windows.Forms.Button();
            this.B_Delete_Info = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BC_Hotel,
            this.BC_Room,
            this.BC_Class,
            this.BC_User,
            this.BC_Reservation,
            this.BC_Log});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(562, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BC_Hotel
            // 
            this.BC_Hotel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BC_Hotel.Image = ((System.Drawing.Image)(resources.GetObject("BC_Hotel.Image")));
            this.BC_Hotel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BC_Hotel.Name = "BC_Hotel";
            this.BC_Hotel.Size = new System.Drawing.Size(45, 22);
            this.BC_Hotel.Text = "Отели";
            this.BC_Hotel.Click += new System.EventHandler(this.BC_Hotel_Click);
            // 
            // BC_Room
            // 
            this.BC_Room.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BC_Room.Image = ((System.Drawing.Image)(resources.GetObject("BC_Room.Image")));
            this.BC_Room.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BC_Room.Name = "BC_Room";
            this.BC_Room.Size = new System.Drawing.Size(61, 22);
            this.BC_Room.Text = "Комнаты";
            this.BC_Room.Click += new System.EventHandler(this.BC_Room_Click);
            // 
            // BC_Class
            // 
            this.BC_Class.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BC_Class.Image = ((System.Drawing.Image)(resources.GetObject("BC_Class.Image")));
            this.BC_Class.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BC_Class.Name = "BC_Class";
            this.BC_Class.Size = new System.Drawing.Size(95, 22);
            this.BC_Class.Text = "Классы комнат";
            this.BC_Class.Click += new System.EventHandler(this.BC_Class_Click);
            // 
            // BC_User
            // 
            this.BC_User.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BC_User.Image = ((System.Drawing.Image)(resources.GetObject("BC_User.Image")));
            this.BC_User.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BC_User.Name = "BC_User";
            this.BC_User.Size = new System.Drawing.Size(89, 22);
            this.BC_User.Text = "Пользователи";
            this.BC_User.Click += new System.EventHandler(this.BC_User_Click);
            // 
            // BC_Reservation
            // 
            this.BC_Reservation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BC_Reservation.Image = ((System.Drawing.Image)(resources.GetObject("BC_Reservation.Image")));
            this.BC_Reservation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BC_Reservation.Name = "BC_Reservation";
            this.BC_Reservation.Size = new System.Drawing.Size(162, 22);
            this.BC_Reservation.Text = "Резервированные комнаты";
            this.BC_Reservation.Click += new System.EventHandler(this.BC_Reservation_Click);
            // 
            // BC_Log
            // 
            this.BC_Log.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BC_Log.Image = ((System.Drawing.Image)(resources.GetObject("BC_Log.Image")));
            this.BC_Log.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BC_Log.Name = "BC_Log";
            this.BC_Log.Size = new System.Drawing.Size(31, 22);
            this.BC_Log.Text = "Лог";
            this.BC_Log.Click += new System.EventHandler(this.BC_Log_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(432, 355);
            this.dataGridView1.TabIndex = 1;
            // 
            // B_AddInfo
            // 
            this.B_AddInfo.Location = new System.Drawing.Point(475, 28);
            this.B_AddInfo.Name = "B_AddInfo";
            this.B_AddInfo.Size = new System.Drawing.Size(75, 51);
            this.B_AddInfo.TabIndex = 2;
            this.B_AddInfo.Text = "Добавить новый элемент";
            this.B_AddInfo.UseVisualStyleBackColor = true;
            this.B_AddInfo.Click += new System.EventHandler(this.B_AddInfo_Click);
            // 
            // CB_SelectUser
            // 
            this.CB_SelectUser.FormattingEnabled = true;
            this.CB_SelectUser.Location = new System.Drawing.Point(438, 127);
            this.CB_SelectUser.Name = "CB_SelectUser";
            this.CB_SelectUser.Size = new System.Drawing.Size(121, 21);
            this.CB_SelectUser.TabIndex = 3;
            this.CB_SelectUser.Visible = false;
            this.CB_SelectUser.SelectedValueChanged += new System.EventHandler(this.CB_SelectUser_SelectedValueChanged);
            this.CB_SelectUser.VisibleChanged += new System.EventHandler(this.CB_SelectUser_VisibleChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // B_UnLogin
            // 
            this.B_UnLogin.Location = new System.Drawing.Point(475, 345);
            this.B_UnLogin.Name = "B_UnLogin";
            this.B_UnLogin.Size = new System.Drawing.Size(75, 23);
            this.B_UnLogin.TabIndex = 5;
            this.B_UnLogin.Text = "Выйти";
            this.B_UnLogin.UseVisualStyleBackColor = true;
            this.B_UnLogin.Click += new System.EventHandler(this.B_UnLogin_Click);
            // 
            // B_Delete_Info
            // 
            this.B_Delete_Info.Location = new System.Drawing.Point(458, 274);
            this.B_Delete_Info.Name = "B_Delete_Info";
            this.B_Delete_Info.Size = new System.Drawing.Size(92, 48);
            this.B_Delete_Info.TabIndex = 6;
            this.B_Delete_Info.Text = "Удалить выбранынй элеменет";
            this.B_Delete_Info.UseVisualStyleBackColor = true;
            this.B_Delete_Info.Click += new System.EventHandler(this.B_Delete_Info_Click);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 380);
            this.ControlBox = false;
            this.Controls.Add(this.B_Delete_Info);
            this.Controls.Add(this.B_UnLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CB_SelectUser);
            this.Controls.Add(this.B_AddInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Form_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Admin_Form_MouseClick);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BC_Hotel;
        private System.Windows.Forms.ToolStripButton BC_Room;
        private System.Windows.Forms.ToolStripButton BC_Class;
        private System.Windows.Forms.ToolStripButton BC_User;
        private System.Windows.Forms.ToolStripButton BC_Reservation;
        private System.Windows.Forms.ToolStripButton BC_Log;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button B_AddInfo;
        private System.Windows.Forms.ComboBox CB_SelectUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button B_UnLogin;
        private System.Windows.Forms.Button B_Delete_Info;
    }
}
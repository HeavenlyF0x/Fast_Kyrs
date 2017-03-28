namespace Kyrs
{
    partial class Users_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users_Form));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BS_Rooms = new System.Windows.Forms.ToolStripButton();
            this.BS_Reservations = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.B_ReservDelete = new System.Windows.Forms.Button();
            this.B_UnLogin = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.B_SelectDay = new System.Windows.Forms.Button();
            this.B_Reserv = new System.Windows.Forms.Button();
            this.L_Hotel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BS_Rooms,
            this.BS_Reservations});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(807, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BS_Rooms
            // 
            this.BS_Rooms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BS_Rooms.Image = ((System.Drawing.Image)(resources.GetObject("BS_Rooms.Image")));
            this.BS_Rooms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BS_Rooms.Name = "BS_Rooms";
            this.BS_Rooms.Size = new System.Drawing.Size(107, 22);
            this.BS_Rooms.Text = "Отели и комнаты";
            this.BS_Rooms.Click += new System.EventHandler(this.BS_Rooms_Click);
            // 
            // BS_Reservations
            // 
            this.BS_Reservations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BS_Reservations.Image = ((System.Drawing.Image)(resources.GetObject("BS_Reservations.Image")));
            this.BS_Reservations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BS_Reservations.Name = "BS_Reservations";
            this.BS_Reservations.Size = new System.Drawing.Size(175, 22);
            this.BS_Reservations.Text = "Зарезервированные комнаты";
            this.BS_Reservations.Click += new System.EventHandler(this.BS_Reservations_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(538, 345);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // B_ReservDelete
            // 
            this.B_ReservDelete.Location = new System.Drawing.Point(573, 48);
            this.B_ReservDelete.Name = "B_ReservDelete";
            this.B_ReservDelete.Size = new System.Drawing.Size(163, 23);
            this.B_ReservDelete.TabIndex = 2;
            this.B_ReservDelete.Text = "Отменить резервирование";
            this.B_ReservDelete.UseVisualStyleBackColor = true;
            this.B_ReservDelete.Visible = false;
            this.B_ReservDelete.Click += new System.EventHandler(this.B_Select_Click);
            // 
            // B_UnLogin
            // 
            this.B_UnLogin.Location = new System.Drawing.Point(573, 335);
            this.B_UnLogin.Name = "B_UnLogin";
            this.B_UnLogin.Size = new System.Drawing.Size(75, 23);
            this.B_UnLogin.TabIndex = 3;
            this.B_UnLogin.Text = "Выйти";
            this.B_UnLogin.UseVisualStyleBackColor = true;
            this.B_UnLogin.Click += new System.EventHandler(this.B_UnLogin_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 46);
            this.dateTimePicker1.MinDate = new System.DateTime(2017, 3, 28, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(16, 88);
            this.dateTimePicker2.MinDate = new System.DateTime(2017, 3, 28, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "С:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "До:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_Reserv);
            this.groupBox1.Controls.Add(this.B_SelectDay);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(557, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 220);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Зарезервировать";
            this.groupBox1.Visible = false;
            // 
            // B_SelectDay
            // 
            this.B_SelectDay.Location = new System.Drawing.Point(31, 140);
            this.B_SelectDay.Name = "B_SelectDay";
            this.B_SelectDay.Size = new System.Drawing.Size(185, 24);
            this.B_SelectDay.TabIndex = 8;
            this.B_SelectDay.Text = "Просмотреть комнаты";
            this.B_SelectDay.UseVisualStyleBackColor = true;
            this.B_SelectDay.Click += new System.EventHandler(this.B_SelectDay_Click);
            // 
            // B_Reserv
            // 
            this.B_Reserv.Location = new System.Drawing.Point(31, 191);
            this.B_Reserv.Name = "B_Reserv";
            this.B_Reserv.Size = new System.Drawing.Size(185, 23);
            this.B_Reserv.TabIndex = 9;
            this.B_Reserv.Text = "Зарезервировать";
            this.B_Reserv.UseVisualStyleBackColor = true;
            this.B_Reserv.Click += new System.EventHandler(this.B_Reserv_Click);
            // 
            // L_Hotel
            // 
            this.L_Hotel.AutoSize = true;
            this.L_Hotel.Location = new System.Drawing.Point(570, 25);
            this.L_Hotel.Name = "L_Hotel";
            this.L_Hotel.Size = new System.Drawing.Size(111, 13);
            this.L_Hotel.TabIndex = 9;
            this.L_Hotel.Text = "Выберите гостиницу";
            // 
            // Users_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 370);
            this.ControlBox = false;
            this.Controls.Add(this.L_Hotel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.B_UnLogin);
            this.Controls.Add(this.B_ReservDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Users_Form";
            this.Text = "Users_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Users_Form_FormClosing);
            this.Load += new System.EventHandler(this.Users_Form_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BS_Rooms;
        private System.Windows.Forms.ToolStripButton BS_Reservations;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button B_ReservDelete;
        private System.Windows.Forms.Button B_UnLogin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button B_SelectDay;
        private System.Windows.Forms.Button B_Reserv;
        private System.Windows.Forms.Label L_Hotel;
    }
}
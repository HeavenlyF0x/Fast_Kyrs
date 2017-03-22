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
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BS_Rooms,
            this.BS_Reservations});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(696, 25);
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
            // 
            // BS_Reservations
            // 
            this.BS_Reservations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BS_Reservations.Image = ((System.Drawing.Image)(resources.GetObject("BS_Reservations.Image")));
            this.BS_Reservations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BS_Reservations.Name = "BS_Reservations";
            this.BS_Reservations.Size = new System.Drawing.Size(175, 22);
            this.BS_Reservations.Text = "Зарезервированные комнаты";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 345);
            this.dataGridView1.TabIndex = 1;
            // 
            // Users_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 370);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Users_Form";
            this.Text = "Users_Form";
            this.Load += new System.EventHandler(this.Users_Form_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BS_Rooms;
        private System.Windows.Forms.ToolStripButton BS_Reservations;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
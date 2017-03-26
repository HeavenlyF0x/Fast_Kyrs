using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrs
{
    public partial class Admin_Form : Form
    {
        DB_Work wdb;

        int Selector = 0;
        public Admin_Form(DB_Work _wdb)
        {
            InitializeComponent();
            this.wdb = _wdb;
        }

        private void BC_Hotel_Click(object sender, EventArgs e)
        {
            dataGridView1 = wdb.FillHotel(dataGridView1);
            Selector = 0;
        }

        private void BC_Room_Click(object sender, EventArgs e)
        {
            Selector = 1;
            dataGridView1 = wdb.FillRoom(dataGridView1);
            if (Selector == 3) CB_SelectUser.Visible = true;
            else CB_SelectUser.Visible = false;
        }

        private void BC_Class_Click(object sender, EventArgs e)
        {
            Selector = 2;
            dataGridView1 = wdb.FillRoomClasses(dataGridView1);
            if (Selector == 3) CB_SelectUser.Visible = true;
            else CB_SelectUser.Visible = false;
        }

        private void BC_Reservation_Click(object sender, EventArgs e)
        {
            Selector = 3;
            if (Selector == 3) CB_SelectUser.Visible = true;
            else CB_SelectUser.Visible = false;
            //dataGridView1 = wdb.FillReservation(dataGridView1, int.Parse(CB_SelectUser.Text.ToString()));
        }

        private void BC_User_Click(object sender, EventArgs e)
        {
            Selector = 4;
            if (Selector == 3) CB_SelectUser.Visible = true;
            else CB_SelectUser.Visible = false;
            dataGridView1 = wdb.FillLogins(dataGridView1);
        }

        private void B_AddInfo_Click(object sender, EventArgs e)
        {
            switch (Selector)
            {
                case 0: { var NewHotel = new New_Hotel_Form(wdb); NewHotel.ShowDialog(); } break;
                case 1: { var NewRoom = new New_Room_Form(wdb); NewRoom.ShowDialog(); } break;
                case 2: { var NewClasses = new New_Classes(wdb); NewClasses.ShowDialog(); } break;
                case 3: { } break;
                case 4: { var NewLogin = new Registr_Form(wdb); NewLogin.ShowDialog(); } break;
            }
        }

        private void Admin_Form_MouseClick(object sender, MouseEventArgs e)
        {
            if (Selector == 3) CB_SelectUser.Visible = true;
            else CB_SelectUser.Visible = false;
        }

        private void CB_SelectUser_SelectedValueChanged(object sender, EventArgs e)
        {
           // dataGridView1 = wdb.FillReservation(dataGridView1, int.Parse(CB_SelectUser.Text));
        }

        private void Admin_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Restart();
        }

        private void BC_Log_Click(object sender, EventArgs e)
        {
            Selector = -1;
            if (Selector == 3) CB_SelectUser.Visible = true;
            else CB_SelectUser.Visible = false;
            dataGridView1 = wdb.FillLog(dataGridView1);
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            CB_SelectUser = wdb.FillBoxUser(CB_SelectUser);
        }

        private void CB_SelectUser_VisibleChanged(object sender, EventArgs e)
        {
            if (CB_SelectUser.Visible)
                button1.Visible = true;
            else
                button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1 = wdb.FillReservation(dataGridView1, int.Parse(CB_SelectUser.Text));
        }

        private void B_UnLogin_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

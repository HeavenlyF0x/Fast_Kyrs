using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kyrs
{
    public partial class Users_Form : Form
    {
        DB_Work wdb;

        int Selector = 0;

        String Selected_Hotel;

        bool roomUp = false;

        bool UslesVar = false;

        public Users_Form(DB_Work _wdb)
        {
            InitializeComponent();
            this.wdb = _wdb;
        }

        private void Users_Form_Load(object sender, EventArgs e)
        {
            dataGridView1 = wdb.FillHotel(dataGridView1);

        }

        private void BS_Rooms_Click(object sender, EventArgs e)
        {
            UslesVar = false;
            Selector = 0;
            roomUp = false;
            B_ReservDelete.Visible = false;
            L_Hotel.Visible = true;
            dataGridView1 = wdb.FillHotel(dataGridView1);
        }

        private void BS_Reservations_Click(object sender, EventArgs e)
        {
            UslesVar = true;
            Selector = 0;
            B_ReservDelete.Visible = true;
            L_Hotel.Visible = false;
            groupBox1.Visible = false;
            dataGridView1 = wdb.FillReservation(dataGridView1, wdb.ActivUser);
        }

        private void Users_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void B_Select_Click(object sender, EventArgs e)
        {
            //dataGridView1 = wdb.FillFree(dataGridView1, dataGridView1[0, SelectedString].Value.ToString());
            if (wdb.DeleteMyReservation(int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString())) != -1)
                MessageBox.Show("Выбранное резеревирование было отменено!");
            else
                MessageBox.Show("Произошла ошибка"+wdb.ex.ToString());
            dataGridView1 = wdb.FillReservation(dataGridView1, wdb.ActivUser);
        }

        private void B_UnLogin_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void B_SelectDay_Click(object sender, EventArgs e)
        {
            dataGridView1 = wdb.FillFree(dataGridView1, Selected_Hotel, dateTimePicker1.Value, dateTimePicker2.Value);
            roomUp = true;
            Selector = 1;
        }

        private void B_Reserv_Click(object sender, EventArgs e)
        {
            wdb.AddReservation(Selected_Hotel, dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString(), wdb.ActivUser, dateTimePicker1.Value, dateTimePicker2.Value);
            MessageBox.Show("Комната зарезервирована.");
            Selector = 0;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (Selector)
            {
                case 0:
                    {
                        Selected_Hotel = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                        if (!UslesVar)
                            groupBox1.Visible = true;
                        L_Hotel.Text = "Выбран отель № " + Selected_Hotel;
                    } break;
                case 1:
                    {
                        if (groupBox1.Visible)
                            if (roomUp)
                                groupBox1.Text = "Зарезервировать комнату № " + dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                    } break;
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePicker1.Value)
                dateTimePicker2.Value = dateTimePicker1.Value;
        }
    }
}

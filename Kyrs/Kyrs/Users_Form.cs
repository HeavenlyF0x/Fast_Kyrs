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
            Selector = 0;
            dataGridView1 = wdb.FillHotel(dataGridView1);
        }

        private void BS_Reservations_Click(object sender, EventArgs e)
        {
            Selector = 1;
            dataGridView1 = wdb.FillReservation(dataGridView1, wdb.ActivUser);
        }

        private void Users_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

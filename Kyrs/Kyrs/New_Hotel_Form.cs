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
    public partial class New_Hotel_Form : Form
    {
        DB_Work wdb;
        public New_Hotel_Form(DB_Work _wdb)
        {
            InitializeComponent();
            this.wdb = _wdb;
        }

        private void New_Hotel_Form_Load(object sender, EventArgs e)
        {

        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            //wdb.AddHotel(E_IdHotel.Text, E_Title.Text, E_Address.Text, int.Parse(N_StarCount.TextAlign.ToString()));
            wdb.AddHotel(E_IdHotel.Text, E_Title.Text, E_Address.Text, int.Parse(textBox1.Text));
        }

        private void B_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class New_Classes : Form
    {
        DB_Work wdb;
        public New_Classes(DB_Work _wdb)
        {
            InitializeComponent();
            this.wdb = _wdb;
            CB_IdHotel = wdb.FiilBoxIdHotel(CB_IdHotel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wdb.AddClasses(CB_IdHotel.Text, E_Class.Text, int.Parse(E_Cost.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class New_Room_Form : Form
    {
        DB_Work wdb;
        public New_Room_Form(DB_Work _wdb)
        {
            InitializeComponent();
            this.wdb = _wdb;
            CB_IdHotel = wdb.FiilBoxIdHotel(CB_IdHotel);
            CB_Class = wdb.FillBoxClass(CB_Class);
        }

        private void New_Room_Form_Load(object sender, EventArgs e)
        {

        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            wdb.AddRoom(CB_IdHotel.Text,E_IdRoom.Text,CB_IdHotel.SelectedIndex);
        }
    }
}

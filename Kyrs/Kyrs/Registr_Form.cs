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
    public partial class Registr_Form : Form
    {
        DB_Work wdb;
        public Registr_Form(DB_Work _wdb)
        {
            InitializeComponent();
            this.wdb = _wdb;
        }

        private void Registr_Form_Load(object sender, EventArgs e)
        {

        }

        private void B_Create_Click(object sender, EventArgs e)
        {
            if ((E_Firstname.Text == "") &&
            (E_Lastname.Text == "") &&
            (E_NewLogin.Text == "") &&
            (E_NewPass.Text == "") &&
            (E_NewPassRe.Text == "") &&
            (E_Number.Text == "") &&
            (E_Patronymic.Text == ""))
                MessageBox.Show("Не все поля заполнены!");
            else
                if (E_NewPass.Text != E_NewPassRe.Text)
                    MessageBox.Show("Пароли не совпадают!");
                else
                    if (wdb.AddNewUser(E_NewLogin.Text, E_NewPass.Text, E_Lastname.Text, E_Firstname.Text, E_Patronymic.Text, E_Number.Text) == 0)
                    {
                        MessageBox.Show("Пользователь создан.");
                        Application.Restart();
                    }
                    else
                        MessageBox.Show("Что-то не так!" + wdb.ex.ToString());
        }

        private void B_Empty_Click(object sender, EventArgs e)
        {
            E_Firstname.Text = "";
            E_Lastname.Text = "";
            E_NewLogin.Text = "";
            E_NewPass.Text = "";
            E_NewPassRe.Text = "";
            E_Number.Text = "";
            E_Patronymic.Text = "";
        }

        private void B_LoginForm_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

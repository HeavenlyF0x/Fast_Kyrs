﻿using System;
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
    public partial class Login_Form : Form
    {
        //static string connectionString = @"Data Source=TPUKCTEP-ПК; Initial Catalog=SQL_Test;Integrated Security=True";
        DB_Work wdb = new DB_Work(); 
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void B_CloseProgramm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_Registr_Click(object sender, EventArgs e)
        {
            var RegisrtForm = new Registr_Form(wdb);
            this.Visible = false;
            RegisrtForm.ShowDialog();
        }

        private void B_Enter_Click(object sender, EventArgs e)
        {
            //if(АУТЕНТИФИКАЦИЯ)
            //then
            var UsersForm = new Users_Form(wdb);
            this.Visible = false;
            UsersForm.ShowDialog();
            //else
            //БРО_ЧТО_ТО_НЕ_ТО_ТЫ_ВВОДИШЬ!
        }
    }
}
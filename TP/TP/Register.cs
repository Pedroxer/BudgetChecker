﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            Hide();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }
    }
}

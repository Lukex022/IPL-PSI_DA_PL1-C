﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            FormPedidos form = new FormPedidos();
            form.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}

﻿using App1MensajeriaCliente;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1Mensajeria
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var ClienteForm = new ClienteChatForm(txtIP.Text, txtPuerto.Text);
            ClienteForm.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}

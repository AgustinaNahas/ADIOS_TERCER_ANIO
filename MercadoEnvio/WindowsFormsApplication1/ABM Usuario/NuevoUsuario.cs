﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var usrLogin = new Ingresar())
            {
                this.Hide();
                usrLogin.ShowDialog();
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var usrLogin = new Ingresar())
            {
                this.Hide();
                usrLogin.ShowDialog();
            } 
        }

    }
}
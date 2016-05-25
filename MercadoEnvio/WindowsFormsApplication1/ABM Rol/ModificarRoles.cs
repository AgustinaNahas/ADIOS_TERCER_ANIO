﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class ModificarRoles : Form
    {
        public ModificarRoles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (String.IsNullOrEmpty(oneCell.Value as String))
                {
                    MessageBox.Show("Intenta agregar una funcionalidad con una linea vacia");
                }
                else
                {
                    if (oneCell.Selected)
                    {
                        dataGridView2.Rows.Add(oneCell.Value);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView2.SelectedCells)
            {
                if (String.IsNullOrEmpty(oneCell.Value as String))
                {
                    MessageBox.Show("Intenta borrar una linea vacia");
                }
                else
                {
                    if (oneCell.Selected)
                    {
                        dataGridView2.Rows.RemoveAt(oneCell.RowIndex);
                        MessageBox.Show("Funcionalidad borrada con exito!");
                    }
                }
            }
        }

        private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(sender, e);
        }

        private void ModificarRoles_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           //Igual que en el agregar, hay que modificar la BD y el mismo ABM
                this.Close();
        }

    }
}
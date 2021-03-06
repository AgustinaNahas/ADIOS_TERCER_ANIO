﻿using MercadoEnvios.ABM_Usuario;
using MercadoEnvios.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.Historial_Cliente
{
    public partial class frmHistorialCliente : Form
    {
        Conexion conn;
        Sesion sesion;
        int cantidad;
        int nroPagina = 0;
        SqlDataAdapter da;
        Utilidades fun = new Utilidades();
        public frmHistorialCliente()
        {
            InitializeComponent();
            conn = Conexion.Instance;
            sesion = Sesion.Instance;
            this.getData();
        }

        public void getData()
        {
            String cmd = "ADIOS_TERCER_ANIO.verHistoricoComprasUsuario";

            SqlParameter cant = new SqlParameter("@cant", SqlDbType.Int);
            cant.SqlValue = DBNull.Value;
            cant.Direction = ParameterDirection.Output;

            SqlParameter idUsuario = new SqlParameter("@userId", SqlDbType.Int);
            idUsuario.SqlValue = sesion.idUsuario;
            idUsuario.Direction = ParameterDirection.Input;

            SqlParameter pagina = new SqlParameter("@pagina", SqlDbType.Int);
            pagina.SqlValue = nroPagina;
            pagina.Direction = ParameterDirection.Input;

            da = new SqlDataAdapter(cmd, conn.getConexion);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add(idUsuario);
            da.SelectCommand.Parameters.Add(pagina);
            da.SelectCommand.Parameters.Add(cant);
            
            da.SelectCommand.ExecuteNonQuery();
            DataTable tablaDeCompras = new DataTable("Historial de Compras/Subastas");
            da.Fill(tablaDeCompras);
            grillaDeCompras.DataSource = tablaDeCompras.DefaultView;

            grillaDeCompras.AllowUserToDeleteRows = false;
            grillaDeCompras.AllowUserToAddRows = false;
            grillaDeCompras.ReadOnly = true;
            grillaDeCompras.Columns[0].Width = 150;
            grillaDeCompras.Columns[3].Width = 250;
            if (nroPagina == 0)
            {
                cantidad = Convert.ToInt32(da.SelectCommand.Parameters["@cant"].Value) / 10;
                btnAnt.Enabled = false;
                btnPrimeraPag.Enabled = false;
            }

            if (nroPagina >= cantidad)
            {
                btnSgte.Enabled = false;
            }

            if (grillaDeCompras.Rows.Count <= 0 || grillaDeCompras.Rows.Count < 10)
            {
                if (btnSgte.Enabled == true)
                {
                    btnSgte.Enabled = false;
                }

                if (btnPrimeraPag.Enabled == true)
                {
                    btnPrimeraPag.Enabled = false;
                }

                if (button1.Enabled == true)
                {
                    button1.Enabled = false;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void frmHistorialCliente_Load(object sender, EventArgs e)
        {
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new frmPantallaPrincipal().Show();
            this.Close();

        }

        private void btnSgte_Click(object sender, EventArgs e)
        {
            if (nroPagina <= cantidad)
            {
                nroPagina++;
                btnAnt.Enabled = true;
                this.getData();
                btnPrimeraPag.Enabled = true;
            }
            else
            {
                btnSgte.Enabled = false;
            }
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            nroPagina--;
            if (nroPagina == 0) btnAnt.Enabled = false;
            btnSgte.Enabled = true;
            button1.Enabled = true;
            this.getData();
        }

        private void btnHistorialCalif_Click(object sender, EventArgs e)
        {
            new VendedorCalif().Show();
            this.Close();
        }

        private void btnPrimeraPag_Click(object sender, EventArgs e)
        {
            nroPagina = 0;
            getData();
            btnSgte.Enabled = true;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nroPagina = cantidad;
            getData();
            btnAnt.Enabled = true;
            btnPrimeraPag.Enabled = true;
        }

        private void txtPagina_TextChanged(object sender, EventArgs e)
        {
            if (txtPagina.Text != "")
            {
                if (Convert.ToInt32(txtPagina.Text) <= cantidad)
                {
                    nroPagina = Convert.ToInt32(txtPagina.Text);
                    getData();
                    if (nroPagina != 0)
                    {
                        btnPrimeraPag.Enabled = true;
                        btnAnt.Enabled = true;
                    }

                    if (nroPagina != cantidad)
                    {
                        button1.Enabled = true;
                        btnSgte.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Número de página excedido del máximo existente.");
                    txtPagina.Text = "0";
                }
            }
        }

        private void txtPagina_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.fun.ingresarNumero(e);
        }
    }
}

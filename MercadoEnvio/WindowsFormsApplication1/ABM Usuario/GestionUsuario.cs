﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace MercadoEnvios.ABM_Usuario
{
    public partial class frmABMUsuario : Form
    {
        Conexion conn;
        Form anterior;
        Sesion sesion = Sesion.Instance;

        public frmABMUsuario()
        {
            InitializeComponent();
            anterior = sesion.anterior;
            this.getData();
        }

        public void getData() 
        {
            String query = "SELECT u.id, u.usuario as Nombre_de_Usuario, iif(u.deleted = 0, 'Habilitado', 'Deshabilitado') AS Estado, r.id as idrol FROM ADIOS_TERCER_ANIO.Usuario u "
                              + "inner join ADIOS_TERCER_ANIO.RolUsuario ru on u.id = ru.idUsuario inner join ADIOS_TERCER_ANIO.Rol r on r.id = ru.idRol WHERE ru.idRol = 2";

            conn = Conexion.Instance;

            SqlCommand buscarClientes = new SqlCommand(query, conn.getConexion);
            SqlDataAdapter da = new SqlDataAdapter(query, conn.getConexion);
            DataTable tablaDeClientes = new DataTable("Clientes");
            da.Fill(tablaDeClientes);
            dgvClientes.DataSource = tablaDeClientes.DefaultView;

            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ReadOnly = true;
            dgvClientes.Columns[0].Visible = false;
            dgvClientes.Columns[1].Width = 150;
            dgvClientes.Columns[2].Width = 150;

            String queryAdm = "SELECT u.id, u.usuario as Nombre_de_Usuario, iif(u.deleted = 0, 'Habilitado', 'Deshabilitado') AS Estado FROM ADIOS_TERCER_ANIO.Usuario u "
                               + "inner join ADIOS_TERCER_ANIO.RolUsuario ru on u.id = ru.idUsuario inner join ADIOS_TERCER_ANIO.Rol r on r.id = ru.idRol WHERE ru.idRol = 3";

            SqlCommand buscarEmpresas = new SqlCommand(queryAdm, conn.getConexion);
            SqlDataAdapter emp = new SqlDataAdapter(queryAdm, conn.getConexion);
            DataTable tablaDeEmpresas = new DataTable("Empresas");
            emp.Fill(tablaDeEmpresas);
            dgvEmpresas.DataSource = tablaDeEmpresas.DefaultView;

            dgvEmpresas.AllowUserToAddRows = false;
            dgvEmpresas.AllowUserToDeleteRows = false;
            dgvEmpresas.ReadOnly = true;
            dgvEmpresas.Columns[0].Visible = true;
            dgvEmpresas.Columns[1].Width = 150;
            dgvEmpresas.Columns[2].Width = 150;

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            new frmPantallaPrincipal().Show();
            this.Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new frmNuevoUsuario().Show();
            sesion.anterior = this;
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows == null)
            {
                MessageBox.Show("Debe seleccionar un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                String query = "UPDATE ADIOS_TERCER_ANIO.Usuario SET deleted = 1 WHERE @idUsuario = id";
                SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
                idUsuario.Direction = ParameterDirection.Input;
                actualizacion.Parameters.Add(idUsuario);
                foreach (DataGridViewRow rows in dgvClientes.SelectedRows)
                {
                    idUsuario.SqlValue = Convert.ToInt32(rows.Cells[0].Value);
                    actualizacion.ExecuteNonQuery();
                }

                this.getData();
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows == null)
            {
                MessageBox.Show("Debe seleccionar un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                String query = "UPDATE ADIOS_TERCER_ANIO.Usuario SET deleted = 0 WHERE @idUsuario = id";
                SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
                idUsuario.Direction = ParameterDirection.Input;
                actualizacion.Parameters.Add(idUsuario);
                foreach (DataGridViewRow rows in dgvClientes.SelectedRows)
                {
                    idUsuario.SqlValue = Convert.ToInt32(rows.Cells[0].Value);
                    actualizacion.ExecuteNonQuery();
                }

                this.getData();
            }
            }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dgvClientes.CurrentRow.Cells[0].Value != null){
                sesion.anterior = this;
                new frmModificarCliente(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value)).Show();
                this.Hide();
            }

        }


        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dgvEmpresas.SelectedRows == null || dgvEmpresas.SelectedRows.Count > 1)
            {
                MessageBox.Show("Debe elegir un usuario de Empresas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                new frmModificarEmpresa(Convert.ToInt32(dgvEmpresas.CurrentRow.Cells[0].Value)).Show();
                this.Close();

            }
        }

        private void btnHabilitarEmpresa_Click(object sender, EventArgs e)
        {
            if (dgvEmpresas.SelectedRows == null)
            {
                MessageBox.Show("Debe seleccionar un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String query = "UPDATE ADIOS_TERCER_ANIO.Usuario SET deleted = 0 WHERE @idUsuario = id";
                SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
                idUsuario.Direction = ParameterDirection.Input;
                actualizacion.Parameters.Add(idUsuario);
                foreach (DataGridViewRow rows in dgvEmpresas.SelectedRows)
                {
                    idUsuario.SqlValue = Convert.ToInt32(rows.Cells[0].Value);
                    actualizacion.ExecuteNonQuery();
                }

                this.getData();
            }
        }

        private void btnDeshabilitarEmpresa_Click(object sender, EventArgs e)
        {
            if (dgvEmpresas.SelectedRows == null)
            {
                MessageBox.Show("Debe seleccionar un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String query = "UPDATE ADIOS_TERCER_ANIO.Usuario SET deleted = 1 WHERE @idUsuario = id";
                SqlCommand actualizacion = new SqlCommand(query, conn.getConexion);
                SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
                idUsuario.Direction = ParameterDirection.Input;
                actualizacion.Parameters.Add(idUsuario);
                foreach (DataGridViewRow rows in dgvEmpresas.SelectedRows)
                {
                    idUsuario.SqlValue = Convert.ToInt32(rows.Cells[0].Value);
                    actualizacion.ExecuteNonQuery();
                }

                this.getData();
            }
        }

        private void frmABMUsuario_Shown(object sender, EventArgs e)
        {
            sesion.anterior = anterior;
        }
    
    }

    }

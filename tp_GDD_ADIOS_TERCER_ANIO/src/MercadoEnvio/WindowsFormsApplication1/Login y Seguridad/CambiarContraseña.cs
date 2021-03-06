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

namespace MercadoEnvios.Login_y_Seguridad
{
    public partial class frmCambiarContraseña : Form
    {
        StringBuilder mensajeDeAviso = new StringBuilder();
        private Utilidades funcionesValidacion = new Utilidades();
        string usuarioDeSesion;
        Conexion conn;

        Sesion sesion = Sesion.Instance;

        public frmCambiarContraseña(string usuario)
        {
            InitializeComponent();
            usuarioDeSesion = usuario;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool contraActualOK = funcionesValidacion.validarNoVacio(contraseñaActual, mensajeDeAviso);
            bool contraNuevaOK = funcionesValidacion.validarNoVacio(contraseñaNueva, mensajeDeAviso);
            bool contraConfirOK = funcionesValidacion.validarNoVacio(contraseñaConfirmada, mensajeDeAviso);

            if (!contraActualOK || !contraNuevaOK || !contraConfirOK)
            {
                MessageBox.Show(mensajeDeAviso.ToString());
                mensajeDeAviso.Remove(0, mensajeDeAviso.Length);

            } else {

                if (!validarPassword(usuarioDeSesion, contraseñaActual.Text)){
                    MessageBox.Show("Contraseña incorrecta");
                    contraseñaActual.Text = "";
                    contraseñaConfirmada.Text = "";
                    contraseñaNueva.Text = "";
                }

                else if (contraseñaNueva.Text != contraseñaConfirmada.Text)
                {
                    MessageBox.Show("La contraseña confirmada difiere de la nueva");
                    contraseñaActual.Text = "";
                    contraseñaConfirmada.Text = "";
                    contraseñaNueva.Text = "";
                } 
                else {

                        SqlCommand comandoModificarPassword = new SqlCommand("ADIOS_TERCER_ANIO.modificarPassword", conn.getConexion);
                        comandoModificarPassword.CommandType = CommandType.StoredProcedure;

                        string passHasheada = Utilidades.encriptarCadenaSHA256(contraseñaNueva.Text);

                        comandoModificarPassword.Parameters.Add("@usuario", SqlDbType.NVarChar, 255);
                        comandoModificarPassword.Parameters.Add("@password", SqlDbType.NVarChar, 255);

                        comandoModificarPassword.Parameters[0].Value = usuarioDeSesion;
                        comandoModificarPassword.Parameters[1].Value = passHasheada;

                        comandoModificarPassword.ExecuteNonQuery();
                        MessageBox.Show("Contraseña cambiada correctamente","La operación fue exitosa!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        new frmPantallaPrincipal().Show();
                        this.Close();
                    }

                }
        }

        public bool validarPassword(string usuarioDeSesion, string password)
        {
            conn = Conexion.Instance;
            System.Data.SqlClient.SqlCommand comandoAUsuario = new System.Data.SqlClient.SqlCommand();
            comandoAUsuario.CommandType = CommandType.StoredProcedure;

            string passHasheada = Utilidades.encriptarCadenaSHA256(password);

            comandoAUsuario.Parameters.Add("@usuario", SqlDbType.VarChar);
            comandoAUsuario.Parameters.Add("@password", SqlDbType.VarChar);


            comandoAUsuario.Parameters[0].Value = usuarioDeSesion;
            comandoAUsuario.Parameters[1].Value = passHasheada;


            comandoAUsuario.CommandText = "ADIOS_TERCER_ANIO.validarPassword";

            bool passwordCorrecta = funcionesValidacion.darEscalar(comandoAUsuario);

            return passwordCorrecta;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmPantallaPrincipal().Show();
            this.Close();

        }
    }
}

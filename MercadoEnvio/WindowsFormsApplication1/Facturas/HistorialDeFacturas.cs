﻿using MercadoEnvios.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MercadoEnvios.Facturas
{
    public partial class HistorialDeFacturas : Form
    {
        Conexion conn = Conexion.Instance;
        SqlDataAdapter da;
        Utilidades fun = new Utilidades();
        StringBuilder mensajeValidacion = new StringBuilder();

        int nroPagina = 0;
        Sesion sesion;
        public HistorialDeFacturas()
        {
            InitializeComponent();
            sesion = Sesion.Instance;
            this.getData();

        }

        private void getData()
        {
            DateTime fechaDesdeD = DateTime.ParseExact("2015-02-28 14:40:52,531", "yyyy-MM-dd HH:mm:ss,fff",
                            System.Globalization.CultureInfo.InvariantCulture);
            DateTime fechaHastaD = DateTime.ParseExact("2016-05-28 14:40:52,531", "yyyy-MM-dd HH:mm:ss,fff",
                                       System.Globalization.CultureInfo.InvariantCulture);
            decimal desdePrecioD = -1;
            decimal hastaPrecioD = -1;
            string descripcionD = "";
            string destinatarioD = "";
            int usaFechaD = 0;
           
           if (checkBox1.Checked)
           {
               fechaDesdeD = fechaDesdeDtp.Value;
               fechaHastaD = fechaHastaDtp.Value;
               usaFechaD = 1;
           }

           if (checkBox2.Checked)
           {
               if (fun.validarNoVacio(desdePrecioTxt,mensajeValidacion) && fun.validarNoVacio(hastaPrecioTxt, mensajeValidacion))
               {
                   if(fun.validarDecimal(hastaPrecioTxt, mensajeValidacion) && fun.validarDecimal(hastaPrecioTxt, mensajeValidacion))
                   {
                       desdePrecioD = Convert.ToDecimal(desdePrecioTxt.Text);
                       hastaPrecioD = Convert.ToDecimal(hastaPrecioTxt.Text);
                   }
               }
           }

           if (checkBox4.Checked)
           {
               if(fun.validarNoVacio(descripcionTxt,mensajeValidacion))
               {
                    descripcionD = descripcionTxt.Text;
               }
           }

           if (checkBox3.Checked)
           {
               if (fun.validarNoVacio(destinatarioTxt, mensajeValidacion))
               {
                   destinatarioD = destinatarioTxt.Text;
               }
           }

           if (mensajeValidacion.Length > 0)
           {
               //ADIOS_TERCER_ANIO.obtenerFacturasPaginaN(@idUsuario INT, @pagina INT, @idRol INT, @usa_fecha INT, @fechaDesde DATETIME,
               //@fechaHasta DATETIME, @desdePrecio DECIMAL(18,2), @hastaPrecio DECIMAL (18,2),
               //@descripcion NVARCHAR(255), @destinatario NVARCHAR(255))
               String cmd = "ADIOS_TERCER_ANIO.obtenerFacturasPaginaN";

               SqlParameter idUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
               idUsuario.SqlValue = sesion.idUsuario;
               idUsuario.Direction = ParameterDirection.Input;

               SqlParameter pagina = new SqlParameter("@pagina", SqlDbType.Int);
               pagina.SqlValue = nroPagina;
               pagina.Direction = ParameterDirection.Input;

               SqlParameter idRol = new SqlParameter("@idRol", SqlDbType.Int);
               idRol.SqlValue = sesion.idRol;
               idRol.Direction = ParameterDirection.Input;

               SqlParameter usa_fecha = new SqlParameter("@usa_fecha", SqlDbType.Int);
               usa_fecha.SqlValue = usaFechaD;
               usa_fecha.Direction = ParameterDirection.Input;

               SqlParameter fechaDesde = new SqlParameter("@fechaDesde", SqlDbType.DateTime);
               fechaDesde.SqlValue = Convert.ToDateTime(fechaDesdeD);
               fechaDesde.Direction = ParameterDirection.Input;

               SqlParameter fechaHasta = new SqlParameter("@fechaHasta", SqlDbType.DateTime);
               fechaHasta.SqlValue = Convert.ToDateTime(fechaHasta);
               fechaHasta.Direction = ParameterDirection.Input;

               SqlParameter desdePrecio = new SqlParameter("@desdePrecio", SqlDbType.Decimal);
               desdePrecio.SqlValue = desdePrecioD;
               desdePrecio.Direction = ParameterDirection.Input;

               SqlParameter hastaPrecio = new SqlParameter("@hastaPrecio", SqlDbType.Decimal);
               hastaPrecio.SqlValue = hastaPrecioD;
               hastaPrecio.Direction = ParameterDirection.Input;

               SqlParameter descripcion = new SqlParameter("@descripcion", SqlDbType.NVarChar, 255);
               descripcion.SqlValue = descripcionD;
               descripcion.Direction = ParameterDirection.Input;

               SqlParameter destinatario = new SqlParameter("@destinatario", SqlDbType.NVarChar, 255);
               destinatario.SqlValue = destinatarioD;
               destinatario.Direction = ParameterDirection.Input;

               da = new SqlDataAdapter(cmd, conn.getConexion);
               da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
               da.SelectCommand.Parameters.Add(idUsuario);
               da.SelectCommand.Parameters.Add(pagina);
               da.SelectCommand.Parameters.Add(idRol);
               da.SelectCommand.Parameters.Add(usa_fecha);
               da.SelectCommand.Parameters.Add(destinatario);
               da.SelectCommand.Parameters.Add(descripcion);
               da.SelectCommand.Parameters.Add(fechaHasta);
               da.SelectCommand.Parameters.Add(fechaDesde);
               da.SelectCommand.Parameters.Add(desdePrecio);
               da.SelectCommand.Parameters.Add(hastaPrecio);

               try
               {
                   da.SelectCommand.ExecuteNonQuery();
                   DataTable tablaDeFacturas = new DataTable("Facturas");
                   da.Fill(tablaDeFacturas);
                   dgvFacturas.DataSource = tablaDeFacturas;
                   dgvFacturas.Columns[0].Width = 50;
                   dgvFacturas.Columns[1].Width = 100;
                   dgvFacturas.Columns[2].Width = 100;
                   dgvFacturas.Columns[3].Width = 150;
                   dgvFacturas.AllowUserToDeleteRows = false;
                   dgvFacturas.AllowUserToAddRows = false;
                   dgvFacturas.ReadOnly = true;
               }
               catch (SqlException error)
               {
                   btnSgte.Enabled = false;
                   MessageBox.Show(error.Message);
               }
           }
           else 
           {
               mensajeValidacion = new StringBuilder();
           }

        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            nroPagina--;
            if (nroPagina == 0) btnAnt.Enabled = false;
            btnSgte.Enabled = true;
            this.getData();
        }

        private void btnSgte_Click(object sender, EventArgs e)
        {
            nroPagina++;
            btnAnt.Enabled = true;
            this.getData();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new MercadoEnvios.ABM_Usuario.frmPantallaPrincipal().Show();
            this.Close();
        }

        private void HistorialDeFacturas_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.getData();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fechaDesdeDtp.Enabled = true;
                fechaHastaDtp.Enabled = true;
            }
            else
            {
                fechaDesdeDtp.Enabled = false;
                fechaHastaDtp.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                desdePrecioTxt.ReadOnly = false;
                hastaPrecioTxt.ReadOnly = false;
            }
            else
            {
                desdePrecioTxt.ReadOnly = true;
                hastaPrecioTxt.ReadOnly = true;
                desdePrecioTxt.Text = "";
                hastaPrecioTxt.Text = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                destinatarioTxt.ReadOnly = false;
            }
            else
            {
                destinatarioTxt.ReadOnly = true;
                destinatarioTxt.Text = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                descripcionTxt.ReadOnly = false;
            }
            else
            {
                descripcionTxt.ReadOnly = true;
                descripcionTxt.Text = "";
            }
        }
    }
}
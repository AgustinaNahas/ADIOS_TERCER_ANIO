﻿namespace MercadoEnvios.ABM_Usuario
{
    partial class frmModificarEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.Razon_Social = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.TextBox();
            this.Contrasenia = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Rubro = new System.Windows.Forms.ComboBox();
            this.Localidad = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre_de_Contacto = new System.Windows.Forms.TextBox();
            this.CUIT = new System.Windows.Forms.TextBox();
            this.Ciudad = new System.Windows.Forms.TextBox();
            this.Codigo_Postal = new System.Windows.Forms.TextBox();
            this.Depto = new System.Windows.Forms.TextBox();
            this.Piso = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.Calle = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(761, 506);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 67;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(621, 506);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Razon_Social
            // 
            this.Razon_Social.Location = new System.Drawing.Point(232, 144);
            this.Razon_Social.Margin = new System.Windows.Forms.Padding(4);
            this.Razon_Social.Name = "Razon_Social";
            this.Razon_Social.Size = new System.Drawing.Size(211, 22);
            this.Razon_Social.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 98;
            this.label2.Text = "Dirección de Mail:";
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(232, 106);
            this.Mail.Margin = new System.Windows.Forms.Padding(4);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(211, 22);
            this.Mail.TabIndex = 3;
            this.Mail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mail_KeyPress_1);
            // 
            // Contrasenia
            // 
            this.Contrasenia.Location = new System.Drawing.Point(232, 74);
            this.Contrasenia.Margin = new System.Windows.Forms.Padding(4);
            this.Contrasenia.MaxLength = 8;
            this.Contrasenia.Name = "Contrasenia";
            this.Contrasenia.PasswordChar = '*';
            this.Contrasenia.Size = new System.Drawing.Size(211, 22);
            this.Contrasenia.TabIndex = 2;
            // 
            // Usuario
            // 
            this.Usuario.AcceptsReturn = true;
            this.Usuario.Location = new System.Drawing.Point(232, 42);
            this.Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.Usuario.MaxLength = 11;
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(211, 22);
            this.Usuario.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(87, 78);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 17);
            this.label14.TabIndex = 97;
            this.label14.Text = "Contraseña:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(87, 46);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 17);
            this.label15.TabIndex = 96;
            this.label15.Text = "Usuario: ";
            // 
            // Rubro
            // 
            this.Rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rubro.FormattingEnabled = true;
            this.Rubro.Location = new System.Drawing.Point(232, 450);
            this.Rubro.Margin = new System.Windows.Forms.Padding(4);
            this.Rubro.Name = "Rubro";
            this.Rubro.Size = new System.Drawing.Size(265, 24);
            this.Rubro.TabIndex = 15;
            // 
            // Localidad
            // 
            this.Localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Localidad.FormattingEnabled = true;
            this.Localidad.Location = new System.Drawing.Point(232, 284);
            this.Localidad.Margin = new System.Windows.Forms.Padding(4);
            this.Localidad.Name = "Localidad";
            this.Localidad.Size = new System.Drawing.Size(180, 24);
            this.Localidad.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(87, 220);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 17);
            this.label13.TabIndex = 95;
            this.label13.Text = "Calle:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 454);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 94;
            this.label12.Text = "Rubro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 422);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 17);
            this.label11.TabIndex = 93;
            this.label11.Text = "Nombre de Contacto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 390);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 92;
            this.label10.Text = "CUIT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 358);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 91;
            this.label9.Text = "Ciudad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 322);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 90;
            this.label8.Text = "Código Postal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 288);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 89;
            this.label7.Text = "Localidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 88;
            this.label6.Text = "Depto.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 87;
            this.label5.Text = "Piso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 86;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "Teléfono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 84;
            this.label1.Text = "Razón Social:";
            // 
            // Nombre_de_Contacto
            // 
            this.Nombre_de_Contacto.Location = new System.Drawing.Point(232, 418);
            this.Nombre_de_Contacto.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre_de_Contacto.Name = "Nombre_de_Contacto";
            this.Nombre_de_Contacto.Size = new System.Drawing.Size(132, 22);
            this.Nombre_de_Contacto.TabIndex = 14;
            this.Nombre_de_Contacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_de_Contacto_KeyPress);
            // 
            // CUIT
            // 
            this.CUIT.Location = new System.Drawing.Point(232, 386);
            this.CUIT.Margin = new System.Windows.Forms.Padding(4);
            this.CUIT.Name = "CUIT";
            this.CUIT.Size = new System.Drawing.Size(132, 22);
            this.CUIT.TabIndex = 13;
            this.CUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CUIT_KeyPress);
            // 
            // Ciudad
            // 
            this.Ciudad.Location = new System.Drawing.Point(232, 354);
            this.Ciudad.Margin = new System.Windows.Forms.Padding(4);
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Size = new System.Drawing.Size(132, 22);
            this.Ciudad.TabIndex = 12;
            this.Ciudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ciudad_KeyPress);
            // 
            // Codigo_Postal
            // 
            this.Codigo_Postal.Location = new System.Drawing.Point(232, 322);
            this.Codigo_Postal.Margin = new System.Windows.Forms.Padding(4);
            this.Codigo_Postal.Name = "Codigo_Postal";
            this.Codigo_Postal.Size = new System.Drawing.Size(132, 22);
            this.Codigo_Postal.TabIndex = 11;
            this.Codigo_Postal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Codigo_Postal_KeyPress);
            // 
            // Depto
            // 
            this.Depto.Location = new System.Drawing.Point(507, 252);
            this.Depto.Margin = new System.Windows.Forms.Padding(4);
            this.Depto.Name = "Depto";
            this.Depto.Size = new System.Drawing.Size(132, 22);
            this.Depto.TabIndex = 9;
            this.Depto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Depto_KeyPress);
            // 
            // Piso
            // 
            this.Piso.Location = new System.Drawing.Point(232, 249);
            this.Piso.Margin = new System.Windows.Forms.Padding(4);
            this.Piso.Name = "Piso";
            this.Piso.Size = new System.Drawing.Size(132, 22);
            this.Piso.TabIndex = 8;
            this.Piso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Piso_KeyPress);
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(507, 217);
            this.Direccion.Margin = new System.Windows.Forms.Padding(4);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(132, 22);
            this.Direccion.TabIndex = 7;
            this.Direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Direccion_KeyPress);
            // 
            // Calle
            // 
            this.Calle.Location = new System.Drawing.Point(232, 217);
            this.Calle.Margin = new System.Windows.Forms.Padding(4);
            this.Calle.Name = "Calle";
            this.Calle.Size = new System.Drawing.Size(132, 22);
            this.Calle.TabIndex = 6;
            this.Calle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calle_KeyPress);
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(232, 180);
            this.Telefono.Margin = new System.Windows.Forms.Padding(4);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(132, 22);
            this.Telefono.TabIndex = 5;
            this.Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Telefono_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(665, 43);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(190, 18);
            this.label28.TabIndex = 273;
            this.label28.Text = "* : Campos Obligatorios";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(463, 43);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 20);
            this.label17.TabIndex = 275;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(463, 75);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 20);
            this.label16.TabIndex = 276;
            this.label16.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(463, 107);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 20);
            this.label18.TabIndex = 277;
            this.label18.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(463, 144);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 20);
            this.label19.TabIndex = 278;
            this.label19.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(373, 390);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 20);
            this.label20.TabIndex = 279;
            this.label20.Text = "*";
            // 
            // frmModificarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 560);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.Razon_Social);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Contrasenia);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Rubro);
            this.Controls.Add(this.Localidad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombre_de_Contacto);
            this.Controls.Add(this.CUIT);
            this.Controls.Add(this.Ciudad);
            this.Controls.Add(this.Codigo_Postal);
            this.Controls.Add(this.Depto);
            this.Controls.Add(this.Piso);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Calle);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModificarEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox Razon_Social;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.TextBox Contrasenia;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox Rubro;
        private System.Windows.Forms.ComboBox Localidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombre_de_Contacto;
        private System.Windows.Forms.TextBox CUIT;
        private System.Windows.Forms.TextBox Ciudad;
        private System.Windows.Forms.TextBox Codigo_Postal;
        private System.Windows.Forms.TextBox Depto;
        private System.Windows.Forms.TextBox Piso;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.TextBox Calle;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}
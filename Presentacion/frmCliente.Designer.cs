﻿namespace Presentacion
{
    partial class frmCliente
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
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.gbDireccion = new System.Windows.Forms.GroupBox();
            this.txtbDpto = new System.Windows.Forms.TextBox();
            this.txtbPiso = new System.Windows.Forms.TextBox();
            this.txtbNro = new System.Windows.Forms.TextBox();
            this.txtbCalle = new System.Windows.Forms.TextBox();
            this.cmboxLocalidad = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cmboxProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cmboxPais = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblNroCalle = new System.Windows.Forms.Label();
            this.txtbRazonSocial = new System.Windows.Forms.TextBox();
            this.txtbCUIT = new System.Windows.Forms.TextBox();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.gbContacto = new System.Windows.Forms.GroupBox();
            this.btnEliminarContacto = new System.Windows.Forms.Button();
            this.btnAgregarContacto = new System.Windows.Forms.Button();
            this.dgvContacto = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gbDireccion.SuspendLayout();
            this.gbContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(165, 61);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(48, 36);
            this.lblIdCliente.TabIndex = 0;
            this.lblIdCliente.Text = "ID:";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuit.Location = new System.Drawing.Point(135, 112);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(76, 36);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "CUIT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Razon social:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(73, 243);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(80, 36);
            this.lblCalle.TabIndex = 3;
            this.lblCalle.Text = "Calle:";
            // 
            // gbDireccion
            // 
            this.gbDireccion.Controls.Add(this.txtbDpto);
            this.gbDireccion.Controls.Add(this.txtbPiso);
            this.gbDireccion.Controls.Add(this.txtbNro);
            this.gbDireccion.Controls.Add(this.txtbCalle);
            this.gbDireccion.Controls.Add(this.cmboxLocalidad);
            this.gbDireccion.Controls.Add(this.lblLocalidad);
            this.gbDireccion.Controls.Add(this.cmboxProvincia);
            this.gbDireccion.Controls.Add(this.lblProvincia);
            this.gbDireccion.Controls.Add(this.cmboxPais);
            this.gbDireccion.Controls.Add(this.lblPais);
            this.gbDireccion.Controls.Add(this.lblDepartamento);
            this.gbDireccion.Controls.Add(this.lblPiso);
            this.gbDireccion.Controls.Add(this.lblNroCalle);
            this.gbDireccion.Controls.Add(this.lblCalle);
            this.gbDireccion.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDireccion.Location = new System.Drawing.Point(48, 233);
            this.gbDireccion.Name = "gbDireccion";
            this.gbDireccion.Size = new System.Drawing.Size(592, 505);
            this.gbDireccion.TabIndex = 4;
            this.gbDireccion.TabStop = false;
            this.gbDireccion.Text = "Direccion";
            // 
            // txtbDpto
            // 
            this.txtbDpto.Location = new System.Drawing.Point(164, 421);
            this.txtbDpto.Name = "txtbDpto";
            this.txtbDpto.Size = new System.Drawing.Size(383, 40);
            this.txtbDpto.TabIndex = 16;
            // 
            // txtbPiso
            // 
            this.txtbPiso.Location = new System.Drawing.Point(164, 360);
            this.txtbPiso.Name = "txtbPiso";
            this.txtbPiso.Size = new System.Drawing.Size(383, 40);
            this.txtbPiso.TabIndex = 15;
            // 
            // txtbNro
            // 
            this.txtbNro.Location = new System.Drawing.Point(164, 299);
            this.txtbNro.Name = "txtbNro";
            this.txtbNro.Size = new System.Drawing.Size(383, 40);
            this.txtbNro.TabIndex = 14;
            // 
            // txtbCalle
            // 
            this.txtbCalle.Location = new System.Drawing.Point(164, 238);
            this.txtbCalle.Name = "txtbCalle";
            this.txtbCalle.Size = new System.Drawing.Size(383, 40);
            this.txtbCalle.TabIndex = 13;
            // 
            // cmboxLocalidad
            // 
            this.cmboxLocalidad.FormattingEnabled = true;
            this.cmboxLocalidad.Location = new System.Drawing.Point(164, 52);
            this.cmboxLocalidad.Name = "cmboxLocalidad";
            this.cmboxLocalidad.Size = new System.Drawing.Size(383, 41);
            this.cmboxLocalidad.TabIndex = 12;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(24, 57);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(134, 36);
            this.lblLocalidad.TabIndex = 11;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // cmboxProvincia
            // 
            this.cmboxProvincia.FormattingEnabled = true;
            this.cmboxProvincia.Location = new System.Drawing.Point(164, 114);
            this.cmboxProvincia.Name = "cmboxProvincia";
            this.cmboxProvincia.Size = new System.Drawing.Size(383, 41);
            this.cmboxProvincia.TabIndex = 10;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(27, 119);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(131, 36);
            this.lblProvincia.TabIndex = 9;
            this.lblProvincia.Text = "Provincia:";
            // 
            // cmboxPais
            // 
            this.cmboxPais.FormattingEnabled = true;
            this.cmboxPais.Location = new System.Drawing.Point(164, 176);
            this.cmboxPais.Name = "cmboxPais";
            this.cmboxPais.Size = new System.Drawing.Size(383, 41);
            this.cmboxPais.TabIndex = 8;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(84, 181);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(69, 36);
            this.lblPais.TabIndex = 7;
            this.lblPais.Text = "Pais:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(73, 429);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(81, 36);
            this.lblDepartamento.TabIndex = 6;
            this.lblDepartamento.Text = "Dpto:";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiso.Location = new System.Drawing.Point(82, 367);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(71, 36);
            this.lblPiso.TabIndex = 5;
            this.lblPiso.Text = "Piso:";
            // 
            // lblNroCalle
            // 
            this.lblNroCalle.AutoSize = true;
            this.lblNroCalle.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCalle.Location = new System.Drawing.Point(87, 305);
            this.lblNroCalle.Name = "lblNroCalle";
            this.lblNroCalle.Size = new System.Drawing.Size(67, 36);
            this.lblNroCalle.TabIndex = 4;
            this.lblNroCalle.Text = "Nro:";
            // 
            // txtbRazonSocial
            // 
            this.txtbRazonSocial.Location = new System.Drawing.Point(224, 168);
            this.txtbRazonSocial.Name = "txtbRazonSocial";
            this.txtbRazonSocial.Size = new System.Drawing.Size(371, 31);
            this.txtbRazonSocial.TabIndex = 14;
            // 
            // txtbCUIT
            // 
            this.txtbCUIT.Location = new System.Drawing.Point(224, 112);
            this.txtbCUIT.Name = "txtbCUIT";
            this.txtbCUIT.Size = new System.Drawing.Size(371, 31);
            this.txtbCUIT.TabIndex = 15;
            // 
            // txtbID
            // 
            this.txtbID.Location = new System.Drawing.Point(224, 61);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(371, 31);
            this.txtbID.TabIndex = 16;
            // 
            // gbContacto
            // 
            this.gbContacto.Controls.Add(this.btnEliminarContacto);
            this.gbContacto.Controls.Add(this.btnAgregarContacto);
            this.gbContacto.Controls.Add(this.dgvContacto);
            this.gbContacto.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContacto.Location = new System.Drawing.Point(678, 61);
            this.gbContacto.Name = "gbContacto";
            this.gbContacto.Size = new System.Drawing.Size(928, 677);
            this.gbContacto.TabIndex = 17;
            this.gbContacto.TabStop = false;
            this.gbContacto.Text = "Contacto";
            // 
            // btnEliminarContacto
            // 
            this.btnEliminarContacto.Location = new System.Drawing.Point(427, 39);
            this.btnEliminarContacto.Name = "btnEliminarContacto";
            this.btnEliminarContacto.Size = new System.Drawing.Size(225, 42);
            this.btnEliminarContacto.TabIndex = 2;
            this.btnEliminarContacto.Text = "Eliminar contacto";
            this.btnEliminarContacto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarContacto
            // 
            this.btnAgregarContacto.Location = new System.Drawing.Point(674, 39);
            this.btnAgregarContacto.Name = "btnAgregarContacto";
            this.btnAgregarContacto.Size = new System.Drawing.Size(237, 42);
            this.btnAgregarContacto.TabIndex = 1;
            this.btnAgregarContacto.Text = "Agregar contacto";
            this.btnAgregarContacto.UseVisualStyleBackColor = true;
            // 
            // dgvContacto
            // 
            this.dgvContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacto.Location = new System.Drawing.Point(6, 107);
            this.dgvContacto.Name = "dgvContacto";
            this.dgvContacto.RowTemplate.Height = 33;
            this.dgvContacto.Size = new System.Drawing.Size(916, 565);
            this.dgvContacto.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(1398, 786);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(202, 52);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(1138, 786);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(226, 52);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 868);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbContacto);
            this.Controls.Add(this.txtbID);
            this.Controls.Add(this.txtbCUIT);
            this.Controls.Add(this.txtbRazonSocial);
            this.Controls.Add(this.gbDireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.lblIdCliente);
            this.MaximumSize = new System.Drawing.Size(1694, 939);
            this.MinimumSize = new System.Drawing.Size(1694, 939);
            this.Name = "frmCliente";
            this.Text = "Formulario cliente";
            this.gbDireccion.ResumeLayout(false);
            this.gbDireccion.PerformLayout();
            this.gbContacto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.GroupBox gbDireccion;
        private System.Windows.Forms.TextBox txtbDpto;
        private System.Windows.Forms.TextBox txtbPiso;
        private System.Windows.Forms.TextBox txtbNro;
        private System.Windows.Forms.TextBox txtbCalle;
        private System.Windows.Forms.ComboBox cmboxLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox cmboxProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cmboxPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblNroCalle;
        private System.Windows.Forms.TextBox txtbRazonSocial;
        private System.Windows.Forms.TextBox txtbCUIT;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.GroupBox gbContacto;
        private System.Windows.Forms.Button btnEliminarContacto;
        private System.Windows.Forms.Button btnAgregarContacto;
        private System.Windows.Forms.DataGridView dgvContacto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
    }
}
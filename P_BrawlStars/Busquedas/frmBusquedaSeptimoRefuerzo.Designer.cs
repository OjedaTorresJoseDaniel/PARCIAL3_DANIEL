﻿namespace P_BrawlStars.Busquedas
{
    partial class frmBusquedaSeptimoRefuerzo
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
            this.dgSeptimoRefuerzo = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSeptimoRefuerzo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSeptimoRefuerzo
            // 
            this.dgSeptimoRefuerzo.AllowUserToAddRows = false;
            this.dgSeptimoRefuerzo.AllowUserToDeleteRows = false;
            this.dgSeptimoRefuerzo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSeptimoRefuerzo.Location = new System.Drawing.Point(103, 64);
            this.dgSeptimoRefuerzo.Name = "dgSeptimoRefuerzo";
            this.dgSeptimoRefuerzo.ReadOnly = true;
            this.dgSeptimoRefuerzo.Size = new System.Drawing.Size(603, 239);
            this.dgSeptimoRefuerzo.TabIndex = 39;
            this.dgSeptimoRefuerzo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSeptimoRefuerzo_CellClick);
            this.dgSeptimoRefuerzo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSeptimoRefuerzo_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(639, 317);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(558, 317);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 37;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(103, 27);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(547, 20);
            this.txtFiltro.TabIndex = 35;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuscar.Image = global::P_BrawlStars.Properties.Resources.lupa1;
            this.btnBuscar.Location = new System.Drawing.Point(656, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 45);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmBusquedaSeptimoRefuerzo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgSeptimoRefuerzo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Name = "frmBusquedaSeptimoRefuerzo";
            this.Text = "frmBusquedaSeptimoRefuerzo";
            this.Load += new System.EventHandler(this.frmBusquedaSeptimoRefuerzo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSeptimoRefuerzo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgSeptimoRefuerzo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}
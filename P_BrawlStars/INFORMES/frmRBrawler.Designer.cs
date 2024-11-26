namespace P_BrawlStars.INFORMES
{
    partial class frmRBrawler
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbCalidad = new System.Windows.Forms.ComboBox();
            this.chTodo = new System.Windows.Forms.CheckBox();
            this.rvBrawler = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(504, 65);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 31);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbCalidad
            // 
            this.cbCalidad.FormattingEnabled = true;
            this.cbCalidad.Location = new System.Drawing.Point(253, 69);
            this.cbCalidad.Name = "cbCalidad";
            this.cbCalidad.Size = new System.Drawing.Size(234, 21);
            this.cbCalidad.TabIndex = 12;
            // 
            // chTodo
            // 
            this.chTodo.AutoSize = true;
            this.chTodo.Location = new System.Drawing.Point(167, 73);
            this.chTodo.Name = "chTodo";
            this.chTodo.Size = new System.Drawing.Size(51, 17);
            this.chTodo.TabIndex = 11;
            this.chTodo.Text = "Todo";
            this.chTodo.UseVisualStyleBackColor = true;
            // 
            // rvBrawler
            // 
            this.rvBrawler.LocalReport.ReportEmbeddedResource = "P_BrawlStars.INFORMES.rFuerza.rdlc";
            this.rvBrawler.Location = new System.Drawing.Point(12, 136);
            this.rvBrawler.Name = "rvBrawler";
            this.rvBrawler.ServerReport.BearerToken = null;
            this.rvBrawler.Size = new System.Drawing.Size(900, 236);
            this.rvBrawler.TabIndex = 10;
            // 
            // frmRBrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbCalidad);
            this.Controls.Add(this.chTodo);
            this.Controls.Add(this.rvBrawler);
            this.Name = "frmRBrawler";
            this.Text = "frmRBrawler";
            this.Load += new System.EventHandler(this.frmRBrawler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbCalidad;
        private System.Windows.Forms.CheckBox chTodo;
        private Microsoft.Reporting.WinForms.ReportViewer rvBrawler;
    }
}
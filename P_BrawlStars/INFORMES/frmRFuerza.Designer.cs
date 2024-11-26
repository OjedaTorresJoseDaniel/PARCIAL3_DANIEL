namespace P_BrawlStars.INFORMES
{
    partial class frmRFuerza
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
            this.rvFuerza = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbSalud = new System.Windows.Forms.ComboBox();
            this.chTodo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rvFuerza
            // 
            this.rvFuerza.LocalReport.ReportEmbeddedResource = "P_BrawlStars.INFORMES.rFuerza.rdlc";
            this.rvFuerza.Location = new System.Drawing.Point(12, 142);
            this.rvFuerza.Name = "rvFuerza";
            this.rvFuerza.ServerReport.BearerToken = null;
            this.rvFuerza.Size = new System.Drawing.Size(900, 236);
            this.rvFuerza.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(504, 71);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 31);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbSalud
            // 
            this.cbSalud.FormattingEnabled = true;
            this.cbSalud.Location = new System.Drawing.Point(253, 75);
            this.cbSalud.Name = "cbSalud";
            this.cbSalud.Size = new System.Drawing.Size(234, 21);
            this.cbSalud.TabIndex = 8;
            // 
            // chTodo
            // 
            this.chTodo.AutoSize = true;
            this.chTodo.Location = new System.Drawing.Point(167, 79);
            this.chTodo.Name = "chTodo";
            this.chTodo.Size = new System.Drawing.Size(51, 17);
            this.chTodo.TabIndex = 7;
            this.chTodo.Text = "Todo";
            this.chTodo.UseVisualStyleBackColor = true;
            // 
            // frmRFuerza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbSalud);
            this.Controls.Add(this.chTodo);
            this.Controls.Add(this.rvFuerza);
            this.Name = "frmRFuerza";
            this.Text = "frmRFuerza";
            this.Load += new System.EventHandler(this.frmRFuerza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvFuerza;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbSalud;
        private System.Windows.Forms.CheckBox chTodo;
    }
}
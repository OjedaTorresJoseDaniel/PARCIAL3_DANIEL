namespace P_BrawlStars.INFORMES
{
    partial class frmRMarca
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
            this.cbCopa = new System.Windows.Forms.ComboBox();
            this.chTodo = new System.Windows.Forms.CheckBox();
            this.rvMarca = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(463, 61);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(121, 31);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbCopa
            // 
            this.cbCopa.FormattingEnabled = true;
            this.cbCopa.Location = new System.Drawing.Point(212, 65);
            this.cbCopa.Name = "cbCopa";
            this.cbCopa.Size = new System.Drawing.Size(234, 21);
            this.cbCopa.TabIndex = 5;
            // 
            // chTodo
            // 
            this.chTodo.AutoSize = true;
            this.chTodo.Location = new System.Drawing.Point(126, 69);
            this.chTodo.Name = "chTodo";
            this.chTodo.Size = new System.Drawing.Size(51, 17);
            this.chTodo.TabIndex = 4;
            this.chTodo.Text = "Todo";
            this.chTodo.UseVisualStyleBackColor = true;
            // 
            // rvMarca
            // 
            this.rvMarca.LocalReport.ReportEmbeddedResource = "P_BrawlStars.INFORMES.rMarca.rdlc";
            this.rvMarca.Location = new System.Drawing.Point(12, 124);
            this.rvMarca.Name = "rvMarca";
            this.rvMarca.ServerReport.BearerToken = null;
            this.rvMarca.Size = new System.Drawing.Size(866, 297);
            this.rvMarca.TabIndex = 7;
            // 
            // frmRMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.rvMarca);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbCopa);
            this.Controls.Add(this.chTodo);
            this.Name = "frmRMarca";
            this.Text = "frmRMarca";
            this.Load += new System.EventHandler(this.frmRMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbCopa;
        private System.Windows.Forms.CheckBox chTodo;
        private Microsoft.Reporting.WinForms.ReportViewer rvMarca;
    }
}
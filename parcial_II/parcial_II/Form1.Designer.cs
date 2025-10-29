namespace parcial_II
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.lblClaveLogin = new System.Windows.Forms.Label();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.txtClaveLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.AutoSize = true;
            this.lblUsuarioLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogin.Location = new System.Drawing.Point(86, 108);
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(75, 19);
            this.lblUsuarioLogin.TabIndex = 0;
            this.lblUsuarioLogin.Text = "USUARIO:";
            // 
            // lblClaveLogin
            // 
            this.lblClaveLogin.AutoSize = true;
            this.lblClaveLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveLogin.Location = new System.Drawing.Point(86, 143);
            this.lblClaveLogin.Name = "lblClaveLogin";
            this.lblClaveLogin.Size = new System.Drawing.Size(54, 19);
            this.lblClaveLogin.TabIndex = 1;
            this.lblClaveLogin.Text = "CLAVE:";
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(167, 107);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioLogin.TabIndex = 2;
            // 
            // txtClaveLogin
            // 
            this.txtClaveLogin.Location = new System.Drawing.Point(167, 142);
            this.txtClaveLogin.Name = "txtClaveLogin";
            this.txtClaveLogin.Size = new System.Drawing.Size(100, 20);
            this.txtClaveLogin.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 247);
            this.Controls.Add(this.txtClaveLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.lblClaveLogin);
            this.Controls.Add(this.lblUsuarioLogin);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioLogin;
        private System.Windows.Forms.Label lblClaveLogin;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.TextBox txtClaveLogin;
    }
}


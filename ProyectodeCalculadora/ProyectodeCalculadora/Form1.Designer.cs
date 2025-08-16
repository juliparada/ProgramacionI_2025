
namespace ProyectodeCalculadora
{
    partial class form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblIsss = new System.Windows.Forms.Label();
            this.lblAfp = new System.Windows.Forms.Label();
            this.lblIsr = new System.Windows.Forms.Label();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.lblDeducciones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(545, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(122, 110);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(85, 22);
            this.lblSueldo.TabIndex = 1;
            this.lblSueldo.Text = "SUELDO:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(213, 110);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(121, 20);
            this.txtSueldo.TabIndex = 2;
            // 
            // lblIsss
            // 
            this.lblIsss.AutoSize = true;
            this.lblIsss.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsss.Location = new System.Drawing.Point(157, 153);
            this.lblIsss.Name = "lblIsss";
            this.lblIsss.Size = new System.Drawing.Size(43, 19);
            this.lblIsss.TabIndex = 3;
            this.lblIsss.Text = "ISSS:";
            // 
            // lblAfp
            // 
            this.lblAfp.AutoSize = true;
            this.lblAfp.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfp.Location = new System.Drawing.Point(157, 191);
            this.lblAfp.Name = "lblAfp";
            this.lblAfp.Size = new System.Drawing.Size(42, 19);
            this.lblAfp.TabIndex = 4;
            this.lblAfp.Text = "AFP:";
            // 
            // lblIsr
            // 
            this.lblIsr.AutoSize = true;
            this.lblIsr.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsr.Location = new System.Drawing.Point(157, 228);
            this.lblIsr.Name = "lblIsr";
            this.lblIsr.Size = new System.Drawing.Size(38, 19);
            this.lblIsr.TabIndex = 5;
            this.lblIsr.Text = "ISR:";
            // 
            // lblSueldoNeto
            // 
            this.lblSueldoNeto.AutoSize = true;
            this.lblSueldoNeto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoNeto.Location = new System.Drawing.Point(440, 200);
            this.lblSueldoNeto.Name = "lblSueldoNeto";
            this.lblSueldoNeto.Size = new System.Drawing.Size(121, 19);
            this.lblSueldoNeto.TabIndex = 6;
            this.lblSueldoNeto.Text = "SUELDO NETO: ";
            // 
            // lblDeducciones
            // 
            this.lblDeducciones.AutoSize = true;
            this.lblDeducciones.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeducciones.Location = new System.Drawing.Point(367, 171);
            this.lblDeducciones.Name = "lblDeducciones";
            this.lblDeducciones.Size = new System.Drawing.Size(194, 19);
            this.lblDeducciones.TabIndex = 7;
            this.lblDeducciones.Text = "TOTAL DE DEDUCCIONES:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "CÁLCULO DE DEDUCCIONES";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(769, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDeducciones);
            this.Controls.Add(this.lblSueldoNeto);
            this.Controls.Add(this.lblIsr);
            this.Controls.Add(this.lblAfp);
            this.Controls.Add(this.lblIsss);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.button1);
            this.Name = "form1";
            this.Text = "Deducciones";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblIsss;
        private System.Windows.Forms.Label lblAfp;
        private System.Windows.Forms.Label lblIsr;
        private System.Windows.Forms.Label lblSueldoNeto;
        private System.Windows.Forms.Label lblDeducciones;
        private System.Windows.Forms.Label label1;
    }
}


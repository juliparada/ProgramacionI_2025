
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.grbOpciones = new System.Windows.Forms.GroupBox();
            this.optPrimo = new System.Windows.Forms.RadioButton();
            this.optFactorial = new System.Windows.Forms.RadioButton();
            this.optPorcentaje = new System.Windows.Forms.RadioButton();
            this.optExponenciacion = new System.Windows.Forms.RadioButton();
            this.optDivision = new System.Windows.Forms.RadioButton();
            this.optMultiplicacion = new System.Windows.Forms.RadioButton();
            this.optResta = new System.Windows.Forms.RadioButton();
            this.optSuma = new System.Windows.Forms.RadioButton();
            this.cboOpciones = new System.Windows.Forms.ComboBox();
            this.btnOpciones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNum1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNum1.Location = new System.Drawing.Point(306, 130);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(116, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNum1.Location = new System.Drawing.Point(248, 124);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(48, 24);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "Num 1:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(78, 270);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(83, 31);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNum2.Location = new System.Drawing.Point(248, 160);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(52, 24);
            this.lblNum2.TabIndex = 4;
            this.lblNum2.Text = "Num 2:";
            // 
            // txtNum2
            // 
            this.txtNum2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNum2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNum2.Location = new System.Drawing.Point(306, 166);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(116, 20);
            this.txtNum2.TabIndex = 3;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblRespuesta.Location = new System.Drawing.Point(248, 240);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(87, 24);
            this.lblRespuesta.TabIndex = 5;
            this.lblRespuesta.Text = "Respuesta: ...";
            // 
            // grbOpciones
            // 
            this.grbOpciones.Controls.Add(this.optPrimo);
            this.grbOpciones.Controls.Add(this.optExponenciacion);
            this.grbOpciones.Controls.Add(this.optSuma);
            this.grbOpciones.Controls.Add(this.optFactorial);
            this.grbOpciones.Controls.Add(this.optResta);
            this.grbOpciones.Controls.Add(this.optMultiplicacion);
            this.grbOpciones.Controls.Add(this.optPorcentaje);
            this.grbOpciones.Controls.Add(this.optDivision);
            this.grbOpciones.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.grbOpciones.Location = new System.Drawing.Point(51, 37);
            this.grbOpciones.Name = "grbOpciones";
            this.grbOpciones.Size = new System.Drawing.Size(137, 227);
            this.grbOpciones.TabIndex = 6;
            this.grbOpciones.TabStop = false;
            this.grbOpciones.Text = "Opciones";
            // 
            // optPrimo
            // 
            this.optPrimo.AutoSize = true;
            this.optPrimo.Location = new System.Drawing.Point(28, 169);
            this.optPrimo.Name = "optPrimo";
            this.optPrimo.Size = new System.Drawing.Size(59, 19);
            this.optPrimo.TabIndex = 10;
            this.optPrimo.Text = "Primo";
            this.optPrimo.UseVisualStyleBackColor = true;
            // 
            // optFactorial
            // 
            this.optFactorial.AutoSize = true;
            this.optFactorial.Location = new System.Drawing.Point(28, 192);
            this.optFactorial.Name = "optFactorial";
            this.optFactorial.Size = new System.Drawing.Size(74, 19);
            this.optFactorial.TabIndex = 9;
            this.optFactorial.Text = "Factorial";
            this.optFactorial.UseVisualStyleBackColor = true;
            // 
            // optPorcentaje
            // 
            this.optPorcentaje.AutoSize = true;
            this.optPorcentaje.Location = new System.Drawing.Point(28, 146);
            this.optPorcentaje.Name = "optPorcentaje";
            this.optPorcentaje.Size = new System.Drawing.Size(82, 19);
            this.optPorcentaje.TabIndex = 8;
            this.optPorcentaje.Text = "Porcentaje";
            this.optPorcentaje.UseVisualStyleBackColor = true;
            // 
            // optExponenciacion
            // 
            this.optExponenciacion.AutoSize = true;
            this.optExponenciacion.Location = new System.Drawing.Point(28, 123);
            this.optExponenciacion.Name = "optExponenciacion";
            this.optExponenciacion.Size = new System.Drawing.Size(82, 19);
            this.optExponenciacion.TabIndex = 7;
            this.optExponenciacion.Text = "Exponente";
            this.optExponenciacion.UseVisualStyleBackColor = true;
            // 
            // optDivision
            // 
            this.optDivision.AutoSize = true;
            this.optDivision.Location = new System.Drawing.Point(28, 100);
            this.optDivision.Name = "optDivision";
            this.optDivision.Size = new System.Drawing.Size(73, 19);
            this.optDivision.TabIndex = 3;
            this.optDivision.Text = "División";
            this.optDivision.UseVisualStyleBackColor = true;
            // 
            // optMultiplicacion
            // 
            this.optMultiplicacion.AutoSize = true;
            this.optMultiplicacion.Location = new System.Drawing.Point(28, 77);
            this.optMultiplicacion.Name = "optMultiplicacion";
            this.optMultiplicacion.Size = new System.Drawing.Size(106, 19);
            this.optMultiplicacion.TabIndex = 2;
            this.optMultiplicacion.Text = "Multiplicación";
            this.optMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // optResta
            // 
            this.optResta.AutoSize = true;
            this.optResta.Location = new System.Drawing.Point(28, 54);
            this.optResta.Name = "optResta";
            this.optResta.Size = new System.Drawing.Size(55, 19);
            this.optResta.TabIndex = 1;
            this.optResta.Text = "Resta";
            this.optResta.UseVisualStyleBackColor = true;
            // 
            // optSuma
            // 
            this.optSuma.AutoSize = true;
            this.optSuma.Checked = true;
            this.optSuma.Location = new System.Drawing.Point(28, 27);
            this.optSuma.Name = "optSuma";
            this.optSuma.Size = new System.Drawing.Size(55, 19);
            this.optSuma.TabIndex = 0;
            this.optSuma.TabStop = true;
            this.optSuma.Text = "Suma";
            this.optSuma.UseVisualStyleBackColor = true;
            // 
            // cboOpciones
            // 
            this.cboOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpciones.FormattingEnabled = true;
            this.cboOpciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division",
            "Exponente",
            "Porcentaje",
            "Factorial",
            "Primo"});
            this.cboOpciones.Location = new System.Drawing.Point(489, 131);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(137, 21);
            this.cboOpciones.TabIndex = 7;
            // 
            // btnOpciones
            // 
            this.btnOpciones.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpciones.ForeColor = System.Drawing.Color.Black;
            this.btnOpciones.Location = new System.Drawing.Point(514, 168);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(83, 31);
            this.btnOpciones.TabIndex = 8;
            this.btnOpciones.Text = "Calcular";
            this.btnOpciones.UseVisualStyleBackColor = true;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(471, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Escoja una de las opciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "CALCULADORA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(249, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Escriba los datos:";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(686, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpciones);
            this.Controls.Add(this.cboOpciones);
            this.Controls.Add(this.grbOpciones);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.txtNum1);
            this.Name = "form1";
            this.Text = "Calculadora";
            this.grbOpciones.ResumeLayout(false);
            this.grbOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.GroupBox grbOpciones;
        private System.Windows.Forms.RadioButton optDivision;
        private System.Windows.Forms.RadioButton optMultiplicacion;
        private System.Windows.Forms.RadioButton optResta;
        private System.Windows.Forms.RadioButton optSuma;
        private System.Windows.Forms.RadioButton optExponenciacion;
        private System.Windows.Forms.RadioButton optPorcentaje;
        private System.Windows.Forms.RadioButton optFactorial;
        private System.Windows.Forms.ComboBox cboOpciones;
        private System.Windows.Forms.Button btnOpciones;
        private System.Windows.Forms.RadioButton optPrimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


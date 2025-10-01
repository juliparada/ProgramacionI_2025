namespace PrimerProyectoCsharp
{
    partial class FrmMateria
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
            this.grbBusquedaMateria = new System.Windows.Forms.GroupBox();
            this.grdMateria = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarMateria = new System.Windows.Forms.TextBox();
            this.gbrEdición = new System.Windows.Forms.GroupBox();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.grbNavegacionMateria = new System.Windows.Forms.GroupBox();
            this.lblnRegistroMateria = new System.Windows.Forms.Label();
            this.btnUltimaMateria = new System.Windows.Forms.Button();
            this.btnSiguienteMateria = new System.Windows.Forms.Button();
            this.btnAnteriorMateria = new System.Windows.Forms.Button();
            this.btnPrimerMateria = new System.Windows.Forms.Button();
            this.grbDatosMateria = new System.Windows.Forms.GroupBox();
            this.idMateria = new System.Windows.Forms.Label();
            this.lblidMateria = new System.Windows.Forms.Label();
            this.txtUvMateria = new System.Windows.Forms.TextBox();
            this.lblUvMateria = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.txtCodigoMateria = new System.Windows.Forms.TextBox();
            this.lblCodigoMateria = new System.Windows.Forms.Label();
            this.grbBusquedaMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMateria)).BeginInit();
            this.gbrEdición.SuspendLayout();
            this.grbNavegacionMateria.SuspendLayout();
            this.grbDatosMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBusquedaMateria
            // 
            this.grbBusquedaMateria.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.grbBusquedaMateria.Controls.Add(this.grdMateria);
            this.grbBusquedaMateria.Controls.Add(this.txtBuscarMateria);
            this.grbBusquedaMateria.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBusquedaMateria.Location = new System.Drawing.Point(383, 24);
            this.grbBusquedaMateria.Name = "grbBusquedaMateria";
            this.grbBusquedaMateria.Size = new System.Drawing.Size(533, 270);
            this.grbBusquedaMateria.TabIndex = 9;
            this.grbBusquedaMateria.TabStop = false;
            this.grbBusquedaMateria.Text = "BUSQUEDA MATERIAS";
            // 
            // grdMateria
            // 
            this.grdMateria.AllowUserToAddRows = false;
            this.grdMateria.AllowUserToDeleteRows = false;
            this.grdMateria.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.grdMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.uv});
            this.grdMateria.Location = new System.Drawing.Point(15, 67);
            this.grdMateria.Name = "grdMateria";
            this.grdMateria.ReadOnly = true;
            this.grdMateria.Size = new System.Drawing.Size(494, 182);
            this.grdMateria.TabIndex = 3;
            // 
            // id
            // 
            this.id.DataPropertyName = "idMateria";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 150;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // uv
            // 
            this.uv.DataPropertyName = "uv";
            this.uv.HeaderText = "UV";
            this.uv.Name = "uv";
            this.uv.ReadOnly = true;
            // 
            // txtBuscarMateria
            // 
            this.txtBuscarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarMateria.Location = new System.Drawing.Point(15, 25);
            this.txtBuscarMateria.Name = "txtBuscarMateria";
            this.txtBuscarMateria.Size = new System.Drawing.Size(494, 22);
            this.txtBuscarMateria.TabIndex = 2;
            this.txtBuscarMateria.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMateria_KeyUp);
            // 
            // gbrEdición
            // 
            this.gbrEdición.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.gbrEdición.Controls.Add(this.btnEliminarMateria);
            this.gbrEdición.Controls.Add(this.btnModificarMateria);
            this.gbrEdición.Controls.Add(this.btnAgregarMateria);
            this.gbrEdición.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrEdición.Location = new System.Drawing.Point(383, 325);
            this.gbrEdición.Name = "gbrEdición";
            this.gbrEdición.Size = new System.Drawing.Size(533, 100);
            this.gbrEdición.TabIndex = 8;
            this.gbrEdición.TabStop = false;
            this.gbrEdición.Text = "EDICIÓN";
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMateria.Location = new System.Drawing.Point(390, 40);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(119, 31);
            this.btnEliminarMateria.TabIndex = 2;
            this.btnEliminarMateria.Text = "ELIMINAR";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMateria.Location = new System.Drawing.Point(205, 40);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(119, 31);
            this.btnModificarMateria.TabIndex = 1;
            this.btnModificarMateria.Text = "MODIFICAR";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            this.btnModificarMateria.Click += new System.EventHandler(this.btnModificarMateria_Click);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMateria.Location = new System.Drawing.Point(15, 40);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(119, 31);
            this.btnAgregarMateria.TabIndex = 0;
            this.btnAgregarMateria.Text = "NUEVO";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // grbNavegacionMateria
            // 
            this.grbNavegacionMateria.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.grbNavegacionMateria.Controls.Add(this.lblnRegistroMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnUltimaMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnSiguienteMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnAnteriorMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnPrimerMateria);
            this.grbNavegacionMateria.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNavegacionMateria.Location = new System.Drawing.Point(23, 325);
            this.grbNavegacionMateria.Name = "grbNavegacionMateria";
            this.grbNavegacionMateria.Size = new System.Drawing.Size(354, 100);
            this.grbNavegacionMateria.TabIndex = 7;
            this.grbNavegacionMateria.TabStop = false;
            this.grbNavegacionMateria.Text = "NAVEGACIÓN";
            // 
            // lblnRegistroMateria
            // 
            this.lblnRegistroMateria.AutoSize = true;
            this.lblnRegistroMateria.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnRegistroMateria.Location = new System.Drawing.Point(149, 47);
            this.lblnRegistroMateria.Name = "lblnRegistroMateria";
            this.lblnRegistroMateria.Size = new System.Drawing.Size(45, 18);
            this.lblnRegistroMateria.TabIndex = 9;
            this.lblnRegistroMateria.Text = "x de n";
            // 
            // btnUltimaMateria
            // 
            this.btnUltimaMateria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimaMateria.Location = new System.Drawing.Point(297, 40);
            this.btnUltimaMateria.Name = "btnUltimaMateria";
            this.btnUltimaMateria.Size = new System.Drawing.Size(43, 31);
            this.btnUltimaMateria.TabIndex = 3;
            this.btnUltimaMateria.Text = ">|";
            this.btnUltimaMateria.UseVisualStyleBackColor = true;
            this.btnUltimaMateria.Click += new System.EventHandler(this.btnUltimaMateria_Click);
            // 
            // btnSiguienteMateria
            // 
            this.btnSiguienteMateria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteMateria.Location = new System.Drawing.Point(248, 40);
            this.btnSiguienteMateria.Name = "btnSiguienteMateria";
            this.btnSiguienteMateria.Size = new System.Drawing.Size(43, 31);
            this.btnSiguienteMateria.TabIndex = 2;
            this.btnSiguienteMateria.Text = ">";
            this.btnSiguienteMateria.UseVisualStyleBackColor = true;
            this.btnSiguienteMateria.Click += new System.EventHandler(this.btnSiguienteMateria_Click);
            // 
            // btnAnteriorMateria
            // 
            this.btnAnteriorMateria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorMateria.Location = new System.Drawing.Point(73, 40);
            this.btnAnteriorMateria.Name = "btnAnteriorMateria";
            this.btnAnteriorMateria.Size = new System.Drawing.Size(43, 31);
            this.btnAnteriorMateria.TabIndex = 1;
            this.btnAnteriorMateria.Text = "<";
            this.btnAnteriorMateria.UseVisualStyleBackColor = true;
            this.btnAnteriorMateria.Click += new System.EventHandler(this.btnAnteriorMateria_Click);
            // 
            // btnPrimerMateria
            // 
            this.btnPrimerMateria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerMateria.Location = new System.Drawing.Point(22, 40);
            this.btnPrimerMateria.Name = "btnPrimerMateria";
            this.btnPrimerMateria.Size = new System.Drawing.Size(43, 31);
            this.btnPrimerMateria.TabIndex = 0;
            this.btnPrimerMateria.Text = "|<";
            this.btnPrimerMateria.UseVisualStyleBackColor = true;
            this.btnPrimerMateria.Click += new System.EventHandler(this.btnPrimerMateria_Click);
            // 
            // grbDatosMateria
            // 
            this.grbDatosMateria.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.grbDatosMateria.Controls.Add(this.idMateria);
            this.grbDatosMateria.Controls.Add(this.lblidMateria);
            this.grbDatosMateria.Controls.Add(this.txtUvMateria);
            this.grbDatosMateria.Controls.Add(this.lblUvMateria);
            this.grbDatosMateria.Controls.Add(this.txtNombreMateria);
            this.grbDatosMateria.Controls.Add(this.lblNombreMateria);
            this.grbDatosMateria.Controls.Add(this.txtCodigoMateria);
            this.grbDatosMateria.Controls.Add(this.lblCodigoMateria);
            this.grbDatosMateria.Enabled = false;
            this.grbDatosMateria.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosMateria.Location = new System.Drawing.Point(23, 24);
            this.grbDatosMateria.Name = "grbDatosMateria";
            this.grbDatosMateria.Size = new System.Drawing.Size(354, 270);
            this.grbDatosMateria.TabIndex = 6;
            this.grbDatosMateria.TabStop = false;
            this.grbDatosMateria.Text = "DATOS";
            // 
            // idMateria
            // 
            this.idMateria.AutoSize = true;
            this.idMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idMateria.Location = new System.Drawing.Point(100, 67);
            this.idMateria.Name = "idMateria";
            this.idMateria.Size = new System.Drawing.Size(16, 16);
            this.idMateria.TabIndex = 9;
            this.idMateria.Text = "...";
            // 
            // lblidMateria
            // 
            this.lblidMateria.AutoSize = true;
            this.lblidMateria.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidMateria.Location = new System.Drawing.Point(22, 67);
            this.lblidMateria.Name = "lblidMateria";
            this.lblidMateria.Size = new System.Drawing.Size(25, 18);
            this.lblidMateria.TabIndex = 8;
            this.lblidMateria.Text = "ID:";
            // 
            // txtUvMateria
            // 
            this.txtUvMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUvMateria.Location = new System.Drawing.Point(103, 158);
            this.txtUvMateria.Name = "txtUvMateria";
            this.txtUvMateria.Size = new System.Drawing.Size(224, 22);
            this.txtUvMateria.TabIndex = 5;
            // 
            // lblUvMateria
            // 
            this.lblUvMateria.AutoSize = true;
            this.lblUvMateria.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUvMateria.Location = new System.Drawing.Point(22, 164);
            this.lblUvMateria.Name = "lblUvMateria";
            this.lblUvMateria.Size = new System.Drawing.Size(29, 18);
            this.lblUvMateria.TabIndex = 4;
            this.lblUvMateria.Text = "UV:";
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMateria.Location = new System.Drawing.Point(103, 130);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(224, 22);
            this.txtNombreMateria.TabIndex = 3;
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMateria.Location = new System.Drawing.Point(22, 136);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(67, 18);
            this.lblNombreMateria.TabIndex = 2;
            this.lblNombreMateria.Text = "NOMBRE:";
            // 
            // txtCodigoMateria
            // 
            this.txtCodigoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMateria.Location = new System.Drawing.Point(103, 102);
            this.txtCodigoMateria.Name = "txtCodigoMateria";
            this.txtCodigoMateria.Size = new System.Drawing.Size(224, 22);
            this.txtCodigoMateria.TabIndex = 1;
            // 
            // lblCodigoMateria
            // 
            this.lblCodigoMateria.AutoSize = true;
            this.lblCodigoMateria.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMateria.Location = new System.Drawing.Point(22, 102);
            this.lblCodigoMateria.Name = "lblCodigoMateria";
            this.lblCodigoMateria.Size = new System.Drawing.Size(62, 18);
            this.lblCodigoMateria.TabIndex = 0;
            this.lblCodigoMateria.Text = "CÓDIGO:";
            // 
            // FrmMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.grbBusquedaMateria);
            this.Controls.Add(this.gbrEdición);
            this.Controls.Add(this.grbNavegacionMateria);
            this.Controls.Add(this.grbDatosMateria);
            this.Name = "FrmMateria";
            this.Text = "FrmMateria";
            this.Load += new System.EventHandler(this.FrmMateria_Load);
            this.grbBusquedaMateria.ResumeLayout(false);
            this.grbBusquedaMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMateria)).EndInit();
            this.gbrEdición.ResumeLayout(false);
            this.grbNavegacionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.PerformLayout();
            this.grbDatosMateria.ResumeLayout(false);
            this.grbDatosMateria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBusquedaMateria;
        private System.Windows.Forms.DataGridView grdMateria;
        private System.Windows.Forms.TextBox txtBuscarMateria;
        private System.Windows.Forms.GroupBox gbrEdición;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.GroupBox grbNavegacionMateria;
        private System.Windows.Forms.Label lblnRegistroMateria;
        private System.Windows.Forms.Button btnUltimaMateria;
        private System.Windows.Forms.Button btnSiguienteMateria;
        private System.Windows.Forms.Button btnAnteriorMateria;
        private System.Windows.Forms.Button btnPrimerMateria;
        private System.Windows.Forms.GroupBox grbDatosMateria;
        private System.Windows.Forms.Label idMateria;
        private System.Windows.Forms.Label lblidMateria;
        private System.Windows.Forms.TextBox txtUvMateria;
        private System.Windows.Forms.Label lblUvMateria;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.TextBox txtCodigoMateria;
        private System.Windows.Forms.Label lblCodigoMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn uv;
    }
}
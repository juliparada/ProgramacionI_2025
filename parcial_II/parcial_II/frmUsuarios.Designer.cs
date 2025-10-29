namespace parcial_II
{
    partial class frmUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblIdUsuarios;
            System.Windows.Forms.Label lblUsuarioUsuarios;
            System.Windows.Forms.Label lblClaveUsuarios;
            System.Windows.Forms.Label lblNombreUsuarios;
            System.Windows.Forms.Label lblDireccionUsuarios;
            System.Windows.Forms.Label lblTelefonoUsuarios;
            this.db_parcialIIDataSet = new parcial_II.db_parcialIIDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new parcial_II.db_parcialIIDataSetTableAdapters.usuarioTableAdapter();
            this.tableAdapterManager = new parcial_II.db_parcialIIDataSetTableAdapters.TableAdapterManager();
            this.lblUsuariosId = new System.Windows.Forms.Label();
            this.txtUsuarioUsuarios = new System.Windows.Forms.TextBox();
            this.txtClaveUsuarios = new System.Windows.Forms.TextBox();
            this.txtNombreUsuarios = new System.Windows.Forms.TextBox();
            this.txtDireccionUsuarios = new System.Windows.Forms.TextBox();
            this.txtTelefonoUsuarios = new System.Windows.Forms.TextBox();
            this.grbUsuarios = new System.Windows.Forms.GroupBox();
            this.grbEdicionUsuario = new System.Windows.Forms.GroupBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.grbNavegacionUsuario = new System.Windows.Forms.GroupBox();
            this.lblnRegistrosUsuarios = new System.Windows.Forms.Label();
            this.btnUltimoUsuario = new System.Windows.Forms.Button();
            this.btnSiguienteUsuario = new System.Windows.Forms.Button();
            this.btnAnteriorUsuario = new System.Windows.Forms.Button();
            this.btnPrimeroUsuario = new System.Windows.Forms.Button();
            lblIdUsuarios = new System.Windows.Forms.Label();
            lblUsuarioUsuarios = new System.Windows.Forms.Label();
            lblClaveUsuarios = new System.Windows.Forms.Label();
            lblNombreUsuarios = new System.Windows.Forms.Label();
            lblDireccionUsuarios = new System.Windows.Forms.Label();
            lblTelefonoUsuarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_parcialIIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.grbUsuarios.SuspendLayout();
            this.grbEdicionUsuario.SuspendLayout();
            this.grbNavegacionUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // db_parcialIIDataSet
            // 
            this.db_parcialIIDataSet.DataSetName = "db_parcialIIDataSet";
            this.db_parcialIIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.db_parcialIIDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = parcial_II.db_parcialIIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // lblIdUsuarios
            // 
            lblIdUsuarios.AutoSize = true;
            lblIdUsuarios.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblIdUsuarios.Location = new System.Drawing.Point(55, 28);
            lblIdUsuarios.Name = "lblIdUsuarios";
            lblIdUsuarios.Size = new System.Drawing.Size(32, 23);
            lblIdUsuarios.TabIndex = 13;
            lblIdUsuarios.Text = "ID:";
            // 
            // lblUsuariosId
            // 
            this.lblUsuariosId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "idUsuario", true));
            this.lblUsuariosId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuariosId.Location = new System.Drawing.Point(160, 35);
            this.lblUsuariosId.Name = "lblUsuariosId";
            this.lblUsuariosId.Size = new System.Drawing.Size(100, 23);
            this.lblUsuariosId.TabIndex = 14;
            this.lblUsuariosId.Text = ". . .";
            // 
            // lblUsuarioUsuarios
            // 
            lblUsuarioUsuarios.AutoSize = true;
            lblUsuarioUsuarios.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUsuarioUsuarios.Location = new System.Drawing.Point(55, 57);
            lblUsuarioUsuarios.Name = "lblUsuarioUsuarios";
            lblUsuarioUsuarios.Size = new System.Drawing.Size(76, 23);
            lblUsuarioUsuarios.TabIndex = 15;
            lblUsuarioUsuarios.Text = "Usuario:";
            // 
            // txtUsuarioUsuarios
            // 
            this.txtUsuarioUsuarios.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "usuario", true));
            this.txtUsuarioUsuarios.Location = new System.Drawing.Point(160, 61);
            this.txtUsuarioUsuarios.Name = "txtUsuarioUsuarios";
            this.txtUsuarioUsuarios.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioUsuarios.TabIndex = 16;
            // 
            // lblClaveUsuarios
            // 
            lblClaveUsuarios.AutoSize = true;
            lblClaveUsuarios.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblClaveUsuarios.Location = new System.Drawing.Point(55, 83);
            lblClaveUsuarios.Name = "lblClaveUsuarios";
            lblClaveUsuarios.Size = new System.Drawing.Size(58, 23);
            lblClaveUsuarios.TabIndex = 17;
            lblClaveUsuarios.Text = "Clave:";
            // 
            // txtClaveUsuarios
            // 
            this.txtClaveUsuarios.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "clave", true));
            this.txtClaveUsuarios.Location = new System.Drawing.Point(160, 87);
            this.txtClaveUsuarios.Name = "txtClaveUsuarios";
            this.txtClaveUsuarios.Size = new System.Drawing.Size(100, 20);
            this.txtClaveUsuarios.TabIndex = 18;
            // 
            // lblNombreUsuarios
            // 
            lblNombreUsuarios.AutoSize = true;
            lblNombreUsuarios.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNombreUsuarios.Location = new System.Drawing.Point(55, 109);
            lblNombreUsuarios.Name = "lblNombreUsuarios";
            lblNombreUsuarios.Size = new System.Drawing.Size(80, 23);
            lblNombreUsuarios.TabIndex = 19;
            lblNombreUsuarios.Text = "Nombre:";
            // 
            // txtNombreUsuarios
            // 
            this.txtNombreUsuarios.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "nombre", true));
            this.txtNombreUsuarios.Location = new System.Drawing.Point(160, 113);
            this.txtNombreUsuarios.Name = "txtNombreUsuarios";
            this.txtNombreUsuarios.Size = new System.Drawing.Size(100, 20);
            this.txtNombreUsuarios.TabIndex = 20;
            // 
            // lblDireccionUsuarios
            // 
            lblDireccionUsuarios.AutoSize = true;
            lblDireccionUsuarios.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDireccionUsuarios.Location = new System.Drawing.Point(55, 135);
            lblDireccionUsuarios.Name = "lblDireccionUsuarios";
            lblDireccionUsuarios.Size = new System.Drawing.Size(90, 23);
            lblDireccionUsuarios.TabIndex = 21;
            lblDireccionUsuarios.Text = "Direccion:";
            // 
            // txtDireccionUsuarios
            // 
            this.txtDireccionUsuarios.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "direccion", true));
            this.txtDireccionUsuarios.Location = new System.Drawing.Point(160, 139);
            this.txtDireccionUsuarios.Name = "txtDireccionUsuarios";
            this.txtDireccionUsuarios.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionUsuarios.TabIndex = 22;
            // 
            // lblTelefonoUsuarios
            // 
            lblTelefonoUsuarios.AutoSize = true;
            lblTelefonoUsuarios.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTelefonoUsuarios.Location = new System.Drawing.Point(55, 161);
            lblTelefonoUsuarios.Name = "lblTelefonoUsuarios";
            lblTelefonoUsuarios.Size = new System.Drawing.Size(83, 23);
            lblTelefonoUsuarios.TabIndex = 23;
            lblTelefonoUsuarios.Text = "Telefono:";
            // 
            // txtTelefonoUsuarios
            // 
            this.txtTelefonoUsuarios.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "telefono", true));
            this.txtTelefonoUsuarios.Location = new System.Drawing.Point(160, 165);
            this.txtTelefonoUsuarios.Name = "txtTelefonoUsuarios";
            this.txtTelefonoUsuarios.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoUsuarios.TabIndex = 24;
            // 
            // grbUsuarios
            // 
            this.grbUsuarios.Controls.Add(this.txtUsuarioUsuarios);
            this.grbUsuarios.Controls.Add(lblIdUsuarios);
            this.grbUsuarios.Controls.Add(this.txtTelefonoUsuarios);
            this.grbUsuarios.Controls.Add(this.lblUsuariosId);
            this.grbUsuarios.Controls.Add(lblTelefonoUsuarios);
            this.grbUsuarios.Controls.Add(lblUsuarioUsuarios);
            this.grbUsuarios.Controls.Add(this.txtDireccionUsuarios);
            this.grbUsuarios.Controls.Add(lblDireccionUsuarios);
            this.grbUsuarios.Controls.Add(lblClaveUsuarios);
            this.grbUsuarios.Controls.Add(this.txtNombreUsuarios);
            this.grbUsuarios.Controls.Add(this.txtClaveUsuarios);
            this.grbUsuarios.Controls.Add(lblNombreUsuarios);
            this.grbUsuarios.Location = new System.Drawing.Point(24, 12);
            this.grbUsuarios.Name = "grbUsuarios";
            this.grbUsuarios.Size = new System.Drawing.Size(323, 218);
            this.grbUsuarios.TabIndex = 25;
            this.grbUsuarios.TabStop = false;
            this.grbUsuarios.Text = "USUARIOS";
            // 
            // grbEdicionUsuario
            // 
            this.grbEdicionUsuario.Controls.Add(this.btnEliminarUsuario);
            this.grbEdicionUsuario.Controls.Add(this.btnModificarUsuario);
            this.grbEdicionUsuario.Controls.Add(this.btnAgregarUsuario);
            this.grbEdicionUsuario.Location = new System.Drawing.Point(24, 328);
            this.grbEdicionUsuario.Name = "grbEdicionUsuario";
            this.grbEdicionUsuario.Size = new System.Drawing.Size(323, 65);
            this.grbEdicionUsuario.TabIndex = 27;
            this.grbEdicionUsuario.TabStop = false;
            this.grbEdicionUsuario.Text = "EDICION";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(217, 15);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(100, 37);
            this.btnEliminarUsuario.TabIndex = 3;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.Location = new System.Drawing.Point(106, 15);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(105, 37);
            this.btnModificarUsuario.TabIndex = 1;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.Location = new System.Drawing.Point(6, 15);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(94, 37);
            this.btnAgregarUsuario.TabIndex = 0;
            this.btnAgregarUsuario.Text = "Nuevo";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // grbNavegacionUsuario
            // 
            this.grbNavegacionUsuario.Controls.Add(this.lblnRegistrosUsuarios);
            this.grbNavegacionUsuario.Controls.Add(this.btnUltimoUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnSiguienteUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnAnteriorUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnPrimeroUsuario);
            this.grbNavegacionUsuario.Location = new System.Drawing.Point(24, 247);
            this.grbNavegacionUsuario.Name = "grbNavegacionUsuario";
            this.grbNavegacionUsuario.Size = new System.Drawing.Size(323, 62);
            this.grbNavegacionUsuario.TabIndex = 26;
            this.grbNavegacionUsuario.TabStop = false;
            this.grbNavegacionUsuario.Text = "NAVEGACION";
            // 
            // lblnRegistrosUsuarios
            // 
            this.lblnRegistrosUsuarios.AutoSize = true;
            this.lblnRegistrosUsuarios.Location = new System.Drawing.Point(136, 27);
            this.lblnRegistrosUsuarios.Name = "lblnRegistrosUsuarios";
            this.lblnRegistrosUsuarios.Size = new System.Drawing.Size(36, 13);
            this.lblnRegistrosUsuarios.TabIndex = 10;
            this.lblnRegistrosUsuarios.Text = "x de n";
            // 
            // btnUltimoUsuario
            // 
            this.btnUltimoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoUsuario.Location = new System.Drawing.Point(275, 14);
            this.btnUltimoUsuario.Name = "btnUltimoUsuario";
            this.btnUltimoUsuario.Size = new System.Drawing.Size(33, 37);
            this.btnUltimoUsuario.TabIndex = 3;
            this.btnUltimoUsuario.Text = ">|";
            this.btnUltimoUsuario.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteUsuario
            // 
            this.btnSiguienteUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteUsuario.Location = new System.Drawing.Point(239, 14);
            this.btnSiguienteUsuario.Name = "btnSiguienteUsuario";
            this.btnSiguienteUsuario.Size = new System.Drawing.Size(33, 37);
            this.btnSiguienteUsuario.TabIndex = 2;
            this.btnSiguienteUsuario.Text = ">";
            this.btnSiguienteUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorUsuario
            // 
            this.btnAnteriorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorUsuario.Location = new System.Drawing.Point(42, 14);
            this.btnAnteriorUsuario.Name = "btnAnteriorUsuario";
            this.btnAnteriorUsuario.Size = new System.Drawing.Size(33, 37);
            this.btnAnteriorUsuario.TabIndex = 1;
            this.btnAnteriorUsuario.Text = "<";
            this.btnAnteriorUsuario.UseVisualStyleBackColor = true;
            // 
            // btnPrimeroUsuario
            // 
            this.btnPrimeroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroUsuario.Location = new System.Drawing.Point(6, 14);
            this.btnPrimeroUsuario.Name = "btnPrimeroUsuario";
            this.btnPrimeroUsuario.Size = new System.Drawing.Size(33, 37);
            this.btnPrimeroUsuario.TabIndex = 0;
            this.btnPrimeroUsuario.Text = "|<";
            this.btnPrimeroUsuario.UseVisualStyleBackColor = true;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 427);
            this.Controls.Add(this.grbEdicionUsuario);
            this.Controls.Add(this.grbNavegacionUsuario);
            this.Controls.Add(this.grbUsuarios);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_parcialIIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.grbUsuarios.ResumeLayout(false);
            this.grbUsuarios.PerformLayout();
            this.grbEdicionUsuario.ResumeLayout(false);
            this.grbNavegacionUsuario.ResumeLayout(false);
            this.grbNavegacionUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private db_parcialIIDataSet db_parcialIIDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private db_parcialIIDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private db_parcialIIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblUsuariosId;
        private System.Windows.Forms.TextBox txtUsuarioUsuarios;
        private System.Windows.Forms.TextBox txtClaveUsuarios;
        private System.Windows.Forms.TextBox txtNombreUsuarios;
        private System.Windows.Forms.TextBox txtDireccionUsuarios;
        private System.Windows.Forms.TextBox txtTelefonoUsuarios;
        private System.Windows.Forms.GroupBox grbUsuarios;
        private System.Windows.Forms.GroupBox grbEdicionUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.GroupBox grbNavegacionUsuario;
        private System.Windows.Forms.Label lblnRegistrosUsuarios;
        private System.Windows.Forms.Button btnUltimoUsuario;
        private System.Windows.Forms.Button btnSiguienteUsuario;
        private System.Windows.Forms.Button btnAnteriorUsuario;
        private System.Windows.Forms.Button btnPrimeroUsuario;
    }
}
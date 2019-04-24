namespace Interfaz.Administración_Tickets
{
    partial class ModificarTickets
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxTecnico = new System.Windows.Forms.ComboBox();
            this.txtPrioridad = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtUsuarioSolicita = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbltecnico = new System.Windows.Forms.Label();
            this.txt_nombTicket = new System.Windows.Forms.TextBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblUsusolicita = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.txt_comentario = new System.Windows.Forms.RichTextBox();
            this.lbl_comentarios = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.conexionComentarios1 = new Interfaz.ConexionComentarios();
            this.listaComentarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colComentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTecnico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarComentario = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.listaComentariosTableAdapter1 = new Interfaz.ConexionComentariosTableAdapters.ListaComentariosTableAdapter();
            this.btnContactar = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionComentarios1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaComentarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxTecnico);
            this.groupBox1.Controls.Add(this.txtPrioridad);
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.txtUsuarioSolicita);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.lbltecnico);
            this.groupBox1.Controls.Add(this.txt_nombTicket);
            this.groupBox1.Controls.Add(this.lblPrioridad);
            this.groupBox1.Controls.Add(this.lblUsusolicita);
            this.groupBox1.Controls.Add(this.lbl_categoria);
            this.groupBox1.Controls.Add(this.txt_comentario);
            this.groupBox1.Controls.Add(this.lbl_comentarios);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1105, 316);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Ticket";
            // 
            // cbxTecnico
            // 
            this.cbxTecnico.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTecnico.FormattingEnabled = true;
            this.cbxTecnico.Location = new System.Drawing.Point(192, 255);
            this.cbxTecnico.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTecnico.Name = "cbxTecnico";
            this.cbxTecnico.Size = new System.Drawing.Size(327, 32);
            this.cbxTecnico.TabIndex = 55;
            // 
            // txtPrioridad
            // 
            this.txtPrioridad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrioridad.Location = new System.Drawing.Point(192, 199);
            this.txtPrioridad.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrioridad.Name = "txtPrioridad";
            this.txtPrioridad.ReadOnly = true;
            this.txtPrioridad.Size = new System.Drawing.Size(327, 32);
            this.txtPrioridad.TabIndex = 50;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(192, 146);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(327, 32);
            this.txtTipo.TabIndex = 49;
            // 
            // txtUsuarioSolicita
            // 
            this.txtUsuarioSolicita.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioSolicita.Location = new System.Drawing.Point(192, 97);
            this.txtUsuarioSolicita.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuarioSolicita.Name = "txtUsuarioSolicita";
            this.txtUsuarioSolicita.ReadOnly = true;
            this.txtUsuarioSolicita.Size = new System.Drawing.Size(327, 32);
            this.txtUsuarioSolicita.TabIndex = 48;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(39, 55);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(136, 24);
            this.lbl_nombre.TabIndex = 25;
            this.lbl_nombre.Text = "Nombre Ticket:";
            // 
            // lbltecnico
            // 
            this.lbltecnico.AutoSize = true;
            this.lbltecnico.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltecnico.ForeColor = System.Drawing.Color.White;
            this.lbltecnico.Location = new System.Drawing.Point(95, 258);
            this.lbltecnico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltecnico.Name = "lbltecnico";
            this.lbltecnico.Size = new System.Drawing.Size(76, 24);
            this.lbltecnico.TabIndex = 43;
            this.lbltecnico.Text = "Técnico:";
            // 
            // txt_nombTicket
            // 
            this.txt_nombTicket.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombTicket.Location = new System.Drawing.Point(192, 47);
            this.txt_nombTicket.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombTicket.Name = "txt_nombTicket";
            this.txt_nombTicket.ReadOnly = true;
            this.txt_nombTicket.Size = new System.Drawing.Size(327, 32);
            this.txt_nombTicket.TabIndex = 26;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.ForeColor = System.Drawing.Color.White;
            this.lblPrioridad.Location = new System.Drawing.Point(91, 207);
            this.lblPrioridad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(92, 24);
            this.lblPrioridad.TabIndex = 46;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // lblUsusolicita
            // 
            this.lblUsusolicita.AutoSize = true;
            this.lblUsusolicita.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsusolicita.ForeColor = System.Drawing.Color.White;
            this.lblUsusolicita.Location = new System.Drawing.Point(4, 101);
            this.lblUsusolicita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsusolicita.Name = "lblUsusolicita";
            this.lblUsusolicita.Size = new System.Drawing.Size(172, 24);
            this.lblUsusolicita.TabIndex = 41;
            this.lblUsusolicita.Text = "Usuario solicitante:";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.ForeColor = System.Drawing.Color.White;
            this.lbl_categoria.Location = new System.Drawing.Point(79, 150);
            this.lbl_categoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(95, 24);
            this.lbl_categoria.TabIndex = 27;
            this.lbl_categoria.Text = "Categoría:";
            // 
            // txt_comentario
            // 
            this.txt_comentario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comentario.Location = new System.Drawing.Point(564, 66);
            this.txt_comentario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_comentario.Name = "txt_comentario";
            this.txt_comentario.ReadOnly = true;
            this.txt_comentario.Size = new System.Drawing.Size(515, 227);
            this.txt_comentario.TabIndex = 31;
            this.txt_comentario.Text = "";
            // 
            // lbl_comentarios
            // 
            this.lbl_comentarios.AutoSize = true;
            this.lbl_comentarios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comentarios.ForeColor = System.Drawing.Color.White;
            this.lbl_comentarios.Location = new System.Drawing.Point(559, 39);
            this.lbl_comentarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_comentarios.Name = "lbl_comentarios";
            this.lbl_comentarios.Size = new System.Drawing.Size(122, 24);
            this.lbl_comentarios.TabIndex = 34;
            this.lbl_comentarios.Text = "Comentarios:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Controls.Add(this.cbxEstado);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(16, 350);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(808, 374);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actualización Ticket";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "ListaComentarios";
            this.gridControl1.DataSource = this.conexionComentarios1;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(8, 100);
            this.gridControl1.MainView = this.listaComentarios;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(791, 267);
            this.gridControl1.TabIndex = 54;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.listaComentarios});
            this.gridControl1.Load += new System.EventHandler(this.filtrar);
            // 
            // conexionComentarios1
            // 
            this.conexionComentarios1.DataSetName = "ConexionComentarios";
            this.conexionComentarios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaComentarios
            // 
            this.listaComentarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colComentario,
            this.colTecnico,
            this.colFecha});
            this.listaComentarios.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.listaComentarios.GridControl = this.gridControl1;
            this.listaComentarios.Name = "listaComentarios";
            this.listaComentarios.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.listaComentarios.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.listaComentarios.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.listaComentarios.OptionsBehavior.Editable = false;
            // 
            // colComentario
            // 
            this.colComentario.FieldName = "Comentario";
            this.colComentario.Name = "colComentario";
            this.colComentario.Visible = true;
            this.colComentario.VisibleIndex = 0;
            // 
            // colTecnico
            // 
            this.colTecnico.FieldName = "Tecnico";
            this.colTecnico.Name = "colTecnico";
            this.colTecnico.Visible = true;
            this.colTecnico.VisibleIndex = 1;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
            // 
            // cbxEstado
            // 
            this.cbxEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(192, 44);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(327, 32);
            this.cbxEstado.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Estado:";
            // 
            // btnAgregarComentario
            // 
            this.btnAgregarComentario.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarComentario.Appearance.Options.UseFont = true;
            this.btnAgregarComentario.Location = new System.Drawing.Point(889, 398);
            this.btnAgregarComentario.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarComentario.Name = "btnAgregarComentario";
            this.btnAgregarComentario.Size = new System.Drawing.Size(196, 50);
            this.btnAgregarComentario.TabIndex = 51;
            this.btnAgregarComentario.Text = "Agregar Comentario";
            this.btnAgregarComentario.Click += new System.EventHandler(this.btnAgregarComentario_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.Location = new System.Drawing.Point(889, 560);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(196, 50);
            this.btnGuardar.TabIndex = 52;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Location = new System.Drawing.Point(889, 651);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(196, 50);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // listaComentariosTableAdapter1
            // 
            this.listaComentariosTableAdapter1.ClearBeforeFill = true;
            // 
            // btnContactar
            // 
            this.btnContactar.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactar.Appearance.Options.UseFont = true;
            this.btnContactar.Location = new System.Drawing.Point(889, 478);
            this.btnContactar.Margin = new System.Windows.Forms.Padding(4);
            this.btnContactar.Name = "btnContactar";
            this.btnContactar.Size = new System.Drawing.Size(196, 50);
            this.btnContactar.TabIndex = 54;
            this.btnContactar.Text = "Contactar Cliente";
            this.btnContactar.Click += new System.EventHandler(this.btnContactar_Click);
            // 
            // ModificarTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1137, 738);
            this.ControlBox = false;
            this.Controls.Add(this.btnContactar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregarComentario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModificarTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarTickets";
            this.Load += new System.EventHandler(this.ModificarTickets_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionComentarios1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaComentarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrioridad;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtUsuarioSolicita;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbltecnico;
        private System.Windows.Forms.TextBox txt_nombTicket;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblUsusolicita;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.RichTextBox txt_comentario;
        private System.Windows.Forms.Label lbl_comentarios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView listaComentarios;
        private DevExpress.XtraEditors.SimpleButton btnAgregarComentario;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private ConexionComentarios conexionComentarios1;
        private DevExpress.XtraGrid.Columns.GridColumn colComentario;
        private DevExpress.XtraGrid.Columns.GridColumn colTecnico;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private ConexionComentariosTableAdapters.ListaComentariosTableAdapter listaComentariosTableAdapter1;
        private System.Windows.Forms.ComboBox cbxTecnico;
        private DevExpress.XtraEditors.SimpleButton btnContactar;
    }
}
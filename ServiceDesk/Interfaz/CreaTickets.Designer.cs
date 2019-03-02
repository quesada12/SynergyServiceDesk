namespace Interfaz
{
    partial class CreaTickets
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
            this.cmb_tecnico = new System.Windows.Forms.ComboBox();
            this.lbltecnico = new System.Windows.Forms.Label();
            this.txt_usuSolicita = new System.Windows.Forms.TextBox();
            this.lblUsusolicita = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_creaTicket = new System.Windows.Forms.Button();
            this.dateEstimada = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.dateCierre = new System.Windows.Forms.DateTimePicker();
            this.lbl_fechaCierre = new System.Windows.Forms.Label();
            this.lbl_comentarios = new System.Windows.Forms.Label();
            this.dateCreacion = new System.Windows.Forms.DateTimePicker();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.txt_comentario = new System.Windows.Forms.RichTextBox();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_creacion = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.txt_nombTicket = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lblCrearTicket = new DevExpress.XtraEditors.LabelControl();
            this.cmb_prioridad = new System.Windows.Forms.ComboBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_tecnico
            // 
            this.cmb_tecnico.FormattingEnabled = true;
            this.cmb_tecnico.Location = new System.Drawing.Point(310, 432);
            this.cmb_tecnico.Name = "cmb_tecnico";
            this.cmb_tecnico.Size = new System.Drawing.Size(121, 21);
            this.cmb_tecnico.TabIndex = 44;
            // 
            // lbltecnico
            // 
            this.lbltecnico.AutoSize = true;
            this.lbltecnico.Location = new System.Drawing.Point(307, 416);
            this.lbltecnico.Name = "lbltecnico";
            this.lbltecnico.Size = new System.Drawing.Size(46, 13);
            this.lbltecnico.TabIndex = 43;
            this.lbltecnico.Text = "Técnico";
            // 
            // txt_usuSolicita
            // 
            this.txt_usuSolicita.Location = new System.Drawing.Point(36, 191);
            this.txt_usuSolicita.Name = "txt_usuSolicita";
            this.txt_usuSolicita.Size = new System.Drawing.Size(100, 20);
            this.txt_usuSolicita.TabIndex = 42;
            // 
            // lblUsusolicita
            // 
            this.lblUsusolicita.AutoSize = true;
            this.lblUsusolicita.Location = new System.Drawing.Point(33, 175);
            this.lblUsusolicita.Name = "lblUsusolicita";
            this.lblUsusolicita.Size = new System.Drawing.Size(93, 13);
            this.lblUsusolicita.TabIndex = 41;
            this.lblUsusolicita.Text = "Usuario solicitante";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(362, 469);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(159, 47);
            this.btn_salir.TabIndex = 40;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_creaTicket
            // 
            this.btn_creaTicket.Location = new System.Drawing.Point(166, 469);
            this.btn_creaTicket.Name = "btn_creaTicket";
            this.btn_creaTicket.Size = new System.Drawing.Size(159, 47);
            this.btn_creaTicket.TabIndex = 39;
            this.btn_creaTicket.Text = "Crear";
            this.btn_creaTicket.UseVisualStyleBackColor = true;
            // 
            // dateEstimada
            // 
            this.dateEstimada.Location = new System.Drawing.Point(36, 332);
            this.dateEstimada.Name = "dateEstimada";
            this.dateEstimada.Size = new System.Drawing.Size(200, 20);
            this.dateEstimada.TabIndex = 38;
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.AutoSize = true;
            this.lblFechaCierre.Location = new System.Drawing.Point(33, 316);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.Size = new System.Drawing.Size(67, 13);
            this.lblFechaCierre.TabIndex = 37;
            this.lblFechaCierre.Text = "Fecha Cierre";
            // 
            // dateCierre
            // 
            this.dateCierre.Location = new System.Drawing.Point(36, 432);
            this.dateCierre.Name = "dateCierre";
            this.dateCierre.Size = new System.Drawing.Size(200, 20);
            this.dateCierre.TabIndex = 36;
            // 
            // lbl_fechaCierre
            // 
            this.lbl_fechaCierre.AutoSize = true;
            this.lbl_fechaCierre.Location = new System.Drawing.Point(33, 416);
            this.lbl_fechaCierre.Name = "lbl_fechaCierre";
            this.lbl_fechaCierre.Size = new System.Drawing.Size(67, 13);
            this.lbl_fechaCierre.TabIndex = 35;
            this.lbl_fechaCierre.Text = "Fecha Cierre";
            // 
            // lbl_comentarios
            // 
            this.lbl_comentarios.AutoSize = true;
            this.lbl_comentarios.Location = new System.Drawing.Point(307, 121);
            this.lbl_comentarios.Name = "lbl_comentarios";
            this.lbl_comentarios.Size = new System.Drawing.Size(65, 13);
            this.lbl_comentarios.TabIndex = 34;
            this.lbl_comentarios.Text = "Comentarios";
            // 
            // dateCreacion
            // 
            this.dateCreacion.Location = new System.Drawing.Point(36, 282);
            this.dateCreacion.Name = "dateCreacion";
            this.dateCreacion.Size = new System.Drawing.Size(200, 20);
            this.dateCreacion.TabIndex = 33;
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Location = new System.Drawing.Point(36, 383);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(121, 21);
            this.cmb_estado.TabIndex = 32;
            this.cmb_estado.SelectedIndexChanged += new System.EventHandler(this.cmb_estado_SelectedIndexChanged);
            // 
            // txt_comentario
            // 
            this.txt_comentario.Location = new System.Drawing.Point(310, 137);
            this.txt_comentario.Name = "txt_comentario";
            this.txt_comentario.Size = new System.Drawing.Size(384, 267);
            this.txt_comentario.TabIndex = 31;
            this.txt_comentario.Text = "";
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(36, 242);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(121, 21);
            this.cmb_categoria.TabIndex = 30;
            this.cmb_categoria.SelectedIndexChanged += new System.EventHandler(this.cmb_categoria_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Estado Ticket";
            // 
            // lbl_creacion
            // 
            this.lbl_creacion.AutoSize = true;
            this.lbl_creacion.Location = new System.Drawing.Point(33, 266);
            this.lbl_creacion.Name = "lbl_creacion";
            this.lbl_creacion.Size = new System.Drawing.Size(82, 13);
            this.lbl_creacion.TabIndex = 28;
            this.lbl_creacion.Text = "Fecha Creación";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(33, 225);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(57, 13);
            this.lbl_categoria.TabIndex = 27;
            this.lbl_categoria.Text = "Categoría ";
            // 
            // txt_nombTicket
            // 
            this.txt_nombTicket.Location = new System.Drawing.Point(36, 137);
            this.txt_nombTicket.Name = "txt_nombTicket";
            this.txt_nombTicket.Size = new System.Drawing.Size(100, 20);
            this.txt_nombTicket.TabIndex = 26;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(33, 121);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(77, 13);
            this.lbl_nombre.TabIndex = 25;
            this.lbl_nombre.Text = "Nombre Ticket";
            // 
            // lblCrearTicket
            // 
            this.lblCrearTicket.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.lblCrearTicket.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCrearTicket.Appearance.Options.UseFont = true;
            this.lblCrearTicket.Appearance.Options.UseForeColor = true;
            this.lblCrearTicket.Location = new System.Drawing.Point(234, 30);
            this.lblCrearTicket.Name = "lblCrearTicket";
            this.lblCrearTicket.Size = new System.Drawing.Size(287, 41);
            this.lblCrearTicket.TabIndex = 45;
            this.lblCrearTicket.Text = "Crear Nuevo Ticket";
            // 
            // cmb_prioridad
            // 
            this.cmb_prioridad.FormattingEnabled = true;
            this.cmb_prioridad.Location = new System.Drawing.Point(456, 431);
            this.cmb_prioridad.Name = "cmb_prioridad";
            this.cmb_prioridad.Size = new System.Drawing.Size(121, 21);
            this.cmb_prioridad.TabIndex = 47;
            this.cmb_prioridad.SelectedIndexChanged += new System.EventHandler(this.cmbPrioridad_SelectedIndexChanged);
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(453, 415);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(48, 13);
            this.lblPrioridad.TabIndex = 46;
            this.lblPrioridad.Text = "Prioridad";
            // 
            // CreaTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 533);
            this.Controls.Add(this.cmb_prioridad);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.lblCrearTicket);
            this.Controls.Add(this.cmb_tecnico);
            this.Controls.Add(this.lbltecnico);
            this.Controls.Add(this.txt_usuSolicita);
            this.Controls.Add(this.lblUsusolicita);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_creaTicket);
            this.Controls.Add(this.dateEstimada);
            this.Controls.Add(this.lblFechaCierre);
            this.Controls.Add(this.dateCierre);
            this.Controls.Add(this.lbl_fechaCierre);
            this.Controls.Add(this.lbl_comentarios);
            this.Controls.Add(this.dateCreacion);
            this.Controls.Add(this.cmb_estado);
            this.Controls.Add(this.txt_comentario);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_creacion);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.txt_nombTicket);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "CreaTickets";
            this.Text = "CreaTickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_tecnico;
        private System.Windows.Forms.Label lbltecnico;
        private System.Windows.Forms.TextBox txt_usuSolicita;
        private System.Windows.Forms.Label lblUsusolicita;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_creaTicket;
        private System.Windows.Forms.DateTimePicker dateEstimada;
        private System.Windows.Forms.Label lblFechaCierre;
        private System.Windows.Forms.DateTimePicker dateCierre;
        private System.Windows.Forms.Label lbl_fechaCierre;
        private System.Windows.Forms.Label lbl_comentarios;
        private System.Windows.Forms.DateTimePicker dateCreacion;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.RichTextBox txt_comentario;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_creacion;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.TextBox txt_nombTicket;
        private System.Windows.Forms.Label lbl_nombre;
        private DevExpress.XtraEditors.LabelControl lblCrearTicket;
        private System.Windows.Forms.ComboBox cmb_prioridad;
        private System.Windows.Forms.Label lblPrioridad;
    }
}
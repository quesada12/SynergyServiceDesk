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
            this.lblUsusolicita = new System.Windows.Forms.Label();
            this.lbl_comentarios = new System.Windows.Forms.Label();
            this.txt_comentario = new System.Windows.Forms.RichTextBox();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.txt_nombTicket = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.cmb_prioridad = new System.Windows.Forms.ComboBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSolicita = new System.Windows.Forms.ComboBox();
            this.btnCrear = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_tecnico
            // 
            this.cmb_tecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tecnico.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tecnico.FormattingEnabled = true;
            this.cmb_tecnico.Location = new System.Drawing.Point(144, 230);
            this.cmb_tecnico.Name = "cmb_tecnico";
            this.cmb_tecnico.Size = new System.Drawing.Size(246, 27);
            this.cmb_tecnico.TabIndex = 44;
            // 
            // lbltecnico
            // 
            this.lbltecnico.AutoSize = true;
            this.lbltecnico.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltecnico.ForeColor = System.Drawing.Color.White;
            this.lbltecnico.Location = new System.Drawing.Point(68, 233);
            this.lbltecnico.Name = "lbltecnico";
            this.lbltecnico.Size = new System.Drawing.Size(58, 19);
            this.lbltecnico.TabIndex = 43;
            this.lbltecnico.Text = "Técnico";
            // 
            // lblUsusolicita
            // 
            this.lblUsusolicita.AutoSize = true;
            this.lblUsusolicita.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsusolicita.ForeColor = System.Drawing.Color.White;
            this.lblUsusolicita.Location = new System.Drawing.Point(3, 106);
            this.lblUsusolicita.Name = "lblUsusolicita";
            this.lblUsusolicita.Size = new System.Drawing.Size(135, 19);
            this.lblUsusolicita.TabIndex = 41;
            this.lblUsusolicita.Text = "Usuario solicitante:";
            // 
            // lbl_comentarios
            // 
            this.lbl_comentarios.AutoSize = true;
            this.lbl_comentarios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comentarios.ForeColor = System.Drawing.Color.White;
            this.lbl_comentarios.Location = new System.Drawing.Point(419, 56);
            this.lbl_comentarios.Name = "lbl_comentarios";
            this.lbl_comentarios.Size = new System.Drawing.Size(95, 19);
            this.lbl_comentarios.TabIndex = 34;
            this.lbl_comentarios.Text = "Comentarios:";
            // 
            // txt_comentario
            // 
            this.txt_comentario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comentario.Location = new System.Drawing.Point(423, 85);
            this.txt_comentario.Name = "txt_comentario";
            this.txt_comentario.Size = new System.Drawing.Size(387, 178);
            this.txt_comentario.TabIndex = 31;
            this.txt_comentario.Text = "";
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(144, 143);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(246, 27);
            this.cmb_categoria.TabIndex = 30;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.ForeColor = System.Drawing.Color.White;
            this.lbl_categoria.Location = new System.Drawing.Point(59, 146);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(76, 19);
            this.lbl_categoria.TabIndex = 27;
            this.lbl_categoria.Text = "Categoría:";
            // 
            // txt_nombTicket
            // 
            this.txt_nombTicket.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombTicket.Location = new System.Drawing.Point(144, 62);
            this.txt_nombTicket.Name = "txt_nombTicket";
            this.txt_nombTicket.Size = new System.Drawing.Size(246, 27);
            this.txt_nombTicket.TabIndex = 26;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(29, 69);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(106, 19);
            this.lbl_nombre.TabIndex = 25;
            this.lbl_nombre.Text = "Nombre Ticket:";
            // 
            // cmb_prioridad
            // 
            this.cmb_prioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_prioridad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_prioridad.FormattingEnabled = true;
            this.cmb_prioridad.Location = new System.Drawing.Point(144, 186);
            this.cmb_prioridad.Name = "cmb_prioridad";
            this.cmb_prioridad.Size = new System.Drawing.Size(246, 27);
            this.cmb_prioridad.TabIndex = 47;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.ForeColor = System.Drawing.Color.White;
            this.lblPrioridad.Location = new System.Drawing.Point(68, 194);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(67, 19);
            this.lblPrioridad.TabIndex = 46;
            this.lblPrioridad.Text = "Prioridad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSolicita);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.cmb_tecnico);
            this.groupBox1.Controls.Add(this.cmb_prioridad);
            this.groupBox1.Controls.Add(this.lbltecnico);
            this.groupBox1.Controls.Add(this.txt_nombTicket);
            this.groupBox1.Controls.Add(this.lblPrioridad);
            this.groupBox1.Controls.Add(this.lblUsusolicita);
            this.groupBox1.Controls.Add(this.lbl_categoria);
            this.groupBox1.Controls.Add(this.cmb_categoria);
            this.groupBox1.Controls.Add(this.txt_comentario);
            this.groupBox1.Controls.Add(this.lbl_comentarios);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 363);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Ticket";
            // 
            // cmbSolicita
            // 
            this.cmbSolicita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSolicita.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSolicita.FormattingEnabled = true;
            this.cmbSolicita.Location = new System.Drawing.Point(144, 103);
            this.cmbSolicita.Name = "cmbSolicita";
            this.cmbSolicita.Size = new System.Drawing.Size(246, 27);
            this.cmbSolicita.TabIndex = 48;
            // 
            // btnCrear
            // 
            this.btnCrear.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Appearance.Options.UseFont = true;
            this.btnCrear.Location = new System.Drawing.Point(694, 433);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(147, 41);
            this.btnCrear.TabIndex = 49;
            this.btnCrear.Text = "Crear";
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Location = new System.Drawing.Point(738, 496);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 37);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // CreaTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(853, 561);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreaTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreaTickets";
            this.Load += new System.EventHandler(this.CreaTickets_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_tecnico;
        private System.Windows.Forms.Label lbltecnico;
        private System.Windows.Forms.Label lblUsusolicita;
        private System.Windows.Forms.Label lbl_comentarios;
        private System.Windows.Forms.RichTextBox txt_comentario;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.TextBox txt_nombTicket;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.ComboBox cmb_prioridad;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSolicita;
        private DevExpress.XtraEditors.SimpleButton btnCrear;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
    }
}
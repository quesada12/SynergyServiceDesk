namespace Interfaz
{
    partial class AdminMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnDepartamento = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(79, 19);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 17);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label2";
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.Location = new System.Drawing.Point(52, 59);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(226, 74);
            this.btnDepartamento.TabIndex = 2;
            this.btnDepartamento.Text = "Crear Departamento";
            this.btnDepartamento.UseVisualStyleBackColor = true;
            this.btnDepartamento.Click += new System.EventHandler(this.btnDepartamento_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(52, 146);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(226, 74);
            this.btnUsuario.TabIndex = 3;
            this.btnUsuario.Text = "Crear Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(52, 236);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(226, 74);
            this.btnActivar.TabIndex = 4;
            this.btnActivar.Text = "Activar Usuario";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(188, 437);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 34);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Cerrar Sesión";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInactivar
            // 
            this.btnInactivar.Location = new System.Drawing.Point(52, 326);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(226, 74);
            this.btnInactivar.TabIndex = 6;
            this.btnInactivar.Text = "Inactivar Usuario";
            this.btnInactivar.UseVisualStyleBackColor = true;
            this.btnInactivar.Click += new System.EventHandler(this.btnInactivar_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 483);
            this.Controls.Add(this.btnInactivar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnDepartamento);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Name = "AdminMenu";
            this.Text = "Menú Administrador";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnDepartamento;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInactivar;
    }
}
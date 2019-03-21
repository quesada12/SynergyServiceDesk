namespace Interfaz
{
    partial class ActivarUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbxUsuarios = new System.Windows.Forms.ComboBox();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activar Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione un usuario:";
            // 
            // cbxUsuarios
            // 
            this.cbxUsuarios.FormattingEnabled = true;
            this.cbxUsuarios.Location = new System.Drawing.Point(187, 90);
            this.cbxUsuarios.Name = "cbxUsuarios";
            this.cbxUsuarios.Size = new System.Drawing.Size(225, 24);
            this.cbxUsuarios.TabIndex = 2;
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(246, 151);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(166, 53);
            this.btnActivar.TabIndex = 3;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(110, 171);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(113, 33);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // ActivarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 232);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.cbxUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ActivarUsuario";
            this.Text = "ActivarUsuario";
            this.Load += new System.EventHandler(this.ActivarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxUsuarios;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnRegresar;
    }
}
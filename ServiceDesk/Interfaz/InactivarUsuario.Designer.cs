namespace Interfaz
{
    partial class InactivarUsuario
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
            this.btnInactivar = new System.Windows.Forms.Button();
            this.cbxUsuarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInactivar
            // 
            this.btnInactivar.Location = new System.Drawing.Point(249, 146);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(166, 53);
            this.btnInactivar.TabIndex = 7;
            this.btnInactivar.Text = "Inactivar";
            this.btnInactivar.UseVisualStyleBackColor = true;
            this.btnInactivar.Click += new System.EventHandler(this.btnInactivar_Click);
            // 
            // cbxUsuarios
            // 
            this.cbxUsuarios.FormattingEnabled = true;
            this.cbxUsuarios.Location = new System.Drawing.Point(190, 85);
            this.cbxUsuarios.Name = "cbxUsuarios";
            this.cbxUsuarios.Size = new System.Drawing.Size(225, 24);
            this.cbxUsuarios.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione un usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inactivar Usuario";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(110, 166);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(113, 33);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // InactivarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 222);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnInactivar);
            this.Controls.Add(this.cbxUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InactivarUsuario";
            this.Text = "InactivarUsuario";
            this.Load += new System.EventHandler(this.InactivarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.ComboBox cbxUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
    }
}
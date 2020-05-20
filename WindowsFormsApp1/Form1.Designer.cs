namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lnombre = new System.Windows.Forms.Label();
            this.llistasocios = new System.Windows.Forms.Label();
            this.lapellidos = new System.Windows.Forms.Label();
            this.ltelefono = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tApellidos = new System.Windows.Forms.TextBox();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.tListaSocios = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Location = new System.Drawing.Point(29, 31);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(66, 17);
            this.lnombre.TabIndex = 0;
            this.lnombre.Text = "Nombre: ";
            // 
            // llistasocios
            // 
            this.llistasocios.AutoSize = true;
            this.llistasocios.Location = new System.Drawing.Point(29, 114);
            this.llistasocios.Name = "llistasocios";
            this.llistasocios.Size = new System.Drawing.Size(84, 17);
            this.llistasocios.TabIndex = 1;
            this.llistasocios.Text = "Lista Socios";
            // 
            // lapellidos
            // 
            this.lapellidos.AutoSize = true;
            this.lapellidos.Location = new System.Drawing.Point(247, 31);
            this.lapellidos.Name = "lapellidos";
            this.lapellidos.Size = new System.Drawing.Size(69, 17);
            this.lapellidos.TabIndex = 2;
            this.lapellidos.Text = "Apellidos:";
            // 
            // ltelefono
            // 
            this.ltelefono.AutoSize = true;
            this.ltelefono.Location = new System.Drawing.Point(494, 31);
            this.ltelefono.Name = "ltelefono";
            this.ltelefono.Size = new System.Drawing.Size(68, 17);
            this.ltelefono.TabIndex = 3;
            this.ltelefono.Text = "Teléfono:";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(90, 28);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(140, 22);
            this.tNombre.TabIndex = 4;
            // 
            // tApellidos
            // 
            this.tApellidos.Location = new System.Drawing.Point(322, 28);
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(148, 22);
            this.tApellidos.TabIndex = 5;
            // 
            // tTelefono
            // 
            this.tTelefono.Location = new System.Drawing.Point(568, 28);
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(140, 22);
            this.tTelefono.TabIndex = 6;
            // 
            // tListaSocios
            // 
            this.tListaSocios.Location = new System.Drawing.Point(32, 134);
            this.tListaSocios.Multiline = true;
            this.tListaSocios.Name = "tListaSocios";
            this.tListaSocios.ReadOnly = true;
            this.tListaSocios.Size = new System.Drawing.Size(702, 286);
            this.tListaSocios.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tListaSocios);
            this.Controls.Add(this.tTelefono);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.ltelefono);
            this.Controls.Add(this.lapellidos);
            this.Controls.Add(this.llistasocios);
            this.Controls.Add(this.lnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lnombre;
        private System.Windows.Forms.Label llistasocios;
        private System.Windows.Forms.Label lapellidos;
        private System.Windows.Forms.Label ltelefono;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tApellidos;
        private System.Windows.Forms.TextBox tTelefono;
        private System.Windows.Forms.TextBox tListaSocios;
    }
}


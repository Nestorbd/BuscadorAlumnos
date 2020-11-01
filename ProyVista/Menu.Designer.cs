namespace Buscador.Vista
{
    partial class Menu

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
            this.verAlumnos = new System.Windows.Forms.Button();
            this.busEliAlumno = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // verAlumnos
            // 
            this.verAlumnos.Location = new System.Drawing.Point(12, 12);
            this.verAlumnos.Name = "verAlumnos";
            this.verAlumnos.Size = new System.Drawing.Size(213, 47);
            this.verAlumnos.TabIndex = 0;
            this.verAlumnos.Text = "Ver Alumnos";
            this.verAlumnos.UseVisualStyleBackColor = true;
            this.verAlumnos.Click += new System.EventHandler(this.verAlumnos_Click);
            // 
            // busEliAlumno
            // 
            this.busEliAlumno.Location = new System.Drawing.Point(12, 65);
            this.busEliAlumno.Name = "busEliAlumno";
            this.busEliAlumno.Size = new System.Drawing.Size(213, 47);
            this.busEliAlumno.TabIndex = 1;
            this.busEliAlumno.Text = "Buscar/Eliminar Alumno";
            this.busEliAlumno.UseVisualStyleBackColor = true;
            this.busEliAlumno.Click += new System.EventHandler(this.busEliAlumno_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(12, 118);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(213, 47);
            this.salir.TabIndex = 2;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 178);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.busEliAlumno);
            this.Controls.Add(this.verAlumnos);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button verAlumnos;
        private System.Windows.Forms.Button busEliAlumno;
        private System.Windows.Forms.Button salir;
    }
}


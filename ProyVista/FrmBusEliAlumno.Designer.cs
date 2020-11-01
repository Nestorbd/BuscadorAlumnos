using System.Windows.Forms;

namespace Buscador.Vista
{
    partial class FrmBusEliAlumno
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
            this.dniAlumno = new System.Windows.Forms.Label();
            this.txtDniAlumno = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.dataGridAlumno = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // dniAlumno
            // 
            this.dniAlumno.AutoSize = true;
            this.dniAlumno.Location = new System.Drawing.Point(76, 27);
            this.dniAlumno.Name = "dniAlumno";
            this.dniAlumno.Size = new System.Drawing.Size(78, 13);
            this.dniAlumno.TabIndex = 0;
            this.dniAlumno.Text = "DNI ALUMNO:";
            // 
            // txtDniAlumno
            // 
            this.txtDniAlumno.Location = new System.Drawing.Point(160, 25);
            this.txtDniAlumno.Name = "txtDniAlumno";
            this.txtDniAlumno.Size = new System.Drawing.Size(73, 20);
            this.txtDniAlumno.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(239, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 137);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(336, 137);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // dataGridAlumno
            // 
            this.dataGridAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumno.Location = new System.Drawing.Point(12, 62);
            this.dataGridAlumno.Name = "dataGridAlumno";
            this.dataGridAlumno.Size = new System.Drawing.Size(445, 60);
            this.dataGridAlumno.TabIndex = 11;
            // 
            // FrmBusEliAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 163);
            this.Controls.Add(this.dataGridAlumno);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDniAlumno);
            this.Controls.Add(this.dniAlumno);
            this.Name = "FrmBusEliAlumno";
            this.Text = "Buscar/Eliminar Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dniAlumno;
        private System.Windows.Forms.TextBox txtDniAlumno;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMenu;
        private DataGridView dataGridAlumno;

        public TextBox TxtDniAlumno { get => txtDniAlumno; set => txtDniAlumno = value; }
        public Button BtnBuscar { get => btnBuscar; set => btnBuscar = value; }
        public Button BtnEliminar { get => btnEliminar; set => btnEliminar = value; }
        public Button BtnMenu { get => btnMenu; set => btnMenu = value; }
        public DataGridView DataGridAlumno { get => dataGridAlumno; set => dataGridAlumno = value; }
    }
}
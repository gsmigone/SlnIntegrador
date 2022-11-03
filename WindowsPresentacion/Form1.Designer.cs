namespace WindowsPresentacion
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
            this.gridMedicos = new System.Windows.Forms.DataGridView();
            this.btnMostrarMedicos = new System.Windows.Forms.Button();
            this.lstHabitaciones = new System.Windows.Forms.ListBox();
            this.lstMedicosClinicos = new System.Windows.Forms.ListBox();
            this.btnMostrarPacientes = new System.Windows.Forms.Button();
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.btnMostrarHabitaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMedicos
            // 
            this.gridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicos.Location = new System.Drawing.Point(29, 172);
            this.gridMedicos.Name = "gridMedicos";
            this.gridMedicos.Size = new System.Drawing.Size(403, 228);
            this.gridMedicos.TabIndex = 0;
            // 
            // btnMostrarMedicos
            // 
            this.btnMostrarMedicos.Location = new System.Drawing.Point(29, 88);
            this.btnMostrarMedicos.Name = "btnMostrarMedicos";
            this.btnMostrarMedicos.Size = new System.Drawing.Size(180, 43);
            this.btnMostrarMedicos.TabIndex = 1;
            this.btnMostrarMedicos.Text = "Mostrar Medicos";
            this.btnMostrarMedicos.UseVisualStyleBackColor = true;
            this.btnMostrarMedicos.Click += new System.EventHandler(this.btnMostrarMedicos_Click);
            // 
            // lstHabitaciones
            // 
            this.lstHabitaciones.FormattingEnabled = true;
            this.lstHabitaciones.Location = new System.Drawing.Point(504, 520);
            this.lstHabitaciones.Name = "lstHabitaciones";
            this.lstHabitaciones.Size = new System.Drawing.Size(120, 95);
            this.lstHabitaciones.TabIndex = 2;
            // 
            // lstMedicosClinicos
            // 
            this.lstMedicosClinicos.FormattingEnabled = true;
            this.lstMedicosClinicos.Location = new System.Drawing.Point(504, 184);
            this.lstMedicosClinicos.Name = "lstMedicosClinicos";
            this.lstMedicosClinicos.Size = new System.Drawing.Size(120, 95);
            this.lstMedicosClinicos.TabIndex = 3;
            // 
            // btnMostrarPacientes
            // 
            this.btnMostrarPacientes.Location = new System.Drawing.Point(29, 447);
            this.btnMostrarPacientes.Name = "btnMostrarPacientes";
            this.btnMostrarPacientes.Size = new System.Drawing.Size(180, 43);
            this.btnMostrarPacientes.TabIndex = 4;
            this.btnMostrarPacientes.Text = "Mostrar Pacientes";
            this.btnMostrarPacientes.UseVisualStyleBackColor = true;
            this.btnMostrarPacientes.Click += new System.EventHandler(this.btnMostrarPacientes_Click);
            // 
            // gridPacientes
            // 
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.Location = new System.Drawing.Point(29, 520);
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.Size = new System.Drawing.Size(403, 228);
            this.gridPacientes.TabIndex = 5;
            // 
            // btnMostrarHabitaciones
            // 
            this.btnMostrarHabitaciones.Location = new System.Drawing.Point(504, 447);
            this.btnMostrarHabitaciones.Name = "btnMostrarHabitaciones";
            this.btnMostrarHabitaciones.Size = new System.Drawing.Size(120, 43);
            this.btnMostrarHabitaciones.TabIndex = 6;
            this.btnMostrarHabitaciones.Text = "Mostrar Habitaciones";
            this.btnMostrarHabitaciones.UseVisualStyleBackColor = true;
            this.btnMostrarHabitaciones.Click += new System.EventHandler(this.btnMostrarHabitaciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.btnMostrarHabitaciones);
            this.Controls.Add(this.gridPacientes);
            this.Controls.Add(this.btnMostrarPacientes);
            this.Controls.Add(this.lstMedicosClinicos);
            this.Controls.Add(this.lstHabitaciones);
            this.Controls.Add(this.btnMostrarMedicos);
            this.Controls.Add(this.gridMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMedicos;
        private System.Windows.Forms.Button btnMostrarMedicos;
        private System.Windows.Forms.ListBox lstHabitaciones;
        private System.Windows.Forms.ListBox lstMedicosClinicos;
        private System.Windows.Forms.Button btnMostrarPacientes;
        private System.Windows.Forms.DataGridView gridPacientes;
        private System.Windows.Forms.Button btnMostrarHabitaciones;
    }
}


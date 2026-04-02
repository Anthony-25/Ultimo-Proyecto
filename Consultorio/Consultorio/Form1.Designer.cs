namespace Consultorio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtID = new TextBox();
            txtPaciente = new TextBox();
            txtFecha = new TextBox();
            txtHora = new TextBox();
            txtDuracion = new TextBox();
            txtDentista = new TextBox();
            txtMotivo = new TextBox();
            btnAgendar = new Button();
            btnMostrar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnExportar = new Button();
            btnSalir = new Button();
            dgvCitas = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Paciente = new DataGridViewTextBoxColumn();
            FechaHora = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            Dentista = new DataGridViewTextBoxColumn();
            Motivo = new DataGridViewTextBoxColumn();
            DiasRestantes = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 47);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "ID de Cita";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 97);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Paciente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 145);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 196);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Hora";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 242);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Duración";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 297);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 5;
            label6.Text = "Dentista";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 352);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 6;
            label7.Text = "Motivo";
            // 
            // txtID
            // 
            txtID.Location = new Point(136, 39);
            txtID.Name = "txtID";
            txtID.Size = new Size(198, 23);
            txtID.TabIndex = 7;
            // 
            // txtPaciente
            // 
            txtPaciente.Location = new Point(136, 89);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(198, 23);
            txtPaciente.TabIndex = 8;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(136, 137);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(198, 23);
            txtFecha.TabIndex = 9;
            // 
            // txtHora
            // 
            txtHora.Location = new Point(136, 188);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(198, 23);
            txtHora.TabIndex = 10;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(136, 234);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(198, 23);
            txtDuracion.TabIndex = 11;
            txtDuracion.TextChanged += TxtDuracion_TextChanged;
            // 
            // txtDentista
            // 
            txtDentista.Location = new Point(136, 289);
            txtDentista.Name = "txtDentista";
            txtDentista.Size = new Size(198, 23);
            txtDentista.TabIndex = 12;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(136, 349);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(198, 23);
            txtMotivo.TabIndex = 13;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(39, 443);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(87, 47);
            btnAgendar.TabIndex = 14;
            btnAgendar.Text = "Agendar Cita";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(132, 443);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(87, 47);
            btnMostrar.TabIndex = 15;
            btnMostrar.Text = "Mostrar Citas";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(225, 443);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(87, 47);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Actualizar Cita";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += BtnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(381, 443);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(87, 47);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar Cita";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(474, 443);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(87, 47);
            btnExportar.TabIndex = 18;
            btnExportar.Text = "Exportar CSV";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(567, 443);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(87, 47);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvCitas
            // 
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Columns.AddRange(new DataGridViewColumn[] { ID, Paciente, FechaHora, Duracion, Dentista, Motivo, DiasRestantes, Estado });
            dgvCitas.Location = new Point(366, 39);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.Size = new Size(637, 192);
            dgvCitas.TabIndex = 20;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Paciente
            // 
            Paciente.HeaderText = "Paciente";
            Paciente.Name = "Paciente";
            // 
            // FechaHora
            // 
            FechaHora.HeaderText = "Fecha y Hora";
            FechaHora.Name = "FechaHora";
            // 
            // Duracion
            // 
            Duracion.HeaderText = "Duración";
            Duracion.Name = "Duracion";
            // 
            // Dentista
            // 
            Dentista.HeaderText = "Dentista";
            Dentista.Name = "Dentista";
            // 
            // Motivo
            // 
            Motivo.HeaderText = "Motivo";
            Motivo.Name = "Motivo";
            // 
            // DiasRestantes
            // 
            DiasRestantes.HeaderText = "Días Restantes";
            DiasRestantes.Name = "DiasRestantes";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1015, 503);
            Controls.Add(dgvCitas);
            Controls.Add(btnSalir);
            Controls.Add(btnExportar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnMostrar);
            Controls.Add(btnAgendar);
            Controls.Add(txtMotivo);
            Controls.Add(txtDentista);
            Controls.Add(txtDuracion);
            Controls.Add(txtHora);
            Controls.Add(txtFecha);
            Controls.Add(txtPaciente);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtID;
        private TextBox txtPaciente;
        private TextBox txtFecha;
        private TextBox txtHora;
        private TextBox txtDuracion;
        private TextBox txtDentista;
        private TextBox txtMotivo;
        private Button btnAgendar;
        private Button btnMostrar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnExportar;
        private Button btnSalir;
        private DataGridView dgvCitas;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Paciente;
        private DataGridViewTextBoxColumn FechaHora;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Dentista;
        private DataGridViewTextBoxColumn Motivo;
        private DataGridViewTextBoxColumn DiasRestantes;
        private DataGridViewTextBoxColumn Estado;
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Consultorio;

namespace Consultorio

{
    public partial class Form1 : Form
    {
        private List<Cita> citas = new List<Cita>();

        public Form1()
        {
            InitializeComponent();
        }

        private void TxtDuracion_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            foreach (var c in citas)
            {
                if (c.ID == txtID.Text)
                {
                    try
                    {
                        DateTime fechaHora = DateTime.Parse(txtFecha.Text + " " + txtHora.Text);
                        c.Paciente = txtPaciente.Text;
                        c.FechaHora = fechaHora;
                        c.Duracion = int.Parse(txtDuracion.Text);
                        c.Dentista = txtDentista.Text;
                        c.Motivo = txtMotivo.Text;
                        MessageBox.Show("Cita actualizada correctamente");
                        return;
                    }
                    catch
                    {
                        MessageBox.Show("Error en los datos ingresados, ID no encontrado...");
                        return;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agendando cita...");
            try
            {
                foreach (var c in citas)
                {
                    if (c.ID == txtID.Text)
                    {
                        MessageBox.Show("El ID ya existe");
                        return;
                    }
                }

                DateTime fechaHora = DateTime.Parse(txtFecha.Text + " " + txtHora.Text);

                Cita nueva = new Cita()
                {
                    ID = txtID.Text,
                    Paciente = txtPaciente.Text,
                    FechaHora = fechaHora,
                    Duracion = int.Parse(txtDuracion.Text),
                    Dentista = txtDentista.Text,
                    Motivo = txtMotivo.Text
                };

                citas.Add(nueva);

                MessageBox.Show("Cita registrada correctamente");
            }
            catch
            {
                MessageBox.Show("Error en los datos ingresados");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvCitas.Rows.Clear();
            foreach (var c in citas)
            {
                dgvCitas.Rows.Add(c.ID, c.Paciente, c.FechaHora.ToString("g"), c.Duracion, c.Dentista, c.Motivo);
            }
            
        }
       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < citas.Count; i++)
            {
                if (citas[i].ID == txtID.Text)
                {
                    citas.RemoveAt(i);
                    MessageBox.Show("Cita eliminada correctamente");
                    return;

                }
            }
            MessageBox.Show("ID no encontrado...");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Citas.csv");
            sw.WriteLine("ID, Paciente, FechaHora, Duracion, Dentista, Motivo");

            foreach (var c in citas)
            {
                sw.WriteLine($"{c.ID}, {c.Paciente}, {c.FechaHora}, {c.Duracion}, {c.Dentista}, {c.Motivo}");

            }

            sw.Close();
            MessageBox.Show("Archivo exportado correctacmente");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


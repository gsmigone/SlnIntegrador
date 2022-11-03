using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Models;
using Negocio.Models;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarMedicos_Click(object sender, EventArgs e)
        {
            

            AdmMedico adminMedico = new AdmMedico();        
            gridMedicos.DataSource = adminMedico.Listar();
            List<Medico> medicosClinicos;
            medicosClinicos = adminMedico.Listar("clinico");
            foreach (Medico medico in medicosClinicos)
            {
                lstMedicosClinicos.Items.Add(medico.Nombre + " " + medico.Apellido);
            }

        }

        private void btnMostrarPacientes_Click(object sender, EventArgs e)
        {
            List<Paciente> lista;

            AdmPaciente adminPaciente = new AdmPaciente();

            lista = adminPaciente.Listar();

            gridPacientes.DataSource = lista;

        }

        private void btnMostrarHabitaciones_Click(object sender, EventArgs e)
        {
            AdmHabitacion admHabitaciones = new AdmHabitacion();
            foreach (Habitacion habitacion in admHabitaciones.Listar())
            {
                lstHabitaciones.Items.Add("Número: " + habitacion.Numero + ", estado: " + habitacion.Estado);
            }
        }
    }
}

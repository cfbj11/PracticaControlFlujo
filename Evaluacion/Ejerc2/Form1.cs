using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejerc2
{
    public partial class Form1 : Form
    {
        private Persona persona = new Persona();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombres = tbName.Text;
            string apellidos = tbLastName.Text;
            DateTime fechanacimiento = dtpBirthDate.Value;

            Persona persona = new Persona(nombres,apellidos,fechanacimiento);

            personas.Add(persona);

            tbName.Clear();
            tbLastName.Clear();
            dtpBirthDate.Value = DateTime.Now;

            lbDatos.Items.Add($"{persona.Nombres} {persona.Apellidos} / Edad: {persona.Age()}");
            MessageBox.Show("Persona agregada.")

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
            Estudiantes estudiantes = new Estudiantes();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = tbName.Text;
            
            if (nombre.Length > 25)
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc2.persona
{
    internal class storage
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona (string nombres, string apellidos, DateTime fechanacimiento)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNacimiento = fechanacimiento;
        }

        public int Age()
        {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < FechaNacimiento.DayOfYear) {
                edad--;
            return edad;
        }
    }
}

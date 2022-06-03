using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscadorDeAlumnos
{
    class Alumno
    {
        private string nombre;
        private string apellido;
        private int id;
        private bool isActive;
        private List<int> arregloNotas = new List<int>();
        private int promNotas;

        public Alumno(string nombre, string apellido, int id, bool isActive)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.id = id;
            this.isActive = isActive;
        }

    }


}

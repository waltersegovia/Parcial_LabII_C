using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Alumno))]
    [Serializable]
    public class Persona
    {
        private string apellido;
        private int dni;
        private string nombre;
        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        protected Persona(string nombre, string apellido, int edad, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Edad = edad;
        }

    }
}

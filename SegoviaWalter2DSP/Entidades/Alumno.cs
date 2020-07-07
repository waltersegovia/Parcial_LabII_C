using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Alumno:Persona
    {
        private int id;
        private string direccion;


        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Alumno():base(null,null,0,0)
        { }

        public Alumno(int id,string nombre,string apellido,int edad, int dni, string direccion) :base(nombre,apellido,edad, dni)
        {
            this.id = id;
            this.direccion = direccion;
        }

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido;
        }
    }
}

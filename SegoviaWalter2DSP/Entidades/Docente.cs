using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Docente : Persona
    {
        private string direccion;
        private int id;
        private string email;
        private string sexo;

        public string Sexo
        {
            get { return this.sexo; }
            set { this.sexo = value; }
        }

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

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Docente():base(null,null,0,0)
        { }

        public Docente(string direccion,int id,string email,string nombre,string apellido,int edad,string sexo,int dni)
            :base(nombre,apellido,dni,edad)
        {
            this.Direccion = direccion;
            this.Id = id;
            this.Email = email;
            this.Sexo = sexo;
        }

        public override string ToString()
        {
            return this.Nombre + "  " + this.Apellido;
        }
    }
}

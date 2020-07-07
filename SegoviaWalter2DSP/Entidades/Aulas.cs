using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Aulas
    {
        private int idAula;
        public string Salita;

        public int IdAula
        {
            get { return idAula; }
            set { idAula = value; }
        }

        public Aulas()
        { }

        public Aulas(string salita)
        {
            this.Salita = salita;
        }

        public Aulas(int idAula,string salita):this(salita)
        {
            this.idAula = idAula;
        }
    }
}

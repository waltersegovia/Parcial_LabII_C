using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Evaluaciones
    {
        private int idEvaluacion;
        private int idAlumno;
        private int idDocente;
        private int idAula;
        public int Nota_1;
        public int Nota_2;
        public float NotaFinal;
        public string Observaciones;

        public int IdEvaluacion
        {
            get { return idEvaluacion; }
            set { idEvaluacion = value; }
        }

        public int IdAlumno
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }

        public int IdDocente
        {
            get { return idDocente; }
            set { idDocente = value; }
        }

        public int IdAula
        {
            get { return idAula; }
            set { idAula = value; }
        }

        public Evaluaciones()
        { }

        public Evaluaciones(int idAlumno, int idDocente, int idAula, int nota1, int nota2, float notaFinal, string observaciones)
        {
            this.idAlumno = idAlumno;
            this.idDocente = idDocente;
            this.idAula = idAula;
            Nota_1 = nota1;
            Nota_2 = nota2;
            NotaFinal = notaFinal;
            Observaciones = observaciones;
        }

        public Evaluaciones(int idEvaluacion,int idAlumno,int idDocente,int idAula,int nota1,int nota2,float notaFinal,string observaciones):this(idAlumno,idDocente,idAula,nota1,nota2,notaFinal,observaciones)
        {
            this.idEvaluacion = idEvaluacion;
        }
    }
}

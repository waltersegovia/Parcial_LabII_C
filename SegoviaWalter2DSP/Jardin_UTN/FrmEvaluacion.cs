using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;
using System.IO;

namespace Jardin_UTN
{
    public delegate void DMensaje(string mje);

    public partial class FrmEvaluacion : Form
    {
        public delegate void DEvaluado(List<Alumno> alumnosEv);
        public DEvaluado evaluados;
        DateTime date = DateTime.Now;
        Thread t2;
        
        FrmEvaluados frmEv;
        List<Aulas>aulas;
        private List<Docente> docentes;
        private Queue<Alumno> colaAlumnos;
        private List<Alumno> listaEvaluados;
        private List<Alumno> alumnos;
        Thread t;
        string alum;
        string observacion = " ";
        Aulas aulaAux;
        Docente aux2;
        Alumno auxiliar;
        string aux;
        int nota_1;
        int nota_2;
        float notaFinal;

        public FrmEvaluacion()
        {
            InitializeComponent();
            colaAlumnos = new Queue<Alumno>();
        }

        /// <summary>
        /// Carga la cola y el listbox con la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEvaluacion_Load(object sender, EventArgs e)
        {
            listaEvaluados = new List<Alumno>();
            frmEv = new FrmEvaluados();
         


            frmEv.Show();

        }

        /// <summary>
        /// Metodo para enviar lista de Evaluados
        /// </summary>
        public void RefrescaListaEvaluados()
        {
            //USo el delegado para cargar la lista de Alumnos evaluados
            evaluados = new DEvaluado(frmEv.CargaAlumnos);
            evaluados.Invoke(listaEvaluados);
        }

        /// <summary>
        /// Método Random para Aulas
        /// </summary>
        /// <returns></returns>
        private int ColorSalita()
        {
            Random r = new Random();

            int idColor = r.Next(0, aulas.Count);
            return idColor;
        }

        /// <summary>
        /// Método asociado al delegado 
        /// </summary>
        /// <param name="aulas"></param>
        public void ListaAulas(List<Aulas> aulas)
        {
            this.aulas = aulas;
        }

        /// <summary>
        /// Metodo asociado al delegado de FrmPpal
        /// </summary>
        /// <param name="lDocente"></param>
        public void ListDocente(List<Docente> lDocente)
        {
            this.docentes = lDocente;
        }

        /// <summary>
        /// Método Random para elegir el docente
        /// </summary>
        /// <returns></returns>
        public Docente RandomDocente()
        {
            Docente aux;
            Random rd = new Random();
            int idDoc = rd.Next(0, docentes.Count);
            try
            {
                if (docentes.Count > 0)
                {
                    aux = docentes[idDoc];
                    return aux;
                }
                else { throw new DocentesException("Lista Docente vacia"); }
            }
            catch (DocentesException ex)
            {
                string direccion = AppDomain.CurrentDomain.BaseDirectory;
                Texto texto = new Texto();
                texto.Guardar(direccion + "\\log.txt", "Ejecutó evaluación con la lista Docente vacia");
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        /// <summary>
        /// Método Evaluar Alumno con Método de Extensión
        /// </summary>
        /// <param name=""></param>
        public void EvaluaAlumno()
        {
            Evaluaciones ev;

            while (colaAlumnos.Count > 0 && (RandomDocente() != null))
            {
                t2 = new Thread(Proximo);
                
                if (!(t2.IsAlive))
                    t2.Start();
                t2.Join();

                EvalInvoke2(aux);

                EvalInvoke4(aux2.ToString());
                Thread.Sleep(1000);
                EvalInvoke3(notaFinal.ToString());
                Thread.Sleep(1000);
                EvalInvoke2(string.Empty);
                EvalInvoke3(string.Empty);
                EvalInvoke4(string.Empty);

                listaEvaluados.Add(auxiliar);
                ev = new Evaluaciones(auxiliar.Id, aux2.Id, aulaAux.IdAula, nota_1, nota_2, notaFinal,observacion);

                ConexionDAO.InsertarEvaluado(ev);
                
                Serializar(ev);         
                RefrescaListaEvaluados();
                Actualizarlista();
            }

            tmReloj.Enabled = false;
        }

        /// <summary>
        /// Método para el proximo Alumno
        /// </summary>
        /// <param name="a"></param>
        public void Proximo()
        {
            aulaAux = aulas[ColorSalita()];
            int notaAlu = 11;

            //Uso el Método de extensión
            nota_1 = notaAlu.EvaluaRandom();
            Thread.Sleep(30);
            nota_2 = notaAlu.EvaluaRandom();
            Thread.Sleep(20);
            notaFinal = 0;

            if (nota_1 >= 4 && nota_2 >= 4)
            {
                notaFinal = notaAlu.EvaluaRandom();
                if (notaFinal >= 4)
                    observacion = "Aprobado";
            }
            else
            {
                observacion = "Desaprobado";
            }

            aux2 = RandomDocente();
            auxiliar = colaAlumnos.Dequeue();
            alumnos.Remove(auxiliar);

            string str = String.Format("{0:dd_mm_yyyy}", date);
            alum = string.Format("{0}_{1}_{2}.xml", auxiliar.Nombre, auxiliar.Apellido, str);

            aux = auxiliar.ToString();

            EvalInvoke(aux);
            Thread.Sleep(8000);
            EvalInvoke(string.Empty);      
        }

        /// <summary>
        /// Invoke
        /// </summary>
        /// <param name="mje"></param>
        public void EvalInvoke(string mje)
        {
            if (txtProximoAlumno.InvokeRequired)
            {
                DMensaje miAlumno = new DMensaje(EvalInvoke);
                this.Invoke(miAlumno, new object[] { mje });
            }
            else
            {
                txtProximoAlumno.Text = mje;
            }
        }

        public void EvalInvoke2(string mje)
        {
            if (txtAlumno.InvokeRequired)
            {
                DMensaje miAlumno = new DMensaje(EvalInvoke2);
                this.Invoke(miAlumno, new object[] { mje });
            }
            else
            {
                txtAlumno.Text = mje;
            }
        }

        public void EvalInvoke3(string nota)
        {
            if (txtNota.InvokeRequired)
            {
                DMensaje miNota = new DMensaje(EvalInvoke3);
                this.Invoke(miNota, new object[] { nota });
            }
            else
            {
                txtNota.Text = nota;
            }
        }

        public void EvalInvoke4(string d)
        {
            if (txtProfesor.InvokeRequired)
            {
                DMensaje miNota = new DMensaje(EvalInvoke4);
                this.Invoke(miNota, new object[] { d });
            }
            else
            {
                txtProfesor.Text = d;
            }
        }

        /// <summary>
        /// Actualizo la lista
        /// </summary>
        private void Actualizarlista()
        {
            if (lstbAEvaluar.InvokeRequired)
            {
                lstbAEvaluar.BeginInvoke((MethodInvoker)delegate
                {
                    lstbAEvaluar.DataSource = null;
                    lstbAEvaluar.DataSource = alumnos;
                });
            }
            else
            {
                lstbAEvaluar.DataSource = null;
                lstbAEvaluar.DataSource = alumnos;
            }
        }
        /// <summary>
        /// Metodo CargarListBox asociado al delegado DCarga de FrmPpal
        /// </summary>
        /// <param name="listAlu"></param>
        public void CargarListBox(List<Alumno> listAlu)
        {
            //La tomo para actualizar el listBox del form
            this.alumnos = listAlu;
            foreach (Alumno item in listAlu)
            {
                colaAlumnos.Enqueue(item);
            }

            lstbAEvaluar.DataSource = null;
            lstbAEvaluar.DataSource = listAlu;
        }

        /// <summary>
        /// Serializador
        /// </summary>
        /// <param name="ev"></param>
        /// <returns></returns>
        public void Serializar(Evaluaciones eval)
        {
            //+ "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\Aprobados\\"
            //+ "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\Desaprobados\\" 

            //string pathA = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + alum;
            //string pathD = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + alum;
            try  
            {
                SerializadorXml<Evaluaciones> ser = new SerializadorXml<Evaluaciones>();
                if (eval.NotaFinal >= 4)
                {
                    //if (!Directory.Exists(pathA))
                    //{
                    //    DirectoryInfo dApr = Directory.CreateDirectory(pathA);
                    //} 
                    //LLama al método de Entidades
                    ser.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + alum, eval);
                }

                else
                {
                    //if (!Directory.Exists(pathD))
                    //{
                    //    DirectoryInfo dDes = Directory.CreateDirectory(pathD);
                    //}
                    ser.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + alum, eval);
                }
            }

            catch (Exception e)
            {
                string direccion = AppDomain.CurrentDomain.BaseDirectory;
                Texto texto = new Texto();
                texto.Guardar(direccion + "\\log.txt", "Error en la serialización");
                MessageBox.Show(e.Message);
            }
        }

        private void FrmEvaluacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t.IsAlive)
                t.Abort();
            if (t2.IsAlive)
                t2.Abort();
        }

        private void tmReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEv.Close();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            t = new Thread(EvaluaAlumno);
            t.Start();
        }
    }
}

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
using System.Data.SqlClient;
using System.Threading;


namespace Jardin_UTN
{

    public delegate void DCarga(List<Alumno> listAlumnos);
    public delegate void DelDocente(List<Docente> listDocentes);
    public delegate void DelAulas(List<Aulas> listaAulas);

    public partial class FrmPpal : Form
    {
        List<Docente> docentes;
        List<Alumno> alumnos;
        List<Aulas> aulas;
        
        DCarga cargaList;
        DelDocente lstDocente;
        DelAulas lstAulas;
        Thread t;
        FrmEvaluacion frmEvaluacion;

        public FrmPpal()
        {
            InitializeComponent();
            docentes = new List<Docente>();
            alumnos = new List<Alumno>();
            aulas = new List<Aulas>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            //LLamo alumnos desde la Base
            ConexionDAO.Leer(alumnos);
            ConexionDAO.Leer(aulas);
            lblRecreo.Text = string.Empty;
            t = new Thread(Recreo);
            t.Start();
            ///Carga los alumnos que llamamos de la base
            foreach (Alumno item in this.alumnos)
            {
                ListViewItem lista = new ListViewItem(item.Id.ToString());                
                lista.SubItems.Add(item.Nombre);
                lista.SubItems.Add(item.Apellido);
                lista.SubItems.Add(item.Dni.ToString());
                lista.SubItems.Add(item.Edad.ToString());
                lista.SubItems.Add(item.Direccion.ToString());
               

                lstvAlumnos.Items.Add(lista);
            }

            ///Carga los aulas que llamamos de la base
            foreach (Aulas item in this.aulas)
            {
                ListViewItem lista = new ListViewItem(item.IdAula.ToString());
                lista.SubItems.Add(item.Salita);

                lstvAulas.Items.Add(lista);
            }

        }
        /// <summary>
        /// Método Recreo para el hilo t
        /// </summary>
        internal void Recreo()
        {
            while (true)
            {
                Thread.Sleep(20000);
                RecreoInvoke("EMPEZÓ EL RECREO");
                Thread.Sleep(5000);
                RecreoInvoke("FINALIZÓ EL RECREO");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        public void RecreoInvoke(string d)
        {
            if (lblRecreo.InvokeRequired)
            {
                DMensaje recreo = new DMensaje(RecreoInvoke);
                this.Invoke(recreo, new object[] { d });
            }
            else
            {
                lblRecreo.Text = d;
            }
        }

        /// <summary>
        /// Deserealiza la lista de docentes
        /// </summary>
        /// <returns></returns>
        public List<Docente> LeerXml()
        {
            try
            {
                string direccion = AppDomain.CurrentDomain.BaseDirectory;
                //Llamo a la clase SerializadorXml
                SerializadorXml<List<Docente>> ser = new SerializadorXml<List<Docente>>();
                List<Docente> aux;
                if (ser.Leer(direccion + "\\Docentes.xml", out aux))
                {
                    docentes = aux;
                    return aux;
                }
           
                return null;
            }

            catch (ArchivosException e)
            {
                throw e;
            }
        }
        /// <summary>
        /// btn Evaluar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEvaluarAlumno_Click(object sender, EventArgs e)
        {
            frmEvaluacion = new FrmEvaluacion();
            //Uso el delegado y le paso la lista de alumnos al form de evaluación
            cargaList = new DCarga (frmEvaluacion.CargarListBox);
            cargaList.Invoke(alumnos);
            //Uso el delegado para enviar la lista 
            lstDocente = new DelDocente (frmEvaluacion.ListDocente);
            lstDocente.Invoke(docentes);
            //Envio lista a FrmEvaluación
            lstAulas = new DelAulas(frmEvaluacion.ListaAulas);
            lstAulas.Invoke(aulas);

            frmEvaluacion.Show();           

        }

        /// <summary>
        /// Carga lista Docente en ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listaDeDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(LeerXml()==null))
                {
                    foreach (Docente item in this.docentes)
                    {
                        ListViewItem lista = new ListViewItem(item.Id.ToString());
                        lista.SubItems.Add(item.Nombre);
                        lista.SubItems.Add(item.Apellido);
                        lista.SubItems.Add(item.Dni.ToString());
                        lista.SubItems.Add(item.Edad.ToString());
                        lista.SubItems.Add(item.Direccion.ToString());
                        lista.SubItems.Add(item.Sexo.ToString());
                        lista.SubItems.Add(item.Email.ToString());

                        lstvDocentes.Items.Add(lista);
                    }
                }
            }
            catch (ArchivosException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t.IsAlive)
                t.Abort();
        }

        /// <summary>
        /// Guarda Docentes y crea el log en caso de error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guardarDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (docentes.Count > 0)
            {
                foreach (Docente item in docentes)
                {
                    ConexionDAO.InsertarDocente(item);
                }

                MessageBox.Show("Se Guardó en BD");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aEvaluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvaluacion = new FrmEvaluacion();
            //Uso el delegado y le paso la lista de alumnos al form de evaluación
            cargaList = new DCarga(frmEvaluacion.CargarListBox);
            cargaList.Invoke(alumnos);
            //Uso el delegado para enviar la lista 
            lstDocente = new DelDocente(frmEvaluacion.ListDocente);
            lstDocente.Invoke(docentes);
            //Envio lista a FrmEvaluación
            lstAulas = new DelAulas(frmEvaluacion.ListaAulas);
            lstAulas.Invoke(aulas);

            frmEvaluacion.Show();
        }
    }
}

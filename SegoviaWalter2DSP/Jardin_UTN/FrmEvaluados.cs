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

namespace Jardin_UTN
{
  
    public partial class FrmEvaluados : Form
    {     
        public FrmEvaluados()
        {
            InitializeComponent();;
        }

        private void FrmEvaluados_Load(object sender, EventArgs e)
        {
            
            
        }

        /// <summary>
        /// Método asociado al delegado y la verifica para que vayan al recreo
        /// </summary>
        /// <param name="alumnosEv"></param>
        public void CargaAlumnos(List<Alumno> alumnosEv)
        {
            if (lstbEvaluados.InvokeRequired)
            {
                lstbEvaluados.BeginInvoke((MethodInvoker)delegate
                {
                    lstbEvaluados.DataSource = null;
                    lstbEvaluados.DataSource = alumnosEv;
                });
            }
            else
            {
                lstbEvaluados.DataSource = null;
                lstbEvaluados.DataSource = alumnosEv;
            }
        }

        private void FrmEvaluados_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

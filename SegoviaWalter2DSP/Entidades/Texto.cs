using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            StreamWriter sw = new StreamWriter(archivo, true, Encoding.UTF8);
            try
            {
                sw.WriteLine(datos);
                return true;
            }

            catch (Exception e)
            {
                throw new ArchivosException(e.InnerException);
            }

            finally
            {
                sw.Close();
            }
        }

        public bool Leer(string archivo, out string datos)
        {
            StreamReader sr = new StreamReader(archivo);
            try
            {
                string aux = null;
                while ((sr.ReadLine()) != null)
                {
                    aux = sr.ReadLine();
                }
                datos = aux;
                return true;
            }

            catch (Exception e)
            {
                throw new ArchivosException(e);
            }

            finally
            {
                sr.Close();
            }
        }
    }
}

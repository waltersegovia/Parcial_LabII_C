using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public class SerializadorXml<T>:IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            //Stream sw = new FileStream(archivo, FileMode.Create,FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(T));
            TextWriter tw = new StreamWriter(archivo);

            try
            {
                xml.Serialize(tw, datos);
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e.InnerException);
            }

            finally
            {
                tw.Close();
            }

        }

        public bool Leer(string archivo, out T datos)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));
                XmlTextReader wt = new XmlTextReader(archivo);
                datos = (T)ser.Deserialize(wt);
                wt.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
    }
}

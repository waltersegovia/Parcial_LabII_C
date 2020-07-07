using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace UnitTestJardin
{
    [TestClass]
    public class UnitTest_JardinUtn
    {
        [TestMethod]
        public void TestValorNuloEnID()
        {
            Alumno i2 = new Alumno(2, "Roberto", "Juarez", 45, 12234456, "Corrientes 200");
            int aux = i2.Id;
            Assert.IsNotNull(aux);
        }

        [TestMethod]
        public void TestSerializar()
        {
            Alumno a = new Alumno(2, "Roberto", "Juarez", 45, 12234456, "Corrientes 200");
            SerializadorXml<Alumno> ser = new SerializadorXml<Alumno>();
            bool resultado = ser.Guardar("Test", a);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void TestDeserializar()
        {
            string direccion = AppDomain.CurrentDomain.BaseDirectory;
            SerializadorXml<List<Docente>> ser = new SerializadorXml<List<Docente>>();
            List<Docente> aux;

            Assert.IsFalse(ser.Leer(direccion + "\\Docentes.xml", out aux));
        }

    }
}
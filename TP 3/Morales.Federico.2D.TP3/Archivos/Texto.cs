using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

//Archivos:
// Generar una interfaz con las firmas para guardar y leer.
// Implementar la interfaz en las clases Xml y Texto, a fin de poder guardar y leer archivos de esos tipos.

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            StreamWriter writer;

            try
            {
                writer = File.CreateText(archivo);
                writer.Write(datos);
                writer.Close();
                return true;
            }
            catch(Exception e)
            {
                throw new ArchivosException(e);
            }            
        }

        public bool Leer(string archivo, out string datos)
        {
            StreamReader reader;

            try
            {
                reader = File.OpenText(archivo);
                datos = reader.ReadToEnd();
                reader.Close();
                return true;
            }
            catch(Exception e)
            {
                datos = string.Empty;
                throw new ArchivosException(e);
            }
        }
    }
}

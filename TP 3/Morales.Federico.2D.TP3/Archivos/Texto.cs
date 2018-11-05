using System;
using System.IO;
using Excepciones;

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

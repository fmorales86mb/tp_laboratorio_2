using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            catch(Exception)
            {                
                return false;
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
            catch(Exception)
            {
                datos = string.Empty;
                return false;
            }
        }
    }
}

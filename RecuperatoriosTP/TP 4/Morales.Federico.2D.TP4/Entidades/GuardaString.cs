using System;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {
        /// <summary>
        /// Guarda el String en un archivo de texto en el escritorio de la máquina. Si el archivo existe, agregará información en él.
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="archivo">Nombre del archivo.</param>
        /// <returns></returns>
        public static bool Guardar(this string texto, string archivo)
        {
            bool guardado = true;
            StreamWriter writer = null;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\" + archivo;                            

            try
            {
                writer = File.CreateText(path);
                writer.Write(texto);                
            }
            catch
            {
                guardado = false;
            }
            finally
            {
                writer.Close();
            }           

            return guardado;
        }
    }
}

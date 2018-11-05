using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            XmlTextWriter writer;
            XmlSerializer serializer;

            try
            {
                writer = new XmlTextWriter(archivo, Encoding.Default);
                serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, datos);
                writer.Close();
                return true;
            }
            catch(Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        public bool Leer(string archivo, out T datos)
        {
            XmlTextReader reader;
            XmlSerializer serializer;

            try
            {
                reader = new XmlTextReader(archivo);
                serializer = new XmlSerializer(typeof(T));
                datos = (T)serializer.Deserialize(reader);
                reader.Close();
                return true;
            }
            catch(Exception e)
            {
                datos = default(T);
                throw new ArchivosException(e);
            }
        }
    }
}

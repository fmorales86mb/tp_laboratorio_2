using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//GuardaString
//1. Crear un método de extensión para la clase String
//2. Este guardará en un archivo de texto en el escritorio de la máquina.
//3. Recibirá como parámetro el nombre del archivo.
//4. Si el archivo existe, agregará información en él.

namespace Entidades
{
    public static class GuardaString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            return true;
        }
    }
}

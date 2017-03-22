using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class sello
    {   public static string mensaje;     
        public static ConsoleColor color;
        public static string imprimir()
       {
        return mensaje;
       }
        public static void borrar()
        {
            sello.mensaje="";
        }
        public static void imprimirEnColor
        { 
            Console.ForegroundColor=sello.color;
            console.writeLine(sello.imprimir());
        }
   
    }
}

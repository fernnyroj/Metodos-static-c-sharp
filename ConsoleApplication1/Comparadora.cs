using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Comparadora
    {  
        
        /// <summary>
        /// este metodo retorna el mayor de los numeros ingresados por parametros
        /// </summary>
        /// <param name="Numero1">el primero, entero</param>
        /// <param name="Numero2">el segundo, entero</param>
        /// <returns>el mayor de los dos</returns>
        public static int RetornarMayor(int Numero1, int Numero2)
        {
            int retorno = 0;
            if (Numero1 < Numero2)
                retorno = Numero2;

            else
                retorno = Numero1;

            return retorno;
        }
        /// <summary>
        /// este metodo retona valor del medio
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
       public static void MostrarElDelMedio (int num1, int num2, int num3)
           {
     

           }
    }

}

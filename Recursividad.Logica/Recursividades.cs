using System;
using System.Collections.Generic;
using System.Text;

namespace Recursividad.Logica
{
    public class Recursividades
    {

            public int CalcularFactorial(int num)
            {
                //Caso base condición de salida

                if (num == 1)
                {
                    return 1;
                }

                //Caso general
                return num = num * CalcularFactorial(num - 1);



            }

            //public int SumarNumeros(int num)
            //{
            //    //Caso Base o salida


            //    //Caso general
            //}


        
    }
}

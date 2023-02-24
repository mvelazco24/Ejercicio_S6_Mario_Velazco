using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioS6_Mario_Velazco.Model
{
    internal class Expresion
    {
        public class expresion
        {
            public float num1 { get; set; }
            public float num2 { get; set; }
            public float resultado { get; set; }

            public int suma()
            {
               float res_suma = num1 + num2;
                resultado = res_suma;

                return resultado;
            }

            public int resta()
            {
                float res_resta = num1 - num2;
                resultado = res_resta;

                return resultado;
            }

            public int multi()
            {
                float res_multiplicacion = num1 * num2;
                resultado = res_multiplicacion;

                return resultado;
            }

            public int division()
            {
                float res_division = num1 / num2;
                resultado = res_division;

                return resultado;
            }

            public override string ToString()
            {
                return $"El resultado es:  {resultado}";
            }
        }
    }

        
}

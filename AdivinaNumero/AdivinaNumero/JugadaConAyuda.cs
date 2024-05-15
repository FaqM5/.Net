using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaNumero
{
    internal class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero)
        {
        }

        public override void Comparar(int numero)
        {
            int diferencia = Math.Abs(numero - Numero);

            if (numero > Numero)
            {
                if (diferencia > 100)
                {
                    Console.WriteLine("El número ingresado es mayor y está muy lejos.");
                }
                else if (diferencia <= 5)
                {
                    Console.WriteLine("El número ingresado es mayor y está cerca.");
                }
                else
                {
                    Console.WriteLine("El número ingresado es mayor.");
                }
            }
            else if (numero < Numero)
            {
                if (diferencia > 100)
                {
                    Console.WriteLine("El número ingresado es menor y está muy lejos.");
                }
                else if (diferencia <= 5)
                {
                    Console.WriteLine("El número ingresado es menor y está cerca.");
                }
                else
                {
                    Console.WriteLine("El número ingresado es menor.");
                }
            }
            else
            {
                Console.WriteLine("¡Adivinaste el número!");
                Adivino = true;
            }
        }
    }
}

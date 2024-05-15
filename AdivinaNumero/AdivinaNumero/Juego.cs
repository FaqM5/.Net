using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaNumero
{
    internal class Juego
    {
        private int _record = int.MaxValue;

        public Juego()
        {
            throw new System.NotImplementedException();
        }

        public void ComenzarJuego()
        {
            Console.WriteLine("¡Bienvenido al juego!");

            while (true)
            {
                int maximo = PreguntarMaximo();
                Jugada jugada = new JugadaConAyuda(maximo);
                int intentos = 0;

                while (!jugada.Adivino)
                {
                    int numero = PreguntarNumero();
                    jugada.Comparar(numero);
                    intentos++;
                }

                if (jugada.Intentos < _record)
                {
                    _record = jugada.Intentos;
                    Console.WriteLine("¡Nuevo record de intentos: " + _record + "!");
                }

                if (!Continuar())
                {
                    break;
                }
            }

            Console.WriteLine("Gracias por jugar.");
        }

        private void CompararRecord(int intentos)
        {
            if (intentos < _record)
            {
                _record = intentos;
                Console.WriteLine("¡Nuevo record de intentos: " + _record + "!");
            }
        }

        private bool Continuar()
        {
            Console.Write("¿Desea jugar otra vez? (S/N): ");
            string respuesta = Console.ReadLine().Trim().ToUpper();
            return respuesta == "S";
        }

        private int PreguntarMaximo()
        {
            Console.Write("Ingrese el máximo número para adivinar: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private int PreguntarNumero()
        {
            Console.Write("Ingrese un número: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}

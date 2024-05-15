using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdivinaNumero
{
    internal class Jugada
    {
        private int _adivino;
        private int _intento;
        private int _numero;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }

        public bool Adivino
        {
            get { return _adivino; }
            set { _adivino = value; }
        }

        public int Intentos
        {
            get { return _intento; }
            set { _intento = value; }
        }

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public void Comparar(int numero)
        {
            _intento++;
            if (numero == _numero)
            {
                _adivino = _intento;
            }
        }
    }
}

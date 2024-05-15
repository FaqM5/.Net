using System.Reflection.Metadata;

    namespace Clases
    {
            public class A
            {

            private string nombreInstancia;

            public string NombreInstancia
            {
                get { return nombreInstancia; }
                set { nombreInstancia = value; }
            }
            public A()
                {
                    this.nombreInstancia = "Instancia sin nombre";
                }

            public A(string n)
            {
                this.nombreInstancia = n;

            }

            public void MostrarNombre()
            {
                System.Console.WriteLine(nombreInstancia);

            }

            public  void M1()
            {
                System.Console.WriteLine("El metodo M1 fue invocado");
            }

            public  void M2()
            {
                System.Console.WriteLine("El metodo M2 fue invocado");
            }
            public  void M3()
            {
                System.Console.WriteLine("El metodo M3 fue invocado");
            }

        }
    }


namespace Clases
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;

        public Persona(string n, string a, int dni, int e)
        {
            this.nombre = n;
            this.apellido = a;
            this.dni = dni;
            this.edad = e;
        }

        ~Persona()
        {
            Console.WriteLine("Se ha destruido el objeto de la clase Persona.");
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

   
        public string ObtenerApellido()
        {
            return apellido;
        }

        
        public int ObtenerEdad()
        {
            return edad;
        }

        
        public int ObtenerDNI()
        {
            return dni;
        }


        public void GetFullName()
        {
            Console.WriteLine("El nombre completo de la persona es " + this.ObtenerNombre() + " " + this.ObtenerApellido());
        }

        public void GetAge()
        {
            Console.WriteLine("La edad de la persona es"+this.ObtenerEdad());
        }
    }
}

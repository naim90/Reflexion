using System;
using System.Reflection;

namespace Reflexion
{

    class ReflectedClass

    {

        private Int32 _id;

        private string Name { get; set; }

        private string Prenom { get; set; }

        private int Age { get; set; }

        private string Action { get; set; }


        public ReflectedClass()

        {

            _id = 0;
            this.Name = "Titi";
            this.Prenom = "Toto";
            this.Age = 19;
            this.Action = Action;


        }


        private void Manger()

        {
            Console.WriteLine("Il mange ...");

        }

        private void Parler()

        {
            Console.WriteLine("Il parle ...");
        }

    }
    class Program
    {


        static void Main(string[] args)

        {
            var reflected = new ReflectedClass();
            DisplayAllAttributes(reflected);

        }


        private static void DisplayAllAttributes(object reflected)

        {

           /* Type objectType = reflected.GetType();*/


            PropertyInfo[] properties = reflected.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);

            MethodInfo[] methods = reflected.GetType().GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            FieldInfo[] fields = reflected.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);


            Console.WriteLine("Properties");

            foreach (var p in properties)

            {

                Console.WriteLine("\t" + p.Name +" "+p.PropertyType);

            }

            Console.WriteLine("Methods");

            foreach (var m in methods)

            {

                Console.WriteLine("\t" + m.Name + " " + m.DeclaringType);

            }


            Console.WriteLine("Fields");

            foreach (var f in fields)

            {

                Console.WriteLine("\t" + f.Name + " " + f.DeclaringType);

            }

        }
    }
}

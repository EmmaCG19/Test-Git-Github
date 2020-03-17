using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Generics
{
    class Program
    {

        private static void BoxingTime(int value, ref object box)
        {
            //Convert a value-type to a reference type using Boxing
            box = value;
        }


        private static void UnboxingTime(object box, ref int value)
        {
            //Convert a reference type in the data-type that must be

            try
            {
                value = (int)box;

            }
            catch (Exception e)
            {
                value = -1;

            }
            finally
            {
                value++;
            }

        }

        private static void Add()
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Define ConnectionString using App.config

                using ()
                {

                }

            }

        }

        static void Main(string[] args)
        {

            //GENERICS
            // Foo<int, string> generico = new Foo<int, string>(10, "Tenes un");
            //generico.ShowMessage();

            //Derived<bool> heredado = new Derived<bool>(true);
            //heredado.ShowMessage();

            //BOXING UNBOXING
            object box = "Hola";
            int valor = 0;

            UnboxingTime(box, ref valor);

            Console.WriteLine("box: {0}", box.ToString());
            Console.WriteLine("valor: {0}", valor);

            Console.ReadKey();
        }
    }
}

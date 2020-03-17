using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Ejemplo de Generics
namespace Generics
{
    class Foo<T, U>
    {
        public Foo(T value, U another)
        {
            this.Bar = value;
            this.NotBar = another;
        }

        public T Bar { get; set; }
        public U NotBar { get; set; }

        public virtual void ShowMessage()
        {
            Console.WriteLine("La propiedad {0} es del tipo {1}", this.Bar.ToString(), typeof(T));
            Console.WriteLine("La propiedad {0} es del tipo {1}", this.NotBar.ToString(), typeof(U));
            
        }
    }

    class Derived<Z> : Foo<int, string>
    {
        public Derived(Z other) : base(6, "Te sacaste un")
        {
            this.NotNotBar = other;
        }

        public Z NotNotBar { get; set; }

        public override void ShowMessage()
        {
            base.ShowMessage();
            //Deberia mostrar 10 y Otro
            Console.WriteLine("La propiedad {0} es del tipo {1}", this.NotNotBar.ToString(), typeof(Z));
        }

    }
}
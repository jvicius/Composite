using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Componente;
using Composite.Composite;
using Composite.Hoja;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            ComponenteRecambio tornillo1 = new ElementoRecambio("Birlo", "Birlo ACME", 0.21);
            ComponenteRecambio tornillo2 = new ElementoRecambio("Birlo", "Birlo ACME", 0.21);
            ComponenteRecambio tornillo3 = new ElementoRecambio("Birlo", "Birlo ACME", 0.21);
            ComponenteRecambio tornillo4 = new ElementoRecambio("Birlo", "Birlo ACME", 0.21);
            ComponenteRecambio tornillo5 = new ElementoRecambio("Birlo", "Birlo ACME", 0.21);

            ComponenteRecambio rin = new Recambio("RIN 15'", "RIN ACME 15'", 42.22);

            Console.WriteLine($"{rin.getNombre()}");
            Console.WriteLine($"{rin.getPrecio()}");

            rin.add(tornillo1);
            rin.add(tornillo2);
            rin.add(tornillo3);
            rin.add(tornillo4);

            Console.WriteLine($"{rin.getNombre()}");
            Console.WriteLine($"{rin.getPrecio()}");

            Console.ReadKey();

            ComponenteRecambio valvula = new ElementoRecambio("Válvula", "Válvula de neumático genérica", 0.49);
            ComponenteRecambio llanta = new ElementoRecambio("Neumático 15'", "Neumático Michelin de 15'", 13.42);
            ComponenteRecambio rin2 = new Recambio("RIN 15'", "RIN ACME 15'", 42.22);

            rin2.add(llanta);
            rin2.add(valvula);
            rin2.add(tornillo1);
            rin2.add(tornillo2);
            rin2.add(tornillo3);
            rin2.add(tornillo4);
            rin2.add(tornillo5);

            Console.WriteLine($"{rin2.getNombre()}");
            Console.WriteLine($"{rin2.getPrecio()}");

            Console.ReadKey();
        }
    }
}

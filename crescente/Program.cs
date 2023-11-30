using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crescente {
    class Program {
        static void Main(string[] args) {

            int x, y;

            Console.WriteLine("Digite dois numeros:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y) {
                Console.WriteLine("Crescente.");
            }
            else if (x > y) {
                Console.WriteLine("Decrescente.");
            }

            while (x != y) {
                Console.WriteLine("Digite dois numeros:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                if (x < y) {
                    Console.WriteLine("Crescente.");
                }
                else if (x > y) {
                    Console.WriteLine("Decrescente.");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program23
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("A: ");
            if (!int.TryParse(Console.ReadLine(), out int A)) { Console.WriteLine("Ошибка."); return; }
            Console.Write("B: ");
            if (!int.TryParse(Console.ReadLine(), out int B)) { Console.WriteLine("Ошибка."); return; }

            if (B == 0)
            {
                Console.WriteLine("Деление на ноль невозможно.");
                return;
            }

            Console.WriteLine((A % B == 0) ? "Делится без остатка" : "Не делится без остатка");
        }
    }
}
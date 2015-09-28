using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int number = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число {0} в разных форматах!", number);
            Console.WriteLine("Число {0} в формате с : {0:c}", number);
            Console.WriteLine("Число {0} в формате d5: {0:d5}", number);
            Console.WriteLine("Число {0} в формате e : {0:e}", number);
            Console.WriteLine("Число {0} в формате E : {0:E}", number);
            Console.WriteLine("Число {0} в формате f5: {0:f5}", number);
            Console.WriteLine("Число {0} в формате F3: {0:F3}", number);
            Console.WriteLine("Число {0} в формате n : {0:n}", number);
            Console.WriteLine("Число {0} в формате x : {0:x}", number);
            Console.WriteLine("Число {0} в формате X : {0:X}", number);
            Console.WriteLine("Число {0} в формате g : {0:g}", number);
            Console.ReadLine();
        }
    }
}

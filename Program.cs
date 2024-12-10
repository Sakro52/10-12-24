using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_12_24
{
    /// <summary>
    /// Подсичать кол-во число 5 в одномерном массиве 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] omas = { 5,7,1,9,5,3,6,5,4 };
            
            //Первый способ
            
             //int count = 0;
            //foreach(var el in omas)
            //{
            //    if (el == 5)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //Второй способ
            
            int count = omas.Count(x => x == 5);
            Console.WriteLine(count);


            Console.ReadLine();
        }
    }
}

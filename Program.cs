﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _10_12_24
{
    /// <summary>
    /// Удалить все четные элементы из одномерного масива
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            int[] omas = { 5,7,1,9,5,3,5,};
            omas=omas.Where(x=>x %2!=0).ToArray();
            Console.WriteLine("Нечетные элм масива");
            foreach(var el in omas)
            {
                Console.Write($"{omas}\t");
            }
            Console.ReadLine();
        }
    }
}

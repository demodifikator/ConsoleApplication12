using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            byte m, i;
            Random rand = new Random();
            Console.Write("Введите количество элементов массива: ");
            m = byte.Parse(Console.ReadLine());
            int[] arr = new int[m];
            for (i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(0,100);
            Console.WriteLine("В прямом порядке: ");
            for(i = 0; i<arr.Length;i++)
                Console.WriteLine($"{i+1}) {arr[i]}");

            Console.WriteLine("В обратном порядке: ");
            for(i = (byte)(arr.Length-1); i>=0; i--)
                Console.WriteLine($"{i+1}) {arr[i]}");
        }
    }
}

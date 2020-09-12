using System;
using System.Text;

namespace gtnn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int size;
            int[] array;
            Console.WriteLine("Nhập kích thước mảng: ");
            size = Int32.Parse(Console.ReadLine());

            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Nhập phần tử của mảng " + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("Property list: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
            }
            int min = MinValue(array);
            Console.WriteLine("Phần tử nhỏ nhất trong mảng là :{0}", min);

        }
        static int MinValue(int[] array)
        {

            int min = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            return min;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp1
{

    internal class Program
    {
        private static int NumOfCows;
        private static int NumOfTypesOfDishes;
        private static int DishesPerCow;
        private static Random random = new Random();

        public static void Main(string[] args)
        {
            int[] dishes;
            Console.OutputEncoding = System.Text.Encoding.Default;
            if (!IsGenerate())
            {
                DataInput(ref NumOfCows, "Введіть кількість корів", "Кількість корів повина бути в межах", 2, 200);
                DataInput(ref DishesPerCow, "Введіть кількість блюд, що може принести корова",
                    "Кількість блюд, що може принести корова повина бути в межах", 0, 6);
                DataInput(ref NumOfTypesOfDishes, "Введіть кількість видів блюд", "Кількість видів блюд повина бути в межах", 5, 100);

                dishes = new int[NumOfTypesOfDishes];

                Console.WriteLine("ВВедіть максимальну кількість блюд для кожного типу.");
                for (var i = 0; i < NumOfTypesOfDishes; i++)
                {
                    Console.Write("Для " + (i + 1) + " блюда: ");
                    dishes[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            else
            {
                NumOfCows = random.Next(3, 200);
                NumOfTypesOfDishes = random.Next(6, 101);
                DishesPerCow = random.Next(1, 7);
                Console.WriteLine("Згенерувати вхідні данні: ");
                Console.WriteLine("Кількість корів - " + NumOfCows);
                Console.WriteLine("Кількість блюд  - " + NumOfTypesOfDishes);
                Console.WriteLine("Кількість блюд, зо може принести корова - " + DishesPerCow);
                dishes = new int[NumOfTypesOfDishes];
                for (var i = 0; i < dishes.Length; i++)
                {
                    dishes[i] = random.Next(4, 21);
                }
                Console.Write("Максималька кількість блюд для кожного типу: ");
                ArrayPrint(dishes);
            }
            var n = 0;
            var count = 0;
            for (var i = 0; i < NumOfCows; i++)
            {
                Array.Sort(dishes);
                Array.Reverse(dishes);
                for (var j = 0; j < DishesPerCow; j++)
                {
                    if (dishes[n] == 0)
                    {
                        break;
                    }
                    dishes[n] = dishes[n] - 1;
                    count++;
                    n++;
                }
                n = 0;
            }
            Console.WriteLine("Кількість блюд, що можуть принести корови: " + count);
            Console.ReadKey();
        }

        private static void DataInput(ref int value, string message1, string message2, int min, int max)
        {
            do
            {
                Console.Write(message1 + "(" + min + ", " + max + "): ");
                try
                {
                    value = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                }
            } while (value <= min || value >= max);
        }

        private static bool IsGenerate()
        {
            string gen;
            do
            {
                Console.Write("Згенерувати данні?(1 - так, 0 - ні): ");
                gen = Console.ReadLine();
            } while (!gen.Equals("1") && !gen.Equals("0"));

            return gen.Equals("1");
        }

        private static void ArrayPrint(int[] array)
        {
            if (array == null) throw new ArgumentNullException("array");
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

    }


}

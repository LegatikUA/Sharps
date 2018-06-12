using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var folder1 = new Folder();
            folder1.Add(new MyDataFile1<string>("File1", 247));
            folder1.Add(new MyDataFile1<string>("File2", 314));
            folder1.PrintTitles();
            folder1.PrintLengths();

            var folder2 = folder1.DeepCopy();
            folder2.Add(new MyDataFile1<string>("File3", 115));
            folder2.PrintTitles();
            folder2.PrintLengths();
            folder2.GetHashCodeofFiles();
            Console.ReadKey();


        }
    }
}

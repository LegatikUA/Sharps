using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_1
{
    class MyDataFile1<T> : File
    {
        private T MyData1;
        public MyDataFile1(string title, int length)
        {
            this.title = title;
            this.length = length;
        }
        public override void Write()
        {
            Console.Write(MyData1);
        }

        public override void Read()
        {
            Console.WriteLine(title + ": ");
        }
        public override File DeepCopy()
        {
            return new MyDataFile1<T>(this.title, this.length);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_1
{
    class MyDataFile2<R> : File
    {
        private R MyData2;
        public MyDataFile2(string title, int length)
        {
            this.title = title;
            this.length = length;
        }
        public override void Write()
        {
            Console.Write(MyData2);
        }

        public override void Read()
        {
            Console.WriteLine(title + ": ");
        }
        public override File DeepCopy()
        {
            return new MyDataFile2<R>(this.title, this.length);
        }
    }
}

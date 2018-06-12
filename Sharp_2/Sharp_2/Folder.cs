using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_1
{
    class Folder
    {
        private List<File> files = new List<File>();

        public Folder()
        {

        }
        public Folder(List<File> files)
        {
            this.files = files;
        }
        public void PrintTitles()
        {
            Console.Write("Titles: ");
            foreach (var file in files)
            {
                Console.Write(file.GetTitle() + ", ");
            }
            Console.WriteLine();
        }

        public void PrintLengths()
        {
            Console.Write("Lengths: ");
            foreach (var file in files)
            {
                Console.Write(file.GetLength() + ", ");
            }
            Console.WriteLine();
        }

        public void Add(File file)
        {
            files.Add(file);
        }

        public void RemoveAt(int index)
        {
            files.RemoveAt(index);
        }


        private sealed class HashandEqueks : IEqualityComparer<Folder>
        {
            public bool Equals(Folder a, Folder b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }
                if (a.GetType() == b.GetType())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public int GetHashCode(Folder obj)
            {
                return (obj.files != null ? obj.files.GetHashCode() : 0);
            }
        }

        public void GetHashCodeofFiles()
        {
            Console.Write("Hash: ");
            foreach (var file in files)
            {
                Console.Write(file.GetHashCode() + ", ");
            }
            Console.WriteLine();
        }
        public Folder DeepCopy()
        {
            var files = new List<File>();
            foreach (var file in this.files)
            {
                files.Add(file.DeepCopy());
            }
            return new Folder(files);
        }
    }
}

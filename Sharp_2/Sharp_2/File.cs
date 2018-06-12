using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_1
{
    public abstract class File
    {
        protected string title;
        protected int length;
        public virtual void Open()
        {
            Console.WriteLine(title + " is opened.");
        }
        public virtual void Close()
        {
            Console.WriteLine(title + " is closed.");
        }
        public virtual void Seek(string s)
        {

        }
        public virtual void Write()
        {

        }

        public virtual void Read()
        {

        }
        public string GetTitle()
        {
            return title;
        }

        public int GetLength()
        {
            return length;
        }
        private sealed class HashandEqueks : IEqualityComparer<File>
        {
            public bool Equals(File a, File b)
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
            public int GetHashCode(File file)
            {
                int hashCode = 1;
                hashCode = (10 * hashCode) - file.title.GetHashCode();
                hashCode = (10 * hashCode) + file.length;
                return hashCode;
            }
        }
        private static readonly IEqualityComparer<File> example = new HashandEqueks();

        public static IEqualityComparer<File> same
        {
            get
            {
                if (example != null) return example;
                return null;
            }
        }
        public static bool operator ==(File file1, File file2)
        {
            return file1.Equals(file2);
        }
        public static bool operator !=(File file1, File file2)
        {
            return !file1.Equals(file2);
        }

        public abstract File DeepCopy();
        public override string ToString()
        {
            return ("Title: " + title + ", length: " + length);
        }







    }
}

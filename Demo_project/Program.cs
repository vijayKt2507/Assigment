using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> names = new Dictionary<int, string>();
            //names.Add(1, "vijay");
            //names.Add(2, "kumar");

            //foreach(KeyValuePair<int, string> kv in names)
            //{
            //    Console.WriteLine(kv);
            //}


            //List<string> li = new List<string>();
            //li.Add("vijay");
            //foreach(var name in li)
            //{
            //    Console.WriteLine(name);
            //    Console.ReadLine();
            //}
            //HashSet<string> name = new HashSet<string>();
            //name.Add("hii");
            //name.Add("vijay");
            //foreach(var names in name)
            //{
            //    Console.WriteLine(names);
            //}
            //Stack<string> name = new Stack<string>();
            //name.Push("vijay");
            //name.Push("apple");
            //name.Push("add");
            //foreach (string names in name)
            //{
            //    Console.WriteLine(names);
            //    Console.ReadLine();
            //}

            //Console.WriteLine("Peek element: " + names.Peek());
            ////Console.WriteLine("Pop: " + name.Pop());
            ////Console.WriteLine("After Pop, Peek element: " + name.Peek());
            FileStream f = new FileStream("file.txt", FileMode.Create,FileAccess.Write,FileShare.None);//creating file stream 
            string text = "this is string";
            byte[] byt = Encoding.UTF8.GetBytes(text);
            f.Write(byt, 0, byt.Length);
            f.Close();
            

        }
    }
}

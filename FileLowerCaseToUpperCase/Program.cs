using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLowerCaseToUpperCase
{

    using System;
    using System.IO;

    class LowerCaseToUpperCase
    {
        static void Main()
        {

            string name = @"C:\Users\Vijay KT\Downloads\EmpData.csv";

            if (File.Exists(name))
            {
                StreamReader fileRw = File.OpenText(name);
                StreamWriter fileWr = File.CreateText(name + "uppercase" + ".csv");
                string line;
                do
                {
                    line = fileRw.ReadLine();
                    if (line != null)
                    {
                        fileWr.WriteLine(line.ToUpper());
                        Console.WriteLine(line.ToUpper());
                    }
                }
                while (line != null);
                fileRw.Close();
                fileWr.Close();
                if (File.Exists(name + "uppercase" + ".csv"))
                    Console.WriteLine("Conversion successful!");
                Console.ReadLine();
            }
        }
    }
}

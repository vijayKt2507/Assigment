using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_person
{
    class Student
    {

        public string name { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string dep { get; set; }
        public double year { get; set; }
        public int fees { get; set; }
        public override string ToString()
        {
            // return $"{EmpId},{EmpName},{EmpAddress},{EmpSalary}\n";
            return $"{name},{city},{state},{dep},{year},{fees}\n";
        }
        public Student(string name,string city,string state,string dep,double year,int fees)
        {
            this.name = name;
            this.city = city;
            this.state = state;
            this.dep = dep;
            this.year = year;
            this.fees = fees;
        }
        public void studentDetails()
        {
            Console.WriteLine("name; " + name + "city; " + city + "state " + state + "dep " + dep + "year " + year + "fees " + fees);
        }
    }
}

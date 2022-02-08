using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_person
{
    class Staff
    {
        public string name { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string school_name { get; set; }
        public double salary { get; set; }
        public override string ToString()
        {
             //return $"{EmpId},{EmpName},{EmpAddress},{EmpSalary}\n";
            return $"{name},{city},{state},{school_name},{salary}\n";
        }
        public Staff(string name,string city,string state,string school_name,double salary)
        {
            this.name = name;
            this.city = city;
            this.state = state;
            this.school_name = school_name;
            this.salary = salary;

        }
        public void displayStaffDetails()
        {
            Console.WriteLine("name: " + name + "city:  " + city + "state: " + state + "school_name " + school_name + "salary: " + salary);
        }
        



    }
}

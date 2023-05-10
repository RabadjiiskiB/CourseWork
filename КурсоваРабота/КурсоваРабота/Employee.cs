using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КурсоваРабота
{
    internal class Employee
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string mname { get; set; }
        public string lname { get; set; }
        public string proffesion { get; set; }
        public string department { get; set; }
        public decimal wage { get; set; }
        public int date_of_emoloyment { get; set; }

        public Employee(int Id,string Fname,string Mname,string Lname, string Proffesion, string Department, decimal Wage, int Date)
        {
            id = Id;
            fname = Fname;
            mname = Mname;
            lname = Lname;
            proffesion = Proffesion;
            department = Department;
            wage = Wage;
            date_of_emoloyment = Date;
        }
    }
}

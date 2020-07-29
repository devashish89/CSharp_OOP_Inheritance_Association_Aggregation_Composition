using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Association_Aggregation_Composition
{
    class Employee
    {

        private string _name;
        private Int16 _empId;
        private string _emaild;
        private double _salary;


        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _emaild; } set { _emaild = value; } }
        public Int16 EmpID { get { return _empId; } set { _empId = value; } }
        public double Salary { get { return _salary; } set { _salary = value; } }

    }
}

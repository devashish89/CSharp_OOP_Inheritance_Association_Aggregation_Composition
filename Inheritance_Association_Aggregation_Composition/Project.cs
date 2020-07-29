using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Association_Aggregation_Composition
{
    class Project
    {
        public bool IsSuccess { get; set; }
        private Manager oManager;

        //Composition relationship
        public Project(Manager obj) 
        {
            oManager = obj;
        }

        public void ManagerSalaryManipulation()
        {
            Console.WriteLine("####" + IsSuccess.ToString());
            if (IsSuccess)
            {
                oManager.Salary = oManager.Salary * 1.1;
            }
            else
            {
                oManager.Salary = oManager.Salary * 0.8;
            }
        }
    }
}

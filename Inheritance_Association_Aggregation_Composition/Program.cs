using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Association_Aggregation_Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager mgr1 = new Manager();
            mgr1.Name = "Devashish Nigam";
            mgr1.Email = "dnigam@xxx.com";
            mgr1.EmpID = 1;
            mgr1.Salary = 10000;

            SwipeCard sc1 = new SwipeCard();
            Console.WriteLine(sc1.MakeOfCard());

            mgr1.Logon(sc1); //Association

            IndividualContributors e1 = new IndividualContributors();
            e1.Name = "Sohan";
            e1.EmpID = 11;
            e1.Email = "sohan@xxx.com";
            e1.Salary = 1000;

            mgr1.workers.Add(e1);
            mgr1.HowIsTheManager(true); //Composition - 1 object is dependent on another object (there lifetime is related)
            Console.WriteLine(mgr1.Salary);




        }
    }
}

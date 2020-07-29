using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Association_Aggregation_Composition
{
    class Manager : Employee
    {

        private Project oProject;
     
        //Aggregation Relationship
        public List<IndividualContributors> workers = new List<IndividualContributors>();

        //Composition relationship
        public Manager() 
        {
            oProject = new Project(this);
        }
        public void Logon(SwipeCard swipeCard) //Association - Relationship (has a Relationship)
        {
            swipeCard.Swipe(this);
        }

        

        public void HowIsTheManager(bool Good)
        {
            if (Good)
            {
                oProject.IsSuccess = true;
                Console.WriteLine("Project status:"+oProject.IsSuccess.ToString());
                oProject.ManagerSalaryManipulation();
                
            }
            else
            {
                oProject.IsSuccess = false;
                Console.WriteLine("Propject status:"+oProject.IsSuccess.ToString());
                oProject.ManagerSalaryManipulation();
            }
        }


    }
}

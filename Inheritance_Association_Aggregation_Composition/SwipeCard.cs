using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Association_Aggregation_Composition
{
    class SwipeCard
    {
        public void Swipe(Manager manager) //Association Relationship
        {
            Console.WriteLine("Swipe done by emp:"+manager.Name);
        }

        public string MakeOfCard()
        {
            return "C001";
        }
    }
}

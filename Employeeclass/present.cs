using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeeclass
{
    public class present
    {
        public void main()
        {
            int fulldayperhours = 0;
            int wagesperhours = 20;
            int present = 1;
            int daliy_wage = 0;
            Random random = new Random();
            int employee = random.Next(0, 2);

            if (employee == present)
            {
                fulldayperhours = 8;
                Console.WriteLine("present");

            }
            else
            {
                fulldayperhours = 0;
                Console.WriteLine("absent");
            }
            daliy_wage = fulldayperhours * wagesperhours;
            Console.WriteLine("daliy employee wage :" + daliy_wage);
        }

       
    }
}

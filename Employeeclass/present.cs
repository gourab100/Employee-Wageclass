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
            int fulldayperhours = 8;
            int workinghours = 0;
            int wagesperhours = 20;
            int present = 2;
            int parttime = 1;
            int daliy_wage = 0;
            Random random = new Random();
            int employee = random.Next(0, 3);

            if (employee == parttime)
            {
                workinghours = workinghours + fulldayperhours;
                Console.WriteLine("parttimer");


            }
            else if (employee == present)
            {
                workinghours = (fulldayperhours - workinghours) / 2;
                Console.WriteLine("present");

            }
            else
            {
                Console.WriteLine("absent");
            }
            daliy_wage = fulldayperhours * wagesperhours;
            Console.WriteLine("daliy employee wage :" + daliy_wage);

        }
    }
}

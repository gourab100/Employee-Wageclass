using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeeclass
{
    public class Switch
    {
        public void Employee()
        {
            
            int workinghours = 0;
            const int wagesperhours = 20;
            const int present = 2;
            const int parttime = 1;
            int daliy_wage = 0;
            Random random = new Random();
            int employee = random.Next(0, 3);
            switch (employee)
            {
                case parttime:
                    workinghours = 4;
                    Console.WriteLine("parttimer");
                    break;
                case present:
                    workinghours = 8;
                    Console.WriteLine("present");
                    break;
                default:
                    workinghours = 0;
                    Console.WriteLine("absent");
                    break;
            }
            daliy_wage = workinghours * wagesperhours;
            Console.WriteLine("emp wage: "+ daliy_wage);

        }
    }
}

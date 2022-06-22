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

            const int present = 2;
            const int parttime = 1;
            int wagesperhours = 20;
            const int workingday = 20;
            const int maxworkinghours = 100;


            double totalwage = 0;
            int daliy_wage = 0;
            int emphrs = 0;

            int totalworkingdays = 0;
            int totalemphours = 0;

            while (totalemphours <= maxworkinghours && totalworkingdays < workingday)
            {
                totalworkingdays++;
                Random random = new Random();
                int employee = random.Next(0, 3);


                switch (employee)
                {
                    case parttime:

                        const int parttimeperhours = 4;
                        Console.WriteLine("parttimer");
                        daliy_wage = parttimeperhours * wagesperhours;
                        totalwage += daliy_wage;
                        Console.WriteLine("daliy employee wage :" + daliy_wage);
                        break;
                    case present:
                        const int fulldayperhours = 8;
                        Console.WriteLine("present");
                        daliy_wage = fulldayperhours * wagesperhours;
                        totalwage += daliy_wage;
                        Console.WriteLine("daliy employee wage :" + daliy_wage);
                        break;
                    default:
                        Console.WriteLine("Absent");
                        break;
                }
                totalemphours += emphrs;
                Console.WriteLine("days :" + totalworkingdays);

            }
            Console.WriteLine("total wage: " + totalwage);
        }
        }
    }

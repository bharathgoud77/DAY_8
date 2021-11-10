
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    internal class EmpAttendance
    {
        public void Compute()
        {
            int Is_Full_Time = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is present");
                Console.ReadLine();
            }

            else

            {
                Console.WriteLine("Employee is Absent");
                Console.ReadLine();

            }
        }
    }
    namespace employee
    {
        class empAttendance
        {

            public static void Main(string[] args)
            {
                EmpAttendance obj1 = new EmpAttendance();
                obj1.Compute();
            }

        }
    }
}


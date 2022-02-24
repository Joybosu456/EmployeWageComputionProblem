using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class EmpWageUC7
    {

        /// <summary>
        ///UC-7 Calculate the employee wage.
        /// </summary>

        public static int IS_FULL_TIME;
        public static int IS_PAR_TIME;
        public static int EMP_RATE_PER_HOUR;

        public EmpWageUC7()
        {
            IS_FULL_TIME = 1;
            IS_PAR_TIME = 2;
            EMP_RATE_PER_HOUR = 20;
        }
        public static void CalEmpWage()
        {


           

            int empHour = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            if (empCheck == IS_FULL_TIME)
            {
                empHour = 8;
            }
            else if (empCheck == IS_PAR_TIME)
            {
                empHour = 4;

            }
            else
            {
                empHour = 0;
            }
            empWage = empHour * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is :" + empWage);
        }

        public void display()
        {
            Console.WriteLine();
        }
    }
}
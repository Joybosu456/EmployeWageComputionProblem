using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            

            EmpWageUC7 obj = new EmpWageUC7();

            
            Console.WriteLine(obj.EMP_RATE_PER_HOUR);
            Console.WriteLine(obj.IS_PAR_TIME);
            Console.WriteLine(obj.IS_FULL_TIME);
            obj.display();
        }
    }
}

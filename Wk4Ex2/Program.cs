using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarations
            
            int assignType = 0;
            double midterms = 0;
            double finals = 0;
            
            Console.WriteLine("What type of assignment is it? 1 for Regular Assignment, 2 for Midterms, 3 for final exams.");
            switch (assignType)
            {
                case 1:
                    AssignmentsGrade();
                    break;

            }

        }

        public static double AssignmentsGrade()
        {
            int count = 0;
            double grade = 0;
            double assignments = 0;
            string addAssignment = "";

            while (true)
            {
                Console.WriteLine("What your grade?");
                grade = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Add another assignment? Y/N");
                addAssignment = Console.ReadLine();
                if (addAssignment == "Y")
                {
                    count++;
                    Console.WriteLine("What your grade?");
                    grade = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Good bye.");
                }



                
            }





            return assignments;
        }
        public static double MidtermsGrade()
        {

        }
        public static double FinalExamsGrade()
        {

        }
        public static double CalculateFinalGrade(double assignments, double midterms, double finals)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial_student
{
    class Program
    {
        static void Main(string[] args)
        {
            int presentCount = 0, absentCount = 0, unknownCount = 0;

            Console.WriteLine("Please start inserting students' presence (type 'present' or 'absent'; any other input will be considered as 'presence unknown'):");

            int students = 10; 

            for (int i = 0; i < students;)
            {
                Console.Write($"Student {i + 1}: ");
                string input = Console.ReadLine().Trim().ToLower();

                switch (input)
                {
                    case "present":
                        presentCount++;
                        i++; 
                        break;
                    case "absent":
                        absentCount++;
                        i++; 
                        break;
                    default:
                        if (input == "present" || input == "absent")
                        {

                        }
                        else
                        {
                            unknownCount++;
                            i++; 
                        }
                        break;
                }
            }

            Console.WriteLine($"{presentCount} students are present.");
            Console.WriteLine($"{absentCount} students are absent.");
            Console.WriteLine($"{unknownCount} student(s) presence unknown.");
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}

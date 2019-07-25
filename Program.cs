using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ArL = new ArrayList();
            Console.WriteLine("input at least 9 students, input '?' to stop: ");
            string student = Console.ReadLine();
            
            while(1 != 0)
            {
                if(student == "?")
                {
                    if (ArL.Count < 9)
                    {
                        Console.WriteLine("need more students");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    ArL.Add(student);
                }
                student = Console.ReadLine();
            }

            Console.WriteLine("there are {0} students in the class", ArL.Count);
            for(int i = 0; i < ArL.Count; i++)
            {
                Console.WriteLine("Student #{0} - {1}",i + 1, ArL[i]);
            }

            ArL.RemoveRange(ArL.Count / 2, 5);
            ArL.Insert(ArL.Count - 1, "George");
            ArL.Insert(ArL.Count - 1, "SwatSec");

            Console.WriteLine("there are {0} students in the class", ArL.Count);
            for (int i = 0; i < ArL.Count; i++)
            {
                Console.WriteLine("Student #{0} - {1}", i + 1, ArL[i]);
            }
        }
    }
}

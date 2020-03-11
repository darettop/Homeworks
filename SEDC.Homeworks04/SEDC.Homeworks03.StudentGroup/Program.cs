using System;

namespace SEDC.Homeworks03.StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[] {"Zdravko", "Petko", "Stanko", "Branko", "Trajko"};
            string[] studentsG2 = new string[] { "Darko", "Ance", "Vasil", "Trajce", "Stefan"};
            Console.WriteLine("Enter student group (1/2)");
            string group = Console.ReadLine();
            if(group == "1")
            {
                Console.WriteLine("The students in G1 are: ");
                for (int i = 0; i < studentsG1.Length; i++)
                {
                    Console.WriteLine(studentsG1[i]);
                }
            }

            else if (group == "2")
            {
                Console.WriteLine("The students in G2 are: ");
                for (int i = 0; i < studentsG2.Length; i++)
                {
                    Console.WriteLine(studentsG2[i]);
                }
            }

            Console.ReadLine();
        }
    }
}

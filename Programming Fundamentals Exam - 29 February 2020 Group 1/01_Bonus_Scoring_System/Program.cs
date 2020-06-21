using System;

namespace _01_Bonus_Scoring_System
{
    class Program
    {
        static void Main()
        {
            int countStudents = int.Parse(Console.ReadLine());
            double countLectures = double.Parse(Console.ReadLine());
            double additionalBonus = double.Parse(Console.ReadLine());

            double maxBonus = 0;
            double maxLectures = 0;

            for (int i = 0; i < countStudents; i++)
            {
                double studentAttendances = double.Parse(Console.ReadLine());
                double totalBonus = Math.Ceiling(studentAttendances / countLectures * (5 + additionalBonus));

                if (totalBonus >= maxBonus)
                {
                    maxBonus = totalBonus;
                    maxLectures = studentAttendances;
                }
            }
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxLectures} lectures.");
        }
    }
}
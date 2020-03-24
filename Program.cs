using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task1, string> TaskSolver = task =>
            {
                float population = System.Single.Parse(task.City.Population);
                float sickPercentage = System.Single.Parse(task.City.SickPercentage);
                float letality = System.Single.Parse(task.Virus.KillProbability);
                int sickNumber = (int)(Math.Truncate(population * sickPercentage));
                int deathNumber = (int)(Math.Truncate(population * sickPercentage * letality));

                return $"There are {sickNumber} people sick with {task.Virus.Name} in the city of {task.City.Name}, {deathNumber} of which died";
            };

            Task1.CheckSolver(TaskSolver);
        }
    }
}

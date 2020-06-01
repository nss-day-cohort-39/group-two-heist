using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Heist!");
            Console.WriteLine("Enter Team Member's name");
            string newName = Console.ReadLine();
            Console.WriteLine("Enter Team Member's skill level");
            int newSkillLevel = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Team Member's courage level");
            double newCourageFactor = Convert.ToDouble(Console.ReadLine());

            TeamMember newTeamMember = new TeamMember()
            {
                Name = newName,
                SkillLevel = newSkillLevel,
                CourageFactor = newCourageFactor

            };
            Console.WriteLine(newTeamMember);


        }

    }
}
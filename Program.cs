using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Heist!");
            Console.WriteLine("Enter Team Member's name");
            string newName = Console.ReadLine();
            int newSkillLevel = new int();
            double newCourageFactor = new double();

            Team heistTeam = new Team();

            while (newName != "")
            {
                Console.Write($"Enter {newName}'s skill level: ");
                newSkillLevel = Int32.Parse(Console.ReadLine());
                Console.Write($"Enter {newName}'s courage level: ");
                newCourageFactor = Convert.ToDouble(Console.ReadLine());


                TeamMember newTeamMember = new TeamMember()
                {
                    Name = newName,
                    SkillLevel = newSkillLevel,
                    CourageFactor = newCourageFactor

                };
                heistTeam.AddTeamMember(newTeamMember);
                Console.WriteLine("---------------");
                Console.Write("Enter Next Team Member's name: ");
                newName = Console.ReadLine();

            }

            List<TeamMember> teamNames = heistTeam.getTeamMembers();

            //             Console.WriteLine("");
            //             Console.WriteLine($"Your heist team has {heistTeam.teamCount} members.");
            //             Console.WriteLine("Your team members are:");
            //             foreach (var member in teamNames)
            //             {
            //                 Console.WriteLine($@"
            // Team Member {teamNames.IndexOf(member) + 1}
            // {member.Name}
            // -------------
            // Skill Level : {member.SkillLevel}
            // Courage Factor: {member.CourageFactor}
            // ");


            // }
            int BankDifficulty = 100;
            int CombinedSkill = heistTeam.getTotalSkill();

            Random rand = new Random(); //Random is a data type! creates a new Random class
            int LuckValue = rand.Next(-10, 11); //gets you a non-negative random integer between 1 and 100
            BankDifficulty = BankDifficulty + LuckValue;

            Console.Write($"The team's combined skill level is {CombinedSkill}.");
            Console.Write($"The bank's difficulty level is {BankDifficulty}.");

            if (BankDifficulty <= CombinedSkill)
            {
                Console.WriteLine("Bank heist is successfull.");
            }
            else
            {
                Console.WriteLine("Team goes to jail.");
            }


        }

    }
}
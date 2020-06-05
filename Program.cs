using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Heist!");

            Console.WriteLine("Choose your bank Difficulty: ");
            int BankDifficulty = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Team Member's name");
            string newName = Console.ReadLine();
            int newSkillLevel = new int();
            double newCourageFactor = new double();

            Team heistTeam = new Team();

            while (newName != "")
            {
                Console.Write($"Enter {newName}'s skill level: ");
                newSkillLevel = Int32.Parse(Console.ReadLine());

                while (newSkillLevel < 0)
                {
                    Console.WriteLine("Skill level has to be a postive number, please try again.");
                    Console.Write($"Enter {newName}'s skill level: ");
                    newSkillLevel = Int32.Parse(Console.ReadLine());
                }

                Console.Write($"Enter {newName}'s courage level: ");
                newCourageFactor = Convert.ToDouble(Console.ReadLine());

                while (newCourageFactor > 2.0 || newCourageFactor < 0)
                {
                    Console.WriteLine("Courage can't be higher than 2 or less than 0, please try again.");
                    Console.Write($"Enter {newName}'s courage level: ");
                    newCourageFactor = Int32.Parse(Console.ReadLine());
                }

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

            int CombinedSkill = heistTeam.getTotalSkill();

            Console.Write("How many heists? ");
            int numTrialRuns = Int32.Parse(Console.ReadLine());

            int counter = 1;

            int goodRuns = 0;
            int badRuns = 0;

            while (numTrialRuns > 0)
            {

                Random rand = new Random(); //Random is a data type! creates a new Random class
                int LuckValue = rand.Next(-10, 11); //gets you a non-negative random integer between 1 and 100
                BankDifficulty = BankDifficulty + LuckValue;

                Console.WriteLine($"Run #{counter}");

                Console.Write($"The team's combined skill level is {CombinedSkill}.");
                Console.Write($"The bank's difficulty level is {BankDifficulty}.");

                Console.WriteLine();

                if (BankDifficulty <= CombinedSkill)
                {
                    Console.WriteLine("Bank heist is successful.");
                    goodRuns++;
                }
                else
                {
                    Console.WriteLine("Team goes to jail.");
                    badRuns++;
                }

                numTrialRuns--;
                counter++;

            }

            Console.WriteLine($"{goodRuns} successful run{(goodRuns != 1 ? "s" : "")}. {badRuns} bad run{(badRuns != 1 ? "s" : "")}.");

        }

    }
}
using System;

namespace PlanYourHeist
{
    public class TeamMember
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public double CourageFactor { get; set; }

        public override string ToString()
        {
            return $@"
            {Name}
            -------------
            Skill Level : {SkillLevel}
            Courage Factor: {CourageFactor}
            ";
        }
    }


}
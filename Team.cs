using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanYourHeist
{
    public class Team
    {
        private List<TeamMember> _team = new List<TeamMember>();

        public void AddTeamMember(TeamMember newMember)
        {
            _team.Add(newMember);
        }

        public int teamCount
        {
            get
            {
                return _team.Count;
            }
        }

        public List<TeamMember> getTeamMembers()
        {
            return _team;
        }
        public int getTotalSkill()
        {
            return _team.Sum(member => member.SkillLevel);
        }

    }
}
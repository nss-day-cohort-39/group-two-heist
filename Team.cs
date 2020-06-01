using System;
using System.Collections.Generic;

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

    }
}
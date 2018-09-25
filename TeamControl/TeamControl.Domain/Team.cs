using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamControl.Domain
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }

        public Team(int id, string teamName)
        {
            this.Id = id;
            this.TeamName = teamName;
        }
    }
}

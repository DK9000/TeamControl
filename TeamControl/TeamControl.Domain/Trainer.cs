using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamControl.Domain
{
    class Trainer : Member
    {
        public Trainer(int id, String firstName, String lastName, String playerName, String phoneNo, String emailAddress, String memberNote)
        {
            this.MemberType = "Coach";
        }
    }
}

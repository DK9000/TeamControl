using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamControl.Domain
{
    public class Player : Member
    {   
        public string PhoneNoParents { get; set; }
        public string EmailParents { get;  set; }
        public string BTag { get; set; }
        public string SteamId { get; set; }
        public int SkillRating { get; set; }

        public Player(int memberID, string firstName, string lastName, string playerName, string phoneNo, string emailAddress,
                  string phoneNoParents, string emailParents, string bTag, string steamID,
                  int skillRating, string memberNote)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PlayerName = playerName;
            this.PhoneNo = phoneNoParents;
            this.EmailAddress = emailAddress;
            this.PhoneNoParents = phoneNoParents;
            this.EmailParents = emailParents;
            this.BTag = bTag;
            this.SteamId = steamID;
            this.SkillRating = skillRating;
            this.MemberNote = memberNote;
            this.MemberType = "player";
        }

    }
}

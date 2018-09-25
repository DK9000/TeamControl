using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamControl.Domain
{
    public class Member
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PlayerName { get; set; }
        public string PhoneNo { get; set; }
        public string EmailAddress { get; set; }
        public string MemberNote { get; set; }
        public string MemberType { get; set; }

        public Member()
        {
            MemberID = 0;
        }
        public Member(int memberID, string firstName, string lastName, string playerName, string phoneNo, string emailAddress, string memberNote)
        {
            this.MemberID = memberID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PlayerName = playerName;
            this.PhoneNo = phoneNo;
            this.EmailAddress = emailAddress;
            this.MemberNote = memberNote;
            this.MemberType = "Member";
        }
    }
}

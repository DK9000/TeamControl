using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamControl.Domain;
using TeamControl.businessLogic.Interfaces;

namespace TeamControl.businessLogic
{
    class MemberCtr : MemberCtrIF<Member>
    {
        public void Create(Member entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Member Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Member> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Member entity)
        {
            throw new NotImplementedException();
        }
    }
}

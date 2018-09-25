using TeamControl.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamControl.Domain;
using System.Data.SqlClient;

namespace TeamControl.DataAccessLayer
{
    public class DbMember : MemberDbIF<Member>

    {
        public void Create(Member entity)
        {
            using (SqlConnection connection = new SqlConnection())
            {

            }
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

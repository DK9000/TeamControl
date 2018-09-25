using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamControl.businessLogic.Interfaces
{
    interface MemberCtrIF<T>
    {
        void Create(T entity);
        T Get(int id);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Delete(int id)
    }
}

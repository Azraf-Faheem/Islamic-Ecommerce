using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<Type, Id, Return>
    {
        Return Create(Type obj);

        List<Type> Read();

        Type Read(Id id);

        Return Update(Type obj);

        bool Delete(Id id);
    }
}

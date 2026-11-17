using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_app.Member
{
    internal class SqlMemberRepository : IMemberRepository
    {
        public void DeactivateById(int memberId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Member> GetAll()
        {
            throw new NotImplementedException();
        }

        public Member GetMemberByRut(string rut)
        {
            throw new NotImplementedException();
        }

        public void Save(Member member)
        {
            var sql = "SELECT ";

        }

        public void Update(Member member)
        {
            throw new NotImplementedException();
        }
    }
}

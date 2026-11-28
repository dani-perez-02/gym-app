using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_app.Member
{
    internal interface IMemberRepository
    {
        void Save(Member member);
        void Update(Member member);

        void DeactivateById(int memberId);
        IEnumerable<Member> GetAll(MemberFilter.MembersFilter filtro);

        Member GetMemberByRut(string rut);
    }
}

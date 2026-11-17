using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_app.Member
{

    internal class InMemoryMemberRepository : IMemberRepository
    {
        private readonly List<Member> _members = new();
        private int _nextId = 1;

        public void DeactivateById(int memberId)
        {
            var existing = _members.FirstOrDefault(m => m.MemberId == memberId);
            if (existing != null) existing.IsActive = false;
        }

        public IEnumerable<Member> GetAll()
        {
            return _members.Where(m => m.IsActive).ToList();
        }

        public Member GetMemberByRut(string rut)
        {
            return _members.FirstOrDefault(m => m.Rut == rut && m.IsActive);
        }

        public void Save(Member member)
        {
            member.MemberId = _nextId++;
            member.RegisteredAt = DateTime.Now;
            member.IsActive = true;
            _members.Add(member);
        }

        public void Update(Member member)
        {
            var existing = _members.FirstOrDefault(m => m.MemberId == member.MemberId);
            if (existing == null) return;

            existing.Name = member.Name;
            existing.Phone = member.Phone;
            existing.Email = member.Email;
        }
    }
}

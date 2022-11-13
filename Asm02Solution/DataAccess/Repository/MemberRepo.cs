using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Objects;

namespace DataAccess.Repository
{
    public class MemberRepo : IMemberRepo
    {
        private readonly FstoreContext _db;

        public MemberRepo()
        {
            _db = new();
        }

        public void CreateMember(Member member)
        {
            if(member != null)
            {
                _db.Members.Add(member);
                _db.SaveChanges();
            }
        }

        public void DeleteMember(int memberId)
        {
            var member = _db.Members.Find(memberId);
            if(member != null)
            {
                _db.Members.Remove(member);
                _db.SaveChanges();
            }
        }

        public List<Member> GetMembers() => _db.Members.ToList();

        public void UpdateMember(Member member)
        {
            if (member != null)
            {
                _db.Members.Update(member);
                _db.SaveChanges();
            }
        }
    }
}

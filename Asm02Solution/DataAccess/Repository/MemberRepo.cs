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

        public List<Member> GetMembers() => _db.Members.ToList();
    }
}

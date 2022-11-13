using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Objects;

namespace DataAccess.Repository
{
    public interface IMemberRepo
    {
        List<Member> GetMembers();
        void CreateMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int memberId);
    }
}

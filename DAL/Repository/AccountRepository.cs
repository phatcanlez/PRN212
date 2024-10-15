using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class AccountRepository
    {

        private readonly Swp391FengShuiKoiConsultingDbContext _context;

        public AccountRepository()
        {
            _context = new Swp391FengShuiKoiConsultingDbContext();
        }

        public bool CheckLogin(string userId, string password)
        {
            return _context.Accounts.Any(x => x.UserId == userId && x.Password == password);
        }

    }
}

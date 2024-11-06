using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class AccountRepository
    {

        private  Swp391FengShuiKoiConsultingDbContext _context;

        public List<Account> GetAll()
        {
            _context = new();
            return _context.Accounts.ToList();
        }

        public void Add(Account account)
        {
            _context = new();
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public void Update(Account account) {
            _context = new();
            _context.Accounts.Update(account);
            _context.SaveChanges();
        }

        public void Delete(Account account)
        {
            _context = new();
            _context.Accounts.Remove(account);
            _context.SaveChanges();
        }

    }
}

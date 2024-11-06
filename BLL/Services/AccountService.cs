using DAL.Entities;
using DAL.Repository;

namespace BLL.Services
{
    public class AccountService
    {
        AccountRepository accountRepository = new();
        public Account? Login(string userId, string password)
        {
            return accountRepository.GetAll().Find(account => account.UserId == userId && account.Password == password);
        }
    }
}

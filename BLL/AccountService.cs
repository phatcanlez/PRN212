using DAL.Repository;

namespace BLL
{
    public class AccountService
    {
        AccountRepository accountRepository = new();
        public string Login(string userId, string password)
        {
            if (accountRepository.CheckLogin(userId, password))
            {
                return "Login success";
            }
            return "Login Fail";

        }
    }
}

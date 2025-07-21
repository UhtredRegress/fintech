using fintech.Data.IRepository;
using fintech.Data.Model;
using fintech.Service.IService;

namespace fintech.Service
{
    public class AccountService:IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository) 
        {
            _accountRepository = accountRepository;
        }

        public async Task<Account> CreateAccount(Account account)
        {
            var foundAccount = await _accountRepository.FindAccountByAccountNumber(account.AccountNumber);
            if (foundAccount != null)
            {
                throw new Exception("Account number is already existed");
            }
            account.CreatedAt = DateTime.Now;

            return await _accountRepository.CreateAccount(account);
        }
    }
}

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

        public async Task<Account?> CreateAccount(Account account)
        {
            var foundAccount = await _accountRepository.FindAccountById(account.Id);
            if (foundAccount != null)
            {
                throw new Exception("Account number is already existed");
            }

            return await _accountRepository.CreateAccount(account);
        }
    }
}

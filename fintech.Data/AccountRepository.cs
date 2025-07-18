using fintech.Data.IRepository;
using fintech.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fintech.Data
{
    public class AccountRepository:IAccountRepository
    {
        private readonly FintechDbContext _dbContext;

        public AccountRepository(FintechDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task<Account> CreateAccount(Account account)
        {
            await _dbContext.Set<Account>().AddAsync(account);
            await _dbContext.SaveChangesAsync();
            return account;
        }

        public async Task<Account?> FindAccountById(int id)
        {
            return await _dbContext.FindAsync<Account>(id);
        }
    }
}

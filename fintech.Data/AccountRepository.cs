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
        private readonly DbContext _dbContext;

        public AccountRepository(DbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task<Account> CreateAccount(Account account)
        {
            await _dbContext.AddAsync(account);
            await _dbContext.SaveChangesAsync();
            return account;
        }
    }
}

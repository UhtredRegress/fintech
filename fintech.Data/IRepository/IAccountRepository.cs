using fintech.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fintech.Data.IRepository
{
    public interface IAccountRepository
    {
        Task<Account> CreateAccount(Account account);
    }
}

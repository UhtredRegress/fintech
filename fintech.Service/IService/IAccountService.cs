using fintech.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fintech.Service.IService
{
    public interface IAccountService
    {
        Task<Account?> CreateAccount(Account account);
    }
}

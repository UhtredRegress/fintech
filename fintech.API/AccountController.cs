using fintech.Data.Model;
using fintech.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace fintech.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAccount(Account account)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var createdAccount = await _accountService.CreateAccount(account);
                return Created($"/account/{createdAccount.Id}", createdAccount);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            
            }
        }
    }
}

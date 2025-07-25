using fintech.Service.IService;
using Fintech.Transactor;
using Grpc.Core;

namespace fintech.API
{
    public class WithDrawMoneyService : TransactionService.TransactionServiceBase
    {
        private readonly IAccountService _accountService;

        public WithDrawMoneyService(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public override Task<TransactionReply> WithdrawMoney(TransactionRequest request, ServerCallContext context)
        {
            return base.WithdrawMoney(request, context);
        }
    }
}

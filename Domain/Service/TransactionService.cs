using Domain.Interface.Transaction;
using Domain.Model;

namespace Domain.Service
{
    public class TransactionService : ITransactionService
    {
        public Task<string> CreateTransaction(TransactionModel model)
        {
            return Task.FromResult(model.Name);
        }
    }
}

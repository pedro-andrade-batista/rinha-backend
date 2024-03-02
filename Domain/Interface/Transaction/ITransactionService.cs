using Domain.Model;

namespace Domain.Interface.Transaction
{
    public interface ITransactionService
    {
        Task<string> CreateTransaction(TransactionModel model);
    }
}

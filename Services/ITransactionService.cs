using MyWebApiWithControllers.DatabaseModel;

namespace MyWebApiWithControllers.Services;

public interface ITransactionService
{
    List<Transaction> GetAllTransactions();
    Transaction GetTransactionById(int id);
}
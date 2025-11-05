using MyWebApiWithControllers.Model;

namespace MyWebApiWithControllers.Services;

public interface ITransactionService
{
    List<Transaction> GetAllTransactions();
    Transaction GetTransactionById(int id);
}
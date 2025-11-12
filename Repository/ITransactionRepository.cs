using MyWebApiWithControllers.DatabaseModel;

namespace MyWebApiWithControllers.Repository;

public interface ITransactionRepository
{
    List<Transaction> GetAllTransactions();
    
    Transaction GetTransactionById(int id);
}
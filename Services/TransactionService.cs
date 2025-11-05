using MyWebApiWithControllers.Model;
using MyWebApiWithControllers.Repository;

namespace MyWebApiWithControllers.Services;

public class TransactionService : ITransactionService {
    private readonly ITransactionRepository _transactionRepository;

    public TransactionService(ITransactionRepository transactionRepository)
    {
        _transactionRepository = transactionRepository;
    }

    public List<Transaction> GetAllTransactions() 
    {
        return _transactionRepository.GetAllTransactions();
    }
    
    public Transaction GetTransactionById(int id) 
    {
        return _transactionRepository.GetTransactionById(id);
    }
}
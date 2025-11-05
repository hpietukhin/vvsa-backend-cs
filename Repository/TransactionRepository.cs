using MyWebApiWithControllers.Model;

namespace MyWebApiWithControllers.Repository;

public class TransactionRepository : ITransactionRepository {
    private List<Transaction> transactions;

    public TransactionRepository() 
    {
        transactions = new List<Transaction>{
            new Transaction { TransactionId=1 },
            new Transaction { TransactionId=2 }
        };
    }

    public List<Transaction> GetAllTransactions() 
    {
        return transactions;
    }

    public Transaction GetTransactionById(int id) 
    {
        return transactions.FirstOrDefault(t => t.TransactionId == id);
    }

    public void Add(Transaction transaction)
    {
        transactions.Add(transaction);
    }

    public void DeleteById(int id) 
    {
        var transaction = transactions.FirstOrDefault(t => t.TransactionId == id);
        if (transaction != null)
        {
            transactions.Remove(transaction);
        }
    }
}
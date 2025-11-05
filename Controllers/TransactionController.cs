using Microsoft.AspNetCore.Mvc;
using MyWebApiWithControllers.Services;
using MyWebApiWithControllers.Repository;
using MyWebApiWithControllers.Model;

namespace MyWebApiWithControllers.Controllers;

[ApiController]
[Route("[controller]")]
public class TransactionController : ControllerBase
{
    private readonly ITransactionService _transactionService;

    public TransactionController(ITransactionService transactionService)
    {
        _transactionService = transactionService;
    }

    [HttpGet(Name = "GetAllTransactions")]
    public List<Transaction> GetAllTransactions()
    {
        return _transactionService.GetAllTransactions();
    }

    [HttpGet("{id}", Name = "GetTransactionById")]
    public Transaction GetTransactionById(int id)
    {
        return _transactionService.GetTransactionById(id);
    }
}

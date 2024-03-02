using Domain.Interface.Transaction;
using Microsoft.AspNetCore.Mvc;
using Domain.Model;

namespace rinha_backend.Controllers.v1
{

    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        public readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        public IActionResult CreateTransaction() 
        {
            return Ok(_transactionService.CreateTransaction(new TransactionModel { Id = 1, Name = "Pedro" }));
        }
    }
}
